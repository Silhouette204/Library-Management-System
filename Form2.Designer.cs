namespace WinFormsApp1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCreateUser = new TextBox();
            maskTxtNewPass = new MaskedTextBox();
            cbShow = new CheckBox();
            btnSignIn = new Button();
            label4 = new Label();
            btnReadySU = new Button();
            rbCreateStudent = new RadioButton();
            rbCreateTeacher = new RadioButton();
            label5 = new Label();
            rbSUAdmin = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(171, 41);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(50, 128);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 1;
            label2.Text = "Create Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(50, 191);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 2;
            label3.Text = "Create Password:";
            // 
            // txtCreateUser
            // 
            txtCreateUser.Location = new Point(186, 127);
            txtCreateUser.Name = "txtCreateUser";
            txtCreateUser.Size = new Size(185, 23);
            txtCreateUser.TabIndex = 3;
            // 
            // maskTxtNewPass
            // 
            maskTxtNewPass.Location = new Point(186, 185);
            maskTxtNewPass.Name = "maskTxtNewPass";
            maskTxtNewPass.Size = new Size(185, 23);
            maskTxtNewPass.TabIndex = 4;
            maskTxtNewPass.UseSystemPasswordChar = true;
            // 
            // cbShow
            // 
            cbShow.AutoSize = true;
            cbShow.BackColor = SystemColors.ButtonHighlight;
            cbShow.ForeColor = Color.DimGray;
            cbShow.Location = new Point(186, 214);
            cbShow.Name = "cbShow";
            cbShow.Size = new Size(108, 19);
            cbShow.TabIndex = 5;
            cbShow.Text = "Show Password";
            cbShow.UseVisualStyleBackColor = false;
            cbShow.CheckedChanged += cbShow_CheckedChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.ControlDark;
            btnSignIn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.ForeColor = SystemColors.ActiveCaptionText;
            btnSignIn.Location = new Point(50, 326);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(93, 40);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(50, 299);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 7;
            label4.Text = "Already have an account?";
            // 
            // btnReadySU
            // 
            btnReadySU.BackColor = SystemColors.ControlDark;
            btnReadySU.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReadySU.ForeColor = SystemColors.ActiveCaptionText;
            btnReadySU.Location = new Point(259, 326);
            btnReadySU.Name = "btnReadySU";
            btnReadySU.Size = new Size(93, 40);
            btnReadySU.TabIndex = 8;
            btnReadySU.Text = "Sign Up";
            btnReadySU.UseVisualStyleBackColor = false;
            btnReadySU.Click += btnReadySU_Click;
            // 
            // rbCreateStudent
            // 
            rbCreateStudent.AutoSize = true;
            rbCreateStudent.BackColor = SystemColors.ButtonHighlight;
            rbCreateStudent.ForeColor = Color.DimGray;
            rbCreateStudent.Location = new Point(171, 257);
            rbCreateStudent.Name = "rbCreateStudent";
            rbCreateStudent.Size = new Size(66, 19);
            rbCreateStudent.TabIndex = 9;
            rbCreateStudent.TabStop = true;
            rbCreateStudent.Text = "Student";
            rbCreateStudent.UseVisualStyleBackColor = false;
            rbCreateStudent.CheckedChanged += rbCreateStudent_CheckedChanged;
            // 
            // rbCreateTeacher
            // 
            rbCreateTeacher.AutoSize = true;
            rbCreateTeacher.BackColor = SystemColors.ButtonHighlight;
            rbCreateTeacher.ForeColor = Color.DimGray;
            rbCreateTeacher.Location = new Point(243, 257);
            rbCreateTeacher.Name = "rbCreateTeacher";
            rbCreateTeacher.Size = new Size(65, 19);
            rbCreateTeacher.TabIndex = 10;
            rbCreateTeacher.TabStop = true;
            rbCreateTeacher.Text = "Teacher";
            rbCreateTeacher.UseVisualStyleBackColor = false;
            rbCreateTeacher.CheckedChanged += rbCreateTeacher_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(50, 259);
            label5.Name = "label5";
            label5.Size = new Size(93, 17);
            label5.TabIndex = 11;
            label5.Text = "Create Status:";
            // 
            // rbSUAdmin
            // 
            rbSUAdmin.AutoSize = true;
            rbSUAdmin.BackColor = SystemColors.ButtonHighlight;
            rbSUAdmin.ForeColor = SystemColors.WindowFrame;
            rbSUAdmin.Location = new Point(314, 257);
            rbSUAdmin.Name = "rbSUAdmin";
            rbSUAdmin.Size = new Size(61, 19);
            rbSUAdmin.TabIndex = 12;
            rbSUAdmin.TabStop = true;
            rbSUAdmin.Text = "Admin";
            rbSUAdmin.UseVisualStyleBackColor = false;
            rbSUAdmin.CheckedChanged += rbSUAdmin_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 98);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(410, 121);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(403, 404);
            Controls.Add(pictureBox1);
            Controls.Add(rbSUAdmin);
            Controls.Add(label5);
            Controls.Add(rbCreateTeacher);
            Controls.Add(rbCreateStudent);
            Controls.Add(btnReadySU);
            Controls.Add(label4);
            Controls.Add(btnSignIn);
            Controls.Add(cbShow);
            Controls.Add(maskTxtNewPass);
            Controls.Add(txtCreateUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Name = "SignUp";
            Text = "Form2";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCreateUser;
        private MaskedTextBox maskTxtNewPass;
        private CheckBox cbShow;
        private Button btnSignIn;
        private Label label4;
        private Button btnReadySU;
        private RadioButton rbCreateStudent;
        private RadioButton rbCreateTeacher;
        private Label label5;
        private RadioButton rbSUAdmin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}