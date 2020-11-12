using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson2G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            // 1a) 'switch' with no default
            ResultSwitch1A.Text = Ex2gCalculations.Switch01(Input1A.Text);

            //1b) Seperate 'if' statements
            Result2A.Text = Ex2gCalculations.If01(Input1A.Text);

            //3) else if 
            Result3A.Text = Ex2gCalculations.ElseIf01(Input1A.Text);

            //4) Nested if
            Result4A.Text = Ex2gCalculations.NestedIfElse01(Input1A.Text);

            //5) default
            Result5A.Text = Ex2gCalculations.SwitchDefault01(Input1A.Text);

            //6) does not equal R/C
            Result6A.Text = Ex2gCalculations.IfDefault01(Input1A.Text);

            //7) else if not equal
            Result7A.Text = Ex2gCalculations.ElseIfDefault01(Input1A.Text);

            //8) Nested not equal
            Result8A.Text = Ex2gCalculations.NestedIfElseDefault01(Input1A.Text);

            //9)
            Resultswitch2.Text = Ex2gCalculations.Switch02(Input2A.Text);

            //10
            Resultif2.Text = Ex2gCalculations.If02(Input2A.Text);

            //11
            Resultelseif2.Text = Ex2gCalculations.ElseIf02(Input2A.Text);

            //12
            ResultNested2.Text = Ex2gCalculations.NestedIfElse02(Input2A.Text);
        }
    }
}
