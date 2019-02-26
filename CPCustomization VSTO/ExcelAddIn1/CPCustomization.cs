using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using ExcelAddIn1.Utility;
using ExcelAddIn1.SelectionModifications;

namespace ExcelAddIn1
{
    public partial class CPCustomization
    {
        Excel.Application xlApplication;
        
        private void FooRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            xlApplication = Globals.ThisAddIn.Application;

            ThisAddIn.SynchronizeUI(xlApplication.ActiveSheet);
        }

        private void OffsetLeft_Click(object sender, RibbonControlEventArgs e)
        {
            Offset.Left(xlApplication, _currentSelection);
        }

        private void OffsetUp_Click(object sender, RibbonControlEventArgs e)
        {
            Offset.Up(xlApplication, _currentSelection);
        }

        private void OffsetDown_Click(object sender, RibbonControlEventArgs e)
        {
            Offset.Down(xlApplication, _currentSelection);
        }

        private void OffsetRight_Click(object sender, RibbonControlEventArgs e)
        {
            Offset.Right(xlApplication, _currentSelection);
        }

        private Excel.Range _currentSelection => CurrentSelection.RangeSelection(xlApplication);
        
        private void R1C1ReferenceStyle_Click(object sender, RibbonControlEventArgs e)
        {
            var checkBox = sender as RibbonCheckBox;

            xlApplication.ReferenceStyle = checkBox.Checked
                ? Excel.XlReferenceStyle.xlR1C1
                : Excel.XlReferenceStyle.xlA1;
        }

        private void DisplayPageBreaks_Click(object sender, RibbonControlEventArgs e)
        {
            if (xlApplication.ActiveSheet is Excel.Worksheet activeSheet)
            {
                activeSheet.DisplayPageBreaks = ((RibbonCheckBox)sender).Checked;
            }            
        }

        private void TableStructureReference_Click(object sender, RibbonControlEventArgs e)
        {
            xlApplication.GenerateTableRefs = ((RibbonCheckBox)sender).Checked
                ? Excel.XlGenerateTableRefs.xlGenerateTableRefStruct
                : Excel.XlGenerateTableRefs.xlGenerateTableRefA1;
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
            _currentSelection.Columns.AutoFit();
        }

        private void AutoFitRows_Click(object sender, RibbonControlEventArgs e)
        {
            _currentSelection.Rows.AutoFit();
        }

        private void ListFromSelection_Click(object sender, RibbonControlEventArgs e)
        {
            var uniqueValues = UniqueCellValues(_currentSelection);

            if (!uniqueValues.Any())
            {
                MessageBox.Show(List_From_Selection.NothingToCreate, List_From_Selection.ListNotCreated, MessageBoxButtons.OK);

                return;
            }

            var testDestination = xlApplication.InputBox(List_From_Selection.ChooseListDestination, List_From_Selection.ListLocation, Type: 8);
            if (!(testDestination is Excel.Range destination))
            { 
                MessageBox.Show(List_From_Selection.NoDestinationChosen, List_From_Selection.ListNotCreated, MessageBoxButtons.OK);
                return;
            }

            destination = destination.Resize[uniqueValues.Count];
            
            if (CheckDestination.WillOverwriteInformation(destination))
            {
                var result = MessageBox.Show(string.Format(List_From_Selection.OverwriteMessage,Environment.NewLine), 
                    List_From_Selection.OverwriteTitle, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            
            destination.Value2 = xlApplication.WorksheetFunction.Transpose(uniqueValues.ToArray());
            destination.BorderAround2(Excel.XlLineStyle.xlContinuous);
        }

        private List<string> UniqueCellValues(Excel.Range selection)
        {
            var uniqueValues = new List<string>();
            foreach (Excel.Range cell in selection.Cells)
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
            foreach (Excel.Range subArea in _currentSelection.Areas)
            {
                ConvertToNumber(subArea);
            }
        }

        private void ConvertToNumber(Excel.Range subArea)
        {
            if (subArea.Cells.Count > 1)
            {
                foreach (Excel.Range cell in subArea.Cells)
                {
                    CheckAndConvert(cell);
                }
            }
            else
            {
                CheckAndConvert(subArea);
            }

            void CheckAndConvert(Excel.Range cell)
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

        private System_Of_Linear_Equations.SystemsOfEquationsPresenter presenter = new System_Of_Linear_Equations.SystemsOfEquationsPresenter();
        private void SolveSystemOfLinearEquations_Click(object sender, RibbonControlEventArgs e)
        {
            presenter.View.Hide();
            presenter.View.Show();
        }

        private void ResizeDecreaseColumn_Click(object sender, RibbonControlEventArgs e)
        {
            Resize.DecreaseColumn(xlApplication);
        }

        private void ResizeIncreaseColumn_Click(object sender, RibbonControlEventArgs e)
        {
            Resize.IncreaseColumn(xlApplication);
        }

        private void ResizeDecreaseRow_Click(object sender, RibbonControlEventArgs e)
        {
            Resize.DecreaseRow(xlApplication);
        }

        private void ResizeIncreaseRow_Click(object sender, RibbonControlEventArgs e)
        {
            Resize.IncreaseRow(xlApplication);
        }

        private void FillWithR1C1_Click(object sender, RibbonControlEventArgs e)
        {
            _currentSelection.Formula = "=\"R\"&ROW()&\"C\"&COLUMN()";

            foreach (Excel.Range subArea in _currentSelection.Areas)
            {
                subArea.Value2 = subArea.Value2;
            }
        }
    }
}
