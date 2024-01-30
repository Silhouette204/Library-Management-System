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
using System.Drawing;
using static WinFormsApp1.Form1;


namespace WinFormsApp1
{
    public partial class libraryMainForm : Form
    {
        private string username;
        private string status;
        private string bookStatus;


        public libraryMainForm(string username, string status, string bookStatus)
        {


            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            lblUsername.Text = $"USERNAME: {username}";
            lblStatus.Text = $"STATUS: {status}";

            this.username = username;
            this.status = status;
            this.bookStatus = bookStatus;

        }



        private void libraryMainForm_Load(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookReturn bookreturn = new BookReturn(username, status, bookStatus);

            bookreturn.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookList booklist = new BookList(username, status, bookStatus);

            booklist.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            form.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (status == "Student")
            {
                BookBorrowerStudent bookBorrowerStudent = new BookBorrowerStudent(username, status, bookStatus);
                bookBorrowerStudent.Show();

                this.Hide();

            }
            else if (status == "Teacher")
            {
                BookBorrowerTeacher bookBorrowerTeacher = new BookBorrowerTeacher(username, status, bookStatus);
                bookBorrowerTeacher.Show();

                this.Hide();
            }
        }



        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void libraryBookReservation_Click(object sender, EventArgs e)
        {
            if (status == "Student")
            {
                BookReserveStudent bookReserveStudent = new BookReserveStudent(username, status, bookStatus);
                bookReserveStudent.Show();

                this.Hide();

            }
            else if (status == "Teacher")
            {
                BookReserveTeacher bookReserveTeacher = new BookReserveTeacher(username, status, bookStatus);
                bookReserveTeacher.Show();

                this.Hide();
            }
        }
    }
}
