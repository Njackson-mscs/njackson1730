using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson1e
{
    public partial class TestAverages : Form
    {
        public TestAverages()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ((
                 Convert.ToDecimal(txtScoreOne.Text) 
                 + Convert.ToDecimal(txtScoreTwo.Text) 
                 + Convert.ToDecimal(txtScoreThree.Text)) / 3m).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScoreOne.Text = "0";
            txtScoreTwo.Text = "0";
            txtScoreThree.Text = "0";
            txtAverage.Text = "";
            
        }
    }
}
