using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class IfCondition
    {
        public void calcAge()
        {
            int age = Convert.ToInt32(Console.ReadLine());

            if(age <= 0 || age >= 120)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                if(age > 0 && age <= 18)
                {
                    Console.WriteLine("You are between 0 and 18");
                }
                else if(age > 18 && age <= 50)
                {
                    Console.WriteLine("You are between 18 and 50");
                }
                else
                {
                    Console.WriteLine("You are older than 50");
                }
            }
        }
    }
}
