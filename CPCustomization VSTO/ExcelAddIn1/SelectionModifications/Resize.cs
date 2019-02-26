using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAddIn1.Utility;

namespace ExcelAddIn1.SelectionModifications
{
    //Inspiration from Oaktree
    //http://www.mrexcel.com/forum/excel-questions/313245-resizing-non-contiguous-range.html#post1539010
    public static class Resize
    {
        public static void DecreaseRow(Excel.Application application)
        {
            ResizeSelection(application, true, false);
        }

        public static void IncreaseRow(Excel.Application application)
        {
            ResizeSelection(application, true, true);
        }

        public static void DecreaseColumn(Excel.Application application)
        {
            ResizeSelection(application, false, false);
        }

        public static void IncreaseColumn(Excel.Application application)
        {
            ResizeSelection(application, false, true);
        }

        private static void ResizeSelection(Excel.Application application, bool isRow, bool isIncrease)
        {
            if (application.ActiveWindow == null)
            {
                MessageBox.Show(UI_Resources.ResizeSelection_NoActiveWindow);
                return;
            }

            var source = CurrentSelection.RangeSelection(application);

            Excel.Range r1 = null;

            int increment = isIncrease ? 1 : -1;

            foreach (Excel.Range r2 in source.Areas)
            {
                int currentSize = isRow ? r2.Rows.Count : r2.Columns.Count;
                int size = increment + currentSize;

                if (size.Equals(0))
                {
                    MessageBox.Show(UI_Resources.ResizeSelection_LastRowColumnError);
                    return;
                }

                //TODO: This section will still produce an error if the last column or row in a spreadsheet is trying to increase its size.
                if (r1  == null)
                {
                    r1 = isRow ? r2.Resize[RowSize: size] : r2.Resize[ColumnSize: size];
                }
                else
                {
                    r1 = application.Union(r1,
                            isRow 
                                ? r2.Resize[RowSize: size] 
                                : r2.Resize[ColumnSize: size]);
                }
            }

            r1.Select();
        }
    }
}
