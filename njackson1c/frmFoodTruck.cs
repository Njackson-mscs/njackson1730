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
            //txtHotDogsSubtotal.Text = (
            //    4.0m * Convert.ToInt32(txtHotDogs.Text)
            //    ).ToString("0.00")
            //    ;
            int hotdogs = Convert.ToInt32(txtHotDogs.Text); // get user input
            decimal hdprice = 4.0m; // M uses it as a literal variable
            decimal hdsubtotal = hotdogs * hdprice; //how to calculate
            txtHotDogsSubtotal.Text = hdsubtotal.ToString("0.00"); //displayed calc            

            //txtHamburgersSubtotal.Text = (
            //    5.0m * Convert.ToInt32(txtHamburgers.Text)
            //    ).ToString("0.00")
            //    ;
            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamprice = 5.0m;
            decimal hamsubtotal = hamburgers * hamprice;
            txtHamburgersSubtotal.Text = hamsubtotal.ToString("0.00m");

            //txtPretaxTotal.Text = (
            //    Convert.ToDecimal(txtHotDogsSubtotal.Text)
            //    + Convert.ToDecimal(txtHamburgersSubtotal.Text)).ToString("0.00")
            //    ;
            decimal PretaxTotal = hamsubtotal + hdsubtotal;
            txtPretaxTotal.Text = PretaxTotal.ToString("0.00");

            
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

        private void frmFoodTruck_Load(object sender, EventArgs e)
        {

        }
    }
}
