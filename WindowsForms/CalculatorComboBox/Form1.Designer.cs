namespace CalculatorComboBox
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboSymbol = new ComboBox();
            lblHeading = new Label();
            txtFirstNum = new TextBox();
            txtSecondNum = new TextBox();
            lblEqual = new Label();
            txtResult = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // cboSymbol
            // 
            cboSymbol.FormattingEnabled = true;
            cboSymbol.Items.AddRange(new object[] { "+", "-", "*", "/", "%", "sqrt", "^" });
            cboSymbol.Location = new Point(257, 144);
            cboSymbol.Name = "cboSymbol";
            cboSymbol.Size = new Size(36, 23);
            cboSymbol.TabIndex = 0;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(294, 47);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(86, 15);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Calculator App";
            // 
            // txtFirstNum
            // 
            txtFirstNum.Location = new Point(127, 144);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(100, 23);
            txtFirstNum.TabIndex = 2;
            // 
            // txtSecondNum
            // 
            txtSecondNum.Location = new Point(327, 144);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(100, 23);
            txtSecondNum.TabIndex = 3;
            // 
            // lblEqual
            // 
            lblEqual.AutoSize = true;
            lblEqual.Location = new Point(444, 147);
            lblEqual.Name = "lblEqual";
            lblEqual.Size = new Size(15, 15);
            lblEqual.TabIndex = 4;
            lblEqual.Text = "=";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(476, 144);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(305, 241);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(lblEqual);
            Controls.Add(txtSecondNum);
            Controls.Add(txtFirstNum);
            Controls.Add(lblHeading);
            Controls.Add(cboSymbol);
            Name = "CalculatorForm";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSymbol;
        private Label lblHeading;
        private TextBox txtFirstNum;
        private TextBox txtSecondNum;
        private Label lblEqual;
        private TextBox txtResult;
        private Button btnCalculate;
    }
}
