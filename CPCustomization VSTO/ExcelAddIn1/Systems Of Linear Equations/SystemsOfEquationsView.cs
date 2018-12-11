using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XL = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1.Systems_Of_Linear_Equations
{
    public partial class SystemsOfEquationsView : Form
    {
        private readonly Color _defaultForeColor = Color.Black;
        private readonly Color _alertForeColor = Color.Red;

        public SystemsOfEquationsView()
        {
            InitializeComponent();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            RestoreDefaultColoring();

            if (!AreInputValuesValid())
            {
                return;
            }

            XL.Range coefficientMatrix = ((XL.Worksheet)Globals.ThisAddIn.Application.ActiveSheet).get_Range(CoefficientMatrixInput.Text);
            if (coefficientMatrix.Rows.Count != coefficientMatrix.Columns.Count)
            {
                CoefficientMatrixInput.ForeColor = Color.Red;
                MessageBox.Show(SystemOfLinearEquations.NonSquareMatrixText, SystemOfLinearEquations.NonSquareMatrixCaption);
                //CoefficientMatrixInput.Focus();
                //return;
            }

            double matrixDeterminant;
            try
            {
                matrixDeterminant = Globals.ThisAddIn.Application.WorksheetFunction.MDeterm(coefficientMatrix);
            }
            catch (Exception)
            {
                MessageBox.Show(SystemOfLinearEquations.NonSingularMatrixText, SystemOfLinearEquations.NonSingularMatrixCaption);
                return;
            }

            XL.Range rightHandSideVector = ((XL.Worksheet)Globals.ThisAddIn.Application.ActiveSheet).get_Range(RightHandSideVectorInput.Text);
            if (rightHandSideVector.Rows.Count != coefficientMatrix.Columns.Count)
            {
                RightHandSideVectorInput.ForeColor = _alertForeColor;
                MessageBox.Show(SystemOfLinearEquations.RightHandSideVectorMustMatchCoeffMatrixColumns);
                //RightHandSideVectorInput.Focus();
                //return;
            }

            if (rightHandSideVector.Columns.Count != 1)
            {
                RightHandSideVectorInput.ForeColor = _alertForeColor;
                RightHandSideVectorInput.Text = UpdateRefEdit(rightHandSideVector);
                MessageBox.Show(SystemOfLinearEquations.RightHandSideVectorSingleColumn);
                //RightHandSideVectorInput.Focus();
            }

            XL.Range inverseCoefficientMatrix = ((XL.Worksheet)Globals.ThisAddIn.Application.ActiveSheet)
                .get_Range(InverseCoefficientMatrixInput.Text)
                .Resize[coefficientMatrix.Rows.Count, coefficientMatrix.Columns.Count];
            InverseCoefficientMatrixInput.Text = UpdateRefEdit(inverseCoefficientMatrix);

            XL.Range solutionVector = ((XL.Worksheet)Globals.ThisAddIn.Application.ActiveSheet)
                .get_Range(SolutionVectorInput.Text)
                .Resize[rightHandSideVector.Rows.Count, 1];
            SolutionVectorInput.Text = UpdateRefEdit(solutionVector);

            if (WillOverwriteInformation(inverseCoefficientMatrix) || WillOverwriteInformation(solutionVector))
            {
                DialogResult result = MessageBox.Show("Information will be erased if you continue", "Ok to proceed?", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.No))
                {
                    return;
                }
            }

            inverseCoefficientMatrix.FormulaArray = $"=minverse({coefficientMatrix.Address})";
            solutionVector.FormulaArray = $"=mmult({inverseCoefficientMatrix.Address},{rightHandSideVector.Address})";
        }

        private void RestoreDefaultColoring()
        {
            CoefficientMatrixInput.ForeColor = _defaultForeColor;
            RightHandSideVectorInput.ForeColor = _defaultForeColor;
            InverseCoefficientMatrixInput.ForeColor = _defaultForeColor;
            SolutionVectorInput.ForeColor = _defaultForeColor;
        }

        private string UpdateRefEdit(XL.Range value)
        {
            return value.Parent.Name + "!" + value.Columns[1].Address;
        }

        //TODO convert to static utility class
        private bool WillOverwriteInformation(XL.Range destination, bool checkForConstants = true, bool checkForFormulas = true)
        {
            bool willOverwriteConstants = false;
            bool willOverwriteFormulas = false;

            if (checkForConstants)
            {
                try
                {
                    willOverwriteConstants = destination.SpecialCells(XL.XlCellType.xlCellTypeConstants).Count > 0;
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    willOverwriteConstants = false;
                }
            }

            if (checkForFormulas)
            {
                try
                {
                    willOverwriteFormulas = destination.SpecialCells(XL.XlCellType.xlCellTypeFormulas).Count > 0;
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    willOverwriteFormulas = false;
                }
            }

            return willOverwriteConstants || willOverwriteFormulas;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CoefficientMatrixInput.Clear();
            RightHandSideVectorInput.Clear();
            InverseCoefficientMatrixInput.Clear();
            SolutionVectorInput.Clear();
        }

        private bool AreInputValuesValid()
        {
            CoefficientMatrixLabel.ForeColor = IsCellReferenceValid(CoefficientMatrixInput.Text)
                ? _defaultForeColor
                : _alertForeColor;

            RightHandSideVectorLabel.ForeColor = IsCellReferenceValid(RightHandSideVectorInput.Text)
                ? _defaultForeColor
                : _alertForeColor;

            InverseCoefficientMatrixLabel.ForeColor = IsCellReferenceValid(InverseCoefficientMatrixInput.Text)
                ? _defaultForeColor
                : _alertForeColor;

            SolutionVectorLabel.ForeColor = IsCellReferenceValid(SolutionVectorInput.Text)
                ? _defaultForeColor
                : _alertForeColor;

            return !(CoefficientMatrixLabel.ForeColor.Equals(_alertForeColor)
                || RightHandSideVectorLabel.Equals(_alertForeColor)
                || InverseCoefficientMatrixLabel.Equals(_alertForeColor)
                || SolutionVectorLabel.Equals(_alertForeColor));


            bool IsCellReferenceValid(string reference)
            {
                const string A1OrR1C1 = @"[a-zA-Z]+\d+|R\d+C\d+";
                var regex = new System.Text.RegularExpressions.Regex(A1OrR1C1);
                return regex.IsMatch(reference);
            }
        }
    }
}
