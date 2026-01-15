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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTRegister = new System.Windows.Forms.Button();
            this.BTForgotPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(480, 140);
            this.TBUsername.Margin = new System.Windows.Forms.Padding(2);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(203, 20);
            this.TBUsername.TabIndex = 2;
            this.TBUsername.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(480, 187);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(203, 20);
            this.TBPassword.TabIndex = 3;
            // 
            // BTLogin
            // 
            this.BTLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogin.Location = new System.Drawing.Point(375, 239);
            this.BTLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.Size = new System.Drawing.Size(149, 33);
            this.BTLogin.TabIndex = 4;
            this.BTLogin.Text = "Log In";
            this.BTLogin.UseVisualStyleBackColor = true;
            this.BTLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 231);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BTRegister
            // 
            this.BTRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegister.Location = new System.Drawing.Point(534, 239);
            this.BTRegister.Margin = new System.Windows.Forms.Padding(2);
            this.BTRegister.Name = "BTRegister";
            this.BTRegister.Size = new System.Drawing.Size(149, 33);
            this.BTRegister.TabIndex = 6;
            this.BTRegister.Text = "Register";
            this.BTRegister.UseVisualStyleBackColor = true;
            this.BTRegister.Click += new System.EventHandler(this.BTRegister_Click);
            // 
            // BTForgotPass
            // 
            this.BTForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTForgotPass.Location = new System.Drawing.Point(375, 286);
            this.BTForgotPass.Margin = new System.Windows.Forms.Padding(2);
            this.BTForgotPass.Name = "BTForgotPass";
            this.BTForgotPass.Size = new System.Drawing.Size(308, 33);
            this.BTForgotPass.TabIndex = 7;
            this.BTForgotPass.Text = "Forgot Password?";
            this.BTForgotPass.UseVisualStyleBackColor = true;
            this.BTForgotPass.Click += new System.EventHandler(this.BTForgotPass_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTForgotPass);
            this.Controls.Add(this.BTRegister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTRegister;
        private System.Windows.Forms.Button BTForgotPass;
    }
}

