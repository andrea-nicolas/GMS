using System;

namespace GMS
{
    partial class AdminEmployeesCrud
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
            this.components = new System.ComponentModel.Container();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.usersDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gMSDataSet5 = new GMS.GMSDataSet5();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.gMSDataSet4 = new GMS.GMSDataSet4();
            this.cartsDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartsDBTableAdapter = new GMS.GMSDataSet4TableAdapters.cartsDBTableAdapter();
            this.usersDBTableAdapter = new GMS.GMSDataSet5TableAdapters.usersDBTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSecurityAns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartsDBBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUser
            // 
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUserId,
            this.dgvEmail,
            this.dgvGender,
            this.dgvPhoneNo,
            this.dgvPass,
            this.dgvUserName,
            this.dgvRole,
            this.dgvSecurityAns,
            this.dgvCounter,
            this.dgvAccStatus});
            this.dgvUser.DataSource = this.usersDBBindingSource;
            this.dgvUser.Location = new System.Drawing.Point(3, 3);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(416, 446);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            // 
            // usersDBBindingSource
            // 
            this.usersDBBindingSource.DataMember = "usersDB";
            this.usersDBBindingSource.DataSource = this.gMSDataSet5;
            // 
            // gMSDataSet5
            // 
            this.gMSDataSet5.DataSetName = "GMSDataSet5";
            this.gMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 345);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(697, 372);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Counter:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(516, 50);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(235, 22);
            this.txtUserName.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(516, 81);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(516, 149);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 22);
            this.txtPhone.TabIndex = 18;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(516, 178);
            this.txtRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(235, 22);
            this.txtRole.TabIndex = 19;
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(516, 212);
            this.txtCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(235, 22);
            this.txtCounter.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(516, 301);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 22);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "active",
            "inactive",
            "innactive",
            "pending",
            "rejected"});
            this.cmbStatus.Location = new System.Drawing.Point(516, 240);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(235, 24);
            this.cmbStatus.TabIndex = 23;
            // 
            // gMSDataSet4
            // 
            this.gMSDataSet4.DataSetName = "GMSDataSet4";
            this.gMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartsDBBindingSource
            // 
            this.cartsDBBindingSource.DataMember = "cartsDB";
            this.cartsDBBindingSource.DataSource = this.gMSDataSet4;
            // 
            // cartsDBTableAdapter
            // 
            this.cartsDBTableAdapter.ClearBeforeFill = true;
            // 
            // usersDBTableAdapter
            // 
            this.usersDBTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtFemale);
            this.panel1.Controls.Add(this.rbtMale);
            this.panel1.Location = new System.Drawing.Point(516, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 30);
            this.panel1.TabIndex = 24;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(129, 3);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(36, 20);
            this.rbtFemale.TabIndex = 25;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "F";
            this.rbtFemale.UseVisualStyleBackColor = true;
            this.rbtFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(3, 3);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(39, 20);
            this.rbtMale.TabIndex = 0;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "M";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "User ID :";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(515, 17);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(235, 22);
            this.txtUserId.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Security Ans";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(516, 273);
            this.txtSecurityAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new System.Drawing.Size(236, 22);
            this.txtSecurityAnswer.TabIndex = 28;
            this.txtSecurityAnswer.UseSystemPasswordChar = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(502, 372);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(515, 408);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 22);
            this.txtSearch.TabIndex = 30;
            // 
            // dgvUserId
            // 
            this.dgvUserId.DataPropertyName = "userID";
            this.dgvUserId.HeaderText = "User ID";
            this.dgvUserId.MinimumWidth = 6;
            this.dgvUserId.Name = "dgvUserId";
            this.dgvUserId.ReadOnly = true;
            this.dgvUserId.Width = 125;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "email";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Width = 125;
            // 
            // dgvGender
            // 
            this.dgvGender.DataPropertyName = "gender";
            this.dgvGender.HeaderText = "Gender";
            this.dgvGender.MinimumWidth = 6;
            this.dgvGender.Name = "dgvGender";
            this.dgvGender.Width = 125;
            // 
            // dgvPhoneNo
            // 
            this.dgvPhoneNo.DataPropertyName = "phoneNo";
            this.dgvPhoneNo.HeaderText = "Phone No";
            this.dgvPhoneNo.MinimumWidth = 6;
            this.dgvPhoneNo.Name = "dgvPhoneNo";
            this.dgvPhoneNo.Width = 125;
            // 
            // dgvPass
            // 
            this.dgvPass.DataPropertyName = "password";
            this.dgvPass.HeaderText = "Password";
            this.dgvPass.MinimumWidth = 6;
            this.dgvPass.Name = "dgvPass";
            this.dgvPass.Width = 125;
            // 
            // dgvUserName
            // 
            this.dgvUserName.DataPropertyName = "username";
            this.dgvUserName.HeaderText = "Name";
            this.dgvUserName.MinimumWidth = 6;
            this.dgvUserName.Name = "dgvUserName";
            this.dgvUserName.Width = 125;
            // 
            // dgvRole
            // 
            this.dgvRole.DataPropertyName = "role";
            this.dgvRole.HeaderText = "Role";
            this.dgvRole.MinimumWidth = 6;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.Width = 125;
            // 
            // dgvSecurityAns
            // 
            this.dgvSecurityAns.DataPropertyName = "securityAnswer";
            this.dgvSecurityAns.HeaderText = "Security Answer";
            this.dgvSecurityAns.MinimumWidth = 6;
            this.dgvSecurityAns.Name = "dgvSecurityAns";
            this.dgvSecurityAns.Width = 125;
            // 
            // dgvCounter
            // 
            this.dgvCounter.DataPropertyName = "assignedCounter";
            this.dgvCounter.HeaderText = "Counter";
            this.dgvCounter.MinimumWidth = 6;
            this.dgvCounter.Name = "dgvCounter";
            this.dgvCounter.Width = 125;
            // 
            // dgvAccStatus
            // 
            this.dgvAccStatus.DataPropertyName = "accountStatus";
            this.dgvAccStatus.HeaderText = "Status";
            this.dgvAccStatus.MinimumWidth = 6;
            this.dgvAccStatus.Name = "dgvAccStatus";
            this.dgvAccStatus.Width = 125;
            // 
            // AdminEmployeesCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminEmployeesCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEmployeesCrud";
            this.Load += new System.EventHandler(this.AdminEmployeesCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartsDBBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        









        #endregion

        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbStatus;
        private GMSDataSet4 gMSDataSet4;
        private System.Windows.Forms.BindingSource cartsDBBindingSource;
        private GMSDataSet4TableAdapters.cartsDBTableAdapter cartsDBTableAdapter;
        private GMSDataSet5 gMSDataSet5;
        private System.Windows.Forms.BindingSource usersDBBindingSource;
        private GMSDataSet5TableAdapters.usersDBTableAdapter usersDBTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSecurityAns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccStatus;
    }
}