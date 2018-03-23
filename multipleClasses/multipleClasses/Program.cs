using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            getValues g1 = new getValues();
            //g1.length = 5;
            //g1.width = 6;

            g1.userLength();

            
            g1.userWidth();

            g1.getArea();
            //int area;
            //g1.getArea(g1.userLength, g1.userWidth);

           

            //area = g1.length * g1.width;

            //Console.WriteLine("The area is : {0}", area);

            Console.ReadLine();

        }
    }

    class getValues
    {
        private int length;
        private int width;


        public int userLength()
        {
            Console.WriteLine("Please enter the length");
            length = Convert.ToInt32(Console.ReadLine());

            return length;

        }

        public int userWidth()
        {
            Console.WriteLine("Please enter the width");
            width = Convert.ToInt32(Console.ReadLine());

            return width;
        }
         
                        

        public void getArea()
        {
            int area;
            area = length * width;

            Console.WriteLine("The area is : {0}", area);

        }
         
        public getValues()
        {
            Console.WriteLine("Constructor");

        }
        ~getValues()
        {
            Console.WriteLine("DEConstructor");
        }

    }
}
