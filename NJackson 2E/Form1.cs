using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NJackson_2E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            Result1.Text = "";
            Result2.Text = "";
            Result3A.Text = "";
            Result3B.Text = "";
            Result4A.Text = "";
            Result4B.Text = "";
            Result5A.Text = "";
            Result5B.Text = "";
            Result6A.Text = "";
            Result6B.Text = "";
            Result7.Text = "";
            Result8.Text = "";
            Result9A.Text = "";
            Result9B.Text = "";
            Result10.Text = "";

            //#1
            decimal subtotal = Convert.ToDecimal(Input1A.Text);
           // Result1.Text = (subtotal >= 250 && subtotal < 500).ToString();
            Result1.Text = (LogicalOperations.q01(subtotal) ).ToString();

            //#2
            Int32 TimeInService = Convert.ToInt32(Input2.Text);
            //Result2.Text = (TimeInService <= 4 || TimeInService >= 12).ToString();
            Result2.Text = (LogicalOperations.q02(TimeInService)).ToString();

            //#3 - 6 initialize
            bool IsValid = Convert.ToBoolean(Input3A.Text);
            int years = Convert.ToInt32(Input3C.Text);

            //#3
            int counter = Convert.ToInt32(Input3B.Text);
            //Result3A.Text = (IsValid == true & counter++ < years).ToString();
            Result3A.Text = (LogicalOperations.q03(IsValid, years, counter)).ToString();
            Result3B.Text = counter.ToString();

            //#4
            counter = Convert.ToInt32(Input3B.Text);
            //Result4A.Text = (IsValid == true && counter++ < years).ToString();
            Result4A.Text = (LogicalOperations.q04(IsValid, years, counter)).ToString();
            Result4B.Text = counter.ToString();

            //#5
            counter = Convert.ToInt32(Input3B.Text);
            //Result5A.Text = (IsValid == true || counter++ < years).ToString();
            Result5A.Text = (LogicalOperations.q05(IsValid, years, counter)).ToString();
            Result5B.Text = counter.ToString();

            //#6
            counter = Convert.ToInt32(Input3B.Text);
           // Result6A.Text = (IsValid == true | counter++ < years).ToString();
            Result6A.Text = (LogicalOperations.q06(IsValid, years, counter)).ToString();
            Result6B.Text = counter.ToString();

            //#7
            DateTime startdate = Convert.ToDateTime(Input7A.Text);
            DateTime expdate = Convert.ToDateTime(Input7B.Text);
            DateTime date = Convert.ToDateTime(Input7C.Text);
            IsValid = Convert.ToBoolean(Input7D.Text);

            //Result7.Text = (date > startdate && date < expdate || IsValid == true).ToString();
            Result7.Text = (LogicalOperations.q07(startdate, expdate, date, IsValid)).ToString();

            //#8
            decimal thisYTD = Convert.ToDecimal(Input8A.Text);
            decimal lastYTD = Convert.ToDecimal(Input8B.Text);
            string emptype = Input8C.Text;
            int startyear = Convert.ToInt32(Input8D.Text);
            int currentyear = Convert.ToInt32(Input8E.Text);

            //Result8.Text = (((thisYTD > lastYTD) || emptype == "Part time") && startyear < currentyear).ToString();
            Result8.Text = (LogicalOperations.q08(thisYTD, lastYTD, emptype, startyear, currentyear)).ToString();

            //#9
            counter = Convert.ToInt32(Input9A.Text);
            years = Convert.ToInt32(Input9B.Text);

            //Result9A.Text = (!(counter++ >= years)).ToString();
            Result9A.Text = (LogicalOperations.q09(counter, years)).ToString();
            Result9B.Text = counter.ToString();

            //#10
            int a = Convert.ToInt32(Input10A.Text);
            int b = Convert.ToInt32(Input10B.Text);
            int c = Convert.ToInt32(Input10C.Text);
            int d = Convert.ToInt32(Input10D.Text);

            //Result10.Text = (a > b && b < c || c < d).ToString();
            Result10.Text = (LogicalOperations.q10(a, b, c, d)).ToString();

            //#11
            bool member = Convert.ToBoolean(Input11A.Text);
            decimal price = Convert.ToDecimal(Input11B.Text);
            float weight = Convert.ToSingle(Input11C.Text);

            Result11.Text = (LogicalOperations.q11(member, price, weight)).ToString();

            //#12
            member = Convert.ToBoolean(Input12A.Text);
            price = Convert.ToDecimal(Input12B.Text);
            weight = Convert.ToSingle(Input12C.Text);

            Result12.Text = (LogicalOperations.q12(member, price, weight)).ToString();

            //#13
            string shipstate = Input13A.Text;
            string itemtype = Input13B.Text;

            Result13.Text = LogicalOperations.q13(shipstate, itemtype).ToString();
        }
    }
}
