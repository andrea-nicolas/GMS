namespace GMS
{
    partial class EmployeeList
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSecurityAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAssignedCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccountStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUserId,
            this.dgvEmail,
            this.dgvGender,
            this.dgvPhoneNo,
            this.dgvPassword,
            this.dgvUserName,
            this.dgvRole,
            this.dgvSecurityAnswer,
            this.dgvAssignedCounter,
            this.dgvAccountStatus});
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeList.Location = new System.Drawing.Point(3, 63);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(922, 392);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvEmployeeList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 458);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(25, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 41);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(145, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(275, 20);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(615, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // dgvUserId
            // 
            this.dgvUserId.DataPropertyName = "userID";
            this.dgvUserId.HeaderText = "User ID";
            this.dgvUserId.MinimumWidth = 6;
            this.dgvUserId.Name = "dgvUserId";
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
            // dgvPassword
            // 
            this.dgvPassword.DataPropertyName = "password";
            this.dgvPassword.HeaderText = "Password";
            this.dgvPassword.MinimumWidth = 6;
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.Width = 125;
            // 
            // dgvUserName
            // 
            this.dgvUserName.DataPropertyName = "username";
            this.dgvUserName.HeaderText = "User Name";
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
            // dgvSecurityAnswer
            // 
            this.dgvSecurityAnswer.DataPropertyName = "securityAnswer";
            this.dgvSecurityAnswer.HeaderText = "Security Answer";
            this.dgvSecurityAnswer.MinimumWidth = 6;
            this.dgvSecurityAnswer.Name = "dgvSecurityAnswer";
            this.dgvSecurityAnswer.Width = 125;
            // 
            // dgvAssignedCounter
            // 
            this.dgvAssignedCounter.DataPropertyName = "assignedCounter";
            this.dgvAssignedCounter.HeaderText = "Assigned Counter";
            this.dgvAssignedCounter.MinimumWidth = 6;
            this.dgvAssignedCounter.Name = "dgvAssignedCounter";
            this.dgvAssignedCounter.Width = 125;
            // 
            // dgvAccountStatus
            // 
            this.dgvAccountStatus.DataPropertyName = "accountStatus";
            this.dgvAccountStatus.HeaderText = "Account Status";
            this.dgvAccountStatus.MinimumWidth = 6;
            this.dgvAccountStatus.Name = "dgvAccountStatus";
            this.dgvAccountStatus.Width = 125;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSecurityAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAssignedCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccountStatus;
    }
}