using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace viliProekt2
{
    public partial class TableEmp : Form
    {
        public TableEmp()
        {
            InitializeComponent();
        }
 string stringConnection = @"Data Source= .\SQLEXPRESS;
                                     Initial Catalog = Shelter;
                                     Integrated Security = true;";
        private void TableEmp_Load(object sender, EventArgs e)
        {


           

           
                using (SqlConnection cnn = new SqlConnection(stringConnection))
                {
                    cnn.Open();
                    string cmd = "SELECT * FROM Employees";
                    SqlCommand quer = new SqlCommand(cmd, cnn);
                    var reader = quer.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                    cnn.Close();


                }
                // TODO: This line of code loads data into the 'shelterDataSet.Employees' table. You can move, or remove it, as needed.
                //this.employeesTableAdapter.Fill(this.shelterDataSet.Employees);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
