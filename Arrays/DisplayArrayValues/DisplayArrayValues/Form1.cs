using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayArrayValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> students = new List<string>();
            students.Add("Mike");
            students.Add("John");
            students.Add("Jenny");
            students.Sort();
            foreach (string child in students)
            {
                listBox1.Items.Add(child);
            }
          

            //string[] arrayString = new string[5] { "This is", "a", "string", "from", "array" };

            //listBox1.Items.Add(arrayString[2]);

            //int[] timesArray = new int[10];
            //int times = int.Parse(txtArraySize.Text);

            //for (int i=0; i!=timesArray.Length; i++)
            //{
            //    timesArray[i] = (i+1) * times;
            //    listBox1.Items.Add(times+" times "+(i+1) +" = " + timesArray[i]);
            //}


            //int[] score = new int[10]; //{80, 82, 84, 86};
            ////listBox1.Items.Add(score[0]);

            //for (int i=0;i!=score.Length;i++)
            //{
            //    score[i] = i + 1;
            //    listBox1.Items.Add(score[i]);
            //}

            //int[] score = new int[Convert.ToInt32(txtArraySize.Text)];
            ////listBox1.Items.Add(score.Length);

            //for(int i=0;i!=score.Length;i++)
            //{
            //    score[i] = i * 5;
            //    listBox1.Items.Add(score[i]);

            //}


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Form1.
        }
    }
}
