namespace RateCalculator
{
    partial class MenuForm
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
            this.SimplePercent = new System.Windows.Forms.Button();
            this.CompoundPercent = new System.Windows.Forms.Button();
            this.AnnualRate = new System.Windows.Forms.Button();
            this.ContiniousRate = new System.Windows.Forms.Button();
            this.RealRate = new System.Windows.Forms.Button();
            this.FisherRealRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SimplePercent
            // 
            this.SimplePercent.Location = new System.Drawing.Point(24, 28);
            this.SimplePercent.Name = "SimplePercent";
            this.SimplePercent.Size = new System.Drawing.Size(237, 44);
            this.SimplePercent.TabIndex = 0;
            this.SimplePercent.Text = "Простые проценты";
            this.SimplePercent.UseVisualStyleBackColor = true;
            this.SimplePercent.Click += new System.EventHandler(this.SimplePercent_Click);
            // 
            // CompoundPercent
            // 
            this.CompoundPercent.Location = new System.Drawing.Point(24, 96);
            this.CompoundPercent.Name = "CompoundPercent";
            this.CompoundPercent.Size = new System.Drawing.Size(237, 44);
            this.CompoundPercent.TabIndex = 1;
            this.CompoundPercent.Text = "Сложные проценты";
            this.CompoundPercent.UseVisualStyleBackColor = true;
            this.CompoundPercent.Click += new System.EventHandler(this.CompoundPercent_Click);
            // 
            // AnnualRate
            // 
            this.AnnualRate.Location = new System.Drawing.Point(24, 166);
            this.AnnualRate.Name = "AnnualRate";
            this.AnnualRate.Size = new System.Drawing.Size(237, 44);
            this.AnnualRate.TabIndex = 2;
            this.AnnualRate.Text = "Годовая процентная ставка";
            this.AnnualRate.UseVisualStyleBackColor = true;
            this.AnnualRate.Click += new System.EventHandler(this.AnnualRate_Click);
            // 
            // ContiniousRate
            // 
            this.ContiniousRate.Location = new System.Drawing.Point(24, 234);
            this.ContiniousRate.Name = "ContiniousRate";
            this.ContiniousRate.Size = new System.Drawing.Size(237, 44);
            this.ContiniousRate.TabIndex = 3;
            this.ContiniousRate.Text = "Непрерывная процентная ставка";
            this.ContiniousRate.UseVisualStyleBackColor = true;
            this.ContiniousRate.Click += new System.EventHandler(this.ContiniousRate_Click);
            // 
            // RealRate
            // 
            this.RealRate.Location = new System.Drawing.Point(24, 300);
            this.RealRate.Name = "RealRate";
            this.RealRate.Size = new System.Drawing.Size(237, 44);
            this.RealRate.TabIndex = 4;
            this.RealRate.Text = "Реальная процентная ставка";
            this.RealRate.UseVisualStyleBackColor = true;
            this.RealRate.Click += new System.EventHandler(this.RealRate_Click);
            // 
            // FisherRealRate
            // 
            this.FisherRealRate.Location = new System.Drawing.Point(24, 364);
            this.FisherRealRate.Name = "FisherRealRate";
            this.FisherRealRate.Size = new System.Drawing.Size(237, 44);
            this.FisherRealRate.TabIndex = 5;
            this.FisherRealRate.Text = "Реальная процентная ставка по Фишеру";
            this.FisherRealRate.UseVisualStyleBackColor = true;
            this.FisherRealRate.Click += new System.EventHandler(this.FisherRealRate_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 439);
            this.Controls.Add(this.FisherRealRate);
            this.Controls.Add(this.RealRate);
            this.Controls.Add(this.ContiniousRate);
            this.Controls.Add(this.AnnualRate);
            this.Controls.Add(this.CompoundPercent);
            this.Controls.Add(this.SimplePercent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SimplePercent;
        private System.Windows.Forms.Button CompoundPercent;
        private System.Windows.Forms.Button AnnualRate;
        private System.Windows.Forms.Button ContiniousRate;
        private System.Windows.Forms.Button RealRate;
        private System.Windows.Forms.Button FisherRealRate;
    }
}