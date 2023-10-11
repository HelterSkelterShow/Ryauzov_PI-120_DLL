using System;

using System.Windows.Forms;

namespace RateCalculator
{
    public partial class MenuForm : Form
    {
        private static MenuForm inst;
        public MenuForm()
        {
                InitializeComponent();
        }

        private void SimplePercent_Click(object sender, EventArgs e)
        {
            SimplePercentForm.GetSimpleForm().Show();

        }

        private void CompoundPercent_Click(object sender, EventArgs e)
        {
            CompoundPercentForm.GetCompoundForm().Show();
        }

        private void AnnualRate_Click(object sender, EventArgs e)
        {
            AnnualPercentForm.GetAnnualForm().Show();
        }

        private void ContiniousRate_Click(object sender, EventArgs e)
        {
            ContiniousPercentForm.GetContiniousForm().Show();
        }

        private void RealRate_Click(object sender, EventArgs e)
        {
            RealRateForm.GetRealRateForm().Show();
        }

        private void FisherRealRate_Click(object sender, EventArgs e)
        {
            FisherRateForm.GetFisherRealRateForm().Show();
        }
    }
}
