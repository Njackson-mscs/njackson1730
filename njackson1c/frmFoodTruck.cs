using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson1c
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00")
                ;

            txtHamburgersSubtotal.Text = (
                5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00")
                ;


            txtPretaxTotal.Text = (
                Convert.ToDecimal(txtHotDogsSubtotal.Text)
                + Convert.ToDecimal(txtHamburgersSubtotal.Text)).ToString("0.00")
                ;

            
            const decimal Tax = 0.06875m;   ///Tax that will be applied to purchase
            txtTax.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) * Tax).ToString("0.00")
                ;

            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text)
                + Convert.ToDecimal(txtTax.Text)).ToString("0.00");

            btnClear.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHamburgers.Text = "0";
            txtHotDogs.Text = "0";
            txtHamburgersSubtotal.Text = "";
            txtHotDogsSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }
    }
}
