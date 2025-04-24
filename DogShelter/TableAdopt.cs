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
    public partial class TableAdopt : Form
    {
        public TableAdopt()
        {
            InitializeComponent();
        }
        string stringConnection = @"Data Source= .\SQLEXPRESS;
                                     Initial Catalog = Shelter;
                                     Integrated Security = true;";

        private void TableAdopt_Load(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                cnn.Open();
                string cmd = "SELECT * FROM Adopters";
                SqlCommand quer = new SqlCommand(cmd, cnn);
                var reader = quer.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
                cnn.Close();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
