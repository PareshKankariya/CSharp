using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPropertiesGetSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {

            //HappyBirthday BirthdayMessage = new HappyBirthday();

           // MessageBox.Show(BirthdayMessage.getMessage("TEST"));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BirthdayParty birthdayWishes = new BirthdayParty();

            MessageBox.Show(birthdayWishes.getMessage("Testing"));

            MessageBox.Show(birthdayWishes.getPresents(5));

            MessageBox.Show(birthdayWishes.getParty(false));
                     


        }
    }
}
