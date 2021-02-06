namespace _2._0
{
    partial class frmSimpleCalculator
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
            this.lblOperandOne = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblOperandTwo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOperandOne = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtOperandTwo = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOperandOne
            // 
            this.lblOperandOne.AutoSize = true;
            this.lblOperandOne.Location = new System.Drawing.Point(46, 56);
            this.lblOperandOne.Name = "lblOperandOne";
            this.lblOperandOne.Size = new System.Drawing.Size(80, 17);
            this.lblOperandOne.TabIndex = 0;
            this.lblOperandOne.Text = "Operand 1:";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(46, 99);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(69, 17);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Operator:";
            // 
            // lblOperandTwo
            // 
            this.lblOperandTwo.AutoSize = true;
            this.lblOperandTwo.Location = new System.Drawing.Point(46, 145);
            this.lblOperandTwo.Name = "lblOperandTwo";
            this.lblOperandTwo.Size = new System.Drawing.Size(80, 17);
            this.lblOperandTwo.TabIndex = 2;
            this.lblOperandTwo.Text = "Operand 2:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(46, 195);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(49, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(209, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOperandOne
            // 
            this.txtOperandOne.Location = new System.Drawing.Point(168, 51);
            this.txtOperandOne.Name = "txtOperandOne";
            this.txtOperandOne.Size = new System.Drawing.Size(164, 22);
            this.txtOperandOne.TabIndex = 6;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(168, 94);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(100, 22);
            this.txtOperator.TabIndex = 7;
            // 
            // txtOperandTwo
            // 
            this.txtOperandTwo.Location = new System.Drawing.Point(168, 140);
            this.txtOperandTwo.Name = "txtOperandTwo";
            this.txtOperandTwo.Size = new System.Drawing.Size(164, 22);
            this.txtOperandTwo.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(168, 190);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(164, 22);
            this.txtResult.TabIndex = 9;
            // 
            // frmSimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 327);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperandTwo);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtOperandOne);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperandTwo);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOperandOne);
            this.Name = "frmSimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperandOne;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblOperandTwo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOperandOne;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtOperandTwo;
        private System.Windows.Forms.TextBox txtResult;
    }
}

