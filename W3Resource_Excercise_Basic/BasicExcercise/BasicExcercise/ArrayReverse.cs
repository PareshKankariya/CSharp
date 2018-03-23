using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class ArrayReverse
    {
        public void arrayReverse()
        {
            int[] newArray = new int[10];
            Console.WriteLine("Enter 10 numbers separated by comma : ");
            string input = Console.ReadLine();
            string[] split = input.Split(',');
            
            //for (int i = 0; i < 10; i++)
            foreach (string num in split)
            {
                int i = 0;
                newArray[i] =  Convert.ToInt32(split[i]);
                i++;
            }

            Console.WriteLine("The reversed array is : ");

            for (int j = 10; j > 0; j--)
            {
                Console.Write(newArray[j-1]+" ");
            }
            Console.ReadLine();

        }
    }
}
