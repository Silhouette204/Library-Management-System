namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            txtEmail = new TextBox();
            mTxtPass = new MaskedTextBox();
            btnReg = new Button();
            btnShow = new CheckBox();
            label4 = new Label();
            btnExit = new Button();
            rbTeacher = new RadioButton();
            rbStudent = new RadioButton();
            label3 = new Label();
            btnSignIn = new Button();
            rbAdmin = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(166, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // mTxtPass
            // 
            mTxtPass.Location = new Point(166, 185);
            mTxtPass.Name = "mTxtPass";
            mTxtPass.Size = new Size(216, 23);
            mTxtPass.TabIndex = 7;
            mTxtPass.UseSystemPasswordChar = true;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.Orange;
            btnReg.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReg.Location = new Point(89, 300);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(97, 43);
            btnReg.TabIndex = 8;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // btnShow
            // 
            btnShow.AutoSize = true;
            btnShow.BackColor = Color.SeaShell;
            btnShow.Location = new Point(166, 214);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(108, 19);
            btnShow.TabIndex = 9;
            btnShow.Text = "Show Password";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.CheckedChanged += btnShow_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaShell;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 188);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 10;
            label4.Text = "Password:";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Orange;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(12, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(69, 34);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // rbTeacher
            // 
            rbTeacher.AutoSize = true;
            rbTeacher.BackColor = Color.SeaShell;
            rbTeacher.Location = new Point(239, 248);
            rbTeacher.Name = "rbTeacher";
            rbTeacher.Size = new Size(65, 19);
            rbTeacher.TabIndex = 15;
            rbTeacher.TabStop = true;
            rbTeacher.Text = "Teacher";
            rbTeacher.UseVisualStyleBackColor = false;
            rbTeacher.CheckedChanged += rbTeacher_CheckedChanged;
            // 
            // rbStudent
            // 
            rbStudent.AutoSize = true;
            rbStudent.BackColor = Color.SeaShell;
            rbStudent.Location = new Point(166, 248);
            rbStudent.Name = "rbStudent";
            rbStudent.Size = new Size(66, 19);
            rbStudent.TabIndex = 14;
            rbStudent.TabStop = true;
            rbStudent.Text = "Student";
            rbStudent.UseVisualStyleBackColor = false;
            rbStudent.CheckedChanged += rbStudent_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 250);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 16;
            label3.Text = "Status:";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Orange;
            btnSignIn.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.Location = new Point(255, 300);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(97, 43);
            btnSignIn.TabIndex = 17;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.BackColor = Color.SeaShell;
            rbAdmin.Location = new Point(310, 248);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(61, 19);
            rbAdmin.TabIndex = 18;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 66);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(39, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 66);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(130, 32);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 21;
            label5.Text = "Library";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(133, 59);
            label6.Name = "label6";
            label6.Size = new Size(259, 25);
            label6.TabIndex = 22;
            label6.Text = "Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(420, 404);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rbAdmin);
            Controls.Add(btnSignIn);
            Controls.Add(label3);
            Controls.Add(rbTeacher);
            Controls.Add(rbStudent);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(btnShow);
            Controls.Add(btnReg);
            Controls.Add(mTxtPass);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal TextBox txtEmail;
        private Label label2;
        private MaskedTextBox mTxtPass;
        private Button btnReg;
        private CheckBox btnShow;
        private Label label4;
        private Button btnExit;
        private RadioButton rbTeacher;
        private RadioButton rbStudent;
        private Label label3;
        private Button btnSignIn;
        private RadioButton rbAdmin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
    }
}