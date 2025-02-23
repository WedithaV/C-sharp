using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class TryParseFunction
    {
        public void display()
        {
            Console.Write("Enter number : ");

            string inputNum = Console.ReadLine();
            //Above code line will give an error if you enter input like "10h" and
            //it will stop the program execution

            //solution
            int num ;
            int.TryParse(inputNum, out num);    //If converted successfull value will printed, 
                                                //Otherwise 0 will be printed 
            Console.WriteLine(num);


            //Exercise
            Console.WriteLine();
            Console.Write("Enter number 2 : ");
            string inputNum2 = Console.ReadLine();

            if(int.TryParse(inputNum2, out int num2))
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("Failed to convert");
            }
        }
    }
}
