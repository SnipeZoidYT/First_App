﻿namespace First_App
{
    partial class Registration
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
            button2 = new Button();
            textName = new TextBox();
            textPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textEmail = new TextBox();
            textAge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(261, 29);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // button1
            // 
            button1.Location = new Point(261, 324);
            button1.Name = "button1";
            button1.Size = new Size(132, 27);
            button1.TabIndex = 1;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 371);
            button2.Name = "button2";
            button2.Size = new Size(160, 29);
            button2.TabIndex = 2;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textName
            // 
            textName.Location = new Point(248, 107);
            textName.Name = "textName";
            textName.Size = new Size(160, 23);
            textName.TabIndex = 3;
            textName.TextChanged += textName_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(248, 284);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(160, 23);
            textPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 257);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 197);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 142);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Age:";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(248, 215);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(160, 23);
            textEmail.TabIndex = 9;
            // 
            // textAge
            // 
            textAge.Location = new Point(248, 160);
            textAge.Name = "textAge";
            textAge.Size = new Size(160, 23);
            textAge.TabIndex = 10;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 421);
            Controls.Add(textAge);
            Controls.Add(textEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textPassword);
            Controls.Add(textName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textName;
        private TextBox textPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textEmail;
        private TextBox textAge;
    }
}