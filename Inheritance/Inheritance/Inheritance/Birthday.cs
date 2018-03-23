using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Birthday
    {
        private string birthdayMessage;
        private string presents;

        public Birthday()
        {
            birthdayMessage = "Happy Birthday : ";
            presents = "Presents you get :";
        }

        public string getMessage (string getName)
        {
            return birthdayMessage + getName;
        }

        public string getPresents (int numOfPresents)
        {
            return presents + numOfPresents.ToString();
        }

    }

    class BirthdayInheritance : Birthday
    {
        public BirthdayInheritance() : base ()
        {

        }

        public string getParty(Boolean partyMessage)
        {
            if (partyMessage == true)
            {
                return "Enjoy your party";
            }
            else
            {
                return "No party for you";
            }
        }

        public string getParty(Boolean partyMessage, string aName)
        {
            if (partyMessage == true)
            {
                return "Enjoy your party "+aName;
            }
            else
            {
                return "No party for you "+aName;
            }
        }


    }
}
