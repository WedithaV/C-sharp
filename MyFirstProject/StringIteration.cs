using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstProject
{
    class StringIteration
    {
        public void display()
        {
            string text = "C# is awsome";

            for(int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(150);
            }

            Console.WriteLine();
            Console.WriteLine();

            for(int i = 0;  i < text.Length; i++)
            {
                if(text.Contains('c'))
                {
                    Console.WriteLine("Found");
                }

            }
        }
    }
}
