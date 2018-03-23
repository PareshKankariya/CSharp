using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWishes_Click(object sender, EventArgs e)
        {
            BirthdayInheritance BirthdayMessages = new BirthdayInheritance();

            MessageBox.Show(BirthdayMessages.getMessage("TestName"));

            MessageBox.Show(BirthdayMessages.getPresents(5));

            MessageBox.Show(BirthdayMessages.getParty(true));

            MessageBox.Show(BirthdayMessages.getParty(true, "TestName"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show ((Stats.getSum(5, 7).ToString()));

        }
    }
}
