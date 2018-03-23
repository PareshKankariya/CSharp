using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime theDate;

            theDate = new DateTime();

            theDate = DateTime.Now;

            MessageBox.Show("Date and Time Now " + theDate.ToString());

            theDate = DateTime.Now.Date;

            MessageBox.Show("Today's Date "+ theDate.ToString());

            theDate = DateTime.UtcNow;

            MessageBox.Show("UTC Date and Time " + theDate.ToString());


        }
    }
}
