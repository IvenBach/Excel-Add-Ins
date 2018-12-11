using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XL = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1.Systems_Of_Linear_Equations
{
    class SystemOfLinearEquationsModel
    {
        public XL.Range CoefficientMatrix { get; set; }
        public XL.Range RightHandSideVector { get; set; }
        public XL.Range InverseCoefficientMatrix { get; set; }
        public XL.Range SolutionVector { get; set; }
    }
}
