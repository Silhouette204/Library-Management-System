namespace WinFormsApp1
{
    partial class BookBorrowerTeacher
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
            label1 = new Label();
            GDBookBorrowerTeacher = new DataGridView();
            btnSearch = new Button();
            btnBack = new Button();
            txtSearchBorrowerTeacher = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GDBookBorrowerTeacher).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 0;
            label1.Text = "BookBorrower";
            // 
            // GDBookBorrowerTeacher
            // 
            GDBookBorrowerTeacher.BackgroundColor = SystemColors.Info;
            GDBookBorrowerTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GDBookBorrowerTeacher.Location = new Point(34, 57);
            GDBookBorrowerTeacher.Name = "GDBookBorrowerTeacher";
            GDBookBorrowerTeacher.RowTemplate.Height = 25;
            GDBookBorrowerTeacher.Size = new Size(575, 312);
            GDBookBorrowerTeacher.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Location = new Point(339, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OrangeRed;
            btnBack.Location = new Point(563, 377);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 34);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtSearchBorrowerTeacher
            // 
            txtSearchBorrowerTeacher.Location = new Point(420, 25);
            txtSearchBorrowerTeacher.Name = "txtSearchBorrowerTeacher";
            txtSearchBorrowerTeacher.Size = new Size(189, 23);
            txtSearchBorrowerTeacher.TabIndex = 4;
            // 
            // BookBorrowerTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(650, 423);
            Controls.Add(txtSearchBorrowerTeacher);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(GDBookBorrowerTeacher);
            Controls.Add(label1);
            Name = "BookBorrowerTeacher";
            Text = "BookBorrowerTeacher";
            Load += BookBorrowerTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)GDBookBorrowerTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView GDBookBorrowerTeacher;
        private Button btnSearch;
        private Button btnBack;
        private TextBox txtSearchBorrowerTeacher;
    }
}