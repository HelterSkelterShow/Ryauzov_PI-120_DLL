namespace RateCalculator
{
    partial class FisherRateForm
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
            this.FisherRealRateRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FisherExpInflationIn = new System.Windows.Forms.TextBox();
            this.txtBxLabel = new System.Windows.Forms.Label();
            this.FisherNomRateIn = new System.Windows.Forms.TextBox();
            this.FisherRealRateResBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FisherRealRateRes
            // 
            this.FisherRealRateRes.AutoSize = true;
            this.FisherRealRateRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FisherRealRateRes.Location = new System.Drawing.Point(340, 259);
            this.FisherRealRateRes.Name = "FisherRealRateRes";
            this.FisherRealRateRes.Size = new System.Drawing.Size(0, 20);
            this.FisherRealRateRes.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Реальная процентная ставка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ожидаемая инфляция, %";
            // 
            // FisherExpInflationIn
            // 
            this.FisherExpInflationIn.Location = new System.Drawing.Point(298, 156);
            this.FisherExpInflationIn.Name = "FisherExpInflationIn";
            this.FisherExpInflationIn.Size = new System.Drawing.Size(109, 23);
            this.FisherExpInflationIn.TabIndex = 17;
            // 
            // txtBxLabel
            // 
            this.txtBxLabel.AutoSize = true;
            this.txtBxLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxLabel.Location = new System.Drawing.Point(27, 83);
            this.txtBxLabel.Name = "txtBxLabel";
            this.txtBxLabel.Size = new System.Drawing.Size(262, 20);
            this.txtBxLabel.TabIndex = 16;
            this.txtBxLabel.Text = "Номинальная процентная ставка, %";
            // 
            // FisherNomRateIn
            // 
            this.FisherNomRateIn.Location = new System.Drawing.Point(298, 83);
            this.FisherNomRateIn.Name = "FisherNomRateIn";
            this.FisherNomRateIn.Size = new System.Drawing.Size(109, 23);
            this.FisherNomRateIn.TabIndex = 15;
            // 
            // FisherRealRateResBtn
            // 
            this.FisherRealRateResBtn.Location = new System.Drawing.Point(207, 348);
            this.FisherRealRateResBtn.Name = "FisherRealRateResBtn";
            this.FisherRealRateResBtn.Size = new System.Drawing.Size(200, 30);
            this.FisherRealRateResBtn.TabIndex = 14;
            this.FisherRealRateResBtn.Text = "Рассчитать";
            this.FisherRealRateResBtn.UseVisualStyleBackColor = true;
            this.FisherRealRateResBtn.Click += new System.EventHandler(this.FisherRealRateResBtn_Click);
            // 
            // FisherRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.FisherRealRateRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FisherExpInflationIn);
            this.Controls.Add(this.txtBxLabel);
            this.Controls.Add(this.FisherNomRateIn);
            this.Controls.Add(this.FisherRealRateResBtn);
            this.Name = "FisherRateForm";
            this.Text = "Реальная процентная ставка по Фишеру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FisherRealRateRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FisherExpInflationIn;
        private System.Windows.Forms.Label txtBxLabel;
        private System.Windows.Forms.TextBox FisherNomRateIn;
        private System.Windows.Forms.Button FisherRealRateResBtn;
    }
}