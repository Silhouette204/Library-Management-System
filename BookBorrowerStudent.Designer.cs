namespace WinFormsApp1
{
    partial class BookBorrowerStudent
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
            DGStudentBorrower = new DataGridView();
            btnBack = new Button();
            btnSearch = new Button();
            txtStudentBorrower = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGStudentBorrower).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 0;
            label1.Text = "BookBorrower";
            // 
            // DGStudentBorrower
            // 
            DGStudentBorrower.BackgroundColor = SystemColors.Info;
            DGStudentBorrower.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGStudentBorrower.Location = new Point(44, 68);
            DGStudentBorrower.Name = "DGStudentBorrower";
            DGStudentBorrower.RowTemplate.Height = 25;
            DGStudentBorrower.Size = new Size(528, 286);
            DGStudentBorrower.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OrangeRed;
            btnBack.Location = new Point(528, 364);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 32);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Location = new Point(303, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtStudentBorrower
            // 
            txtStudentBorrower.Location = new Point(387, 36);
            txtStudentBorrower.Name = "txtStudentBorrower";
            txtStudentBorrower.Size = new Size(185, 23);
            txtStudentBorrower.TabIndex = 4;
            // 
            // BookBorrowerStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(615, 408);
            Controls.Add(txtStudentBorrower);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Controls.Add(DGStudentBorrower);
            Controls.Add(label1);
            Name = "BookBorrowerStudent";
            Text = "BookBorrowerStudent";
            Load += BookBorrowerStudent_Load;
            ((System.ComponentModel.ISupportInitialize)DGStudentBorrower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGStudentBorrower;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtStudentBorrower;
    }
}