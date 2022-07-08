using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_梁延睿_CSharp_HW
{
    class Utilities
    {
        public class score
        {
            public static string name { get; set; }
            public static double chi { get; set; }
            public static double math { get; set; }
            public static double eng { get; set; }
            public override string ToString()
            {
                return string.Format("Student Name: {0} \nChinese Score: {1}\nMath Score: {2}\nEnglish Score: {3}", name, chi.ToString(), math.ToString(), eng.ToString());
            }
        }
    }
}
