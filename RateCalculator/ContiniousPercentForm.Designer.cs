namespace RateCalculator
{
    partial class ContiniousPercentForm
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
            this.ContRes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContResBtn = new System.Windows.Forms.Button();
            this.ContValueIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContPeriodIn = new System.Windows.Forms.TextBox();
            this.txtBxLabel = new System.Windows.Forms.Label();
            this.ContPercentIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ContRes
            // 
            this.ContRes.AutoSize = true;
            this.ContRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContRes.Location = new System.Drawing.Point(290, 288);
            this.ContRes.Name = "ContRes";
            this.ContRes.Size = new System.Drawing.Size(0, 20);
            this.ContRes.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Сумма для погашения:";
            // 
            // ContResBtn
            // 
            this.ContResBtn.Location = new System.Drawing.Point(193, 366);
            this.ContResBtn.Name = "ContResBtn";
            this.ContResBtn.Size = new System.Drawing.Size(200, 30);
            this.ContResBtn.TabIndex = 15;
            this.ContResBtn.Text = "Рассчитать";
            this.ContResBtn.UseVisualStyleBackColor = true;
            this.ContResBtn.Click += new System.EventHandler(this.ContResBtn_Click);
            // 
            // ContValueIn
            // 
            this.ContValueIn.Location = new System.Drawing.Point(304, 210);
            this.ContValueIn.Name = "ContValueIn";
            this.ContValueIn.Size = new System.Drawing.Size(109, 23);
            this.ContValueIn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(175, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Объем кредита";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Количество периодов начисления, лет";
            // 
            // ContPeriodIn
            // 
            this.ContPeriodIn.Location = new System.Drawing.Point(304, 136);
            this.ContPeriodIn.Name = "ContPeriodIn";
            this.ContPeriodIn.Size = new System.Drawing.Size(109, 23);
            this.ContPeriodIn.TabIndex = 11;
            // 
            // txtBxLabel
            // 
            this.txtBxLabel.AutoSize = true;
            this.txtBxLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxLabel.Location = new System.Drawing.Point(33, 63);
            this.txtBxLabel.Name = "txtBxLabel";
            this.txtBxLabel.Size = new System.Drawing.Size(258, 20);
            this.txtBxLabel.TabIndex = 10;
            this.txtBxLabel.Text = "Ежемесячная процентная ставка, %";
            // 
            // ContPercentIn
            // 
            this.ContPercentIn.Location = new System.Drawing.Point(304, 63);
            this.ContPercentIn.Name = "ContPercentIn";
            this.ContPercentIn.Size = new System.Drawing.Size(109, 23);
            this.ContPercentIn.TabIndex = 9;
            // 
            // ContiniousPercentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.ContRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContResBtn);
            this.Controls.Add(this.ContValueIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContPeriodIn);
            this.Controls.Add(this.txtBxLabel);
            this.Controls.Add(this.ContPercentIn);
            this.Name = "ContiniousPercentForm";
            this.Text = "Непрерывно начисляемые проценты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ContResBtn;
        private System.Windows.Forms.TextBox ContValueIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContPeriodIn;
        private System.Windows.Forms.Label txtBxLabel;
        private System.Windows.Forms.TextBox ContPercentIn;
    }
}