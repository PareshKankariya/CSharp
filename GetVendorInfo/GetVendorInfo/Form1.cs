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
namespace GetVendorInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {


            string conn = null;

            //conn = "Data Source=LOCALHOST;Initial Catalog=AdventureWorks2014;Persist Security Info=True;User ID=paresh;Password=Password1";

            conn = Properties.Settings.Default.SQLConn;

            SqlConnection cnn = new SqlConnection(conn);

            cnn.Open();

            string sqlGetVendorInfo = "SELECT BusinessEntityID, AccountNumber, Name FROM Purchasing.Vendor (nolock) WHERE BusinessEntityID = '"+txtID.Text.ToString()+"'";


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();


            string sqlGetVendorProducts = "select pv.ProductID, p.Name, p.ProductNumber, pv.StandardPrice  from Purchasing.productVendor pv (nolock) INNER JOIN production.product p (nolock) on pv.ProductID = p.ProductID WHERE pv.BusinessEntityID = '" + txtID.Text.ToString() + "'";

            SqlCommand cmd = new SqlCommand(sqlGetVendorInfo, cnn);

            adapter.SelectCommand = new SqlCommand(sqlGetVendorProducts, cnn);

            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


         //   MessageBox.Show(rdr.HasRows().);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("No Record Exist for "+ txtID.Text.ToString());
                //rdr.Close();
                cnn.Close();
            }
            else
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtID.Text = rdr[0].ToString();
                    txtAcc.Text = rdr[1].ToString();
                    txtVName.Text = rdr[2].ToString();
                }

       
                rdr.Close();

                SqlCommand cmd2 = new SqlCommand(sqlGetVendorProducts, cnn);

                SqlDataReader rdr1 = cmd2.ExecuteReader();

                lstProduct.Items.Clear();
                lstProduct.Items.Add("Product ID\t" + "Product Name\t\t" + "Product Number\t\t" + "Standard Price");

                while (rdr1.Read())
                {
                    lstProduct.Items.Add(rdr1[0].ToString() + "\t\t" + rdr1[1].ToString() + "\t\t" + rdr1[2].ToString() + "\t\t" + rdr1[3].ToString());

                }

                rdr1.Close();
                cnn.Close();
            
            }
            

        }
    }
}
