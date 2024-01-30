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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminBorrowerList borrowerlist = new AdminBorrowerList();
            borrowerlist.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminBookBorrower bookborrower = new AdminBookBorrower();
            bookborrower.Show();

            this.Hide();


        }

        private void btnBookReservation_Click(object sender, EventArgs e)
        {
            AdminReserveList adminReserveList = new AdminReserveList();
            adminReserveList.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminBookReturn3 bookreturn = new adminBookReturn3();
            bookreturn.Show();

            this.Hide();
        }
    }
}
