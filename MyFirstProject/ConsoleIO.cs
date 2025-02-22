using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class ConsoleIO
    {
        public ConsoleIO() 
        {
            Console.Write("Enter your name :  ");
            string name = Console.ReadLine();
            Console.Write("Enter your age :   ");
            string age = Console.ReadLine(); // Console.ReadLine() return a string value

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);
        }
    }
}
