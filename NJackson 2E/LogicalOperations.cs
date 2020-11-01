using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NJackson_2E
{
    public class LogicalOperations
    {
        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }

        public static bool q02(Int32 TimeInService)
        {
            return TimeInService <= 4 ||
                TimeInService >= 12;
        }

        public static bool q03(bool IsValid, int years, int counter)
        {
            return IsValid == true & counter++ < years;            
        }

        public static bool q04(bool IsValid, int years, int counter)
        {
            return IsValid == true && counter++ < years;
        }

        public static bool q05(bool IsValid, int years, int counter)
        {
            return IsValid == true || counter++ < years;
        }

        public static bool q06(bool IsValid, int years, int counter)
        {
            return IsValid == true | counter++ < years;
        }

        public static bool q07(DateTime startdate, DateTime expdate, DateTime date, bool IsValid)
        {
            return date > startdate && date < expdate || IsValid == true;
        }

        public static bool q08(decimal thisYTD, decimal lastYTD, string emptype, int startyear, int currentyear)
        {
            return ((thisYTD > lastYTD) || emptype == "Part time") && startyear < currentyear;
        }

        public static bool q09(int counter, int years)
        {
            return !(counter++ >= years);
        }

        public static bool q10(int a, int b, int c, int d)
        {
            return a > b && b < c || c < d;
        }

        public static bool q11(bool member, decimal price, float weight)
        {
            return member == true || price >= 25 || weight <= 1.0;
        }

        public static bool q12(bool member, decimal price, float weight)
        {
            return member == true || price >= 25 && weight < 1.0;
        }

        public static bool q13(string shipstate, string itemtype)
        {
            return shipstate == "MN" & itemtype != "Clothing" && itemtype != "Food";
        }

    }
}
