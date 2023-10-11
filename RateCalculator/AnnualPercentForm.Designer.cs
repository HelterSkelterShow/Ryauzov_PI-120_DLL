namespace RateCalculator
{
    partial class AnnualPercentForm
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
            this.AnnualRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnnualResBtn = new System.Windows.Forms.Button();
            this.AnnualTimesIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnnualPeriodIn = new System.Windows.Forms.TextBox();
            this.txtBxLabel = new System.Windows.Forms.Label();
            this.AnnualPercentIn = new System.Windows.Forms.TextBox();
            this.AnnualValueIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnnualRes
            // 
            this.AnnualRes.AutoSize = true;
            this.AnnualRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnnualRes.Location = new System.Drawing.Point(299, 317);
            this.AnnualRes.Name = "AnnualRes";
            this.AnnualRes.Size = new System.Drawing.Size(0, 20);
            this.AnnualRes.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Сумма для погашения:";
            // 
            // AnnualResBtn
            // 
            this.AnnualResBtn.Location = new System.Drawing.Point(208, 394);
            this.AnnualResBtn.Name = "AnnualResBtn";
            this.AnnualResBtn.Size = new System.Drawing.Size(200, 30);
            this.AnnualResBtn.TabIndex = 15;
            this.AnnualResBtn.Text = "Рассчитать";
            this.AnnualResBtn.UseVisualStyleBackColor = true;
            this.AnnualResBtn.Click += new System.EventHandler(this.AnnualResBtn_Click);
            // 
            // AnnualTimesIn
            // 
            this.AnnualTimesIn.Location = new System.Drawing.Point(277, 173);
            this.AnnualTimesIn.Name = "AnnualTimesIn";
            this.AnnualTimesIn.Size = new System.Drawing.Size(109, 23);
            this.AnnualTimesIn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Начислений процентов за год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Срок выплаты, лет";
            // 
            // AnnualPeriodIn
            // 
            this.AnnualPeriodIn.Location = new System.Drawing.Point(277, 100);
            this.AnnualPeriodIn.Name = "AnnualPeriodIn";
            this.AnnualPeriodIn.Size = new System.Drawing.Size(109, 23);
            this.AnnualPeriodIn.TabIndex = 11;
            // 
            // txtBxLabel
            // 
            this.txtBxLabel.AutoSize = true;
            this.txtBxLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxLabel.Location = new System.Drawing.Point(43, 30);
            this.txtBxLabel.Name = "txtBxLabel";
            this.txtBxLabel.Size = new System.Drawing.Size(221, 20);
            this.txtBxLabel.TabIndex = 10;
            this.txtBxLabel.Text = "Годовая процентная ставка, %";
            // 
            // AnnualPercentIn
            // 
            this.AnnualPercentIn.Location = new System.Drawing.Point(277, 31);
            this.AnnualPercentIn.Name = "AnnualPercentIn";
            this.AnnualPercentIn.Size = new System.Drawing.Size(109, 23);
            this.AnnualPercentIn.TabIndex = 9;
            // 
            // AnnualValueIn
            // 
            this.AnnualValueIn.Location = new System.Drawing.Point(277, 246);
            this.AnnualValueIn.Name = "AnnualValueIn";
            this.AnnualValueIn.Size = new System.Drawing.Size(109, 23);
            this.AnnualValueIn.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(148, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Объем кредита";
            // 
            // AnnualPercentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.AnnualValueIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnnualRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnnualResBtn);
            this.Controls.Add(this.AnnualTimesIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnnualPeriodIn);
            this.Controls.Add(this.txtBxLabel);
            this.Controls.Add(this.AnnualPercentIn);
            this.Name = "AnnualPercentForm";
            this.Text = "Годовая процентная ставка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnnualRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AnnualResBtn;
        private System.Windows.Forms.TextBox AnnualTimesIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnnualPeriodIn;
        private System.Windows.Forms.Label txtBxLabel;
        private System.Windows.Forms.TextBox AnnualPercentIn;
        private System.Windows.Forms.TextBox AnnualValueIn;
        private System.Windows.Forms.Label label4;
    }
}