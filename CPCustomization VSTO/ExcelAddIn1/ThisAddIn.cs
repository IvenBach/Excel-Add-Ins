using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

using System.Runtime.InteropServices;

namespace ExcelAddIn1
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            Application.SheetActivate += Application_SheetActivate;
            Application.WorkbookActivate += Application_WorkbookActivate;
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            Application.SheetActivate -= Application_SheetActivate;
            Application.WorkbookActivate -= Application_WorkbookActivate;
        }

        private void Application_WorkbookActivate(Excel.Workbook Wb)
        {
            SynchronizeUI(Wb.ActiveSheet);
        }

        private void Application_SheetActivate(object Sh)
        {
            SynchronizeUI(Application.ActiveSheet);
        }

        public static void SynchronizeUI(object sheet)
        {
            var cpRibbon = Globals.Ribbons.CPCustomization;

            SynchronizeDisplayGroup(cpRibbon, sheet);
            ToggleSelectionDependentGroup(cpRibbon.GroupView, sheet);
            ToggleSelectionDependentGroup(cpRibbon.GroupSelection, sheet);
            ToggleSelectionDependentGroup(cpRibbon.GroupRangeOffset, sheet);
        }

        private static void SynchronizeDisplayGroup(CPCustomization cpRibbon, object sheet)
        {
            cpRibbon.R1C1ReferenceStyle.Checked = Globals.ThisAddIn.Application.ReferenceStyle == Excel.XlReferenceStyle.xlR1C1;
            cpRibbon.StructuredTableReferences.Checked = Globals.ThisAddIn.Application.GenerateTableRefs == Excel.XlGenerateTableRefs.xlGenerateTableRefStruct;

            var isEnabled = sheet is Excel.Worksheet;
            cpRibbon.DisplayPageBreaks.Enabled = isEnabled;
            try
            {
                cpRibbon.DisplayPageBreaks.Checked = ((Excel.Worksheet)sheet)?.DisplayPageBreaks ?? false;
            }
            catch (InvalidCastException ex)
            {
                cpRibbon.DisplayPageBreaks.Checked = false;
            }
        }

        private static void ToggleSelectionDependentGroup(Microsoft.Office.Tools.Ribbon.RibbonGroup ribbonGroup, object sheet)
        {
            var isEnabled = sheet is Excel.Worksheet;
            foreach (var item in ribbonGroup.Items)
            {
                item.Enabled = isEnabled;
            }
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
