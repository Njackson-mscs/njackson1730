using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson1F
{
    public partial class frmCC_v2 : Form
    {
        public frmCC_v2()
        {
            InitializeComponent();
        }

        private void frmCC_v2_Load(object sender, EventArgs e)
        {
            btnArgentina.BackgroundImage = picArgentina.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnFinland.BackgroundImage = picFinlandDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.0132797";
            lblCurrency.Text = btnArgentina.Text + ":";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnArgentina_Click(object sender, EventArgs e)
        {
            btnArgentina.BackgroundImage = picArgentina.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnFinland.BackgroundImage = picFinlandDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.0132797";
            lblCurrency.Text = btnArgentina.Text + ":";            
            txtCurrency.Focus();
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnArgentina.BackgroundImage = picArgentinaDim.Image;
            btnFinland.BackgroundImage = picFinlandDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.757394";
            lblCurrency.Text = btnCanada.Text + ":";            
            txtCurrency.Focus();
        }

        private void btnFinland_Click(object sender, EventArgs e)
        {
            btnFinland.BackgroundImage = picFinland.Image;
            btnArgentina.BackgroundImage = picArgentinaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "1.18437";
            lblCurrency.Text = btnFinland.Text + ":";            
            txtCurrency.Focus();
        }

        private void btnFrance_Click(object sender, EventArgs e)
        {
            btnFrance.BackgroundImage = picFrance.Image;
            btnArgentina.BackgroundImage = picArgentinaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnFinland.BackgroundImage = picFinlandDim.Image;
            txtRate.Text = "0.180546";
            lblCurrency.Text = btnFrance.Text + ":";            
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text +
                " + " + txtUSD.Text;

            txtCurrency.Focus();
            txtCurrency.SelectAll();

            txtTotalUSD.Text = (
                Convert.ToDecimal(txtTotalUSD.Text)
                + Convert.ToDecimal(txtUSD.Text)).ToString();

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnArgentina.BackgroundImage = picArgentina.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnFinland.BackgroundImage = picFinlandDim.Image;
            btnFrance.BackgroundImage = picFranceDim.Image;
            txtRate.Text = "0.0132797";
            lblCurrency.Text = btnArgentina.Text + ":";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = " ";
            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
