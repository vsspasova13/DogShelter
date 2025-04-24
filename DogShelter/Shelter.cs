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
    public partial class Shelter : Form
    {
        public Shelter()
        {
            InitializeComponent();
        }

        string stringConnection = @"Data Source= .\SQLEXPRESS;
                                     Initial Catalog = Shelter;
                                     Integrated Security = true;";


        private void Pupp_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                cnn.Open();

                //cnn.Close();

                Puppies pupi = new Puppies();
                pupi.ShowDialog();
            }
        }

        private void Empp_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
           emp.ShowDialog();
        }

        private void Adoptt_Click(object sender, EventArgs e)
        {
            Adopters ad = new Adopters();
            ad.ShowDialog();
        }

        private void Shelter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
