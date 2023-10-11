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
    public partial class SimplePercentForm : Form
    {  
        private SimplePercentForm()
        {
            InitializeComponent();
        }

        private static SimplePercentForm simlePercentForm;

        public static SimplePercentForm GetSimpleForm()    //Да будет синглтон :)
        {
            if (simlePercentForm == null || simlePercentForm.IsDisposed)
            {
                simlePercentForm = new SimplePercentForm();
            }
            return simlePercentForm;
        }



        private void Result_Click(object sender, EventArgs e)
        {
            try
            {
                int periods = int.Parse(periodIn.Text);
                Decimal value = Convert.ToDecimal(valueIn.Text);
                double percent = double.Parse(percentIn.Text);
                CompRes.Text = Convert.ToString(Rates.SimpleRate(periods, value, percent));
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
