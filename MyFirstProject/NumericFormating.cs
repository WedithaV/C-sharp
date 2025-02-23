using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class NumericFormating
    {
        public void display()
        {
            double value = 1024D / 33;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0}", value));
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0:0.000}", value));


            double money = -10D / 3;
            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = ${0:0.00}", money));

            //solution
            Console.WriteLine(money.ToString("C"));  //will show $ because lap is built in usa
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine(money.ToString("C3"));
            Console.WriteLine(money.ToString("C4"));

            //TO use another currency

            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-Au")));
        }
    }
}
