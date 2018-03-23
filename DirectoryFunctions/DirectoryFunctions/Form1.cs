using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirectoryFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\Paresh"))
            {
                MessageBox.Show("Directory Already Exist. Deleting existing directory");
                Directory.Delete("c:\\Paresh");
                MessageBox.Show("Existing directory deleted");
                Directory.CreateDirectory("c:\\Paresh");

                MessageBox.Show("New Directory Created");

            }
            else
            {

                Directory.CreateDirectory("c:\\Paresh");

                MessageBox.Show("Directory Created");
            }

        }
    }
}
