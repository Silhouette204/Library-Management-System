namespace WinFormsApp1
{
    partial class AdminReserveList
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
            DGTeacherReserve = new DataGridView();
            btnReserveBack = new Button();
            btnSearchReserve = new Button();
            txtStudentTeacherReserve = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGStudentReserve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGTeacherReserve).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 0;
            label1.Text = "Reserve List";
            // 
            // DGStudentReserve
            // 
            DGStudentReserve.BackgroundColor = SystemColors.Info;
            DGStudentReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGStudentReserve.Location = new Point(23, 141);
            DGStudentReserve.Name = "DGStudentReserve";
            DGStudentReserve.RowTemplate.Height = 25;
            DGStudentReserve.Size = new Size(381, 317);
            DGStudentReserve.TabIndex = 1;
            // 
            // DGTeacherReserve
            // 
            DGTeacherReserve.BackgroundColor = SystemColors.Info;
            DGTeacherReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTeacherReserve.Location = new Point(410, 141);
            DGTeacherReserve.Name = "DGTeacherReserve";
            DGTeacherReserve.RowTemplate.Height = 25;
            DGTeacherReserve.Size = new Size(381, 317);
            DGTeacherReserve.TabIndex = 2;
            // 
            // btnReserveBack
            // 
            btnReserveBack.BackColor = Color.OrangeRed;
            btnReserveBack.Location = new Point(716, 470);
            btnReserveBack.Name = "btnReserveBack";
            btnReserveBack.Size = new Size(75, 32);
            btnReserveBack.TabIndex = 3;
            btnReserveBack.Text = "Back";
            btnReserveBack.UseVisualStyleBackColor = false;
            btnReserveBack.Click += btnReserveBack_Click;
            // 
            // btnSearchReserve
            // 
            btnSearchReserve.BackColor = SystemColors.Highlight;
            btnSearchReserve.Location = new Point(429, 38);
            btnSearchReserve.Name = "btnSearchReserve";
            btnSearchReserve.Size = new Size(75, 32);
            btnSearchReserve.TabIndex = 4;
            btnSearchReserve.Text = "Search";
            btnSearchReserve.UseVisualStyleBackColor = false;
            btnSearchReserve.Click += btnSearchReserve_Click;
            // 
            // txtStudentTeacherReserve
            // 
            txtStudentTeacherReserve.Location = new Point(524, 38);
            txtStudentTeacherReserve.Multiline = true;
            txtStudentTeacherReserve.Name = "txtStudentTeacherReserve";
            txtStudentTeacherReserve.Size = new Size(267, 32);
            txtStudentTeacherReserve.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 90);
            label2.Name = "label2";
            label2.Size = new Size(117, 37);
            label2.TabIndex = 6;
            label2.Text = "Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(559, 90);
            label3.Name = "label3";
            label3.Size = new Size(116, 37);
            label3.TabIndex = 7;
            label3.Text = "Teacher";
            // 
            // AdminReserveList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(813, 514);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStudentTeacherReserve);
            Controls.Add(btnSearchReserve);
            Controls.Add(btnReserveBack);
            Controls.Add(DGTeacherReserve);
            Controls.Add(DGStudentReserve);
            Controls.Add(label1);
            Name = "AdminReserveList";
            Text = "AdminReserveList";
            Load += AdminReserveList_Load;
            ((System.ComponentModel.ISupportInitialize)DGStudentReserve).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGTeacherReserve).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGStudentReserve;
        private DataGridView DGTeacherReserve;
        private Button btnReserveBack;
        private Button btnSearchReserve;
        private TextBox txtStudentTeacherReserve;
        private Label label2;
        private Label label3;
    }
}