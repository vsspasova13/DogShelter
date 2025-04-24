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
    public partial class Adopters : Form
    {
        public Adopters()
        {
            InitializeComponent();
        }
        string stringConnection = @"Data Source= .\SQLEXPRESS;
                                     Initial Catalog = Shelter;
                                     Integrated Security = true;";

        private void showtable_Click(object sender, EventArgs e)
        {
            TableAdopt tbl = new TableAdopt();
            tbl.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string id = (txtId.Text);
            if (id == "")
            {
                MessageBox.Show("Insert Id");
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(stringConnection))
                {
                    try
                    {
                        cnn.Open();
                        string sql = "SELECT Id,[First Name],[Last Name],[Phone Number], [Adoption Date], PuppyId FROM Adopters where Id = " + id;

                        using (SqlCommand command = new SqlCommand(sql, cnn))
                        {
                            using (SqlDataReader dataReader = command.ExecuteReader())
                            {
                                dataReader.Read();
                                {
                                    txtId.Text = dataReader[0].ToString();
                                    txtFN.Text = dataReader[1].ToString();
                                    txtLName.Text = dataReader[2].ToString().Split()[0];
                                    txtPhone.Text = dataReader[3].ToString();
                                    txtAdDate.Text = dataReader[4].ToString();
                                    txtPuppyid.Text = dataReader[5].ToString();
                                   
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string id = (txtId.Text), fname = txtFN.Text, lname = txtLName.Text, phone = txtPhone.Text, ad = txtAdDate.Text, pupid = txtPuppyid.Text;
            ad = ad.Split()[0];
            DateTime dt = DateTime.Parse(ad);

            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "UPDATE Adopters" +
                    @" SET [First Name]='" + fname + @"',[Last Name]='" + lname + @"',[Phone Number]='" + phone +"', [Adoption Date]='" + dt.Year + "/" + dt.Month + "/" + dt.Day +
                    @"',PuppyId=" + pupid +
                    " Where Id=" + id;

                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void addnew_Click(object sender, EventArgs e)
        {
            string id = (txtId.Text), fname = txtFN.Text, lname = txtLName.Text, phone = txtPhone.Text, ad = txtAdDate.Text, pupid = txtPuppyid.Text;
            ad = ad.Split()[0];
            DateTime dt = DateTime.Parse(ad);

            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "" +
                    "INSERT INTO Adopters([First Name],[Last Name],[Phone Number], [Adoption Date], PuppyId) " +
                    @"VALUES( '" + fname + @"','" + lname + @"','" + phone + @"', '" + dt.Year + "/" + dt.Month + "/" + dt.Day +
                    @"'," + pupid + ")";

                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id = (txtId.Text);
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "DELETE FROM Adopters " +
                    "WHERE Id=" + id;

                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtFN.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtAdDate.Clear();
            txtPuppyid.Clear();
        }

        private void PupName_Click(object sender, EventArgs e)
        {
            string id = (txtPuppyid.Text);
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "SELECT Puppies.[Name] FROM Puppies JOIN Adopters ON Puppies.Id = Adopters.PuppyId WHERE Adopters.PuppyId =" + id;
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                txtPupName.Text = dataReader[0].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Няма намерено кученце с такова ID.");
                            }

                        }
                    }

                    //using (SqlCommand command = new SqlCommand(sql, cnn))
                    //{
                    //    command.ExecuteNonQuery();
                    //}
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
    }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
