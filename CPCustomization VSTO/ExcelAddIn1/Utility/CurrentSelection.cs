using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1.Utility
{
    public static class CurrentSelection
    {
        public static dynamic Selection(Excel.Application application)
        {
            return application.ActiveWindow.Selection;
        }

        public static Excel.Range RangeSelection(Excel.Application application)
        {

            return application.ActiveWindow.RangeSelection;
        }
    }
}
