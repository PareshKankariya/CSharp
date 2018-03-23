using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPropertiesGetSet
{
    class HappyBirthday
    {
        private string numberOfPresents;
        private string birthdayMessageNew;

        public HappyBirthday()
        {
            numberOfPresents = "Number of presents : ";
            birthdayMessageNew = "Happy Birthday ";

        }

        public string getMessage(string getName)
        {
            return birthdayMessageNew + getName;
        }

        public string getPresents (int numPresents)
        {
            numberOfPresents = numberOfPresents  + numPresents.ToString();
            return numberOfPresents;
        }

    }

    class BirthdayParty : HappyBirthday
        {
         public BirthdayParty() : base ()
        {

        }   
         public string getParty (Boolean haveParty)
        {
            if(haveParty==true)
            {
                return "Enjoy your party";
            }
            else
            {
                return "No party for you";
            }
        }    


        }
}
