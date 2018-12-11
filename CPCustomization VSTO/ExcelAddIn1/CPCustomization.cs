using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using XL = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace ExcelAddIn1
{
    public partial class CPCustomization
    {
        XL.Application xlApplication;
        
        private void FooRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            xlApplication = Globals.ThisAddIn.Application;

            ThisAddIn.SynchronizeUI(xlApplication.ActiveSheet);
        }

        private void OffsetLeft_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = CurrentSelection;
            if (IsSelectedCellsOnBoundaryOfWorksheet(selection, OffsetDirection.Left))
            {
                return;
            }

            selection.Offset[0, -1].Select();
        }

        private void OffsetUp_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = CurrentSelection;
            if (IsSelectedCellsOnBoundaryOfWorksheet(selection, OffsetDirection.Up))
            {
                return;
            }

            selection.Offset[-1, 0].Select();
        }

        private void OffsetDown_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = CurrentSelection;
            if (IsSelectedCellsOnBoundaryOfWorksheet(selection,  OffsetDirection.Down))
            {
                return;
            }

            selection.Offset[1, 0].Select();
        }

        private void OffsetRight_Click(object sender, RibbonControlEventArgs e)
        {
            var selection = CurrentSelection;
            if (IsSelectedCellsOnBoundaryOfWorksheet(selection, OffsetDirection.Right))
            {
                return;
            }

            selection.Offset[0, 1].Select();
        }

        private bool IsSelectedCellsOnBoundaryOfWorksheet(XL.Range selection, OffsetDirection direction)
        {
            foreach (XL.Range subArea in selection.Areas)
            {
                if (direction == OffsetDirection.Left
                    && subArea.Column == 1)
                {
                    return true;
                }

                if (direction == OffsetDirection.Right
                    && subArea.Column + subArea.Columns.Count - 1 == xlApplication.Columns.Count)
                {
                    return true;
                }

                if (direction == OffsetDirection.Up
                    && subArea.Row == 1)
                {
                    return true;
                }

                if (direction == OffsetDirection.Down
                    && subArea.Row + subArea.Rows.Count - 1 == xlApplication.Rows.Count)
                {
                    return true;
                }
            }

            return false;
        }

        private XL.Range CurrentSelection => xlApplication.ActiveWindow.RangeSelection;

        private void R1C1ReferenceStyle_Click(object sender, RibbonControlEventArgs e)
        {
            var checkBox = sender as RibbonCheckBox;

            xlApplication.ReferenceStyle = checkBox.Checked
                ? XL.XlReferenceStyle.xlR1C1
                : XL.XlReferenceStyle.xlR1C1;
        }

        private void DisplayPageBreaks_Click(object sender, RibbonControlEventArgs e)
        {
            if (xlApplication.ActiveSheet is XL.Worksheet activeSheet)
            {
                activeSheet.DisplayPageBreaks = ((RibbonCheckBox)sender).Checked;
            }            
        }

        private void TableStructureReference_Click(object sender, RibbonControlEventArgs e)
        {
            xlApplication.GenerateTableRefs = ((RibbonCheckBox)sender).Checked
                ? XL.XlGenerateTableRefs.xlGenerateTableRefStruct
                : XL.XlGenerateTableRefs.xlGenerateTableRefA1;
        }

        private void FreezeReFreezePanes_Click(object sender, RibbonControlEventArgs e)
        {
            xlApplication.ActiveWindow.FreezePanes = false;
            xlApplication.ActiveWindow.FreezePanes = true;

            FreezeReFreezePanes.Label = xlApplication.ActiveWindow.FreezePanes
                ? UI_Resources.ReFreezeOnActiveCell
                : UI_Resources.FreezeOnActiveCell;
        }

        private void UnFreezePanes_Click(object sender, RibbonControlEventArgs e)
        {
            xlApplication.ActiveWindow.FreezePanes = false;
            FreezeReFreezePanes.Label = UI_Resources.FreezeOnActiveCell;
        }

        private void AutoFitColumns_Click(object sender, RibbonControlEventArgs e)
        {
            CurrentSelection.Columns.AutoFit();
        }

        private void AutoFitRows_Click(object sender, RibbonControlEventArgs e)
        {
            CurrentSelection.Rows.AutoFit();
        }

        private void ListFromSelection_Click(object sender, RibbonControlEventArgs e)
        {
            var uniqueValues = UniqueCellValues(CurrentSelection);

            if (!uniqueValues.Any())
            {
                MessageBox.Show(List_From_Selection.NothingToCreate, List_From_Selection.ListNotCreated, MessageBoxButtons.OK);

                return;
            }

            var testDestination = xlApplication.InputBox(List_From_Selection.ChooseListDestination, List_From_Selection.ListLocation, Type: 8);
            if (!(testDestination is XL.Range destination))
            { 
                MessageBox.Show(List_From_Selection.NoDestinationChosen, List_From_Selection.ListNotCreated, MessageBoxButtons.OK);
                return;
            }

            destination = destination.Resize[uniqueValues.Count];
            
            if (WillOverwriteCells(destination))
            {
                var result = MessageBox.Show(string.Format(List_From_Selection.OverwriteMessage,Environment.NewLine), 
                    List_From_Selection.OverwriteTitle, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            
            destination.Value2 = xlApplication.WorksheetFunction.Transpose(uniqueValues.ToArray());
            destination.BorderAround2(XL.XlLineStyle.xlContinuous);
        }

        private bool WillOverwriteCells(XL.Range destination)
        {
            bool overwritesFormulas;
            bool overwritesConstants;
            if (destination.Cells.Count == 1)
            {
                overwritesFormulas = destination.HasFormula;
                overwritesConstants = destination.Value2 != string.Empty;
            }
            else
            {
                try
                {
                    overwritesFormulas = destination.SpecialCells(XL.XlCellType.xlCellTypeFormulas).Count > 0;
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    overwritesFormulas = false;
                }

                try
                {
                    overwritesConstants = destination.SpecialCells(XL.XlCellType.xlCellTypeConstants).Count > 0;
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    overwritesConstants = false;
                }
            }

            return overwritesConstants || overwritesFormulas;
        }

        private List<string> UniqueCellValues(XL.Range selection)
        {
            var uniqueValues = new List<string>();
            foreach (XL.Range cell in selection.Cells)
            {
                if (!uniqueValues.Contains(cell.Value2) && cell.Value2 != string.Empty && cell.Value2 != null)
                {
                    uniqueValues.Add(cell.Value2);
                }
            }

            return uniqueValues;
        }

        private void TextualNumbersToNumbers_Click(object sender, RibbonControlEventArgs e)
        {
            foreach (XL.Range subArea in CurrentSelection.Areas)
            {
                ConvertToNumber(subArea);
            }
        }

        private void ConvertToNumber(XL.Range subArea)
        {
            if (subArea.Cells.Count > 1)
            {
                foreach (XL.Range cell in subArea.Cells)
                {
                    CheckAndConvert(cell);
                }
            }
            else
            {
                CheckAndConvert(subArea);
            }

            void CheckAndConvert(XL.Range cell)
            {
                if (cell.Value2 == null
                    || cell.Value2.GetType().Name.Equals("Double"))
                {
                    return;
                }

                if (double.TryParse(cell.Value2, out double numericNumber) && cell.Value2 != string.Empty)
                {
                    cell.Value2 = numericNumber;
                }
            }
        }

        private enum OffsetDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        private void SolveSystemOfLinearEquations_Click(object sender, RibbonControlEventArgs e)
        {
            Systems_Of_Linear_Equations.SystemsOfEquationsView view = new Systems_Of_Linear_Equations.SystemsOfEquationsView();
            view.Show();
        }
    }
}
