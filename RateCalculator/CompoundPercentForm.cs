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
    public partial class CompoundPercentForm : Form
    {
        private CompoundPercentForm()
        {
            InitializeComponent();
        }

        private static CompoundPercentForm сompoundPercent;

        public static CompoundPercentForm GetCompoundForm()   //Да будет синглтон :)
        {
            if (сompoundPercent == null || сompoundPercent.IsDisposed)
            {
                сompoundPercent = new CompoundPercentForm();
            }
            return сompoundPercent;
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int periods = int.Parse(CompPeriodIn.Text);
                Decimal value = Convert.ToDecimal(CompValueIn.Text);
                double percent = double.Parse(CompPeriodIn.Text);
                compResult.Text = String.Concat(Convert.ToString(decimal.Round(Rates.CompoundRate(periods, value, percent), 2)), " руб.");
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
