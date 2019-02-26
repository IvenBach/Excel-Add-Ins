using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1.System_Of_Linear_Equations
{
    public class SystemOfLinearEquationsModel
    {
        public Excel.Range CoefficientMatrix { get; set; }
        public Excel.Range AnswerVector { get; set; }
        public Excel.Range InverseCoefficientMatrix { get; set; }
        public Excel.Range SolutionVector { get; set; }
    }
}
