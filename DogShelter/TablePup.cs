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
    public partial class TablePup : Form
    {
        public TablePup()
        {
            InitializeComponent();
        }

        string stringConnection = @"Data Source= .\SQLEXPRESS;
                                     Initial Catalog = Shelter;
                                     Integrated Security = true;";

        private void TablePup_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                cnn.Open();
                string cmd = "SELECT Id,Name,BirthDate,BreedId,Color,Age FROM Puppies";
                SqlCommand quer = new SqlCommand(cmd, cnn);
                var reader = quer.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                puppiesDataGridView.DataSource = table;
                cnn.Close();


            }
         

        }

        private void puppiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
