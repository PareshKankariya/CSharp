using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Fibonacce
    {
        public void fibonacceSeries()
        {
            int f1 = 0, f2 = 1, f3, count;

            Console.WriteLine("Enter the limit: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fabonacci Series is : ");
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 0; i < count; i++)
            {                
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }

            Console.ReadLine();
        }
    }
}
