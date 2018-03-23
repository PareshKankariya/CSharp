using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] mArray = new int[3, 4] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}                            
            };
            
            for (int i = 0; i<3;i++)
            {
                for (int j=0;j<4;j++)
                {
                    Console.WriteLine("Array[{0},{1}] = {2}", i,j,mArray[i, j]);
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("\n");
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
                Console.WriteLine("ItemNumber : " + i + " = " + numArray[i]);

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
