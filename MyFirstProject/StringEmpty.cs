using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class StringEmpty
    {
        public void display()
        {
            string name1 = "";
            //OR
            string name2 = string.Empty;

            //string.Empty method is good .it makes the code more readable

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            if(name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is empty");
            }
        }
    }
}
