using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XL = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Windows.Forms;
using ExcelAddIn1.Utility;

namespace ExcelAddIn1.System_Of_Linear_Equations
{
    public class SystemsOfEquationsPresenter
    {
        public ISystemsOfEquationsView View;

        public SystemOfLinearEquationsModel Model = new SystemOfLinearEquationsModel();

        public SystemsOfEquationsPresenter()
        {
            View = new SystemsOfEquationsView(this);
        }

        public void SetCoefficientMatrix(XL.Range coefficientMatrix)
        {
            if (coefficientMatrix != null)
            {
                Model.CoefficientMatrix = coefficientMatrix;
            }
        }

        public void SetAnswerVector(XL.Range answerVector)
        {
            if (answerVector != null)
            {
                Model.AnswerVector = answerVector;
            }
        }

        public void SetInverseCoefficientMatrix(XL.Range inverseCoefficientMatrix)
        {
            Model.InverseCoefficientMatrix = inverseCoefficientMatrix;

        }

        public void SetSolutionVector(XL.Range solutionVector)
        {
            if (solutionVector != null)
            {
                Model.SolutionVector = solutionVector;
            }
        }

        public void SolveSystem()
        {
            if (Model.CoefficientMatrix is null
                || Model.AnswerVector is null
                || Model.InverseCoefficientMatrix is null
                || Model.SolutionVector is null)
            {
                MessageBox.Show(SystemOfLinearEquations.InvalidInputText, SystemOfLinearEquations.InvalidInputCaption);
                return;
            }

            if (Model.CoefficientMatrix.Rows.Count != Model.CoefficientMatrix.Columns.Count)
            {
                MessageBox.Show(SystemOfLinearEquations.NonSquareMatrixText, SystemOfLinearEquations.NonSquareMatrixCaption);
                return;
            }

            double matrixDeterminant;
            try
            {
                matrixDeterminant = Globals.ThisAddIn.Application.WorksheetFunction.MDeterm(Model.CoefficientMatrix);
            }
            catch (Exception)
            {
                MessageBox.Show(SystemOfLinearEquations.NonSingularMatrixText, SystemOfLinearEquations.NonSingularMatrixCaption);
                return;
            }

            if (Model.AnswerVector.Rows.Count != Model.CoefficientMatrix.Columns.Count)
            {
                MessageBox.Show(SystemOfLinearEquations.AnswerVectorMustMatchCoeffMatrixColumns);
                return;
            }

            if (Model.AnswerVector.Columns.Count != 1)
            {
                MessageBox.Show(SystemOfLinearEquations.AnswerVectorSingleColumn);
                return;
            }

            Model.InverseCoefficientMatrix = Model.InverseCoefficientMatrix.Resize[Model.CoefficientMatrix.Rows.Count, Model.CoefficientMatrix.Columns.Count];
            Model.SolutionVector = Model.SolutionVector.Resize[Model.AnswerVector.Rows.Count, 1];

            if (CheckDestination.WillOverwriteInformation(Model.InverseCoefficientMatrix) || CheckDestination.WillOverwriteInformation(Model.SolutionVector))
            {
                DialogResult result = MessageBox.Show("Information will be erased if you continue", "Ok to proceed?", MessageBoxButtons.YesNo);
                if (result.Equals(DialogResult.No))
                {
                    return;
                }
            }

            Model.InverseCoefficientMatrix.FormulaArray = $"=minverse({Model.CoefficientMatrix.Address})";
            Model.SolutionVector.FormulaArray = $"=mmult({Model.InverseCoefficientMatrix.Address},{Model.AnswerVector.Address})";
        }
    }
}
