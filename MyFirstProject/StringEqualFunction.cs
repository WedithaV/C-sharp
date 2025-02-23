using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class StringEqualFunction
    {
        public void display()
        {
            string text1 = "Hello";
            string text2 = "Hello";

            // "==" compares values for value types (e.g., int, float).
            // For reference types (e.g., class, object), "==" compares memory locations (references).
            // If two reference type variables hold the same values but are different objects in memory, "==" will return false.
            // To compare values inside reference type objects, use the "Equals()" method (if overridden).

            if(text1 == text2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            if(text1.Equals(text2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            char[] text3 = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object compare = new string(text3);

            if(text1 == compare)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            if(text1.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

        }
    }
}
