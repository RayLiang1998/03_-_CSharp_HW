using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_梁延睿_CSharp_HW
{
    class Class_Loan
    {
        public class loan_num
        {
            public static double loan;
            public static double year;
            public static double rate;
            public static double month;
            public static double down;
            public static double mp;
            public static double tp;
        }

        public double calmp(double loan, double year, double rate, double down)
        {
            double Mrate = (rate / 100) / 12;
            double month = year * 12;
            double MP = (loan - down) * ((Mrate * Math.Pow((1 + Mrate), month)) / (Math.Pow((1 + Mrate), month)-1));
            return MP;
        }

        public double caltp(double mp, double year)
        {
            double TP;
            double month = year * 12;
            TP = Math.Round(mp) * month;
            return TP;
        }

    }
}
