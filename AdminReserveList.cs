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
    public partial class AdminReserveList : Form
    {

        private SqlConnection connection;
        private SqlDataAdapter dataAdapter1, dataAdapter2;
        private DataTable dataTable1, dataTable2;
        public AdminReserveList()
        {
            InitializeComponent();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2ND YEAR 1ST SEM\\Objected Oriented Programming\\FINAL TERM\\ACTIVITIES AND QUIZZES\\OOP FINAL PROJECT\\WinFormsApp1\\WinFormsApp1\\Database1.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            dataAdapter1 = new SqlDataAdapter();
            dataAdapter2 = new SqlDataAdapter();

            dataTable1 = new DataTable();
            dataTable2 = new DataTable();

            DGStudentReserve.AutoGenerateColumns = true;

            DGTeacherReserve.AutoGenerateColumns = true;

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnReserveBack_Click(object sender, EventArgs e)
        {
            adminForm adminform = new adminForm();
            adminform.Show();

            this.Hide();
        }

        public void BorrowerListData()
        {
            try
            {
                connection.Open();

                string selectQuery1 = "SELECT * FROM StudentTableReserved";
                dataAdapter1.SelectCommand = new SqlCommand(selectQuery1, connection);

                dataTable1.Clear();
                dataAdapter1.Fill(dataTable1);

                DGStudentReserve.DataSource = dataTable1;

                string selectQuery2 = "SELECT * FROM TeacherTabelReserved";
                dataAdapter2.SelectCommand = new SqlCommand(selectQuery2, connection);

                dataTable2.Clear();
                dataAdapter2.Fill(dataTable2);

                DGTeacherReserve.DataSource = dataTable2;
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

        public void ReserveListData()
        {
            try
            {
                connection.Open();

                string selectQuery1 = "SELECT * FROM StudentTableReserved";
                dataAdapter1.SelectCommand = new SqlCommand(selectQuery1, connection);

                dataTable1.Clear();
                dataAdapter1.Fill(dataTable1);

                DGStudentReserve.DataSource = dataTable1;

                string selectQuery2 = "SELECT * FROM TeacherTabelReserved";
                dataAdapter2.SelectCommand = new SqlCommand(selectQuery2, connection);

                dataTable2.Clear();
                dataAdapter2.Fill(dataTable2);

                DGTeacherReserve.DataSource = dataTable2;
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

                string selectQuery1 = $"SELECT * FROM StudentTable WHERE StudentName LIKE '%{keyword}%'";
                dataAdapter1.SelectCommand = new SqlCommand(selectQuery1, connection);
                DataTable dataTable1 = new DataTable();
                dataAdapter1.Fill(dataTable1);

                DGStudentReserve.DataSource = dataTable1;

                string selectQuery2 = $"SELECT * FROM TeacherTable WHERE TeacherName LIKE '%{keyword}%'";
                dataAdapter2.SelectCommand = new SqlCommand(selectQuery2, connection);
                DataTable dataTable2 = new DataTable();
                dataAdapter2.Fill(dataTable2);

                DGTeacherReserve.DataSource = dataTable2;

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

        private void AdminReserveList_Load(object sender, EventArgs e)
        {
            ReserveListData();
        }

        private void btnSearchReserve_Click(object sender, EventArgs e)
        {
            SearchData(txtStudentTeacherReserve.Text);
        }
    }
}
