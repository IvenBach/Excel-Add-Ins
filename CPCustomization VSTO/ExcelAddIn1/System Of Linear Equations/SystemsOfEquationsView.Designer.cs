namespace ExcelAddIn1.System_Of_Linear_Equations
{
    partial class SystemsOfEquationsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectAnswerVectorBotton = new System.Windows.Forms.Button();
            this.SelectCoefficientButton = new System.Windows.Forms.Button();
            this.AnswerVectorDisplay = new System.Windows.Forms.TextBox();
            this.CoefficientMatrixDisplay = new System.Windows.Forms.TextBox();
            this.AnswerVectorLabel = new System.Windows.Forms.Label();
            this.CoefficientMatrixLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectSolutionButton = new System.Windows.Forms.Button();
            this.SelectInverseCoefficientButton = new System.Windows.Forms.Button();
            this.SolutionVectorDisplay = new System.Windows.Forms.TextBox();
            this.InverseCoefficientMatrixDisplay = new System.Windows.Forms.TextBox();
            this.SolutionVectorLabel = new System.Windows.Forms.Label();
            this.InverseCoefficientMatrixLabel = new System.Windows.Forms.Label();
            this.ClearInputsButton = new System.Windows.Forms.Button();
            this.SolveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectAnswerVectorBotton);
            this.groupBox1.Controls.Add(this.SelectCoefficientButton);
            this.groupBox1.Controls.Add(this.AnswerVectorDisplay);
            this.groupBox1.Controls.Add(this.CoefficientMatrixDisplay);
            this.groupBox1.Controls.Add(this.AnswerVectorLabel);
            this.groupBox1.Controls.Add(this.CoefficientMatrixLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // SelectAnswerVectorBotton
            // 
            this.SelectAnswerVectorBotton.Location = new System.Drawing.Point(335, 57);
            this.SelectAnswerVectorBotton.Name = "SelectAnswerVectorBotton";
            this.SelectAnswerVectorBotton.Size = new System.Drawing.Size(128, 23);
            this.SelectAnswerVectorBotton.TabIndex = 5;
            this.SelectAnswerVectorBotton.Text = "Select Answer Vector";
            this.SelectAnswerVectorBotton.UseVisualStyleBackColor = true;
            this.SelectAnswerVectorBotton.Click += new System.EventHandler(this.SelectAnswerVectorBotton_Click);
            // 
            // SelectCoefficientButton
            // 
            this.SelectCoefficientButton.Location = new System.Drawing.Point(156, 57);
            this.SelectCoefficientButton.Name = "SelectCoefficientButton";
            this.SelectCoefficientButton.Size = new System.Drawing.Size(100, 23);
            this.SelectCoefficientButton.TabIndex = 4;
            this.SelectCoefficientButton.Text = "Select Coefficient";
            this.SelectCoefficientButton.UseVisualStyleBackColor = true;
            this.SelectCoefficientButton.Click += new System.EventHandler(this.SelectCoefficientButton_Click);
            // 
            // AnswerVectorDisplay
            // 
            this.AnswerVectorDisplay.Enabled = false;
            this.AnswerVectorDisplay.Location = new System.Drawing.Point(349, 31);
            this.AnswerVectorDisplay.Name = "AnswerVectorDisplay";
            this.AnswerVectorDisplay.ReadOnly = true;
            this.AnswerVectorDisplay.Size = new System.Drawing.Size(100, 20);
            this.AnswerVectorDisplay.TabIndex = 3;
            // 
            // CoefficientMatrixDisplay
            // 
            this.CoefficientMatrixDisplay.Enabled = false;
            this.CoefficientMatrixDisplay.Location = new System.Drawing.Point(156, 31);
            this.CoefficientMatrixDisplay.Name = "CoefficientMatrixDisplay";
            this.CoefficientMatrixDisplay.ReadOnly = true;
            this.CoefficientMatrixDisplay.Size = new System.Drawing.Size(100, 20);
            this.CoefficientMatrixDisplay.TabIndex = 2;
            // 
            // AnswerVectorLabel
            // 
            this.AnswerVectorLabel.AutoSize = true;
            this.AnswerVectorLabel.Location = new System.Drawing.Point(268, 34);
            this.AnswerVectorLabel.Name = "AnswerVectorLabel";
            this.AnswerVectorLabel.Size = new System.Drawing.Size(75, 13);
            this.AnswerVectorLabel.TabIndex = 1;
            this.AnswerVectorLabel.Text = "Answer vector";
            // 
            // CoefficientMatrixLabel
            // 
            this.CoefficientMatrixLabel.AutoSize = true;
            this.CoefficientMatrixLabel.Location = new System.Drawing.Point(63, 34);
            this.CoefficientMatrixLabel.Name = "CoefficientMatrixLabel";
            this.CoefficientMatrixLabel.Size = new System.Drawing.Size(87, 13);
            this.CoefficientMatrixLabel.TabIndex = 0;
            this.CoefficientMatrixLabel.Text = "Coefficient matrix";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectSolutionButton);
            this.groupBox2.Controls.Add(this.SelectInverseCoefficientButton);
            this.groupBox2.Controls.Add(this.SolutionVectorDisplay);
            this.groupBox2.Controls.Add(this.InverseCoefficientMatrixDisplay);
            this.groupBox2.Controls.Add(this.SolutionVectorLabel);
            this.groupBox2.Controls.Add(this.InverseCoefficientMatrixLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs: Top left cell";
            // 
            // SelectSolutionButton
            // 
            this.SelectSolutionButton.Location = new System.Drawing.Point(335, 57);
            this.SelectSolutionButton.Name = "SelectSolutionButton";
            this.SelectSolutionButton.Size = new System.Drawing.Size(128, 23);
            this.SelectSolutionButton.TabIndex = 6;
            this.SelectSolutionButton.Text = "Select Solution Vector";
            this.SelectSolutionButton.UseVisualStyleBackColor = true;
            this.SelectSolutionButton.Click += new System.EventHandler(this.SelectSolutionButton_Click);
            // 
            // SelectInverseCoefficientButton
            // 
            this.SelectInverseCoefficientButton.Location = new System.Drawing.Point(156, 57);
            this.SelectInverseCoefficientButton.Name = "SelectInverseCoefficientButton";
            this.SelectInverseCoefficientButton.Size = new System.Drawing.Size(100, 23);
            this.SelectInverseCoefficientButton.TabIndex = 5;
            this.SelectInverseCoefficientButton.Text = "Select Inverse";
            this.SelectInverseCoefficientButton.UseVisualStyleBackColor = true;
            this.SelectInverseCoefficientButton.Click += new System.EventHandler(this.SelectInverseCoefficientButton_Click);
            // 
            // SolutionVectorDisplay
            // 
            this.SolutionVectorDisplay.Enabled = false;
            this.SolutionVectorDisplay.Location = new System.Drawing.Point(349, 31);
            this.SolutionVectorDisplay.Name = "SolutionVectorDisplay";
            this.SolutionVectorDisplay.ReadOnly = true;
            this.SolutionVectorDisplay.Size = new System.Drawing.Size(100, 20);
            this.SolutionVectorDisplay.TabIndex = 4;
            // 
            // InverseCoefficientMatrixDisplay
            // 
            this.InverseCoefficientMatrixDisplay.Enabled = false;
            this.InverseCoefficientMatrixDisplay.Location = new System.Drawing.Point(156, 31);
            this.InverseCoefficientMatrixDisplay.Name = "InverseCoefficientMatrixDisplay";
            this.InverseCoefficientMatrixDisplay.ReadOnly = true;
            this.InverseCoefficientMatrixDisplay.Size = new System.Drawing.Size(100, 20);
            this.InverseCoefficientMatrixDisplay.TabIndex = 3;
            // 
            // SolutionVectorLabel
            // 
            this.SolutionVectorLabel.AutoSize = true;
            this.SolutionVectorLabel.Location = new System.Drawing.Point(265, 34);
            this.SolutionVectorLabel.Name = "SolutionVectorLabel";
            this.SolutionVectorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SolutionVectorLabel.Size = new System.Drawing.Size(78, 13);
            this.SolutionVectorLabel.TabIndex = 1;
            this.SolutionVectorLabel.Text = "Solution vector";
            // 
            // InverseCoefficientMatrixLabel
            // 
            this.InverseCoefficientMatrixLabel.AutoSize = true;
            this.InverseCoefficientMatrixLabel.Location = new System.Drawing.Point(26, 34);
            this.InverseCoefficientMatrixLabel.Name = "InverseCoefficientMatrixLabel";
            this.InverseCoefficientMatrixLabel.Size = new System.Drawing.Size(124, 13);
            this.InverseCoefficientMatrixLabel.TabIndex = 0;
            this.InverseCoefficientMatrixLabel.Text = "Inverse coefficient matrix";
            // 
            // ClearButton
            // 
            this.ClearInputsButton.Location = new System.Drawing.Point(179, 215);
            this.ClearInputsButton.Name = "ClearButton";
            this.ClearInputsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearInputsButton.TabIndex = 2;
            this.ClearInputsButton.Text = "Clear Inputs";
            this.ClearInputsButton.UseVisualStyleBackColor = true;
            this.ClearInputsButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(260, 215);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(75, 23);
            this.SolveButton.TabIndex = 3;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // SystemsOfEquationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 250);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.ClearInputsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SystemsOfEquationsView";
            this.Text = "SystemsOfEquationsView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AnswerVectorLabel;
        private System.Windows.Forms.Label CoefficientMatrixLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SolutionVectorLabel;
        private System.Windows.Forms.Label InverseCoefficientMatrixLabel;
        private System.Windows.Forms.Button ClearInputsButton;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Button SelectAnswerVectorBotton;
        private System.Windows.Forms.Button SelectCoefficientButton;
        private System.Windows.Forms.Button SelectSolutionButton;
        private System.Windows.Forms.Button SelectInverseCoefficientButton;
        private System.Windows.Forms.TextBox AnswerVectorDisplay;
        private System.Windows.Forms.TextBox CoefficientMatrixDisplay;
        private System.Windows.Forms.TextBox SolutionVectorDisplay;
        private System.Windows.Forms.TextBox InverseCoefficientMatrixDisplay;
    }
}