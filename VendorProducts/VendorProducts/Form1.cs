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

namespace VendorProducts
{
    public partial class Form1 : Form
    {

        string datasource;

        string sqlGetVendor, sqlGetVendorProducts;

        SqlConnection connection;

        SqlDataAdapter adapter1;

        SqlDataAdapter adapter2;

        DataSet ds = new DataSet();

        DataSet ds1 = new DataSet();

        string BusinessEntityID;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVendorProducts_Click(object sender, EventArgs e)
        {
            try
            {
                datasource = Properties.Settings.Default.sqlConn;

                connection = new SqlConnection(datasource);

                connection.Open();

                sqlGetVendor = "SELECT BusinessEntityID, Name FROM Purchasing.Vendor (NOLOCK) WHERE Name LIKE '"+ txtVendor.Text.ToString() + "%'";

                adapter1 = new SqlDataAdapter(sqlGetVendor, connection);

                adapter1.Fill(ds);
                                            
                getVenors();

                //dataGridView1.ClearSelection();

                connection.Close();
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }     
                   
           
        }

        private void getVenors()
        {
            
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No record exist for ID "+txtID.Text.ToString());
            }
            else
            {
       
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoResizeColumns();
                                             

            }
            
        }



       private void button1_Click(object sender, EventArgs e)
       {
                      
           //dataGridView2.DataSource = null;

           

           //dataGridView2.Rows.Clear();

           //dataGridView2.Refresh();
           //ds1.Tables[0].Reset();

           BusinessEntityID = dataGridView1.CurrentCell.Value.ToString();

           sqlGetVendorProducts = "select pv.ProductID, p.Name, p.ProductNumber, pv.StandardPrice  from Purchasing.productVendor pv (nolock) INNER JOIN production.product p (nolock) on pv.ProductID = p.ProductID WHERE pv.BusinessEntityID = '" + BusinessEntityID + "'";


           adapter2 = new SqlDataAdapter(sqlGetVendorProducts, connection);

           adapter2.Fill(ds1);
           
           
           dataGridView2.DataSource = ds1.Tables[0];
           dataGridView2.AutoResizeColumns();

           

       }
        

    }
}
