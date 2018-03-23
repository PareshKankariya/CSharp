using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class SumOfNumbers
    {
        public void sum()
        {
            Console.Write("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = input;
            for (int i = 1; i < input; i++)
            {
                output = output + i;
            }
            Console.WriteLine("\nSum of numbers from 1 to {0} is {1}", input, output);
            Console.ReadLine();

        }
    }
}
