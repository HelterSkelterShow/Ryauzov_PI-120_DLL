using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rate;

namespace RateCalculator
{
    public partial class AnnualPercentForm : Form
    {
        private AnnualPercentForm()
        {
            InitializeComponent();
        }

        private static AnnualPercentForm annualPercentForm;

        public static AnnualPercentForm GetAnnualForm()       //Да будет синглтон :)
        {
            if (annualPercentForm == null || annualPercentForm.IsDisposed)
            {
                annualPercentForm = new AnnualPercentForm();
            }
            return annualPercentForm;
        }

        private void AnnualResBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int periods = int.Parse(AnnualPeriodIn.Text);
                Decimal value = Convert.ToDecimal(AnnualValueIn.Text);
                double percent = double.Parse(AnnualPercentIn.Text);
                int times = int.Parse(AnnualTimesIn.Text);
                AnnualRes.Text = String.Concat(Convert.ToString(decimal.Round(Rates.AnnualRate(periods, value, percent, times), 2)), " руб.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка при вводе значений");
            }
            catch
            {
                MessageBox.Show("Мы старались, но что-то пошло не так...");
            }
        }
    }
}
