using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WinFormsApp1.BookList;




namespace WinFormsApp1
{
    public partial class BookList : Form
    {

        private string username;
        private string status;

        string bookStatus = "Available";
        public BookList(string username, string status, string bookStatus)
        {

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.username = username;
            this.status = status;
            this.bookStatus = bookStatus;

            Username.Text = $"USERNAME: {username}";
            Status.Text = $"STATUS: {status}";

        }

        private void Button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            libraryMainForm mainForm = new libraryMainForm(username, status, bookStatus);
            mainForm.Show();
            this.Hide();
        }

        private void UpdateBookUse(string bookTitle)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2ND YEAR 1ST SEM\\Objected Oriented Programming\\FINAL TERM\\ACTIVITIES AND QUIZZES\\OOP FINAL PROJECT\\WinFormsApp1\\WinFormsApp1\\Database1.mdf\";Integrated Security=True"))
                {
                    connection.Open();

                    string selectQuery = "SELECT BookUse FROM logInForm WHERE username = @Username";
                    string updateQuery = "UPDATE logInForm SET BookUse = @BookUse WHERE username = @Username";

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@Username", username);

                        string currentText = Convert.ToString(selectCommand.ExecuteScalar());

                        if (!currentText.Contains(bookTitle))
                        {
                            string newText = currentText + Environment.NewLine + bookTitle;
                            updateCommand.Parameters.AddWithValue("@Username", username);
                            updateCommand.Parameters.AddWithValue("@BookUse", newText);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("Educated");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("Educated");
            }

        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Academic Books are only allowed inside the library.", "Confirmation", MessageBoxButtons.OK);
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();
                UpdateBookUse("The Structure of Scientific");

            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Structure of Scientific");
            }
            else
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Academic Books are only allowed inside the library.", "Confirmation", MessageBoxButtons.OK);
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Interpretation of Dreams");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Interpretation of Dreams");
            }
            else
            {
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Academic Books are only allowed inside the library.", "Confirmation", MessageBoxButtons.OK);
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Second Sex");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Second Sex");
            }
            else
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Academic Books are only allowed inside the library.", "Confirmation", MessageBoxButtons.OK);
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();
                UpdateBookUse("Brief History of Time");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("Brief History of Time");
            }
            else
            {
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookList_Load(object sender, EventArgs e)
        {

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;


            txtBookStatusFic1.Enabled = false;
            txtBookStatusFic2.Enabled = false;
            txtBookStatusFic3.Enabled = false;
            txtBookStatusFic4.Enabled = false;
            txtBookStatusFic5.Enabled = false;
            txtBookStatusFic6.Enabled = false;

            txtBookStatusNFic1.Enabled = false;
            txtBookStatusNFic2.Enabled = false;
            txtBookStatusNFic3.Enabled = false;
            txtBookStatusNFic4.Enabled = false;
            txtBookStatusNFic5.Enabled = false;
            txtBookStatusNFic6.Enabled = false;

            txtBookStatusAcad1.Enabled = false;
            txtBookStatusAcad2.Enabled = false;
            txtBookStatusAcad3.Enabled = false;
            txtBookStatusAcad4.Enabled = false;
            txtBookStatusAcad5.Enabled = false;
            txtBookStatusAcad6.Enabled = false;


            txtBookStatusFic1.Text = "Available";
            txtBookStatusFic2.Text = "Available";
            txtBookStatusFic3.Text = "Available";
            txtBookStatusFic4.Text = "Available";
            txtBookStatusFic5.Text = "Available";
            txtBookStatusFic6.Text = "Available";

            txtBookStatusNFic1.Text = "Available";
            txtBookStatusNFic2.Text = "Available";
            txtBookStatusNFic3.Text = "Available";
            txtBookStatusNFic4.Text = "Available";
            txtBookStatusNFic5.Text = "Available";
            txtBookStatusNFic6.Text = "Available";

            txtBookStatusAcad1.Text = "Available";
            txtBookStatusAcad2.Text = "Available";
            txtBookStatusAcad3.Text = "Available";
            txtBookStatusAcad4.Text = "Available";
            txtBookStatusAcad5.Text = "Available";
            txtBookStatusAcad6.Text = "Available";


        }

        private void btnFic1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("Harry Potter");

            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("Harry Potter");

            }
        }

        private void btnFic2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Great Gatsby");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Great Gatsby");
            }
        }

        private void btnFic3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Lord of Rings");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Lord of Rings");
            }
            else
            {
            }
        }

        private void btnFic4_Click(object sender, EventArgs e)
        {
            // Optionally, you can specify additional parameters
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Hunger Games");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Hunger Games");

            }
            else
            {
            }
        }

        private void btnFic5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Hobbit");

            }

            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Hobbit");
            }

            else
            {
            }
        }


        private void btnFic6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("Pride and Prejudice");

            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("Pride and Prejudice");
            }
            else
            {
            }
        }

        private void btnNFic1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Power of Introverts");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Power of Introverts");
            }
            else
            {
            }
        }

        private void btnNFiction3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Immortal Life");

            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Immortal Life");
            }
            else
            {
            }
        }

        private void btnNFiction4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("Sapiense");
            }

            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("Sapiense");

            }
            else
            {
            }
        }

        private void btnNFiction5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();
                UpdateBookUse("The Sixth Extinction");
            }

            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Sixth Extinction");
            }

            else
            {
            }
        }

        private void btnNFiction6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();
                UpdateBookUse("The Glass Castle");
            }

            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();
                UpdateBookUse("The Glass Castle");
            }
            else
            {
            }
        }

        private void btnAcademic1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Academic Books are only allowed inside the library.", "Confirmation", MessageBoxButtons.OK);
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();
                UpdateBookUse("The Oxford EAP");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Oxford EAP");

            }
            else
            {
            }
        }

        private void btnAcademic4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Academic Books are only allowed inside the library.", "Confirmation", MessageBoxButtons.OK);
            DialogResult result = MessageBox.Show("Are you a Student?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StudentForm studentForm = new StudentForm(username, status, bookStatus);
                studentForm.Show();
                this.Hide();

                UpdateBookUse("The Elements of Style");
            }
            else if (result == DialogResult.No)
            {
                TeacherForm teacherForm = new TeacherForm(username, status);
                teacherForm.Show();
                this.Hide();

                UpdateBookUse("The Elements of Style");

            }
            else
            {
            }
        }

        private void bookStatusFic1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void infoFic1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBookStatusFic1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}






