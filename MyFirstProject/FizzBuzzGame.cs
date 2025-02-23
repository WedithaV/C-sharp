using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class FizzBuzzGame
    {
        public void display()
        {
            Console.Write("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool divThree;
            bool divFive;

            for(int i = 1; i <= num; i++)
            {
                divThree = i % 3 == 0;
                divFive = i % 5 == 0;

                if(divThree && divFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(divThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if(divFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
