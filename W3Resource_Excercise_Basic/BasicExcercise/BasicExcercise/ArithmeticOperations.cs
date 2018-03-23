using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class ArithmeticOperations
    {
        public void ArithOps()
        {
            int num1, num2, result;
            char option;
            Console.Write("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select an option\n\t For addittion, press 1\n\t For subtraction, press 2\n\t For multiplication, press 3\n\t For division, press 4");
            option = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(option);
            
            switch (option)
            {
                case '1' :
                    result = num1 + num2;
                    Console.WriteLine("Addittion of {0} and {1} is {2}", num1, num2, result);
                    break;
                case '2':
                    result = num1 - num2;
                    Console.WriteLine("Subtraction of {0} and {1} is {2}", num1, num2, result);
                    break;
                case '3':
                    result = num1 * num2;
                    Console.WriteLine("Subtraction of {0} and {1} is {2}", num1, num2, result);
                    break;
                case '4':
                    result = num1/num2;
                    Console.WriteLine("Subtraction of {0} and {1} is {2}", num1, num2, result);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
