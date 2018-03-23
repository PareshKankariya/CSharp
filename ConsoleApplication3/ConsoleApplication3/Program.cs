using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string enteredname;

            Program p = new Program();

            //p.getName();

            Console.WriteLine("Hello {0}", p.getName());

            Console.ReadLine();


        }

        public string getName()
        {
            string name;

            Console.WriteLine("Please enter your Name: ");

            name = Console.ReadLine();

            return name;
        }
    }
}
