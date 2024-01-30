namespace WinFormsApp1
{
    partial class StudentForm
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
            label3 = new Label();
            label4 = new Label();
            btnExit = new Button();
            btnSubmit = new Button();
            txtStudID = new TextBox();
            txtStudYr = new TextBox();
            txtStudSec = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 36);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 173);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Section";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 133);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Year Level";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(49, 226);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(218, 226);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 40);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button2_Click;
            // 
            // txtStudID
            // 
            txtStudID.Location = new Point(147, 87);
            txtStudID.Name = "txtStudID";
            txtStudID.Size = new Size(146, 23);
            txtStudID.TabIndex = 6;
            // 
            // txtStudYr
            // 
            txtStudYr.Location = new Point(147, 130);
            txtStudYr.Name = "txtStudYr";
            txtStudYr.Size = new Size(146, 23);
            txtStudYr.TabIndex = 7;
            // 
            // txtStudSec
            // 
            txtStudSec.Location = new Point(147, 170);
            txtStudSec.Name = "txtStudSec";
            txtStudSec.Size = new Size(146, 23);
            txtStudSec.TabIndex = 8;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 305);
            Controls.Add(txtStudSec);
            Controls.Add(txtStudYr);
            Controls.Add(txtStudID);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnExit;
        private Button btnSubmit;
        private TextBox txtStudID;
        private TextBox txtStudYr;
        private TextBox txtStudSec;
    }
}