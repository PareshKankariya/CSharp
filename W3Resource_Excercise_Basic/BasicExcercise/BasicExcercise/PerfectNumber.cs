using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class PerfectNumber
    {
        public void perfectNum()
        {
            Console.Write("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < input; i++)
            {
                if (input%i == 0)
                {
                    sum = sum + i;
                }
            }
           
            if (input == sum)
                Console.WriteLine("Entered number {0} is a perfect number", input);
            else
                Console.WriteLine("Entered number {0} is a NOT perfect number as sum of divisible is {1}", input, sum);
            Console.ReadLine();
        }

        public void perfectNumRange()
        {
            Console.Write("Enter a number. This program will calculate the perfect number between 1 and entered number : ");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.Write("Perfect number between 1 and {0} are 1 2 ", range);
            int sum;
            for (int i = 2; i <= range; i++)
            {
                sum = 0;
                for (int j = 1; j<i; j++)
                 {              
                    if (i%j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (i==sum)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine(); 
        }
    }
}
