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
    public partial class Puppies : Form
    {
        public Puppies()
        {
            InitializeComponent();
        }
        string stringConnection = @"Data Source= .\SQLEXPRESS;
                                     Initial Catalog = Shelter;
                                     Integrated Security = true;";

        
        private void search_Click(object sender, EventArgs e)
        {
            string id = (txtId.Text);
            if (id=="")
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
                        string sql = "SELECT Id,Name,BirthDate," +
                            "BreedId,Color,Age FROM Puppies where Id = " + id;
                        
                        using (SqlCommand command = new SqlCommand(sql, cnn))
                        {
                            using (SqlDataReader dataReader = command.ExecuteReader())
                            {
                                dataReader.Read();
                                {
                                    txtId.Text = dataReader[0].ToString();
                                    txtName.Text = dataReader[1].ToString();
                                    txtBirthDate.Text = dataReader[2].ToString().Split()[0];
                                    txtBreedId.Text = dataReader[3].ToString();
                                    txtColor.Text = dataReader[4].ToString();
                                    txtAge.Text = dataReader[5].ToString();
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }


       
        private void delete_Click(object sender, EventArgs e)
        {
            string id = (txtId.Text);
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "DELETE FROM Puppies " +
                    "WHERE Id="+id;

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
            string id = (txtId.Text), name=txtName.Text,bday=txtBirthDate.Text, brid=txtBreedId.Text,color=txtColor.Text, age=txtAge.Text ;
            bday = bday.Split()[0];
            DateTime dt = DateTime.Parse(bday);
            using (SqlConnection cnn = new SqlConnection(stringConnection))
                {
                    try
                    {
                        cnn.Open();
                        string sql = "" +
                        "INSERT INTO Puppies([Name],BirthDate,BreedId,Color, Age) " +
                        @"VALUES( '"+name+@"','"+ dt.Year + "/" + dt.Month + "/" +
                        dt.Day + "',"+brid+@",'"+color+@"',"+age+")";

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
            //}
        }

 
        private void save_Click(object sender, EventArgs e)
        {
            string id = (txtId.Text), name = txtName.Text,
                   bday = txtBirthDate.Text, brid = txtBreedId.Text, 
                   color = txtColor.Text, age = txtAge.Text;
            bday = bday.Split()[0];
            DateTime dt = DateTime.Parse(bday);
       
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "UPDATE Puppies" +
                    @" SET [Name]='" + name + @"', BirthDate= "+ "'"
                    +dt.Year+"/"+dt.Month +"/"+dt.Day+@"' ,BreedId=" + 
                    brid + @",Color='" + color+"',Age="+age+" Where Id="+id;
                   
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
            //}
        }

     
        private void showtable_Click(object sender, EventArgs e)
        {
            TablePup tbl = new TablePup();
            tbl.ShowDialog();

            }

        private void clear_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtBirthDate.Clear();
            txtBreedId.Clear();
            txtBreedName.Clear();
            txtColor.Clear();
            txtId.Clear();
            txtName.Clear();

        }

        private void brname_Click(object sender, EventArgs e)
        {
            string id = (txtBreedId.Text);
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "SELECT Breeds.[Name] FROM Breeds " +
                        "JOIN Puppies ON Breeds.Id = Puppies.BreedID " +
                        "Where Puppies.BreedId ="+id;
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            dataReader.Read();
                            {
                                txtBreedName.Text = dataReader[0].ToString();
                            }
                        }
                    }
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
    }
}
