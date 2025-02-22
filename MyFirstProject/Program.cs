using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert strings to numerical data types
            string age = "23";
            int a = Convert.ToInt32(age);
            Console.WriteLine(a);

            string big = "43349384983";
            long b = Convert.ToInt64(big);
            Console.WriteLine(b);

            string pi = "3.245454545454";
            double d = Convert.ToDouble(pi);
            Console.WriteLine(d);

            string height = "178.34";
            float e = Convert.ToSingle(height);
            Console.WriteLine(e);

            string money = "343434343";
            decimal f = Convert.ToDecimal(money);
            Console.WriteLine(f);
        }
    }
}
