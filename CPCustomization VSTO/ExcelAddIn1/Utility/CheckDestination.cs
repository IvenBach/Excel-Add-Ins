using System;
using XL = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ExcelAddIn1.Utility
{
    public static class CheckDestination
    {
        public static bool WillOverwriteInformation(XL.Range destination, bool checkForConstants = true, bool checkForFormulas = true)
        {
            bool willOverwriteConstants = OverwriteType(destination, XL.XlCellType.xlCellTypeConstants); //false
            bool willOverwriteFormulas = OverwriteType(destination, XL.XlCellType.xlCellTypeFormulas); //false;

            return willOverwriteConstants || willOverwriteFormulas;
        }

        private static bool OverwriteType(XL.Range range, XL.XlCellType xlCellType)
        {
            bool isSingleCell = range.Count == 1;

            if (isSingleCell)
            {
                try
                {
                    char firstChar = range.Formula[0];
                    if (xlCellType == XL.XlCellType.xlCellTypeFormulas)
                    {
                        return firstChar == '=';
                    }
                    else
                    {
                        return firstChar != '=';
                    }                    
                }
                catch (IndexOutOfRangeException e)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    return range.SpecialCells(xlCellType).Count > 0;
                }
                catch (COMException e)
                {
                    return false;
                }
            }
        }
    }    
}
