﻿using System;
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
    public partial class BookReserveTeacher : Form
    {

        private string username;
        private string status;
        private string bookStatus;

        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public BookReserveTeacher(string username, string status, string bookStatus)
        {
            InitializeComponent();

            this.username = username;
            this.status = status;
            this.bookStatus = bookStatus;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2ND YEAR 1ST SEM\\Objected Oriented Programming\\FINAL TERM\\ACTIVITIES AND QUIZZES\\OOP FINAL PROJECT\\WinFormsApp1\\WinFormsApp1\\Database1.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();

            dataTable = new DataTable();

            DGTeacherReserve.AutoGenerateColumns = true;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            libraryMainForm libraryMain = new libraryMainForm(username, status, bookStatus);
            libraryMain.Show();

            this.Hide();
        }

        private void BookReserveTeacher_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string selectQuery1 = "SELECT * FROM TeacherTabelReserved";
                dataAdapter.SelectCommand = new SqlCommand(selectQuery1, connection);

                dataTable.Clear();
                dataAdapter.Fill(dataTable);

                DGTeacherReserve.DataSource = dataTable;

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

                string selectQuery1 = $"SELECT * FROM TeacherTabelReserved WHERE TeacherName LIKE '%{keyword}%'";
                dataAdapter.SelectCommand = new SqlCommand(selectQuery1, connection);
                DataTable dataTable1 = new DataTable();
                dataAdapter.Fill(dataTable1);

                DGTeacherReserve.DataSource = dataTable1;


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

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SearchData(txtTeacherReserveSearch.Text);
        }
    }
}
