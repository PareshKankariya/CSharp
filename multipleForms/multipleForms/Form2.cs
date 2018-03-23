using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace multipleForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string changecase = Form1.tb.Text;

            if (rbLowerCase.Checked == true)
            {
                changecase = changecase.ToLower();
            }
            else if (rbUpperCase.Checked == true)
            {
                changecase = changecase.ToUpper();
            }
            else if (rbProperCase.Checked == true)
            {
                CultureInfo properCase = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfoObject = properCase.TextInfo;

                changecase = textInfoObject.ToTitleCase(changecase);
            }
            Form1.tb.Text = changecase;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
