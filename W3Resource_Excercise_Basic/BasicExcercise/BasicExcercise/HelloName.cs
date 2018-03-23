using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class HelloName
    {
        public void HelloNameMethod()
        {
            Console.Write("Enter your name : ");

            String input;

            input = Console.ReadLine();

            Console.WriteLine("Hello : " + " " + input);

            Console.ReadLine();
        }
        
    }
}
