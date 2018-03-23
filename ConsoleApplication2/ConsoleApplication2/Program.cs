using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = new string[3];
            input[0] = "Hello";
            input[1] = "World";
            input[2] = "Again!";

            Console.WriteLine("{0} {1} {2}", input[0], input[1], input[2]);

            foreach (string s in input)
                Console.WriteLine(s);

            int[] num = new int[3];
            num[0] = 11;
            num[1] = 12;
            num[2] = 13;

            foreach (int i in num)
                Console.Write(i+"\t");


            
            
            
            //int sum = 0;
            //int i=0;
            //int [] arr = new int[100];
            //do
            //{
            //    Console.WriteLine("Enter a number : ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    i++;
                
            //} while (Console.ReadLine(). 'end');






            //int[] newArr = new int[10];

            //for (int i = 0; i<10; i++)
            //{
            //    Console.WriteLine("Enter the number : ");
            //    newArr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            ////Console.WriteLine("Even Number(s) :");
            //int poscount = 0;
            //int negcount = 0;
            //int possum = 0;
            //int negsum = 0;

            //for (int i = 0; i<10;i++)
            //{
                

            //    if (newArr[i] > 0)
            //    {
                    
            //       possum = possum+newArr[i];
            //       poscount++;
            //    }
            //    else 
            //    {
            //        negsum = negsum+newArr[i];
            //        negcount++;
            //    }
                
            //}
            //Console.WriteLine("Avg of Positive numbers is : {0}", possum/poscount);
            //Console.WriteLine("Avg of Negative numbers is : {0}", negsum/negcount);

            //Console.WriteLine("\n Count: {0}", count);
            Console.ReadLine();
        }
      
    }
}


            //int[] intArr = new int[10];

            //for (int i=0;i<5;i++)
            //{

            //    Console.WriteLine("Please enter the : ");
            //    intArr[i] = Convert.ToInt32(Console.ReadLine());
                
            //}
            //for (int j=0;j<5;j++)
            //{
            //    Console.Write("Original Array : {0}\t", intArr[j]);
            //}  

            //Console.ReadLine();
         
            //   for(char i = 'B'; i <= 'N'; i++)
        // {
        //    Console.Write("{0} ", i);
        // }
        //Console.WriteLine();
        //Console.ReadLine();

        //}
            // int height, width, row, column, max;
            //Console.Write("Enter the width : ");
            //height = Convert.ToInt32(Console.ReadLine());
            //max = height; 
            //width = 0;

            //for (row = 0; row < height;row++ )
            //{

            //    for (column = 0; column < width; column++)

            //        Console.Write(" ");

            //    for (int ast = 0; ast < max; ast++)
            //        Console.Write("*");
                    
            //        width++;
            //        max--;                

            //}



            
            //int dist, hour, min, sec, mps, kmph, mph;
            
            //    Console.Write("Enter the distance in meters : ");
            //    dist = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter the time taken in Hr : ");
            //    hour = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter the time taken in min : ");
            //    min = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter the time taken in sec : ");
            //    sec = Convert.ToInt32(Console.ReadLine());
                
            //    int timesec = ((hour * 60 * 60) + (min * 60) + sec);

            //    mps =  dist/timesec;

            //    kmph = ((dist/1000)/(timesec/3600));

            //    mph = (kmph/Convert.ToInt32(1.609));
            

            //    Console.WriteLine("{0} {1} {2}", mps, kmph, mph);
            
            
            //if (x>=-10 && x<=10)
            //{
            //    y = (x * x) - 2 * x + 1;

            //    Console.Write(y);

            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write("*");
                    
            //    }
            //    Console.WriteLine();
            //}
            
                //for (int i = 1;i<=num;i++)
                //{
                //    if (num%i==0)
                //        div++;
                //}
                //if (div==2)
                //    Console.Write ("Number {0} is a prime numer", num);
                //else
                //    Console.Write ("Number {0} is a NOT a prime numer", num);

                //Console.Write("Enter the value of x from -10 to 10 : ");
                //x = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Enter the operation : ");
                //cOperation = Convert.ToChar(Console.ReadLine());
                //Console.Write("Enter the second number : ");
                //num2 = Convert.ToInt32(Console.ReadLine());       



                //if (cOperation == '+')
                //    Console.WriteLine("{0} {1} {2} = {3}", num1, cOperation, num2, (num1 + num2));
                //else if (cOperation == '-')
                //    Console.WriteLine("{0} {1} {2} = {3}", num1, cOperation, num2, (num1 - num2));
                //else if (cOperation == '*')
                //    Console.WriteLine("{0} {1} {2} = {3}", num1, cOperation, num2, (num1 * num2));
                //else if (cOperation == '/')
                //    Console.WriteLine("{0} {1} {2} = {3}", num1, cOperation, num2, (num1 / num2));
                //else
                //    Console.WriteLine("Invalid Operation");
               
         
            
            
            //do
            //{
                
                

            //} while (((username != "user" && password != "password")) && counter < 3);

            //if (counter == 3)
            //{
            //    Console.Write("Login Unsuccessful");
            //}
            //else
            //{
            //    Console.Write("Login Successful");
            //}                
            
            // Console.ReadLine();

            

