using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class SwapNumbers
    {
        public void swapNumbers (int a, int b)
        {
            int newNum1, newNum2, temp;
            newNum1 = b;
            newNum2 = a;
            Console.WriteLine("Old Numbers : " + a + " and " + b);
            Console.WriteLine("New Numbers : " + newNum1 + " and " + newNum2);
            Console.ReadLine();
        }
    }
}
