namespace WinFormsApp1
{
    partial class AdminBorrowerList
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
            label2 = new Label();
            DGTeacher = new DataGridView();
            txtBorrowerSearch = new TextBox();
            btnSearchBorrower = new Button();
            backBtn = new Button();
            label3 = new Label();
            DGStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 0;
            label1.Text = "Borrower List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 75);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Student";
            // 
            // DGTeacher
            // 
            DGTeacher.BackgroundColor = SystemColors.Info;
            DGTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTeacher.Location = new Point(410, 98);
            DGTeacher.Name = "DGTeacher";
            DGTeacher.RowTemplate.Height = 25;
            DGTeacher.Size = new Size(366, 318);
            DGTeacher.TabIndex = 3;
            DGTeacher.CellContentClick += DGTeacher_CellContentClick;
            // 
            // txtBorrowerSearch
            // 
            txtBorrowerSearch.Location = new Point(619, 36);
            txtBorrowerSearch.Name = "txtBorrowerSearch";
            txtBorrowerSearch.Size = new Size(169, 23);
            txtBorrowerSearch.TabIndex = 5;
            txtBorrowerSearch.TextChanged += txtBorrowerSearch_TextChanged;
            // 
            // btnSearchBorrower
            // 
            btnSearchBorrower.BackColor = SystemColors.MenuHighlight;
            btnSearchBorrower.Location = new Point(510, 28);
            btnSearchBorrower.Name = "btnSearchBorrower";
            btnSearchBorrower.Size = new Size(91, 31);
            btnSearchBorrower.TabIndex = 6;
            btnSearchBorrower.Text = "Search";
            btnSearchBorrower.UseVisualStyleBackColor = false;
            btnSearchBorrower.Click += btnSearchBorrower_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Crimson;
            backBtn.Location = new Point(713, 422);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 7;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(568, 75);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 8;
            label3.Text = "Teacher";
            // 
            // DGStudent
            // 
            DGStudent.BackgroundColor = SystemColors.Info;
            DGStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGStudent.Location = new Point(27, 98);
            DGStudent.Name = "DGStudent";
            DGStudent.RowTemplate.Height = 25;
            DGStudent.Size = new Size(366, 318);
            DGStudent.TabIndex = 9;
            DGStudent.CellContentClick += DGStudent_CellContentClick;
            // 
            // BorrowerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(DGStudent);
            Controls.Add(label3);
            Controls.Add(backBtn);
            Controls.Add(btnSearchBorrower);
            Controls.Add(txtBorrowerSearch);
            Controls.Add(DGTeacher);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BorrowerList";
            Text = "BorrowerList";
            Load += BorrowerList_Load;
            ((System.ComponentModel.ISupportInitialize)DGTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView DGTeacher;
        private TextBox txtBorrowerSearch;
        private Button btnSearchBorrower;
        private Button backBtn;
        private Label label3;
        private DataGridView DGStudent;
    }
}