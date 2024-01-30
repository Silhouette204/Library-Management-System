using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TeacherForm : Form
    {

        private string username;
        private string status;
        private string bookStatus;
        public TeacherForm(string username, string status)
        {

            InitializeComponent();
            this.username = username;
            this.status = status;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList(username, status, bookStatus);

            bookList.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtEmpID.Text) || string.IsNullOrWhiteSpace(txtDept.Text))
            {
                MessageBox.Show("Please fill in all the information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to borrow this book? Borrow(Yes) Reserve (No)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2ND YEAR 1ST SEM\Objected Oriented Programming\FINAL TERM\ACTIVITIES AND QUIZZES\OOP FINAL PROJECT\WinFormsApp1\WinFormsApp1\Database1.mdf"";Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO TeacherTable VALUES(@TeacherName, @EmployeeID, @Department, @BookStatus)";
                        cmd.Parameters.AddWithValue("@TeacherName", username);
                        cmd.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text);
                        cmd.Parameters.AddWithValue("@Department", txtDept.Text);
                        cmd.Parameters.AddWithValue("@BookStatus", "Borrowed");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book Borrowed", "Confirmation");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occurred: " + ex.Message);
                    }
                }

                BookList bookList = new BookList(username, status, bookStatus);
                bookList.ShowDialog();

                this.Hide();

            }
            else if (result == DialogResult.No)
            {

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2ND YEAR 1ST SEM\Objected Oriented Programming\FINAL TERM\ACTIVITIES AND QUIZZES\OOP FINAL PROJECT\WinFormsApp1\WinFormsApp1\Database1.mdf"";Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO TeacherTabelReserved VALUES(@TeacherName, @EmployeeID, @Department, @BookStatus)";
                        cmd.Parameters.AddWithValue("@TeacherName", username);
                        cmd.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text);
                        cmd.Parameters.AddWithValue("@Department", txtDept.Text);
                        cmd.Parameters.AddWithValue("@BookStatus", "Reserved");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book Reserved", "Confirmation");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occurred: " + ex.Message);
                    }
                }
                BookList bookList = new BookList(username, status, bookStatus);
                bookList.ShowDialog();

                this.Hide();
            }
            else
            {
            }
        }
    }
}