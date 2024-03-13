namespace Lab05_A
{
    partial class Form1
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(0, 25);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(230, 35);
            this.lblResult.TabIndex = 21;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAllClear
            // 
            this.btnAllClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAllClear.Location = new System.Drawing.Point(171, 69);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(46, 31);
            this.btnAllClear.TabIndex = 20;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEquals.Location = new System.Drawing.Point(12, 145);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(206, 30);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpression.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExpression.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExpression.Location = new System.Drawing.Point(0, 0);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(230, 25);
            this.lblExpression.TabIndex = 18;
            this.lblExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDivision.Location = new System.Drawing.Point(12, 109);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(46, 31);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMultiplication.Location = new System.Drawing.Point(64, 109);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(47, 31);
            this.btnMultiplication.TabIndex = 16;
            this.btnMultiplication.Text = "×";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubstraction.Location = new System.Drawing.Point(170, 109);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(47, 31);
            this.btnSubstraction.TabIndex = 15;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAddition.Location = new System.Drawing.Point(117, 109);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(47, 31);
            this.btnAddition.TabIndex = 14;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNum.Location = new System.Drawing.Point(12, 69);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(152, 32);
            this.txtNum.TabIndex = 13;
            this.txtNum.Text = "0";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(230, 181);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtNum);
            this.MaximumSize = new System.Drawing.Size(246, 220);
            this.MinimumSize = new System.Drawing.Size(246, 220);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox txtNum;
    }
}

