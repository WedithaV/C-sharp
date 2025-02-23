using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class StringFormating
    {
        public void display()
        {
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            Console.Write("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + name + ", your age is " + age);
            Console.WriteLine("Your name is {0}, your age is {1}",name,age);

            //string interpolation
            Console.WriteLine($"Your name is {name}, your age is {age}");

            //string concat
            Console.WriteLine(string.Concat("Your name is ", name, ", your age is ", age));
        }
    }
}
