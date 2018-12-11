namespace ExcelAddIn1.Systems_Of_Linear_Equations
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
            this.RightHandSideVectorInput = new System.Windows.Forms.TextBox();
            this.CoefficientMatrixInput = new System.Windows.Forms.TextBox();
            this.RightHandSideVectorLabel = new System.Windows.Forms.Label();
            this.CoefficientMatrixLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SolutionVectorInput = new System.Windows.Forms.TextBox();
            this.InverseCoefficientMatrixInput = new System.Windows.Forms.TextBox();
            this.SolutionVectorLabel = new System.Windows.Forms.Label();
            this.InverseCoefficientMatrixLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SolveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RightHandSideVectorInput);
            this.groupBox1.Controls.Add(this.CoefficientMatrixInput);
            this.groupBox1.Controls.Add(this.RightHandSideVectorLabel);
            this.groupBox1.Controls.Add(this.CoefficientMatrixLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // RightHandSideVectorInput
            // 
            this.RightHandSideVectorInput.Location = new System.Drawing.Point(382, 31);
            this.RightHandSideVectorInput.Name = "RightHandSideVectorInput";
            this.RightHandSideVectorInput.Size = new System.Drawing.Size(100, 20);
            this.RightHandSideVectorInput.TabIndex = 3;
            // 
            // CoefficientMatrixInput
            // 
            this.CoefficientMatrixInput.Location = new System.Drawing.Point(156, 31);
            this.CoefficientMatrixInput.Name = "CoefficientMatrixInput";
            this.CoefficientMatrixInput.Size = new System.Drawing.Size(100, 20);
            this.CoefficientMatrixInput.TabIndex = 2;
            // 
            // RightHandSideVectorLabel
            // 
            this.RightHandSideVectorLabel.AutoSize = true;
            this.RightHandSideVectorLabel.Location = new System.Drawing.Point(262, 34);
            this.RightHandSideVectorLabel.Name = "RightHandSideVectorLabel";
            this.RightHandSideVectorLabel.Size = new System.Drawing.Size(114, 13);
            this.RightHandSideVectorLabel.TabIndex = 1;
            this.RightHandSideVectorLabel.Text = "Right hand side vector";
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
            this.groupBox2.Controls.Add(this.SolutionVectorInput);
            this.groupBox2.Controls.Add(this.InverseCoefficientMatrixInput);
            this.groupBox2.Controls.Add(this.SolutionVectorLabel);
            this.groupBox2.Controls.Add(this.InverseCoefficientMatrixLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputs";
            // 
            // SolutionVectorInput
            // 
            this.SolutionVectorInput.Location = new System.Drawing.Point(382, 31);
            this.SolutionVectorInput.Name = "SolutionVectorInput";
            this.SolutionVectorInput.Size = new System.Drawing.Size(100, 20);
            this.SolutionVectorInput.TabIndex = 4;
            // 
            // InverseCoefficientMatrixInput
            // 
            this.InverseCoefficientMatrixInput.Location = new System.Drawing.Point(156, 31);
            this.InverseCoefficientMatrixInput.Name = "InverseCoefficientMatrixInput";
            this.InverseCoefficientMatrixInput.Size = new System.Drawing.Size(100, 20);
            this.InverseCoefficientMatrixInput.TabIndex = 3;
            // 
            // SolutionVectorLabel
            // 
            this.SolutionVectorLabel.AutoSize = true;
            this.SolutionVectorLabel.Location = new System.Drawing.Point(298, 34);
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
            this.ClearButton.Location = new System.Drawing.Point(185, 215);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(266, 215);
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
            this.ClientSize = new System.Drawing.Size(541, 250);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.ClearButton);
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
        private System.Windows.Forms.TextBox RightHandSideVectorInput;
        private System.Windows.Forms.TextBox CoefficientMatrixInput;
        private System.Windows.Forms.Label RightHandSideVectorLabel;
        private System.Windows.Forms.Label CoefficientMatrixLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SolutionVectorInput;
        private System.Windows.Forms.TextBox InverseCoefficientMatrixInput;
        private System.Windows.Forms.Label SolutionVectorLabel;
        private System.Windows.Forms.Label InverseCoefficientMatrixLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SolveButton;
    }
}