using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            for (int num=2; num<11; num++)
            {
            //Console.WriteLine("Please enter the number : ");
            //int num = Convert.ToInt32(Console.ReadLine());

               int div = 0;
               for (int j=1; j<=num; j++)
               {
                   if (num % j == 0)
                       div++;
               }       
               if (div == 2)
               {
                   Console.WriteLine("Prime numbers between 2 to 10 : ");
                   Console.WriteLine(num+"\t");
               }                   
               else
               {
                   Console.WriteLine("NOT Prime numbers between 2 to 10 : ");
                   Console.WriteLine(num + "\t");
               }
            }
            Console.ReadLine();
        }
    }
}

