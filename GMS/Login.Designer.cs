namespace GMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTLogin = new System.Windows.Forms.Button();
            this.BTRegister = new System.Windows.Forms.Button();
            this.BTForgotPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBUsername
            // 
            this.TBUsername.BackColor = System.Drawing.Color.Linen;
            this.TBUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUsername.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsername.ForeColor = System.Drawing.Color.Black;
            this.TBUsername.Location = new System.Drawing.Point(44, 154);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(185, 24);
            this.TBUsername.TabIndex = 2;
            this.TBUsername.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.Linen;
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.ForeColor = System.Drawing.Color.Black;
            this.TBPassword.Location = new System.Drawing.Point(44, 210);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(185, 24);
            this.TBPassword.TabIndex = 3;
            // 
            // BTLogin
            // 
            this.BTLogin.BackColor = System.Drawing.Color.SandyBrown;
            this.BTLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTLogin.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogin.Location = new System.Drawing.Point(43, 315);
            this.BTLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.Size = new System.Drawing.Size(186, 38);
            this.BTLogin.TabIndex = 4;
            this.BTLogin.Text = "Log In";
            this.BTLogin.UseVisualStyleBackColor = false;
            this.BTLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BTRegister
            // 
            this.BTRegister.BackColor = System.Drawing.Color.NavajoWhite;
            this.BTRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTRegister.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegister.Location = new System.Drawing.Point(43, 378);
            this.BTRegister.Margin = new System.Windows.Forms.Padding(2);
            this.BTRegister.Name = "BTRegister";
            this.BTRegister.Size = new System.Drawing.Size(186, 38);
            this.BTRegister.TabIndex = 6;
            this.BTRegister.Text = "Sign Up";
            this.BTRegister.UseVisualStyleBackColor = false;
            this.BTRegister.Click += new System.EventHandler(this.BTRegister_Click);
            // 
            // BTForgotPass
            // 
            this.BTForgotPass.BackColor = System.Drawing.Color.NavajoWhite;
            this.BTForgotPass.FlatAppearance.BorderSize = 0;
            this.BTForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTForgotPass.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTForgotPass.Location = new System.Drawing.Point(124, 233);
            this.BTForgotPass.Margin = new System.Windows.Forms.Padding(2);
            this.BTForgotPass.Name = "BTForgotPass";
            this.BTForgotPass.Size = new System.Drawing.Size(119, 24);
            this.BTForgotPass.TabIndex = 7;
            this.BTForgotPass.Text = "Forgot Password?";
            this.BTForgotPass.UseVisualStyleBackColor = false;
            this.BTForgotPass.Click += new System.EventHandler(this.BTForgotPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Don\'t have an account yet?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.NavajoWhite;
            this.label8.Font = new System.Drawing.Font("Ebrima", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 47);
            this.label8.TabIndex = 15;
            this.label8.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTLogin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BTRegister);
            this.panel1.Controls.Add(this.TBPassword);
            this.panel1.Controls.Add(this.TBUsername);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BTForgotPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(515, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 443);
            this.panel1.TabIndex = 16;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTLogin;
        private System.Windows.Forms.Button BTRegister;
        private System.Windows.Forms.Button BTForgotPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

