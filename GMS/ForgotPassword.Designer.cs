namespace GMS
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBSecAns = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBConfirmPass = new System.Windows.Forms.TextBox();
            this.BTConfirm = new System.Windows.Forms.Button();
            this.BTBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reset Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Security Answer:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TBUsername
            // 
            this.TBUsername.BackColor = System.Drawing.Color.Linen;
            this.TBUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUsername.Location = new System.Drawing.Point(145, 112);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(170, 20);
            this.TBUsername.TabIndex = 5;
            this.TBUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBSecAns
            // 
            this.TBSecAns.BackColor = System.Drawing.Color.Linen;
            this.TBSecAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSecAns.Location = new System.Drawing.Point(147, 156);
            this.TBSecAns.Name = "TBSecAns";
            this.TBSecAns.Size = new System.Drawing.Size(170, 20);
            this.TBSecAns.TabIndex = 6;
            this.TBSecAns.TextChanged += new System.EventHandler(this.TBSecAns_TextChanged);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.Linen;
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Location = new System.Drawing.Point(504, 111);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(170, 20);
            this.TBPassword.TabIndex = 7;
            this.TBPassword.TextChanged += new System.EventHandler(this.TBPassword_TextChanged);
            // 
            // TBConfirmPass
            // 
            this.TBConfirmPass.BackColor = System.Drawing.Color.Linen;
            this.TBConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBConfirmPass.Location = new System.Drawing.Point(504, 152);
            this.TBConfirmPass.Name = "TBConfirmPass";
            this.TBConfirmPass.PasswordChar = '*';
            this.TBConfirmPass.Size = new System.Drawing.Size(170, 20);
            this.TBConfirmPass.TabIndex = 8;
            this.TBConfirmPass.TextChanged += new System.EventHandler(this.TBConfirmPass_TextChanged);
            // 
            // BTConfirm
            // 
            this.BTConfirm.BackColor = System.Drawing.Color.SandyBrown;
            this.BTConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTConfirm.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTConfirm.Location = new System.Drawing.Point(169, 281);
            this.BTConfirm.Name = "BTConfirm";
            this.BTConfirm.Size = new System.Drawing.Size(200, 33);
            this.BTConfirm.TabIndex = 9;
            this.BTConfirm.Text = "Confirm Changes";
            this.BTConfirm.UseVisualStyleBackColor = false;
            this.BTConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTBack
            // 
            this.BTBack.BackColor = System.Drawing.Color.SandyBrown;
            this.BTBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBack.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBack.Location = new System.Drawing.Point(375, 281);
            this.BTBack.Name = "BTBack";
            this.BTBack.Size = new System.Drawing.Size(200, 33);
            this.BTBack.TabIndex = 10;
            this.BTBack.Text = "Back";
            this.BTBack.UseVisualStyleBackColor = false;
            this.BTBack.Click += new System.EventHandler(this.BTBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "What was your first pet?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(38, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 63);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BTBack);
            this.panel1.Controls.Add(this.BTConfirm);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBConfirmPass);
            this.panel1.Controls.Add(this.TBPassword);
            this.panel1.Controls.Add(this.TBUsername);
            this.panel1.Controls.Add(this.TBSecAns);
            this.panel1.Location = new System.Drawing.Point(38, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 332);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.NavajoWhite;
            this.label12.Font = new System.Drawing.Font("Ebrima", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Enter your details:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Font = new System.Drawing.Font("Ebrima", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Enter new pasword:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBSecAns;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBConfirmPass;
        private System.Windows.Forms.Button BTConfirm;
        private System.Windows.Forms.Button BTBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
    }
}