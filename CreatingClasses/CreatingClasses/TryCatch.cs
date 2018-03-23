using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class TryCatch
    {
        public void ReturnNumber()
        {
        Console.Write("Enter a Number : ");
        string num = Console.ReadLine();
            try
            {
                 int num1 = Convert.ToInt32(num);
                Console.WriteLine("Number Entered is : " +num1);
                return;
            }
                
            catch (FormatException e)
            {
                Console.WriteLine("Exception Occured");
            }

            catch (OverflowException e)
            {
                Console.WriteLine("Please enter smaller number");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown Exception" + e.Message);                             
            }
           
            //finally
            //{
            //    ReturnNumber();
            //}
            
        }
        

    }
}
