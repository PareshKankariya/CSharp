using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxSelectIndexEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex==0)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("MasterCard");
                listBox2.Items.Add("Visa");
                listBox2.Items.Add("Discover");
                listBox2.Items.Add("American Express");
            }
            else if (listBox1.SelectedIndex==1)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Personal");
                listBox2.Items.Add("Business");
                listBox2.Items.Add("eCheck");
            }
            else
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("PayPal");
            }

            
            
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                MessageBox.Show("You have selected to pay via " + listBox1.SelectedItem + " - "   + listBox2.SelectedItem);
            }
        }
    }
}
