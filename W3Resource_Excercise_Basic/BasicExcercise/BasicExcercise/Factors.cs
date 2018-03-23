using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Factors
    {
        public void factorsOfNumber()
        {
            Console.Write("Enter a number ");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            Console.Write("Factorial of {0} are : ", input);
            for (int i = 1; i <= input; i++)
            {
                if (input%i == 0)
                {
                    Console.Write(" {0} ", i);
                }

            }
            Console.ReadLine();
        }
    }
}
