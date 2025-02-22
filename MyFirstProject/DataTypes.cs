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

        //************************************************************

        //Var keyword  
        //It can kill the readability of code base 
        //We can use any data type using var keyword. but if we use var keyword we should do the initalinzation and decalration in one line

        void display2()
        {
            var age = 23;
            var big = 3434343L;
            var a = 343.3434D;
            var b = 34.43F;
            var money = 3434343434M;
            var name = "Weditha";
            var grade = 'A';
        }

        //**************************************************************************

        //Constant 
        const int vat = 20;

        //Storing user data
        int num = 0123; //This will save  as "123" .To avoid that we can use string or var
        string num1 = "0123";
        //var num3 = "0123";


    }
}
