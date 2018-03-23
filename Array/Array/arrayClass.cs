using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class arrayClass
    {
        public static void Main(String[] args)
        {

            int[] numArray = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter the number :");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The array values are :");

            foreach (int i in numArray)
                Console.Write(i + "\t");

            Console.Write("\n");
            for (int i = 0; i < numArray.Length; i++)
                Console.WriteLine("ItemNumber : " +i + " = " +numArray[i]);

            Array.Sort(numArray);

            Console.Write("Array Sorted : \n ");
            for (int i = 0; i < numArray.Length; i++)
                Console.WriteLine("ItemNumber : " + i + " = " + numArray[i]);

            Array.Reverse(numArray);
            Console.Write("Array Reversed : \n ");
            for (int i = 0; i < numArray.Length; i++)
                Console.WriteLine("ItemNumber : " + i + " = " + numArray[i]);



                Console.ReadLine();

        }
    }
}