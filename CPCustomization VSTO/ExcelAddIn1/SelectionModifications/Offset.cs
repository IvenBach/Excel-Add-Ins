using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddIn1.SelectionModifications
{
    public static class Offset
    {
        private enum OffsetDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        public static void Left(Excel.Application application, Excel.Range selection)
        {
            if (IsSelectedCellsOnBoundaryOfWorksheet(application, selection, OffsetDirection.Left))
            {
                return;
            }

            selection.Offset[0, -1].Select();
        }

        public static void Right(Excel.Application application, Excel.Range selection)
        {
            if (IsSelectedCellsOnBoundaryOfWorksheet(application, selection, OffsetDirection.Right))
            {
                return;
            }

            selection.Offset[0, 1].Select();
        }

        public static void Up(Excel.Application application, Excel.Range selection)
        {
            if (IsSelectedCellsOnBoundaryOfWorksheet(application, selection, OffsetDirection.Up))
            {
                return;
            }

            selection.Offset[-1, 0].Select();
        }

        public static void Down(Excel.Application application, Excel.Range selection)
        {
            if (IsSelectedCellsOnBoundaryOfWorksheet(application, selection, OffsetDirection.Down))
            {
                return;
            }

            selection.Offset[1, 0].Select();
        }

        private static bool IsSelectedCellsOnBoundaryOfWorksheet(Excel.Application application, Excel.Range selection, OffsetDirection direction)
        {
            foreach (Excel.Range subArea in selection.Areas)
            {
                if (direction == OffsetDirection.Left
                    && subArea.Column == 1)
                {
                    return true;
                }

                if (direction == OffsetDirection.Right
                    && subArea.Column + subArea.Columns.Count - 1 == application.Columns.Count)
                {
                    return true;
                }

                if (direction == OffsetDirection.Up
                    && subArea.Row == 1)
                {
                    return true;
                }

                if (direction == OffsetDirection.Down
                    && subArea.Row + subArea.Rows.Count - 1 == application.Rows.Count)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
