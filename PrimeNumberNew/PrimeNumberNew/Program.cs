using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This code will find the prime numbers between 1 and 10.
namespace PrimeNumberNew
{
    class Program
    {
        static void Main(string[] args)
        {
           // int count = 1;
            Console.WriteLine("Prime Numbers");
            for (int i=2; i<=100;i++)
            {
                int count = 1;
                //Console.WriteLine("Outside Loop {");
                //Console.WriteLine("Value of i is : " + i);
                for (int j=1;j<i;j++)
                {
                    //int count = 1;

                    //Console.WriteLine("Value of j is : " + j);

                    //Console.WriteLine(i % j);
                    
                    if (i%j==0)
                    {
                        count++;
                        //Console.WriteLine("Count is "+count);
                    }

                   
                }
                
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
                //else
                //    Console.WriteLine(i + " is NOT a Prime Number");
            
                //Console.WriteLine("}");
            }
            Console.ReadLine();

        }
    }
}
