using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add AddNumber = new Add();
            int firstNum = int.Parse(txtFirstNum.Text);
            int secondNum = int.Parse(txtSecondNum.Text);
            if ((firstNum < 1 || firstNum > 10) || (secondNum < 1 || secondNum > 10))
            {
                MessageBox.Show("Please enter the number between 1 and 10");
            }
            else
            {
                int addAnswer = AddNumber.AddNumbers(firstNum, secondNum);
                txtAnswer.Text = Convert.ToString(addAnswer);
            }
            
        }
              
        
    }
}
    