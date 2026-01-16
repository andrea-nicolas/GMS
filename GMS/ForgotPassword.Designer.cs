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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reset Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Security Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password:";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(138, 163);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(234, 20);
            this.TBUsername.TabIndex = 5;
            this.TBUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBSecAns
            // 
            this.TBSecAns.Location = new System.Drawing.Point(138, 216);
            this.TBSecAns.Name = "TBSecAns";
            this.TBSecAns.Size = new System.Drawing.Size(234, 20);
            this.TBSecAns.TabIndex = 6;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(501, 162);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(234, 20);
            this.TBPassword.TabIndex = 7;
            // 
            // TBConfirmPass
            // 
            this.TBConfirmPass.Location = new System.Drawing.Point(501, 216);
            this.TBConfirmPass.Name = "TBConfirmPass";
            this.TBConfirmPass.Size = new System.Drawing.Size(234, 20);
            this.TBConfirmPass.TabIndex = 8;
            // 
            // BTConfirm
            // 
            this.BTConfirm.Location = new System.Drawing.Point(266, 275);
            this.BTConfirm.Name = "BTConfirm";
            this.BTConfirm.Size = new System.Drawing.Size(128, 23);
            this.BTConfirm.TabIndex = 9;
            this.BTConfirm.Text = "Confirm";
            this.BTConfirm.UseVisualStyleBackColor = true;
            this.BTConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTBack
            // 
            this.BTBack.Location = new System.Drawing.Point(400, 275);
            this.BTBack.Name = "BTBack";
            this.BTBack.Size = new System.Drawing.Size(128, 23);
            this.BTBack.TabIndex = 10;
            this.BTBack.Text = "Cancel";
            this.BTBack.UseVisualStyleBackColor = true;
            this.BTBack.Click += new System.EventHandler(this.BTBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "What was your first pet?";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTBack);
            this.Controls.Add(this.BTConfirm);
            this.Controls.Add(this.TBConfirmPass);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBSecAns);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}