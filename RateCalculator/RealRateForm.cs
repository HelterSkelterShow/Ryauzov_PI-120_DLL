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
    public partial class RealRateForm : Form
    {
        public RealRateForm()
        {
            InitializeComponent();
        }

        private static RealRateForm realRateForm;

        public static RealRateForm GetRealRateForm()    //Да будет синглтон :)
        {
            if (realRateForm == null || realRateForm.IsDisposed)
            {
                realRateForm = new RealRateForm();
            }
            return realRateForm;
        }

        private void RealRateResBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double nominalRate = int.Parse(NomRateIn.Text);
                double expInflation = double.Parse(ExpInflationIn.Text);
                RealRateRes.Text = String.Concat(Convert.ToString(Rates.RealRate(nominalRate, expInflation)), " %");
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
