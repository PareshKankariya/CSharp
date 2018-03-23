using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            string WebPage = txtAddress.Text.Trim();
            webBrowser1.Navigate(WebPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (webBrowser1.CanGoBack)
           {
               webBrowser1.GoBack();
           }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnBack, "Go Back");
            toolTip1.SetToolTip(btnCancel, "Cancel");
            toolTip1.SetToolTip(btnForward, "Go Forward");
            toolTip1.SetToolTip(btnRefresh, "Refresh");
        }
    }
}
