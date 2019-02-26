namespace ExcelAddIn1.System_Of_Linear_Equations
{
    public interface ISystemsOfEquationsView
    {
        void SelectCoefficientMatrix();
        void SelectAnswerVector();
        void SelectInverseCoefficientMatrix();
        void SelectSolutionVector();

        void ClearInputs();
        void SolveSystem();
        void Show();
        void Hide();
    }
}
