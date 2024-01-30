namespace WinFormsApp1
{
    partial class BookReserveTeacher
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
            DGTeacherReserve = new DataGridView();
            btnSearch = new Button();
            btnBack = new Button();
            txtTeacherReserveSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGTeacherReserve).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 13);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 0;
            label1.Text = "Book Reserve";
            // 
            // DGTeacherReserve
            // 
            DGTeacherReserve.BackgroundColor = SystemColors.Info;
            DGTeacherReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTeacherReserve.Location = new Point(26, 61);
            DGTeacherReserve.Name = "DGTeacherReserve";
            DGTeacherReserve.RowTemplate.Height = 25;
            DGTeacherReserve.Size = new Size(505, 286);
            DGTeacherReserve.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Location = new Point(264, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OrangeRed;
            btnBack.Location = new Point(476, 353);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 36);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtTeacherReserveSearch
            // 
            txtTeacherReserveSearch.Location = new Point(345, 28);
            txtTeacherReserveSearch.Name = "txtTeacherReserveSearch";
            txtTeacherReserveSearch.Size = new Size(186, 23);
            txtTeacherReserveSearch.TabIndex = 4;
            // 
            // BookReserveTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(563, 399);
            Controls.Add(txtTeacherReserveSearch);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(DGTeacherReserve);
            Controls.Add(label1);
            Name = "BookReserveTeacher";
            Text = "BookReserveTeacher";
            Load += BookReserveTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)DGTeacherReserve).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGTeacherReserve;
        private Button btnSearch;
        private Button btnBack;
        private TextBox txtTeacherReserveSearch;
    }
}