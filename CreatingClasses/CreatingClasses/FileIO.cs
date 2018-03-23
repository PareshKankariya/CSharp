using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreatingClasses
{
    class FileIO
    {
        public void FileReadWrite()
        {
            string informationToWrite = "This is written by C # program";
            if (File.Exists("C:/LAFit/Per/C#/FileIO/test2.txt"))
            {
                File.WriteAllText("C:/LAFit/Per/C#/FileIO/test2.txt", informationToWrite);
            }
            else
            {
                Console.WriteLine("File Doesnot exist");
            }
            


            //Using Array to write to the file

            //string[] arrayOfInformation = new string[2];
            //arrayOfInformation[0] = "This is first line";
            //arrayOfInformation[1] = "This is second line";

            //File.WriteAllLines("C:/LAFit/Per/C#/FileIO/test1.txt", arrayOfInformation);

            //Reading from the file

           // string[] highScores = File.ReadAllLines("C:/LAFit/Per/C#/FileIO/test1.txt");

           //// Console.WriteLine(highScores.Length);

           // for (int index = 0; index < highScores.Length;index++)
           // {
           //     string[] token = highScores[index].Split(',');

           //     string name = token[0];

           //     int score = Convert.ToInt32(token[1]);
                
           //     Console.WriteLine(name+"\t"+score+"\n");
           // }



        }
    }
}
