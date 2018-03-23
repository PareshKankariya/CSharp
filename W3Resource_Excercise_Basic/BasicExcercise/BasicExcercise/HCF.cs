using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class HCF
    {
        public void hcfOfNumbers()
        {
            int fNum, sNum;
            int hcf = 0;
            Console.Write("Enter first number : ");
            fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            sNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= fNum || i <= sNum; i++)
            {
                if (fNum%i == 0 && sNum % i == 0)
                {
                    hcf = i;
                }
            }
            Console.WriteLine("The Higest Common Factor (HCF) between {0} and {1} is {2}  ", fNum, sNum, hcf);
            Console.ReadLine();
        }
    }
}
