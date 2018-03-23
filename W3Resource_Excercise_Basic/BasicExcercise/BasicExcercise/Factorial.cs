using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Factorial
    {
        public void factorial()
        {
            Console.WriteLine("Enter an interger number greater than 2 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if ( n<2)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                int output = 1;
                for (int i = n; i > 0; i--)
                {
                       output = output * i ;
                }
                Console.WriteLine("Factorial of {0} is {1}", n, output);
                Console.ReadLine();
            }
        }

        public int factorialRecursive(int a)
        {
            return (a == 0 || a == 1) ? 1 : (a * factorialRecursive(a - 1));
            
        }
    }
}
