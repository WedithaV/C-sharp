using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class StringIsNullorEmpty
    {
        public void display()
        {
            string text1 = "";
            string text2 = null;

            if(text1 == "")      // Check Empty
                Console.WriteLine("0");
            if(text1.Equals(""))  // Check Empty
                Console.WriteLine("1");
            if(string.IsNullOrEmpty(text1))  //Check Null & Empty
                Console.WriteLine("2");

            if(text2 == "")
                Console.WriteLine("00");
          //if(text2.Equals("")   This will give an exception .becasuse function can not work with null values
          //    Console.WriteLine("11")
            if(string.IsNullOrEmpty(text2))
            {
                Console.WriteLine("22");
            }



        }
    }
}
