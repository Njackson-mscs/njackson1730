using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountArgentina.Text = "0.00";
            txtAmountCanada.Text = "0.00";
            txtAmountEuro.Text = "0.00";
            txtAmountFrance.Text = "0.00";
            txtRateArgentina.Text = "0.0134365";
            txtRateCanada.Text = "0.764653";
            txtRateEuro.Text = "1.18395";
            txtRateFrance.Text = "0.180491";
            txtTotalUSD.Text = "0.00";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void ArgentinaTextChanged(object sender, EventArgs e)
        {

            txtUSDArgentina.Text = (
                Convert.ToDecimal(txtAmountArgentina.Text) 
                * Convert.ToDecimal(txtRateArgentina.Text)).ToString("0.00");
                
        }

        private void CanadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
                Convert.ToDecimal(txtAmountCanada.Text)
                * Convert.ToDecimal(txtRateCanada.Text)).ToString("0.00");
        }

        private void EuroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                Convert.ToDecimal(txtAmountEuro.Text)
                * Convert.ToDecimal(txtRateEuro.Text)).ToString("0.00");
        }

        private void FranceTextChanged(object sender, EventArgs e)
        {
            txtUSDFrance.Text = (
                Convert.ToDecimal(txtAmountFrance.Text)
                * Convert.ToDecimal(txtRateFrance.Text)).ToString("0.00");
        }

      
        private void USDTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDArgentina.Text) 
                + Convert.ToDecimal(txtUSDCanada.Text)
                + Convert.ToDecimal(txtUSDEuro.Text)
                + Convert.ToDecimal(txtUSDFrance.Text)).ToString("0.00");       
                
        }
    }
}
