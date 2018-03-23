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

namespace LocalDBApp
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

        private void btnConn_Click(object sender, EventArgs e)
        {

            String ConnectionString = null;

            ConnectionString = "Data Source = Localhost; Initial Catalog = AdventureWorks2014; User ID = paresh; Password = Password1";

            SqlConnection cnn = new SqlConnection(ConnectionString);

            cnn.Open();

           // int productID;

            //textInput.txt = null;

            //productID = textInput.Text.ToInteger();

            //select * from std where REGDNO='" + TextBox1.Text.Trim() + "'";

            String sqlQuery = "SELECT ProductID, Name, ProductNumber, SafetyStockLevel FROM Production.Product WHERE ProductID like '" + txtGetEmp + "'";

            //String sqlQuery = "SELECT ProductID FROM Production.Product WHERE ProductID = 330";

            SqlCommand cmd = new SqlCommand(sqlQuery, cnn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                txtID.Text = rdr[0].ToString();
                txtName.Text = rdr[1].ToString();
                txtNumber.Text = rdr[2].ToString();
                txtLevel.Text = rdr[3].ToString();

            }

            
            
                     

            cnn.Close();
 

         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


//String connectionString = null;

//SqlConnection cnn;

//connectionString = "Data Source=LOCALHOST;Initial Catalog=AdventureWorks2014;User ID=paresh;Password=Password1";

//cnn = new SqlConnection(connectionString);

//SqlCommand newCmd;

//cnn.Open();

//newCmd = new SqlCommand("SELECT ProductID, Name, ProductNumber, SafetyStockLevel FROM Production.Product WHERE ProductID = 321", cnn);

//SqlDataReader rdr = newCmd.ExecuteReader();
//rdr.Read();