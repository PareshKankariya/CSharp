using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            FileIO FileIOobj = new FileIO();
            FileIOobj.FileReadWrite();

            PrimeNumber findPrime = new PrimeNumber();
            findPrime.FindPrime();

            //TryCatch getNumber = new TryCatch();

            //getNumber.ReturnNumber();

            // Player player = new Player("John Smith");

            // Console.WriteLine("Name of player # 1 is : " + player.GetName());

            // Console.WriteLine("Starting score of player # 1 is : " + player.GetScore());

            // player.GetPoints(100);                                             

            // Console.WriteLine("New Score of player # 1 is : " + player.GetScore());

            // Console.WriteLine("Starting Lives Left for player # 1 is : " + player.GetLivesLeft());

            // player.Kill();

            // Console.WriteLine("New Lives Left for player # 1 is : " + player.GetLivesLeft());

            // Properties NewProp = new Properties() { Seconds = 120 };

            //// NewProp.Seconds = 100;

            // Console.WriteLine("Seconds : " + NewProp.Seconds);

            // Console.WriteLine("Minutes : " + NewProp.Minutes);

            Console.ReadLine();
        }
    }
}
