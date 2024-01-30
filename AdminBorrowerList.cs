using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace WinFormsApp1
{
    public partial class AdminBorrowerList : Form
    {

        private SqlConnection connection;
        private SqlDataAdapter dataAdapter1, dataAdapter2;
        private DataTable dataTable1, dataTable2;
        public AdminBorrowerList()
        {
            InitializeComponent();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2ND YEAR 1ST SEM\\Objected Oriented Programming\\FINAL TERM\\ACTIVITIES AND QUIZZES\\OOP FINAL PROJECT\\WinFormsApp1\\WinFormsApp1\\Database1.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            dataAdapter1 = new SqlDataAdapter();
            dataAdapter2 = new SqlDataAdapter();

            dataTable1 = new DataTable();
            dataTable2 = new DataTable();

            DGStudent.AutoGenerateColumns = true;

            DGTeacher.AutoGenerateColumns = true;

            this.StartPosition = FormStartPosition.CenterScreen;
        }




        private void backBtn_Click(object sender, EventArgs e)
        {
            adminForm adminForm = new adminForm();
            adminForm.Show();

            this.Hide();
        }

        private void btnSearchBorrower_Click(object sender, EventArgs e)
        {
            SearchData(txtBorrowerSearch.Text);

        }

        private void DGStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrowerList_Load(object sender, EventArgs e)
        {
            BorrowerListData();

        }

        private void DGTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void BorrowerListData()
        {
            try
            {
                connection.Open();

                string selectQuery1 = "SELECT * FROM StudentTable";
                dataAdapter1.SelectCommand = new SqlCommand(selectQuery1, connection);

                dataTable1.Clear();
                dataAdapter1.Fill(dataTable1);

                DGStudent.DataSource = dataTable1;

                string selectQuery2 = "SELECT * FROM TeacherTable";
                dataAdapter2.SelectCommand = new SqlCommand(selectQuery2, connection);

                dataTable2.Clear();
                dataAdapter2.Fill(dataTable2);

                DGTeacher.DataSource = dataTable2;
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

        private void txtBorrowerSearch_TextChanged(object sender, EventArgs e)
        {

        }

        public void SearchData(string keyword)
        {
            try
            {
                connection.Open();

                string selectQuery1 = $"SELECT * FROM StudentTable WHERE StudentName LIKE '%{keyword}%'";
                dataAdapter1.SelectCommand = new SqlCommand(selectQuery1, connection);
                DataTable dataTable1 = new DataTable();
                dataAdapter1.Fill(dataTable1);

                DGStudent.DataSource = dataTable1;

                string selectQuery2 = $"SELECT * FROM TeacherTable WHERE TeacherName LIKE '%{keyword}%'";
                dataAdapter2.SelectCommand = new SqlCommand(selectQuery2, connection);
                DataTable dataTable2 = new DataTable();
                dataAdapter2.Fill(dataTable2);

                DGTeacher.DataSource = dataTable2;

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
    }
}



