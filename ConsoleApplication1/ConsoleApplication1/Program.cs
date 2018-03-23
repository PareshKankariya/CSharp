using System;
public class Exercise053
{
    public static void Main()
    {

        int num1, num2;
       

        Console.Write("Enter the symbol : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the desired width : ");
        num2 = Convert.ToInt32(Console.ReadLine());
       
        for (int i = 0; i<num2; i++)
        {
            Console.Write("{0}", num1);
        }

        //Console.WriteLine("Reverse of entered string is {0}.", sName.r)
        //try
        //{

        //    int result = num1 / num2;

        //    Console.WriteLine(result);


        //}

        //catch(DivideByZeroException)
        //{
        //    Console.WriteLine("Cannot divide by zero");
        //    Console.ReadLine();
        //    return;
        //}


        Console.WriteLine();
        Console.ReadLine();
    }
}



        //int price, paid, change;

        //Console.Write("Price? ");
        //price = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Paid? ");
        //paid = Convert.ToInt32(Console.ReadLine());

        //change = paid - price;
        //Console.Write("Your change is {0}: ", change);
        //while (change > 0)
        //{
        //    if (change >= 50)
        //    {
        //        Console.Write("50 ");
        //        change -= 50;
        //    }
        //    else
        //    {
        //        if (change >= 20)
        //        {
        //            Console.Write("20 ");
        //            change -= 20;
        //        }
        //        else
        //        {
        //            if (change >= 10)
        //            {
        //                Console.Write("10 ");
        //                change -= 10;
        //            }
        //            else
        //            {
        //                if (change >= 5)
        //                {
        //                    Console.Write("5 ");
        //                    change -= 5;
        //                }
        //                else
        //                {
        //                    if (change >= 2)
        //                    {
        //                        Console.Write("2 ");
        //                        change -= 2;
        //                    }
        //                    else
        //                    {
        //                        Console.Write("1 ");
        //                        change -= 1;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
       