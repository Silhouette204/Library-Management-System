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
    public partial class BookReturn : Form
    {
        private string username;
        private string status;
        private string bookStatus;
        public BookReturn(string username, string status, string bookStatus)
        {
            InitializeComponent();
            this.username = username;
            this.status = status;
            this.bookStatus = bookStatus;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            libraryMainForm libraryMain = new libraryMainForm(username, status, bookStatus);
            libraryMain.Show();

            this.Hide();
        }

       
    }
}
