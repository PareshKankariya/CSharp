using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class PrimeNumber
    {
        public void FindPrime()
        {
            Console.WriteLine("Prime Numbers \t");
            for (int i=1; i<100;i++)
            {                
                int count = 0;
                for (int j=1; j<=i; j++)
                {
                    //Console.WriteLine("Value of i = " + i);
                    //Console.WriteLine("Value of j = " + j);
                    
                    int num = i % j;

                    //Console.WriteLine("i%j = " + num);

                    if (i%j==0)
                    {                       
                        count++;
                    }
                }

                //Console.WriteLine("Count = " + count);
                
                if (count == 2)
                {
                    Console.WriteLine("\t" + i);
                }
                //else
                //{
                //    Console.WriteLine(i + "is NOT a Prime Number");
                //}

            }
            Console.WriteLine();
        }
    }
}
