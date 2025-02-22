using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class DataTypes
    {
        //Numerical Data Types

        int age = 23;
        long big = 3434343L; //If we do not use "L" .It is consider as int
        double a = 34.53D; //"D" is optional
        float b = 3.3F; //If we do not use "F" .It is consider as double
        decimal money = 3434M; //If we do not use "M" .It is consider  as int

        //Text based Data types

        string name = "Weditha";
        char grade = 'A';

        string firstName = ""; //Can be null
        //char dtx = "";  Can not be null

        //***********************************************************************

        void display1()
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

        //************************************************************

        //Boolean values
        bool status = true;

    }
}
