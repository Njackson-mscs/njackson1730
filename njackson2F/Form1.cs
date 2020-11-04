using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {            
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            //#1 if
            Result1A.Text = Ex2fCalculations.Calc01(Input1a.Text);

            //#2 if {block}            
            Result2A.Text = Ex2fCalculations.Calc02(Input2A.Text);

            //#3 if else            
            Result3A.Text = Ex2fCalculations.Calc03(Input3A.Text);

            //#4 if else if
            Result4A.Text = Ex2fCalculations.Calc04(Input4A.Text);

            //#5 better range test            
            Result5A.Text = Ex2fCalculations.Calc05(Input5A.Text);

            // #6 nested if statement            
            Result6A.Text = Ex2fCalculations.Calc06(Input6A.Text, Input6B.Text);

            // #7
            Result7A.Text = Ex2fCalculations.Calc07(Input7A.Text);

            // #8
            Result8A.Text = Ex2fCalculations.Calc08(Input8A.Text, Input8B.Text);

            //#9
            Result9A.Text = Ex2fCalculations.Calc09(Input9A.Text, Input9B.Text);

            //#10
            Result10A.Text = Ex2fCalculations.Calc10(Input10A.Text, Input10B.Text);
        }
    }
}
