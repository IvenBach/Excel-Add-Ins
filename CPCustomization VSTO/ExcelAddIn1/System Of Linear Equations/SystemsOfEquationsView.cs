using System;
using System.Drawing;
using System.Windows.Forms;
using XL = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1.System_Of_Linear_Equations
{
    public partial class SystemsOfEquationsView : Form, ISystemsOfEquationsView
    {
        public SystemsOfEquationsPresenter Presenter { get; }

        private readonly Color _defaultForeColor = Color.Black;
        private readonly Color _alertForeColor = Color.Red;

        private const int RangeSelectionConst = 8;

        public SystemsOfEquationsView(SystemsOfEquationsPresenter presenter)
        {
            InitializeComponent();
            Presenter = presenter;
        }

        public void SolveSystem()
        {
            Presenter.SolveSystem();
        }
        private void SolveButton_Click(object sender, EventArgs e)
        {
            Presenter.SolveSystem();
        }

        internal void RestoreDefaultColoring()
        {
            CoefficientMatrixLabel.ForeColor = _defaultForeColor;
            AnswerVectorLabel.ForeColor = _defaultForeColor;
            InverseCoefficientMatrixLabel.ForeColor = _defaultForeColor;
            SolutionVectorLabel.ForeColor = _defaultForeColor;
        }

        public void ClearInputs()
        {
            Presenter.Model.CoefficientMatrix = null;
            CoefficientMatrixDisplay.Clear();

            Presenter.Model.AnswerVector = null;
            AnswerVectorDisplay.Clear();

            Presenter.Model.InverseCoefficientMatrix = null;
            InverseCoefficientMatrixDisplay.Clear();

            Presenter.Model.SolutionVector = null;
            SolutionVectorDisplay.Clear();

            RestoreDefaultColoring();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        public void SelectCoefficientMatrix()
        {
            Hide();

            dynamic unsafeCoefficientMatrix = Globals.ThisAddIn.Application.InputBox("Select coefficient matrix range", "Coefficient Matrix", Type: RangeSelectionConst);
            if (unsafeCoefficientMatrix is XL.Range)
            {
                Presenter.Model.CoefficientMatrix = unsafeCoefficientMatrix;
                CoefficientMatrixDisplay.Text = Presenter.Model.CoefficientMatrix.Address[false, false];
            }

            Show();
        }
        private void SelectCoefficientButton_Click(object sender, EventArgs e)
        {
            SelectCoefficientMatrix();
        }

        public void SelectAnswerVector()
        {
            Hide();

            dynamic unsafeRHSVector = Globals.ThisAddIn.Application.InputBox("Select answer vector", "Answer vector", Type: RangeSelectionConst);
            if (unsafeRHSVector is XL.Range)
            {
                Presenter.Model.AnswerVector = unsafeRHSVector;
                AnswerVectorDisplay.Text = Presenter.Model.AnswerVector.Address[false, false];
            }

            Show();
        }
        private void SelectAnswerVectorBotton_Click(object sender, EventArgs e)
        {
            SelectAnswerVector();
        }

        public void SelectInverseCoefficientMatrix()
        {
            Hide();

            dynamic unsafeInverceCoefficient = Globals.ThisAddIn.Application.InputBox("Select coefficient matrix", "Coefficient matrix", Type: RangeSelectionConst);
            if (unsafeInverceCoefficient is XL.Range)
            {
                Presenter.Model.InverseCoefficientMatrix = unsafeInverceCoefficient;
                InverseCoefficientMatrixDisplay.Text = Presenter.Model.InverseCoefficientMatrix.Address[false, false];
            }

            Show();
        }
        private void SelectInverseCoefficientButton_Click(object sender, EventArgs e)
        {
            SelectInverseCoefficientMatrix();
        }

        public void SelectSolutionVector()
        {
            Hide();

            dynamic unsafeSolutionVector = Globals.ThisAddIn.Application.InputBox("Select solution vector", "Solution vector", Type: RangeSelectionConst);
            if (unsafeSolutionVector is XL.Range)
            {
                Presenter.Model.SolutionVector = unsafeSolutionVector;
                SolutionVectorDisplay.Text = Presenter.Model.SolutionVector.Address[false, false];
            }

            Show();
        }
        private void SelectSolutionButton_Click(object sender, EventArgs e)
        {
            SelectSolutionVector();
        }
    }
}
