using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class ArmstrongNumber
    {
        public void armstrongNum()
        {
            Console.Write("Enter a 3 digit number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input.ToString().Length != 3)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                int output, reminder;

                output = 0;
                for (int i = input; i > 0; i = i/10)
                {
                    reminder = i % 10;

                    output = output + (reminder * reminder * reminder);

                }
                if (input == output)
                
                    Console.WriteLine("Number {0} is an Armstrong number", input);
                else
                    Console.WriteLine("Number {0} is NOT an Armstrong number as sum of cubes of each digit is {1}", input, output);

            }
        }
    }
}
