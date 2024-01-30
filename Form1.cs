using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using static WinFormsApp1.Form1;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        public string Username { get; private set; }
        public string Status { get; private set; }

        public string bookStatus { get; private set; }
        public string bookTitle { get; private set; }

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        string status;

        private void btnShow_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShow.Checked == true)
            {
                mTxtPass.UseSystemPasswordChar = false;
            }
            else
            {
                mTxtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();

            signup.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {

        }


        public class DataAccess
        {
            private string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2ND YEAR 1ST SEM\Objected Oriented Programming\FINAL TERM\ACTIVITIES AND QUIZZES\OOP FINAL PROJECT\WinFormsApp1\WinFormsApp1\Database1.mdf"";Integrated Security=True");

            public bool SignIn(string username, string password)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM logInForm WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
             string username = txtEmail.Text;
             string password = mTxtPass.Text;


            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(mTxtPass.Text) )
            {
                MessageBox.Show("Input Necessary Details", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                DataAccess dataAccess = new DataAccess();
                bool isAuthenticated = dataAccess.SignIn(username, password);

                if (isAuthenticated)
                {

                   if (rbAdmin.Checked)
                    {
                        adminForm admin = new adminForm();
                        admin.Show();

                        this.Hide();
                       

                    } else if (!rbAdmin.Checked) {
                    if (rbStudent.Checked)
                    {
                            status = "Student";
                    }
                    else if (rbTeacher.Checked)
                    {
                            status = "Teacher";
                    }
                    else
                    {

                        MessageBox.Show("Please select a status (Student or Teacher).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                   

                    if (ValidateCredentials(username, status))
                    {
                        libraryMainForm mainLibraryForm = new libraryMainForm(username, status, bookStatus);
                        mainLibraryForm.Show();

                        this.Hide();
                       
                    } else
        {
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
                }
            }
            }
        }
    

        private bool ValidateCredentials(string username, string status)
        {
           
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2ND YEAR 1ST SEM\\Objected Oriented Programming\\FINAL TERM\\ACTIVITIES AND QUIZZES\\OOP FINAL PROJECT\\WinFormsApp1\\WinFormsApp1\\Database1.mdf\";Integrated Security=True";
            string query = $"SELECT Status FROM logInForm WHERE Username = '{username}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    string storedStatus = result.ToString();

                    return storedStatus.Equals(status, StringComparison.OrdinalIgnoreCase);
                }
                return false;
            } 
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

