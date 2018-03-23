using System;
public class RectangleArea
{
    public static void Main()
    {
        int price, paid, change;

        Console.Write("Price? ");
        price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Paid? ");
        paid = Convert.ToInt32(Console.ReadLine());

        change = paid - price;
        Console.Write("Your change is {0}: ", change);
        while (change > 0)
        {
            if (change >= 50)
            {
                Console.Write("50 ");
                change -= 50;
            }
            else
            {
                if (change >= 20)
                {
                    Console.Write("20 ");
                    change -= 20;
                }
                else
                {
                    if (change >= 10)
                    {
                        Console.Write("10 ");
                        change -= 10;
                    }
                    else
                    {
                        if (change >= 5)
                        {
                            Console.Write("5 ");
                            change -= 5;
                        }
                        else
                        {
                            if (change >= 2)
                            {
                                Console.Write("2 ");
                                change -= 2;
                            }
                            else
                            {
                                Console.Write("1 ");
                                change -= 1;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}
           // int num;
           // string sMessage = "Suspenso";
           //// int div = 0;
           // Console.WriteLine("Please enter the number : ");
           // num = Convert.ToInt32(Console.ReadLine());

           // if (num >= 0 && num < 5)
           //     Console.WriteLine(sMessage);

           // switch (num)
           // {

           //     case 5:
           //         Console.WriteLine("Aprobado");
           //         break;

           //     case 6:
           //         Console.WriteLine("Bien");
           //         break;

           //     case 7:
           //         goto case 8;
           //     case 8:
           //         Console.WriteLine("Notable");
           //         break;

           //     case 9:
           //         goto case 10;
           //     case 10:
           //         Console.WriteLine("Sobresaliente");
           //         break;
           // }


            //for (int i=1;i<=num;i++)
            //{
            //    if (num % i == 0)
            //        div++;
            //}
            //if (div==2)
            
            //    Console.WriteLine("{0} is a Prime number", num);
            //else

            //    Console.WriteLine("Not a Prime number");

 


           //int num1, num2;

           // Console.WriteLine("Please enter the first number : ");
           // num1 = Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("Please enter the second number : ");
           // num2 = Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("For Loop");

           // for (int i=1;i<4;i++)
           // {
           //     for (int j=num1; j<=num2; j++)
           //     {
           //         Console.Write(j);
           //     }
           //     Console.WriteLine();
           // }

           // Console.WriteLine("While Loop");

           // int k = num1;
           // int counter = 0;

           // while (counter<3)
           // {
           //     while (k <= num2)
           //     {
           //         Console.Write("{0}", k);
           //         k++;
           //     }

                
           // }
           // counter++;
           // Console.WriteLine();
            




           // Console.ReadLine();

//for (int i = 10; i <= 20; i += 2)
//{
//    if (i == 16)
//        continue;
//    Console.WriteLine(i);

//}

//Console.WriteLine();
//for (int i = 10; i <= 20; i++ )
//{

//    if (i % 2 == 1)
//        continue;
//    if (i == 16)
//        continue;

//    Console.WriteLine(i);                
//}

//Console.WriteLine();

//for (int i = 10; ;i+=2 )
//{
//    if (i == 16)
//        continue;

//    if (i > 20)
//        break;

//    Console.WriteLine(i);         
//}

//    Console.ReadLine();

            //Console.WriteLine("Please enter the number: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the desired width: ");
            //width = Convert.ToInt32(Console.ReadLine());

            //for (int j = 1; j <= width; j++)
            //{
            //    for (int i = 1; i <= width; i++)
            //    {
            //        Console.Write("{0}", num);
            //    }
            //    Console.WriteLine();
            //    //Console.WriteLine("{0}", num);
           

            
                //do
                //{
                //    Console.WriteLine("Multiplication Table For {0}", num);
                //    for (int i = 1; i < 11; i++)
                //    {

                //        Console.WriteLine("{0}*{1} = {2}", num, i, num * i);

                //    }
                //    num++;

                //} while (num < 7);

           



            //do
            //{
            //    Console.WriteLine("Please enter User ID : ");
            //    user = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Please enter password : ");
            //    pass = Convert.ToInt32(Console.ReadLine());

            //    if ((user != 12) || (pass != 1234))
            //    {
            //         Console.WriteLine("Invalid Login");
            //        counter++;
            //    }


            //} while (((user != 12) || (pass != 1234)) && counter <3);

            //if ((user == 12) || (pass == 1234))
            //{
            //    Console.WriteLine("Login Successful");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Login");
            //}
            //Console.ReadLine();





















            //int user, pass;
            //int counter = 0;

            //do
            //{
            //    Console.Write("Enter a user:  ");
            //    user = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter a password:  ");
            //    pass = Convert.ToInt32(Console.ReadLine());

            //    if ((user != 12) || (pass != 1234))
            //    {
            //        Console.WriteLine("Login Error");
            //        counter++;
            //    }

            //}
            //while (((user != 12) || (pass != 1234)) && (counter != 3));

            //if ((user != 12) || (pass != 1234))
            //    Console.WriteLine("Logged out!");
            //else
            //    Console.WriteLine("Login successful");
           
            
            //int num1, num2;

            ////Console.WriteLine("\t\tNumbers divisible by 3 and 5");

            ////for (int i = 1; i <= 500; i++)
            ////{
            ////    if (i%3==0 && i%5==0)
            ////    {
                    
            ////        Console.Write("\t{0}\t", i);

            ////        //Console.Write("\t{0}\t", i);
            ////    }
            ////}

            ////int sum = 0;
            //do
            //{
            //    Console.WriteLine("Enter user ID Should be a number ");
            //    num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter password ID Should be a number ");
            //    num2 = Convert.ToInt32(Console.ReadLine());         
                
            //    if ((num1 != 12) || (num2 != 1234))
            //    {
            //        Console.WriteLine("Login Error");
            //    }

            //}
            //while (num1 != 12 || num2 = 1234);

            //Console.WriteLine("\nFinished");
            //Console.ReadLine();
                
            //    //, num3;
            ////double result;
                
            
           
            //////Console.WriteLine("Please enter the first number");

            //////num1 = int.Parse(Console.ReadLine());
            ////int i = 1;

            ////while (i<=10)
            ////{

            ////    Console.WriteLine("{0}", i);

            ////    //Console.WriteLine("Please enter the number");

            ////    //num1 = int.Parse(Console.ReadLine());

            //    //Console.WriteLine("10 * {0} = {1}", num1, num1 * 10);
            //    //i++;

            ////} 


            ////Console.WriteLine("Please enter the second number");

            ////num2 = int.Parse(Console.ReadLine());

            ////Console.WriteLine("Please enter the third number");

            ////num3 = int.Parse(Console.ReadLine());

            ////if (num1>num2)
            ////{
            ////    if (num1>num3)
            ////    {
            ////        Console.WriteLine("{0} is greatest.", num1);
            ////        //break;
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("{0} is greatest.", num3);
            ////        //break;
            ////    }
                    
            ////}
            ////else 
            ////    if (num2>num3)
            ////    {
            ////        Console.WriteLine("{0} is greatest.", num2);
            ////        //break;
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("{0} is greatest.", num3);
            ////    }
            ////if (num2 == 0)

            ////    Console.WriteLine("Cannot divide");
            ////else
            ////{
            ////    result = num1 / num2;

            ////    Console.WriteLine("{0}/{1} = {2}", Convert.ToString(num1), Convert.ToString(num2), (result).ToString());
            ////}
            
            
            ////for (int i = 1; i <= 10;i++ )
            ////{

            ////    Console.WriteLine("{0} * {1} = {2}", Convert.ToString(num1), Convert.ToString(i), Convert.ToString(num1 * i));


            ////}

            //////    Console.WriteLine("Please enter the second number");

            ////num2 = int.Parse(Console.ReadLine());

           

            ////int num4 = num1 * num2 * num3;

            ////Console.WriteLine("The multiplication of 3 numbers is : {0}", Convert.ToString(num4));

            ////Console.ReadLine();

