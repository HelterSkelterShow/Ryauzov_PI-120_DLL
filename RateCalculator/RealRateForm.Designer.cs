namespace RateCalculator
{
    partial class RealRateForm
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
            this.RealRateResBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpInflationIn = new System.Windows.Forms.TextBox();
            this.txtBxLabel = new System.Windows.Forms.Label();
            this.NomRateIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RealRateRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RealRateResBtn
            // 
            this.RealRateResBtn.Location = new System.Drawing.Point(192, 368);
            this.RealRateResBtn.Name = "RealRateResBtn";
            this.RealRateResBtn.Size = new System.Drawing.Size(200, 30);
            this.RealRateResBtn.TabIndex = 7;
            this.RealRateResBtn.Text = "Рассчитать";
            this.RealRateResBtn.UseVisualStyleBackColor = true;
            this.RealRateResBtn.Click += new System.EventHandler(this.RealRateResBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ожидаемая инфляция, %";
            // 
            // ExpInflationIn
            // 
            this.ExpInflationIn.Location = new System.Drawing.Point(283, 176);
            this.ExpInflationIn.Name = "ExpInflationIn";
            this.ExpInflationIn.Size = new System.Drawing.Size(109, 23);
            this.ExpInflationIn.TabIndex = 10;
            // 
            // txtBxLabel
            // 
            this.txtBxLabel.AutoSize = true;
            this.txtBxLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxLabel.Location = new System.Drawing.Point(12, 103);
            this.txtBxLabel.Name = "txtBxLabel";
            this.txtBxLabel.Size = new System.Drawing.Size(262, 20);
            this.txtBxLabel.TabIndex = 9;
            this.txtBxLabel.Text = "Номинальная процентная ставка, %";
            // 
            // NomRateIn
            // 
            this.NomRateIn.Location = new System.Drawing.Point(283, 103);
            this.NomRateIn.Name = "NomRateIn";
            this.NomRateIn.Size = new System.Drawing.Size(109, 23);
            this.NomRateIn.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Реальная процентная ставка:";
            // 
            // RealRateRes
            // 
            this.RealRateRes.AutoSize = true;
            this.RealRateRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RealRateRes.Location = new System.Drawing.Point(325, 279);
            this.RealRateRes.Name = "RealRateRes";
            this.RealRateRes.Size = new System.Drawing.Size(0, 20);
            this.RealRateRes.TabIndex = 13;
            // 
            // RealRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.RealRateRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpInflationIn);
            this.Controls.Add(this.txtBxLabel);
            this.Controls.Add(this.NomRateIn);
            this.Controls.Add(this.RealRateResBtn);
            this.Name = "RealRateForm";
            this.Text = "Реальная процентная ставка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RealRateResBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExpInflationIn;
        private System.Windows.Forms.Label txtBxLabel;
        private System.Windows.Forms.TextBox NomRateIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RealRateRes;
    }
}