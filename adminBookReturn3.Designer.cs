namespace WinFormsApp1
{
    partial class adminBookReturn3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            btnBack = new Button();
            txtAdminSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(12, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(239, 32);
            lbl1.TabIndex = 0;
            lbl1.Text = "Admin Book Return";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(507, 257);
            dataGridView1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Location = new Point(269, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OrangeRed;
            btnBack.Location = new Point(517, 347);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 33);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtAdminSearch
            // 
            txtAdminSearch.Location = new Point(350, 54);
            txtAdminSearch.Name = "txtAdminSearch";
            txtAdminSearch.Size = new Size(207, 23);
            txtAdminSearch.TabIndex = 4;
            // 
            // adminBookReturn3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(604, 390);
            Controls.Add(txtAdminSearch);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(lbl1);
            Name = "adminBookReturn3";
            Text = "adminBookReturn3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Button btnBack;
        private TextBox txtAdminSearch;
    }
}