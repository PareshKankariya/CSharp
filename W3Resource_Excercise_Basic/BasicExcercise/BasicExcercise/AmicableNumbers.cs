using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class AmicableNumbers
    {
        public void amicableNum()
        {
            int fNum, sNum, fNumSum, sNumSum;
            fNumSum = 0;
            sNumSum = 0;
            Console.Write("Enter first number : ");
            fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            sNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < fNum; i++)
            {
                if (fNum % i == 0)
                {
                    fNumSum = fNumSum + i;
                }
            }
            for (int j = 1; j < sNum; j++)
            {
                if (sNum % j == 0)
                {
                    sNumSum = sNumSum + j;
                }
            }
            if (fNum == sNumSum && sNum == fNumSum)            
                Console.WriteLine("Numbers {0} and {1} are Amicable numbers.", fNum, sNum) ;
            else
                Console.WriteLine("Numbers {0} and {1} are NOT Amicable numbers.", fNum, sNum);
            Console.ReadLine();
        }
    }
}
