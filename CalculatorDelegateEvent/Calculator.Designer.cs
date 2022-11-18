namespace CalculatorDelegateEvent
{
    partial class Calculator
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
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.cmbArithmetic = new System.Windows.Forms.ComboBox();
            this.Results = new System.Windows.Forms.GroupBox();
            this.Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.BackColor = System.Drawing.Color.Black;
            this.txtFirstNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstNum.ForeColor = System.Drawing.Color.White;
            this.txtFirstNum.Location = new System.Drawing.Point(181, 182);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(118, 29);
            this.txtFirstNum.TabIndex = 0;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.BackColor = System.Drawing.Color.Black;
            this.txtSecondNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecondNum.ForeColor = System.Drawing.Color.White;
            this.txtSecondNum.Location = new System.Drawing.Point(181, 272);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(118, 29);
            this.txtSecondNum.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(45, 339);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 68);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompute.Location = new System.Drawing.Point(208, 339);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(135, 68);
            this.btnCompute.TabIndex = 3;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNum.ForeColor = System.Drawing.Color.White;
            this.lblFirstNum.Location = new System.Drawing.Point(12, 185);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(135, 22);
            this.lblFirstNum.TabIndex = 4;
            this.lblFirstNum.Text = "First Number:";
            // 
            // lblSecondNum
            // 
            this.lblSecondNum.AutoSize = true;
            this.lblSecondNum.BackColor = System.Drawing.Color.Black;
            this.lblSecondNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondNum.ForeColor = System.Drawing.Color.White;
            this.lblSecondNum.Location = new System.Drawing.Point(12, 275);
            this.lblSecondNum.Name = "lblSecondNum";
            this.lblSecondNum.Size = new System.Drawing.Size(163, 22);
            this.lblSecondNum.TabIndex = 5;
            this.lblSecondNum.Text = "Second Number:";
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.Black;
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 24;
            this.lbResult.Location = new System.Drawing.Point(6, 22);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(286, 122);
            this.lbResult.TabIndex = 6;
            // 
            // cmbArithmetic
            // 
            this.cmbArithmetic.BackColor = System.Drawing.Color.Black;
            this.cmbArithmetic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbArithmetic.ForeColor = System.Drawing.Color.White;
            this.cmbArithmetic.FormattingEnabled = true;
            this.cmbArithmetic.Location = new System.Drawing.Point(207, 230);
            this.cmbArithmetic.Name = "cmbArithmetic";
            this.cmbArithmetic.Size = new System.Drawing.Size(65, 26);
            this.cmbArithmetic.TabIndex = 7;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.lbResult);
            this.Results.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Results.ForeColor = System.Drawing.Color.White;
            this.Results.Location = new System.Drawing.Point(45, 12);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(298, 153);
            this.Results.TabIndex = 8;
            this.Results.TabStop = false;
            this.Results.Text = "Results";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 424);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.cmbArithmetic);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Calculator";
            this.Text = "Skylark Calculator";
            this.Results.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirstNum;
        private TextBox txtSecondNum;
        private Button btnCalculate;
        private Button btnCompute;
        private Label lblFirstNum;
        private Label lblSecondNum;
        private ListBox lbResult;
        private ComboBox cmbArithmetic;
        private GroupBox Results;
    }
}