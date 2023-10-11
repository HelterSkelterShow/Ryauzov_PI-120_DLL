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
    public partial class FisherRateForm : Form
    {
        public FisherRateForm()
        {
            InitializeComponent();
        }

        private static FisherRateForm fisherRealRateForm;

        public static FisherRateForm GetFisherRealRateForm()    //Да будет синглтон :)
        {
            if (fisherRealRateForm == null || fisherRealRateForm.IsDisposed)
            {
                fisherRealRateForm = new FisherRateForm();
            }
            return fisherRealRateForm;
        }

        private void FisherRealRateResBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double nominalRate = int.Parse(FisherNomRateIn.Text);
                double expInflation = double.Parse(FisherExpInflationIn.Text);
                FisherRealRateRes.Text = String.Concat(Convert.ToString(Math.Round(Rates.FisherRealRate(nominalRate, expInflation))), " %");
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
