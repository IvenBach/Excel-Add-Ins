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
            this.TabCPCustomization = this.Factory.CreateRibbonTab();
            this.GroupDisplay = this.Factory.CreateRibbonGroup();
            this.R1C1ReferenceStyle = this.Factory.CreateRibbonCheckBox();
            this.DisplayPageBreaks = this.Factory.CreateRibbonCheckBox();
            this.StructuredTableReferences = this.Factory.CreateRibbonCheckBox();
            this.GroupView = this.Factory.CreateRibbonGroup();
            this.FreezeReFreezePanes = this.Factory.CreateRibbonButton();
            this.UnFreezePanes = this.Factory.CreateRibbonButton();
            this.GroupSelection = this.Factory.CreateRibbonGroup();
            this.AutoFitColumns = this.Factory.CreateRibbonButton();
            this.AutoFitRows = this.Factory.CreateRibbonButton();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.ListFromSelection = this.Factory.CreateRibbonButton();
            this.TextualNumbersToNumbers = this.Factory.CreateRibbonButton();
            this.GroupRangeOffset = this.Factory.CreateRibbonGroup();
            this.offsetLeft = this.Factory.CreateRibbonButton();
            this.offsetUp = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.offsetRight = this.Factory.CreateRibbonButton();
            this.offsetDown = this.Factory.CreateRibbonButton();
            this.TabCPCustomization.SuspendLayout();
            this.GroupDisplay.SuspendLayout();
            this.GroupView.SuspendLayout();
            this.GroupSelection.SuspendLayout();
            this.GroupRangeOffset.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabCPCustomization
            // 
            this.TabCPCustomization.Groups.Add(this.GroupDisplay);
            this.TabCPCustomization.Groups.Add(this.GroupView);
            this.TabCPCustomization.Groups.Add(this.GroupSelection);
            this.TabCPCustomization.Groups.Add(this.GroupRangeOffset);
            this.TabCPCustomization.KeyTip = "CPC";
            this.TabCPCustomization.Label = "CPCustomization";
            this.TabCPCustomization.Name = "TabCPCustomization";
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
            // GroupRangeOffset
            // 
            this.GroupRangeOffset.Items.Add(this.offsetLeft);
            this.GroupRangeOffset.Items.Add(this.offsetUp);
            this.GroupRangeOffset.Items.Add(this.separator1);
            this.GroupRangeOffset.Items.Add(this.offsetRight);
            this.GroupRangeOffset.Items.Add(this.offsetDown);
            this.GroupRangeOffset.Label = "Range Offset";
            this.GroupRangeOffset.Name = "GroupRangeOffset";
            // 
            // offsetLeft
            // 
            this.offsetLeft.Image = ((System.Drawing.Image)(resources.GetObject("offsetLeft.Image")));
            this.offsetLeft.KeyTip = "OL";
            this.offsetLeft.Label = "Offset Left";
            this.offsetLeft.Name = "offsetLeft";
            this.offsetLeft.ShowImage = true;
            this.offsetLeft.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetLeft_Click);
            // 
            // offsetUp
            // 
            this.offsetUp.Image = ((System.Drawing.Image)(resources.GetObject("offsetUp.Image")));
            this.offsetUp.KeyTip = "OU";
            this.offsetUp.Label = "Offset Up";
            this.offsetUp.Name = "offsetUp";
            this.offsetUp.ShowImage = true;
            this.offsetUp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetUp_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // offsetRight
            // 
            this.offsetRight.Image = ((System.Drawing.Image)(resources.GetObject("offsetRight.Image")));
            this.offsetRight.KeyTip = "OR";
            this.offsetRight.Label = "Offset Right";
            this.offsetRight.Name = "offsetRight";
            this.offsetRight.ShowImage = true;
            this.offsetRight.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetRight_Click);
            // 
            // offsetDown
            // 
            this.offsetDown.Image = ((System.Drawing.Image)(resources.GetObject("offsetDown.Image")));
            this.offsetDown.KeyTip = "OD";
            this.offsetDown.Label = "Offset Down";
            this.offsetDown.Name = "offsetDown";
            this.offsetDown.ShowImage = true;
            this.offsetDown.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OffsetDown_Click);
            // 
            // CPCustomization
            // 
            this.Name = "CPCustomization";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.TabCPCustomization);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.FooRibbon_Load);
            this.TabCPCustomization.ResumeLayout(false);
            this.TabCPCustomization.PerformLayout();
            this.GroupDisplay.ResumeLayout(false);
            this.GroupDisplay.PerformLayout();
            this.GroupView.ResumeLayout(false);
            this.GroupView.PerformLayout();
            this.GroupSelection.ResumeLayout(false);
            this.GroupSelection.PerformLayout();
            this.GroupRangeOffset.ResumeLayout(false);
            this.GroupRangeOffset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab TabCPCustomization;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupRangeOffset;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton offsetRight;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton offsetUp;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton offsetDown;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton offsetLeft;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupDisplay;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox R1C1ReferenceStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox DisplayPageBreaks;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox StructuredTableReferences;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupView;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton FreezeReFreezePanes;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton UnFreezePanes;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupSelection;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AutoFitColumns;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AutoFitRows;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ListFromSelection;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TextualNumbersToNumbers;
    }

    partial class ThisRibbonCollection
    {
        internal CPCustomization CPCustomization
        {
            get { return this.GetRibbon<CPCustomization>(); }
        }
    }
}
