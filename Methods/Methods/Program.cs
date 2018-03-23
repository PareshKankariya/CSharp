using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountToTen();
            //Console.WriteLine(Sum(10, 15));
            GetNumberFromUser();
            Console.WriteLine(Sum(10.23, 10.25));
            //Console.WriteLine("User Entered: " +GetNumberFromUser());
            
        

            SayHello NewClass = new SayHello();

            NewClass.PrintName();

            Console.ReadLine();

        }

        static void CountToTen()
        {
            for (int index = 0; index <=10; index++)
            {
                Console.WriteLine(index);
            }
        }

        static int Sum(int a, int b)
        {
            return (a + b);
        }

        static double Sum(double a, double b)
        {
            return (a + b);

        }


        static int GetNumberFromUser()
        {
            int userNumber = 0;

            while (userNumber < 1 || userNumber > 10)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
                        
            return userNumber;
        }
    }
}
