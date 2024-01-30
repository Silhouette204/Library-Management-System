using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class adminBookReturn3 : Form
    {
        public adminBookReturn3()
        {
            InitializeComponent(); 
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminForm adminform = new adminForm();
            adminform.Show();

            this.Hide();
           
        }
    }
}
