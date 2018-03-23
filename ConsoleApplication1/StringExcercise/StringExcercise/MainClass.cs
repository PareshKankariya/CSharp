using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringExcercise
{
    public class MainClass
    {
        public static void Main(string[] args)
        {

            UserInput userInputObj = new UserInput();
            CopyString copyStringObj = new CopyString();

            copyStringObj.StringCopy(userInputObj.userInput());
            //CompareInputStrings compareStringObj = new CompareInputStrings();
            //FindAlphabetDigitSpecialCharacter findCharObj = new FindAlphabetDigitSpecialCharacter();
            //findCharObj.findCharacters();
            
            // compareStringObj.compareString();
            //UserInput userInputObj = new UserInput();
            
            //BasicStringOperation basicStringOpearionObj = new BasicStringOperation();
            //String inputS = userInputObj.userInput();
            //basicStringOpearionObj.basicStringOps(inputS);
            Console.ReadLine();

        }
    }
}
