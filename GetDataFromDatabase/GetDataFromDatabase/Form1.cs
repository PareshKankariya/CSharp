using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GetDataFromDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string connString = null;

            connString = "Data Source=LOCALHOST;Initial Catalog=AdventureWorks2014;Persist Security Info=True;User ID=paresh;Password=Password1";

           // DataSet ds = new DataSet();

            //SqlDataAdapter adapter = new SqlDataAdapter();

            SqlConnection cnn = new SqlConnection(connString);

            cnn.Open();

            string sqlQuery = "SELECT FirstName, LastName FROM Person.Person WHERE FirstName like '"+txtGetEmp.Text+"%'";
            SqlCommand cmd = new SqlCommand(sqlQuery, cnn);

            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                txtFirstName.Text = rdr[0].ToString();
                txtLastName.Text = rdr[1].ToString();
                lstEmployee.Items.Add(rdr[0].ToString()); //+ "\t" + rdr[1].ToString());
                //txtFirstName.Text = rdr[0].ToString();
                //txtLastName.Text = rdr[1].ToString();

            }
            rdr.Dispose();
                                   

            cnn.Close();
        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtFirstName.Text = "TEST" ;//rdr[0].ToString();
            //txtLastName.Text = "TEST2";//rdr[1].ToString();

            txtFirstName.Text = lstEmployee.SelectedItem.ToString();

            getEmail(txtFirstName.Text);
                   

        }

        public void getEmail(string emailadd)
        {

            string connString1 = "Data Source=LOCALHOST;Initial Catalog=AdventureWorks2014;Persist Security Info=True;User ID=paresh;Password=Password1";

            SqlConnection cnn1 = new SqlConnection(connString1);

            cnn1.Open();

            //string address = emailadd;
            string sqlQuery1 = "SELECT EmailAddress FROM Person.EmailAddress e JOIN Person.Person p ON e.BusinessEntityID = p.BusinessEntityID WHERE p.FirstName like '" + emailadd + "%'";

            

            SqlCommand cmd1 = new SqlCommand(sqlQuery1, cnn1);

            SqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())
            {
                lstEmail.Items.Add(rdr1[0].ToString());
            }
            cnn1.Close();
        }
 

          
   
    }
}
