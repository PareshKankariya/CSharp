using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //void Add()
        //{
        //    MessageBox.Show("This will add numbers");
        //    return;
        //}

        public int AddNum (int num1, int num2)
        {
            int addition = num1 + num2;
            return addition;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add ();

            int a = Int32.Parse(txt1.Text.ToString());
            int b = Int32.Parse(txt2.Text.ToString());

            txtAnswer.Text = (AddNum(a, b)).ToString();                 


        }
    }
}
