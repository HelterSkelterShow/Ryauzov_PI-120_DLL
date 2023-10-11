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
    public partial class ContiniousPercentForm : Form
    {
        private ContiniousPercentForm()
        {
            InitializeComponent();
        }

        private static ContiniousPercentForm continiousPercentForm;

        public static ContiniousPercentForm GetContiniousForm()    //Да будет синглтон :)
        {
            if (continiousPercentForm == null || continiousPercentForm.IsDisposed)
            {
                continiousPercentForm = new ContiniousPercentForm();
            }
            return continiousPercentForm;
        }

        private void ContResBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int periods = int.Parse(ContPeriodIn.Text);
                Decimal value = Convert.ToDecimal(ContValueIn.Text);
                double percent = double.Parse(ContPeriodIn.Text);
                ContRes.Text = String.Concat(Convert.ToString(decimal.Round(Rates.ContiniousRate(periods, value, percent), 2)), " руб.");
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
