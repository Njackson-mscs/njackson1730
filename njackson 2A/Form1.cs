using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson_2A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            int discount = Convert.ToInt32(txtDiscountPercent.Text);
            decimal discamount = subtotal * discount /100;
            txtDiscountAmount.Text = discamount.ToString("0.00");
            //txtTotal.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
            decimal total = subtotal - discamount;
            txtTotal.Text = total.ToString("0.00");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
