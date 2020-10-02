using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountArgentina = Convert.ToDecimal(txtAmountArgentina.Text);
            decimal rateAregentina = Convert.ToDecimal(txtRateArgentina.Text);
            decimal usdArgentina = amountArgentina * rateAregentina;
            txtUSDArgentina.Text = usdArgentina.ToString("0.00");

            decimal amountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal rateCanada = Convert.ToDecimal(txtRateCanada.Text);
            decimal usdCanada = amountCanada * rateCanada;
            txtUSDCanada.Text = usdCanada.ToString("0.00");

            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = usdEuro.ToString("0.00");

            decimal amountFranc = Convert.ToDecimal(txtAmountFrance.Text);
            decimal rateFranc = Convert.ToDecimal(txtRateFrance.Text);
            decimal usdFranc = amountFranc * rateFranc;
            txtUSDFrance.Text = usdFranc.ToString("0.00");

            decimal USDtotal = usdArgentina + usdCanada + usdEuro + usdFranc;
            txtTotalUSD.Text = USDtotal.ToString("0.00");
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
    }
}
