namespace GMS
{
    partial class EditProfile
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
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.TBPhoneNo = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.BTCancel = new System.Windows.Forms.Button();
            this.BTConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBRole = new System.Windows.Forms.TextBox();
            this.TBSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.Location = new System.Drawing.Point(240, 176);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(48, 17);
            this.RBMale.TabIndex = 45;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = true;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.Location = new System.Drawing.Point(155, 176);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(59, 17);
            this.RBFemale.TabIndex = 44;
            this.RBFemale.TabStop = true;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = true;
            // 
            // TBPhoneNo
            // 
            this.TBPhoneNo.Location = new System.Drawing.Point(140, 199);
            this.TBPhoneNo.Name = "TBPhoneNo";
            this.TBPhoneNo.Size = new System.Drawing.Size(236, 20);
            this.TBPhoneNo.TabIndex = 41;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(140, 145);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(470, 20);
            this.TBEmail.TabIndex = 38;
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(140, 119);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(470, 20);
            this.TBUsername.TabIndex = 37;
            this.TBUsername.TextChanged += new System.EventHandler(this.TBUsername_TextChanged);
            // 
            // BTCancel
            // 
            this.BTCancel.Location = new System.Drawing.Point(419, 365);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(112, 23);
            this.BTCancel.TabIndex = 36;
            this.BTCancel.Text = "Back";
            this.BTCancel.UseVisualStyleBackColor = true;
            this.BTCancel.Click += new System.EventHandler(this.BTCancel_Click);
            // 
            // BTConfirm
            // 
            this.BTConfirm.Location = new System.Drawing.Point(301, 365);
            this.BTConfirm.Name = "BTConfirm";
            this.BTConfirm.Size = new System.Drawing.Size(112, 23);
            this.BTConfirm.TabIndex = 35;
            this.BTConfirm.Text = "Confirm Changes";
            this.BTConfirm.UseVisualStyleBackColor = true;
            this.BTConfirm.Click += new System.EventHandler(this.BTConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Email: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Edit Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBRole
            // 
            this.TBRole.Location = new System.Drawing.Point(140, 226);
            this.TBRole.Name = "TBRole";
            this.TBRole.ReadOnly = true;
            this.TBRole.Size = new System.Drawing.Size(236, 20);
            this.TBRole.TabIndex = 48;
            // 
            // TBSecurityAnswer
            // 
            this.TBSecurityAnswer.Location = new System.Drawing.Point(140, 252);
            this.TBSecurityAnswer.Name = "TBSecurityAnswer";
            this.TBSecurityAnswer.ReadOnly = true;
            this.TBSecurityAnswer.Size = new System.Drawing.Size(236, 20);
            this.TBSecurityAnswer.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Security Answer:";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBSecurityAnswer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBRole);
            this.Controls.Add(this.RBMale);
            this.Controls.Add(this.RBFemale);
            this.Controls.Add(this.TBPhoneNo);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.BTCancel);
            this.Controls.Add(this.BTConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RBMale;
        private System.Windows.Forms.RadioButton RBFemale;
        private System.Windows.Forms.TextBox TBPhoneNo;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Button BTCancel;
        private System.Windows.Forms.Button BTConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBRole;
        private System.Windows.Forms.TextBox TBSecurityAnswer;
        private System.Windows.Forms.Label label7;
    }
}