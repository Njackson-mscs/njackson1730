using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace njackson2F
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = decimal.Parse(input);
            if (subtotal >= 100)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }
        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = decimal.Parse(input);
            discountPercent = 0.0m;
            string status = "standard Rate: ";

            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk Rate: ";
            }
           return status + discountPercent.ToString("n2");             
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300)
                discountPercent = 0.4m;
            else if (subtotal >= 200)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            subtotal = decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;

            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ether = 0m;
            if (input != "")
            {
                decimal dollars = decimal.Parse(input);
                ether = 200m * dollars;
                return ether.ToString("n2");
            }
            return "Invalid Statement";

        public static string Calc08(string inputA, string inputB)
        {
                // #8 Validate input, calculate quantity * price, shipping
                decimal price = decimal.Parse(inputA);
                Int16 quantity = Int16.Parse(inputB);

                if (inputA != "" && inputB != "")
                {
                    if (price > 0 && quantity > 0)
                    {
                       
                    }
                        
                }
                else
                    return "Invalid Statement";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            return "";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            return "";
        }
    }
}
