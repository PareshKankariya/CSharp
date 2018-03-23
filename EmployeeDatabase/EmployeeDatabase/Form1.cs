using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseConnection objConnect;
        string conString;
        DataSet ds;        
        DataRow dRow;
        int MaxRows;
        int inc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();

                conString = Properties.Settings.Default.EmployeesConnectionString;

                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;
              
                ds = objConnect.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;

                NavigateRecords();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];

            txtFirstName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtLastName.Text = dRow.ItemArray.GetValue(2).ToString();
            txtJobTitle.Text = dRow.ItemArray.GetValue(3).ToString();
            txtDepartment.Text = dRow.ItemArray.GetValue(4).ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (inc != MaxRows-1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No More Rows");
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("First Record");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDepartment.Clear();
            txtJobTitle.Clear();

            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateRecords();

            btnAddNew.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow();

            row[1] = txtFirstName.Text;
            row[2] = txtLastName.Text;
            row[3] = txtJobTitle.Text;
            row[4] = txtDepartment.Text;

            ds.Tables[0].Rows.Add(row);
            
        }

        public void UpdateDatabase(System.Data.DataSet ds)
        {
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da_1);

            cb.DataAdapter.Update(ds.Tables[0]);


        }
    }
}
