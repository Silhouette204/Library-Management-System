namespace WinFormsApp1
{
    partial class BookReserveStudent
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
            DGStudentReserve = new DataGridView();
            txtSearchStudentReserved = new TextBox();
            btnSearch = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)DGStudentReserve).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 0;
            label1.Text = "Book Reserve";
            // 
            // DGStudentReserve
            // 
            DGStudentReserve.BackgroundColor = SystemColors.Info;
            DGStudentReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGStudentReserve.Location = new Point(55, 56);
            DGStudentReserve.Name = "DGStudentReserve";
            DGStudentReserve.RowTemplate.Height = 25;
            DGStudentReserve.Size = new Size(496, 263);
            DGStudentReserve.TabIndex = 1;
            // 
            // txtSearchStudentReserved
            // 
            txtSearchStudentReserved.Location = new Point(425, 23);
            txtSearchStudentReserved.Name = "txtSearchStudentReserved";
            txtSearchStudentReserved.Size = new Size(153, 23);
            txtSearchStudentReserved.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Location = new Point(344, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OrangeRed;
            btnBack.ForeColor = SystemColors.ControlText;
            btnBack.Location = new Point(514, 325);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 32);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // BookReserveStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(601, 365);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchStudentReserved);
            Controls.Add(DGStudentReserve);
            Controls.Add(label1);
            Name = "BookReserveStudent";
            Text = "BookReserveStudent";
            Load += BookReserveStudent_Load;
            ((System.ComponentModel.ISupportInitialize)DGStudentReserve).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGStudentReserve;
        private TextBox txtSearchStudentReserved;
        private Button btnSearch;
        private Button btnBack;
    }
}