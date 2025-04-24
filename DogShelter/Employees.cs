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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        string stringConnection = @"Data Source= .\SQLEXPRESS;
                                     Initial Catalog = Shelter;
                                     Integrated Security = true;";
        private void clear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtFN.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtSal.Clear();
            txtHireDate.Clear();
            txtPosId.Clear();
            txtPupId.Clear();
            


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
                        string sql = "SELECT Id,[First Name],[Last Name],[Phone Number], Salary, [Hire Date], PositionId, PuppyId FROM Employees where Id = " + id;

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
                                    txtSal.Text = dataReader[4].ToString();
                                    txtHireDate.Text = dataReader[5].ToString();
                                    txtPosId.Text = dataReader[6].ToString();
                                        txtPupId.Text = dataReader[7].ToString();

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
            string id = (txtId.Text), fname=txtFN.Text, lname=txtLName.Text, phone=txtPhone.Text, sal=txtSal.Text, hdate=txtHireDate.Text, posid=txtPosId.Text, pupid=txtPupId.Text;
            hdate = hdate.Split()[0];
            DateTime dt = DateTime.Parse(hdate);

            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "UPDATE Employees" +
                    @" SET [First Name]='" + fname + @"',[Last Name]='"+lname+@"',[Phone Number]='"+phone+@"',Salary="+sal+", [Hire Date]='" + dt.Year + "/" + dt.Month + "/" + dt.Day +
                    @"' ,PositionId=" + posid + ",PuppyId=" + pupid +
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

            string id = (txtId.Text), fname = txtFN.Text, lname = txtLName.Text, phone = txtPhone.Text, sal = txtSal.Text, hdate = txtHireDate.Text, posid = txtPosId.Text, pupid = txtPupId.Text;
            hdate = hdate.Split()[0];
            DateTime dt = DateTime.Parse(hdate);

            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "" +
                    "INSERT INTO Employees([First Name],[Last Name],[Phone Number], Salary, [Hire Date], PositionId, PuppyId) " +
                    @"VALUES( '" + fname + @"','"  + lname + @"','" + phone + @"'," + sal + ", '" + dt.Year + "/" + dt.Month + "/" + dt.Day +
                    @"' ," + posid + "," + pupid+")";

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
                    string sql = "DELETE FROM Employees " +
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

        private void showtable_Click(object sender, EventArgs e)
        {
            TableEmp tbl = new TableEmp();
            tbl.ShowDialog();
        }

        private void PosName_Click(object sender, EventArgs e)
        {
            string id = (txtPosId.Text);
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "SELECT Positions.[Name] FROM Positions JOIN Employees ON Positions.Id = Employees.PositionId Where Employees.PositionId =" + id;
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            dataReader.Read();
                            {
                                txtPosName.Text = dataReader[0].ToString();

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

        private void PupName_Click(object sender, EventArgs e)
        {
            string id = (txtPupId.Text);
            using (SqlConnection cnn = new SqlConnection(stringConnection))
            {
                try
                {
                    cnn.Open();
                    string sql = "SELECT Puppies.[Name] FROM Puppies JOIN Employees ON Puppies.Id = Employees.PuppyId Where Employees.PuppyId =" + id;
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            dataReader.Read();
                            {
                                txtPupName.Text = dataReader[0].ToString();

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

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

