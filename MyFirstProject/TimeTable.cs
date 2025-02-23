using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class TimeTable
    {
        public void display()
        {
            Console.WriteLine("Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
            }
        }
    }
}
