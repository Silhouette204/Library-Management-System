namespace WinFormsApp1
{
    partial class BookReturn
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
            DGReturnBook = new DataGridView();
            btnSearch = new Button();
            btnReturnBook = new Button();
            btnBack = new Button();
            txtReturnBookSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGReturnBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 0;
            label1.Text = "Book Return";
            // 
            // DGReturnBook
            // 
            DGReturnBook.BackgroundColor = SystemColors.Info;
            DGReturnBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGReturnBook.Location = new Point(34, 108);
            DGReturnBook.Name = "DGReturnBook";
            DGReturnBook.RowTemplate.Height = 25;
            DGReturnBook.Size = new Size(530, 298);
            DGReturnBook.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.Location = new Point(278, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 36);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.Gold;
            btnReturnBook.Location = new Point(34, 67);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(75, 35);
            btnReturnBook.TabIndex = 3;
            btnReturnBook.Text = "Return";
            btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OrangeRed;
            btnBack.Location = new Point(508, 412);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 35);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtReturnBookSearch
            // 
            txtReturnBookSearch.Location = new Point(359, 74);
            txtReturnBookSearch.Name = "txtReturnBookSearch";
            txtReturnBookSearch.Size = new Size(205, 23);
            txtReturnBookSearch.TabIndex = 5;
            // 
            // BookReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(595, 456);
            Controls.Add(txtReturnBookSearch);
            Controls.Add(btnBack);
            Controls.Add(btnReturnBook);
            Controls.Add(btnSearch);
            Controls.Add(DGReturnBook);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "BookReturn";
            Text = "BookReturn";
            ((System.ComponentModel.ISupportInitialize)DGReturnBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGReturnBook;
        private Button btnSearch;
        private Button btnReturnBook;
        private Button btnBack;
        private TextBox txtReturnBookSearch;
    }
}