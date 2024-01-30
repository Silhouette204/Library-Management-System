namespace WinFormsApp1
{
    partial class libraryMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libraryMainForm));
            button1 = new Button();
            libraryBookBorrower = new Button();
            button6 = new Button();
            libraryBookReservation = new Button();
            btnLogOut = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            lblStatus = new Label();
            pbProfile = new PictureBox();
            button10 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(51, 159);
            button1.Name = "button1";
            button1.Size = new Size(149, 117);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // libraryBookBorrower
            // 
            libraryBookBorrower.BackColor = Color.DarkOrange;
            libraryBookBorrower.BackgroundImage = (Image)resources.GetObject("libraryBookBorrower.BackgroundImage");
            libraryBookBorrower.BackgroundImageLayout = ImageLayout.Zoom;
            libraryBookBorrower.FlatStyle = FlatStyle.Popup;
            libraryBookBorrower.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            libraryBookBorrower.Location = new Point(236, 159);
            libraryBookBorrower.Name = "libraryBookBorrower";
            libraryBookBorrower.Size = new Size(150, 117);
            libraryBookBorrower.TabIndex = 9;
            libraryBookBorrower.UseVisualStyleBackColor = false;
            libraryBookBorrower.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkOrange;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            button6.Location = new Point(415, 159);
            button6.Name = "button6";
            button6.Size = new Size(150, 117);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // libraryBookReservation
            // 
            libraryBookReservation.BackColor = Color.DarkOrange;
            libraryBookReservation.BackgroundImage = (Image)resources.GetObject("libraryBookReservation.BackgroundImage");
            libraryBookReservation.BackgroundImageLayout = ImageLayout.Zoom;
            libraryBookReservation.FlatStyle = FlatStyle.Popup;
            libraryBookReservation.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            libraryBookReservation.Location = new Point(51, 323);
            libraryBookReservation.Name = "libraryBookReservation";
            libraryBookReservation.Size = new Size(150, 117);
            libraryBookReservation.TabIndex = 13;
            libraryBookReservation.UseVisualStyleBackColor = false;
            libraryBookReservation.Click += libraryBookReservation_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.PaleTurquoise;
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogOut.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnLogOut.Location = new Point(236, 323);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(150, 117);
            btnLogOut.TabIndex = 14;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(122, 76);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 16;
            label1.Text = "Management Sytem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(122, 43);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 17;
            label2.Text = "Library";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PapayaWhip;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(80, 279);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 18;
            label3.Text = "Book List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PapayaWhip;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(236, 279);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 19;
            label4.Text = "Book Borrower ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PapayaWhip;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(415, 279);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 20;
            label5.Text = "Book Returning";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.PapayaWhip;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(41, 443);
            label6.Name = "label6";
            label6.Size = new Size(169, 25);
            label6.TabIndex = 21;
            label6.Text = "Book Reservation";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PapayaWhip;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(265, 443);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 22;
            label7.Text = "Log out";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(41, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 66);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 66);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(330, 43);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 28;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(351, 79);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "Status";
            // 
            // pbProfile
            // 
            pbProfile.Image = (Image)resources.GetObject("pbProfile.Image");
            pbProfile.Location = new Point(465, 28);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(109, 107);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 30;
            pbProfile.TabStop = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Crimson;
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Location = new Point(415, 323);
            button10.Name = "button10";
            button10.Size = new Size(150, 117);
            button10.TabIndex = 31;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PapayaWhip;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(465, 443);
            label8.Name = "label8";
            label8.Size = new Size(45, 25);
            label8.TabIndex = 32;
            label8.Text = "Exit";
            // 
            // libraryMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(617, 502);
            Controls.Add(label8);
            Controls.Add(button10);
            Controls.Add(pbProfile);
            Controls.Add(lblStatus);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogOut);
            Controls.Add(libraryBookReservation);
            Controls.Add(button6);
            Controls.Add(libraryBookBorrower);
            Controls.Add(button1);
            Name = "libraryMainForm";
            Text = "libraryMainForm";
            Load += libraryMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button libraryBookBorrower;
        private Button button6;
        private Button libraryBookReservation;
        private Button btnLogOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Label lblStatus;
        private PictureBox pbProfile;
        private PictureBox pictureBoxProfile;
        private Button button10;
        private Label label8;
    }
}