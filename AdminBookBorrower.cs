using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminBookBorrower : Form
    {

        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public AdminBookBorrower()
        {
            InitializeComponent();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2ND YEAR 1ST SEM\\Objected Oriented Programming\\FINAL TERM\\ACTIVITIES AND QUIZZES\\OOP FINAL PROJECT\\WinFormsApp1\\WinFormsApp1\\Database1.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();

            dataTable = new DataTable();

            DGBookBorrower.AutoGenerateColumns = true;

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminForm adminform = new adminForm();

            adminform.Show();
            this.Hide();
        }

        private void BookBorrower_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string selectQuery1 = "SELECT * FROM logInForm";
                dataAdapter.SelectCommand = new SqlCommand(selectQuery1, connection);

                dataTable.Clear();
                dataAdapter.Fill(dataTable);

                DGBookBorrower.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void SearchData(string keyword)
        {
            try
            {
                connection.Open();

                string selectQuery1 = $"SELECT * FROM logInForm WHERE Username LIKE '%{keyword}%'";
                dataAdapter.SelectCommand = new SqlCommand(selectQuery1, connection);
                DataTable dataTable1 = new DataTable();
                dataAdapter.Fill(dataTable1);

                DGBookBorrower.DataSource = dataTable1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBookBorrowerSearch_Click(object sender, EventArgs e)
        {
            SearchData(txtBookBorrower.Text);
        }
    }
}
