namespace ExcelAddIn1
{
    partial class CPCustomization : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CPCustomization()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPCustomization));
            this.GroupSystemOfLinearEquations = this.Factory.CreateRibbonGroup();
            this.SolveSystemOfLinearEquations = this.Factory.CreateRibbonButton();
            this.GroupRangeOffset = this.Factory.CreateRibbonGroup();
            this.OffsetLeft = this.Factory.CreateRibbonButton();
            this.OffsetUp = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.OffsetRight = this.Factory.CreateRibbonButton();
            this.OffsetDown = this.Factory.CreateRibbonButton();
            this.GroupSelection = this.Factory.CreateRibbonGroup();
            this.AutoFitColumns = this.Factory.CreateRibbonButton();
            this.AutoFitRows = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.ListFromSelection = this.Factory.CreateRibbonButton();
            this.TextualNumbersToNumbers = this.Factory.CreateRibbonButton();
            this.GroupView = this.Factory.CreateRibbonGroup();
            this.FreezeReFreezePanes = this.Factory.CreateRibbonButton();
            this.UnFreezePanes = this.Factory.CreateRibbonButton();
            this.GroupDisplay = this.Factory.CreateRibbonGroup();
            this.R1C1ReferenceStyle = this.Factory.CreateRibbonCheckBox();
            this.DisplayPageBreaks = this.Factory.CreateRibbonCheckBox();
            this.StructuredTableReferences = this.Factory.CreateRibbonCheckBox();
            this.TabCPCustomization = this.Factory.CreateRibbonTab();
            this.GroupRangeResize = this.Factory.CreateRibbonGroup();
            this.ResizeDecreaseColumn = this.Factory.CreateRibbonButton();
            this.ResizeDecreaseRow = this.Factory.CreateRibbonButton();
            this.separator3 = this.Factory.CreateRibbonSeparator();
            this.ResizeIncreaseColumn = this.Factory.CreateRibbonButton();
            this.ResizeIncreaseRow = this.Factory.CreateRibbonButton();
            this.GroupSystemOfLinearEquations.SuspendLayout();
            this.GroupRangeOffset.SuspendLayout();
            this.GroupSelection.SuspendLayout();
            this.GroupView.SuspendLayout();
            this.GroupDisplay.SuspendLayout();
            this.TabCPCustomization.SuspendLayout();
            this.GroupRangeResize.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupSystemOfLinearEquations
            // 
            this.GroupSystemOfLinearEquations.Items.Add(this.SolveSystemOfLinearEquations);
            this.GroupSystemOfLinearEquations.Label = "System of Linear Equations";
            this.GroupSystemOfLinearEquations.Name = "GroupSystemOfLinearEquations";
            // 
            // SolveSystemOfLinearEquations
            // 
            this.SolveSystemOfLinearEquations.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SolveSystemOfLinearEquations.Image = ((System.Drawing.Image)(resources.GetObject("SolveSystemOfLinearEquations.Image")));
            this.SolveSystemOfLinearEquations.Label = "Solve System";
            this.SolveSystemOfLinearEquations.Name = "SolveSystemOfLinearEquations";
            this.SolveSystemOfLinearEquations.ShowImage = true;
            this.SolveSystemOfLinearEquations.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SolveSystemOfLinearEquations_Click);
            // 
            // GroupRangeOffset
            // 
            this.GroupRangeOffset.Items.Add(this.OffsetLeft);
            this.GroupRangeOffset.Items.Add(this.OffsetUp);
            this.GroupRangeOffset.Items.Add(this.separator1);
            this.GroupRangeOffset.Items.Add(this.OffsetRight);
            this.GroupRangeOffset.Items.Add(this.OffsetDown);
            this.GroupRangeOffset.Label = "Range Offset";
            this.GroupRangeOffset.Name = "GroupRangeOffset";
            // 
            // OffsetLeft
            // 
            this.OffsetLeft.Image = ((System.Drawing.Image)(resources.GetObject("OffsetLeft.Image")));
            this.OffsetLeft.KeyTip = "OL";
            this.OffsetLeft.Label = "Offset Left";
            this.OffsetLeft.Name = "OffsetLeft";
            this.OffsetLeft.ShowImage = true;
            this.OffsetLeft.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetLeft_Click);
            // 
            // OffsetUp
            // 
            this.OffsetUp.Image = ((System.Drawing.Image)(resources.GetObject("OffsetUp.Image")));
            this.OffsetUp.KeyTip = "OU";
            this.OffsetUp.Label = "Offset Up";
            this.OffsetUp.Name = "OffsetUp";
            this.OffsetUp.ShowImage = true;
            this.OffsetUp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetUp_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // OffsetRight
            // 
            this.OffsetRight.Image = ((System.Drawing.Image)(resources.GetObject("OffsetRight.Image")));
            this.OffsetRight.KeyTip = "OR";
            this.OffsetRight.Label = "Offset Right";
            this.OffsetRight.Name = "OffsetRight";
            this.OffsetRight.ShowImage = true;
            this.OffsetRight.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetRight_Click);
            // 
            // OffsetDown
            // 
            this.OffsetDown.Image = ((System.Drawing.Image)(resources.GetObject("OffsetDown.Image")));
            this.OffsetDown.KeyTip = "OD";
            this.OffsetDown.Label = "Offset Down";
            this.OffsetDown.Name = "OffsetDown";
            this.OffsetDown.ShowImage = true;
            this.OffsetDown.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetDown_Click);
            // 
            // GroupSelection
            // 
            this.GroupSelection.Items.Add(this.AutoFitColumns);
            this.GroupSelection.Items.Add(this.AutoFitRows);
            this.GroupSelection.Items.Add(this.separator2);
            this.GroupSelection.Items.Add(this.ListFromSelection);
            this.GroupSelection.Items.Add(this.TextualNumbersToNumbers);
            this.GroupSelection.Label = "Selection";
            this.GroupSelection.Name = "GroupSelection";
            // 
            // AutoFitColumns
            // 
            this.AutoFitColumns.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AutoFitColumns.Label = "Autofit Columns";
            this.AutoFitColumns.Name = "AutoFitColumns";
            this.AutoFitColumns.OfficeImageId = "SpeakByRows";
            this.AutoFitColumns.ShowImage = true;
            this.AutoFitColumns.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AutoFitColumns_Click);
            // 
            // AutoFitRows
            // 
            this.AutoFitRows.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AutoFitRows.Label = "Autofit Rows";
            this.AutoFitRows.Name = "AutoFitRows";
            this.AutoFitRows.OfficeImageId = "SpeakByColumns";
            this.AutoFitRows.ShowImage = true;
            this.AutoFitRows.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AutoFitRows_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // ListFromSelection
            // 
            this.ListFromSelection.Label = "Create List From Selection";
            this.ListFromSelection.Name = "ListFromSelection";
            this.ListFromSelection.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ListFromSelection_Click);
            // 
            // TextualNumbersToNumbers
            // 
            this.TextualNumbersToNumbers.Label = "TextNumbers to Numbers";
            this.TextualNumbersToNumbers.Name = "TextualNumbersToNumbers";
            this.TextualNumbersToNumbers.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TextualNumbersToNumbers_Click);
            // 
            // GroupView
            // 
            this.GroupView.Items.Add(this.FreezeReFreezePanes);
            this.GroupView.Items.Add(this.UnFreezePanes);
            this.GroupView.Label = "View";
            this.GroupView.Name = "GroupView";
            // 
            // FreezeReFreezePanes
            // 
            this.FreezeReFreezePanes.Label = "Freeze Panes";
            this.FreezeReFreezePanes.Name = "FreezeReFreezePanes";
            this.FreezeReFreezePanes.OfficeImageId = "FreezePanes";
            this.FreezeReFreezePanes.ShowImage = true;
            this.FreezeReFreezePanes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.FreezeReFreezePanes_Click);
            // 
            // UnFreezePanes
            // 
            this.UnFreezePanes.Label = "Unfreeze Panes";
            this.UnFreezePanes.Name = "UnFreezePanes";
            this.UnFreezePanes.OfficeImageId = "FreezePanes";
            this.UnFreezePanes.ShowImage = true;
            this.UnFreezePanes.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.UnFreezePanes_Click);
            // 
            // GroupDisplay
            // 
            this.GroupDisplay.Items.Add(this.R1C1ReferenceStyle);
            this.GroupDisplay.Items.Add(this.DisplayPageBreaks);
            this.GroupDisplay.Items.Add(this.StructuredTableReferences);
            this.GroupDisplay.Label = "Display";
            this.GroupDisplay.Name = "GroupDisplay";
            // 
            // R1C1ReferenceStyle
            // 
            this.R1C1ReferenceStyle.Label = "R1C1 Reference Style";
            this.R1C1ReferenceStyle.Name = "R1C1ReferenceStyle";
            this.R1C1ReferenceStyle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.R1C1ReferenceStyle_Click);
            // 
            // DisplayPageBreaks
            // 
            this.DisplayPageBreaks.Label = "Page Breaks";
            this.DisplayPageBreaks.Name = "DisplayPageBreaks";
            this.DisplayPageBreaks.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DisplayPageBreaks_Click);
            // 
            // StructuredTableReferences
            // 
            this.StructuredTableReferences.Label = "Structured Table References";
            this.StructuredTableReferences.Name = "StructuredTableReferences";
            this.StructuredTableReferences.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TableStructureReference_Click);
            // 
            // TabCPCustomization
            // 
            this.TabCPCustomization.Groups.Add(this.GroupDisplay);
            this.TabCPCustomization.Groups.Add(this.GroupView);
            this.TabCPCustomization.Groups.Add(this.GroupSelection);
            this.TabCPCustomization.Groups.Add(this.GroupRangeOffset);
            this.TabCPCustomization.Groups.Add(this.GroupRangeResize);
            this.TabCPCustomization.Groups.Add(this.GroupSystemOfLinearEquations);
            this.TabCPCustomization.KeyTip = "CPC";
            this.TabCPCustomization.Label = "CPCustomization";
            this.TabCPCustomization.Name = "TabCPCustomization";
            // 
            // GroupRangeResize
            // 
            this.GroupRangeResize.Items.Add(this.ResizeDecreaseColumn);
            this.GroupRangeResize.Items.Add(this.ResizeDecreaseRow);
            this.GroupRangeResize.Items.Add(this.separator3);
            this.GroupRangeResize.Items.Add(this.ResizeIncreaseColumn);
            this.GroupRangeResize.Items.Add(this.ResizeIncreaseRow);
            this.GroupRangeResize.Label = "Range Resize";
            this.GroupRangeResize.Name = "GroupRangeResize";
            // 
            // ResizeDecreaseColumn
            // 
            this.ResizeDecreaseColumn.Image = global::ExcelAddIn1.Properties.Resources.ResizeLeft;
            this.ResizeDecreaseColumn.Label = "Decrease Column";
            this.ResizeDecreaseColumn.Name = "ResizeDecreaseColumn";
            this.ResizeDecreaseColumn.ShowImage = true;
            this.ResizeDecreaseColumn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ResizeDecreaseColumn_Click);
            // 
            // ResizeDecreaseRow
            // 
            this.ResizeDecreaseRow.Image = global::ExcelAddIn1.Properties.Resources.ResizeUp;
            this.ResizeDecreaseRow.Label = "Decrease Row";
            this.ResizeDecreaseRow.Name = "ResizeDecreaseRow";
            this.ResizeDecreaseRow.ShowImage = true;
            this.ResizeDecreaseRow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ResizeDecreaseRow_Click);
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            // 
            // ResizeIncreaseColumn
            // 
            this.ResizeIncreaseColumn.Image = global::ExcelAddIn1.Properties.Resources.ResizeRight;
            this.ResizeIncreaseColumn.Label = "Increase Column";
            this.ResizeIncreaseColumn.Name = "ResizeIncreaseColumn";
            this.ResizeIncreaseColumn.ShowImage = true;
            this.ResizeIncreaseColumn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ResizeIncreaseColumn_Click);
            // 
            // ResizeIncreaseRow
            // 
            this.ResizeIncreaseRow.Image = global::ExcelAddIn1.Properties.Resources.ResizeDown;
            this.ResizeIncreaseRow.Label = "Increase Row";
            this.ResizeIncreaseRow.Name = "ResizeIncreaseRow";
            this.ResizeIncreaseRow.ShowImage = true;
            this.ResizeIncreaseRow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ResizeIncreaseRow_Click);
            // 
            // CPCustomization
            // 
            this.Name = "CPCustomization";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.TabCPCustomization);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.FooRibbon_Load);
            this.GroupSystemOfLinearEquations.ResumeLayout(false);
            this.GroupSystemOfLinearEquations.PerformLayout();
            this.GroupRangeOffset.ResumeLayout(false);
            this.GroupRangeOffset.PerformLayout();
            this.GroupSelection.ResumeLayout(false);
            this.GroupSelection.PerformLayout();
            this.GroupView.ResumeLayout(false);
            this.GroupView.PerformLayout();
            this.GroupDisplay.ResumeLayout(false);
            this.GroupDisplay.PerformLayout();
            this.TabCPCustomization.ResumeLayout(false);
            this.TabCPCustomization.PerformLayout();
            this.GroupRangeResize.ResumeLayout(false);
            this.GroupRangeResize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupSystemOfLinearEquations;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SolveSystemOfLinearEquations;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupRangeOffset;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OffsetLeft;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OffsetUp;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OffsetRight;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton OffsetDown;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupSelection;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AutoFitColumns;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AutoFitRows;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ListFromSelection;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TextualNumbersToNumbers;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupView;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FreezeReFreezePanes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton UnFreezePanes;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupDisplay;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox R1C1ReferenceStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox DisplayPageBreaks;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox StructuredTableReferences;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabCPCustomization;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupRangeResize;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ResizeDecreaseColumn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ResizeDecreaseRow;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ResizeIncreaseColumn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ResizeIncreaseRow;
    }

    partial class ThisRibbonCollection
    {
        internal CPCustomization CPCustomization
        {
            get { return this.GetRibbon<CPCustomization>(); }
        }
    }
}
