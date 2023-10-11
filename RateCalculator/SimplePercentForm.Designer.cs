namespace RateCalculator
{
    partial class SimplePercentForm
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
            this.percentIn = new System.Windows.Forms.TextBox();
            this.txtBxLabel = new System.Windows.Forms.Label();
            this.periodIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueIn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CompRes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // percentIn
            // 
            this.percentIn.Location = new System.Drawing.Point(284, 72);
            this.percentIn.Name = "percentIn";
            this.percentIn.Size = new System.Drawing.Size(109, 23);
            this.percentIn.TabIndex = 0;
            // 
            // txtBxLabel
            // 
            this.txtBxLabel.AutoSize = true;
            this.txtBxLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxLabel.Location = new System.Drawing.Point(13, 72);
            this.txtBxLabel.Name = "txtBxLabel";
            this.txtBxLabel.Size = new System.Drawing.Size(258, 20);
            this.txtBxLabel.TabIndex = 1;
            this.txtBxLabel.Text = "Ежемесячная процентная ставка, %";
            // 
            // periodIn
            // 
            this.periodIn.Location = new System.Drawing.Point(284, 145);
            this.periodIn.Name = "periodIn";
            this.periodIn.Size = new System.Drawing.Size(109, 23);
            this.periodIn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество месяцев";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(155, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объем кредита";
            // 
            // valueIn
            // 
            this.valueIn.Location = new System.Drawing.Point(284, 219);
            this.valueIn.Name = "valueIn";
            this.valueIn.Size = new System.Drawing.Size(109, 23);
            this.valueIn.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Result_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сумма для погашения:";
            // 
            // CompRes
            // 
            this.CompRes.AutoSize = true;
            this.CompRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompRes.Location = new System.Drawing.Point(270, 297);
            this.CompRes.Name = "CompRes";
            this.CompRes.Size = new System.Drawing.Size(0, 20);
            this.CompRes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 9;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SimplePercentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CompRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valueIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodIn);
            this.Controls.Add(this.txtBxLabel);
            this.Controls.Add(this.percentIn);
            this.Name = "SimplePercentForm";
            this.Text = "Простые проценты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox percentIn;
        private System.Windows.Forms.Label txtBxLabel;
        private System.Windows.Forms.TextBox periodIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CompRes;
        private System.Windows.Forms.Label label4;
    }
}
