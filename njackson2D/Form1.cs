using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace njackson2D
{
    public partial class calculateBtn : Form
    {
        public calculateBtn()
        {
            InitializeComponent();
        }

        private void PassValuesBtn_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "Frank";
            textBox2input.Text = "";
            textBox3input.Text = "2.3";
            textBox4input.Text = "false";
            textBox5inputA.Text = "2";
            textBox5inputB.Text = "2";
            textBox6input.Text = "xyz";
            textBox7input.Text = "1";
            textBox8inputA.Text = "1";
            textBox8inputB.Text = "2";
            textBox9input.Text = "500";
            textBox10inputA.Text = "5";
            textBox10inputB.Text = "8";
        }

        private void FailValuesbtn_Click(object sender, EventArgs e)
        {
            textBox1input.Text = "xyz";
            textBox2input.Text = "xyz";
            textBox3input.Text = "2.1";
            textBox4input.Text = "true";
            textBox5inputA.Text = "5";
            textBox5inputB.Text = "6";
            textBox6input.Text = "Jones";
            textBox7input.Text = "-2";
            textBox8inputA.Text = "4";
            textBox8inputB.Text = "2";
            textBox9input.Text = "499";
            textBox10inputA.Text = "12";
            textBox10inputB.Text = "6";
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            //textBox1Result.Text = "Fail";
            //textBox2Result.Text = "Fail";
            //textBox3Result.Text = "Fail";
            //textBox4Result.Text = "Fail";
            //textBox5Result.Text = "Fail";
            //textBox6Result.Text = "Fail";
            //textBox7Result.Text = "Fail";
            //textBox8Result.Text = "Fail";
            //textBox9Result.Text = "Fail";
            //textBox10Result.Text = "Fail";

            //Input 1
            if (textBox1input.Text == "Frank")
                textBox1Result.Text = "Success";
            else textBox1Result.Text = "Fail";

            //Input 2
            if (textBox2input.Text == "")
                textBox2Result.Text = "Success";
            else textBox2Result.Text = "Fail";

            //Input 3
            decimal val3 = Convert.ToDecimal(textBox3input.Text);
            if (val3 == 2.3m)
                textBox3Result.Text = "Success";
            else textBox3Result.Text = "Fail";

            //Input 4
            bool val4 = Convert.ToBoolean(textBox4input.Text);
            if (val4 == false)
                textBox4Result.Text = "Success";
            else textBox4Result.Text = "Fail";

            //Input 5
            if (textBox5inputA.Text == textBox5inputB.Text)
                textBox5Result.Text = "Success";
            else textBox5Result.Text = "Fail";

            //Input 6
            if (textBox6input.Text != "Jones")
                textBox6Result.Text = "Success";
            else textBox6Result.Text = "Fail";

            //Input 7
            Int32 val7 = Convert.ToInt32(textBox7input.Text);
            if (val7 > 0) textBox7Result.Text = "Success";
            else textBox7Result.Text = "Fail";

            //Input 8
            Int32 val8A = Convert.ToInt32(textBox8inputA.Text);
            Int32 val8B = Convert.ToInt32(textBox8inputB.Text);
            if (val8A < val8B)
                textBox8Result.Text = "Success";
            else textBox8Result.Text = "Fail";

            //Input 9
            Int32 val9 = Convert.ToInt32(textBox9input.Text);
            if (val9 >= 500)
                textBox9Result.Text = "Success";
            else textBox9Result.Text = "Fail";

            //Input 10
            Int32 val10A = Convert.ToInt32(textBox10inputA.Text);
            Int32 val10B = Convert.ToInt32(textBox10inputB.Text);
            if (val10A <= val10B)
                textBox10Result.Text = "Success";
            else textBox10Result.Text = "Fail";
        }
    }
}
