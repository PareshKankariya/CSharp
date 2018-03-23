using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManupilation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName;

            fileName = "c:\\LAFit\\testfile.txt";

            System.IO.StreamReader readFile;

            if (System.IO.File.Exists (fileName) == true)
                {
                readFile = new System.IO.StreamReader(fileName);

                textBox1.Text = readFile.ReadToEnd();

                readFile.Close();                               
            }

            else
            {
                MessageBox.Show("File does not exist");
            }

            



        }
    }
}
