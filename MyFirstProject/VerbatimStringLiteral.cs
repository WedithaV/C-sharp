using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class VerbatimStringLiteral
    {
        public void display()
        {
            string path1 = "C: \\Users\\Weditha\\Desktop\\C#";
            Console.WriteLine(path1);
            string path2 = @"C: \Users\Weditha\Desktop\C#";
            Console.WriteLine(path2);

            string greet1 = "Hello \"Weditha\"";
            Console.WriteLine(greet1);
            string greet2 = "Hello 'Weditha'";
            Console.WriteLine(greet2);
            string greet3 = @"Hello ""Weditha""";
            Console.WriteLine(greet3);

            string text = @"C: \Users\Weditha\Desktop\C#  \n" + "\nescape caracters doesnt work in @";
            Console.WriteLine(text);

        }
    }
}
