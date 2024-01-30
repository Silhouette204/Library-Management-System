namespace WinFormsApp1
{
    partial class AdminBookBorrower
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
            button1 = new Button();
            txtBookBorrower = new TextBox();
            DGBookBorrower = new DataGridView();
            btnBookBorrowerSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)DGBookBorrower).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "BookBorrower";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(460, 354);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtBookBorrower
            // 
            txtBookBorrower.Location = new Point(363, 48);
            txtBookBorrower.Name = "txtBookBorrower";
            txtBookBorrower.Size = new Size(172, 23);
            txtBookBorrower.TabIndex = 4;
            // 
            // DGBookBorrower
            // 
            DGBookBorrower.BackgroundColor = SystemColors.ActiveCaption;
            DGBookBorrower.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGBookBorrower.Location = new Point(20, 78);
            DGBookBorrower.Name = "DGBookBorrower";
            DGBookBorrower.RowTemplate.Height = 25;
            DGBookBorrower.Size = new Size(515, 270);
            DGBookBorrower.TabIndex = 5;
            // 
            // btnBookBorrowerSearch
            // 
            btnBookBorrowerSearch.Location = new Point(282, 40);
            btnBookBorrowerSearch.Name = "btnBookBorrowerSearch";
            btnBookBorrowerSearch.Size = new Size(75, 32);
            btnBookBorrowerSearch.TabIndex = 6;
            btnBookBorrowerSearch.Text = "Search";
            btnBookBorrowerSearch.UseVisualStyleBackColor = true;
            btnBookBorrowerSearch.Click += btnBookBorrowerSearch_Click;
            // 
            // BookBorrower
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(556, 394);
            Controls.Add(btnBookBorrowerSearch);
            Controls.Add(DGBookBorrower);
            Controls.Add(txtBookBorrower);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "BookBorrower";
            Text = "BookBorrower";
            Load += BookBorrower_Load;
            ((System.ComponentModel.ISupportInitialize)DGBookBorrower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtBookBorrower;
        private DataGridView DGBookBorrower;
        private Button btnBookBorrowerSearch;
    }
}