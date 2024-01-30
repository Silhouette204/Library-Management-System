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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2ND YEAR 1ST SEM\Objected Oriented Programming\FINAL TERM\ACTIVITIES AND QUIZZES\OOP FINAL PROJECT\WinFormsApp1\WinFormsApp1\Database1.mdf"";Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();

         this.StartPosition = FormStartPosition.CenterScreen;
        }

        string status;

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                maskTxtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                maskTxtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1 signIn = new Form1();

            signIn.Show();

            this.Hide();


        }

        private void btnReadySU_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO logInForm (username, password, status, BookUse) VALUES('" + txtCreateUser.Text + "','" + maskTxtNewPass.Text + "','" + status + "','')";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added");

                Form1 signIn = new Form1();

                signIn.Show();

                this.Hide();

            }
            catch
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void rbCreateStudent_CheckedChanged(object sender, EventArgs e)
        {
            status = "Student";
        }

        private void rbCreateTeacher_CheckedChanged(object sender, EventArgs e)
        {
            status = "Teacher";
        }

        private void rbSUAdmin_CheckedChanged(object sender, EventArgs e)
        {
            status = "admin";
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            rbSUAdmin.Hide();
        }
    }
}

