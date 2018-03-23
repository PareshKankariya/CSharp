using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Left button was clicked");
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right button was clicked");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.A)
            {
                MessageBox.Show("Letter A Pressed");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You can't lease this box empty");
                textBox1.Focus();
            }
            else
            {
                textBox1.Text.c
            }
        }
    }
}
