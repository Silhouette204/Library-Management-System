using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class StudentForm : Form
    {
        private string username;
        private string status;
        private string bookStatus;

        public StudentForm(string username, string status, string bookStatus)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.username = username;
            this.status = status;
            this.bookStatus = bookStatus;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudID.Text) || string.IsNullOrWhiteSpace(txtStudYr.Text) || string.IsNullOrWhiteSpace(txtStudSec.Text))
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
                        cmd.CommandText = "INSERT INTO StudentTable VALUES(@StudentName, @StudentID, @YearLevel, @Section, @BookStatus)";
                        cmd.Parameters.AddWithValue("@StudentName", username);
                        cmd.Parameters.AddWithValue("@StudentID", txtStudID.Text);
                        cmd.Parameters.AddWithValue("@YearLevel", txtStudYr.Text);
                        cmd.Parameters.AddWithValue("@Section", txtStudSec.Text);
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
                        cmd.CommandText = "INSERT INTO StudentTableReserved VALUES(@StudentName, @StudentID, @YearLevel, @Section, @BookStatus)";
                        cmd.Parameters.AddWithValue("@StudentName", username);
                        cmd.Parameters.AddWithValue("@StudentID", txtStudID.Text);
                        cmd.Parameters.AddWithValue("@YearLevel", txtStudYr.Text);
                        cmd.Parameters.AddWithValue("@Section", txtStudSec.Text);
                        cmd.Parameters.AddWithValue("@BookStatus", "Reserved");


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book Reserved", "Confirmation");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occurred: " + ex.Message);
                    }
                }

                MessageBox.Show("Thank You!", "Confirmation");

                BookList bookList = new BookList(username, status, bookStatus);
                bookList.ShowDialog();

                this.Hide();
            }
            else
            {
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            BookList booklist = new BookList(username, status, bookStatus);
            booklist.Show();
            this.Hide();
        }
    }
}
