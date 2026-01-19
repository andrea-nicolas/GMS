namespace GMS
{
    partial class SPSalesLog
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
            this.TBLsaleslog = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BTResetPassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BTLogout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BTEditProfile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BTDashboard = new System.Windows.Forms.Button();
            this.TBAssignedCounter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBTotalSales = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TBLsaleslog)).BeginInit();
            this.SuspendLayout();
            // 
            // TBLsaleslog
            // 
            this.TBLsaleslog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLsaleslog.Location = new System.Drawing.Point(216, 67);
            this.TBLsaleslog.Name = "TBLsaleslog";
            this.TBLsaleslog.Size = new System.Drawing.Size(545, 265);
            this.TBLsaleslog.TabIndex = 15;
            this.TBLsaleslog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "My Sales Log";
            // 
            // BTResetPassword
            // 
            this.BTResetPassword.Location = new System.Drawing.Point(22, 210);
            this.BTResetPassword.Name = "BTResetPassword";
            this.BTResetPassword.Size = new System.Drawing.Size(100, 44);
            this.BTResetPassword.TabIndex = 22;
            this.BTResetPassword.Text = "Change Password";
            this.BTResetPassword.UseVisualStyleBackColor = true;
            this.BTResetPassword.Click += new System.EventHandler(this.BTResetPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Assigned Counter:";
            // 
            // BTLogout
            // 
            this.BTLogout.Location = new System.Drawing.Point(32, 407);
            this.BTLogout.Name = "BTLogout";
            this.BTLogout.Size = new System.Drawing.Size(70, 21);
            this.BTLogout.TabIndex = 20;
            this.BTLogout.Text = "Log Out";
            this.BTLogout.UseVisualStyleBackColor = true;
            this.BTLogout.Click += new System.EventHandler(this.BTLogout_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(22, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 19;
            this.button5.Text = "My Sales Log";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTEditProfile
            // 
            this.BTEditProfile.Location = new System.Drawing.Point(22, 160);
            this.BTEditProfile.Name = "BTEditProfile";
            this.BTEditProfile.Size = new System.Drawing.Size(100, 32);
            this.BTEditProfile.TabIndex = 18;
            this.BTEditProfile.Text = "Edit Profile";
            this.BTEditProfile.UseVisualStyleBackColor = true;
            this.BTEditProfile.Click += new System.EventHandler(this.BTEditProfile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Welcome, ";
            // 
            // BTDashboard
            // 
            this.BTDashboard.Location = new System.Drawing.Point(22, 272);
            this.BTDashboard.Name = "BTDashboard";
            this.BTDashboard.Size = new System.Drawing.Size(100, 28);
            this.BTDashboard.TabIndex = 23;
            this.BTDashboard.Text = "Dashboard";
            this.BTDashboard.UseVisualStyleBackColor = true;
            this.BTDashboard.Click += new System.EventHandler(this.BTDashboard_Click);
            // 
            // TBAssignedCounter
            // 
            this.TBAssignedCounter.Location = new System.Drawing.Point(118, 52);
            this.TBAssignedCounter.Name = "TBAssignedCounter";
            this.TBAssignedCounter.ReadOnly = true;
            this.TBAssignedCounter.Size = new System.Drawing.Size(36, 20);
            this.TBAssignedCounter.TabIndex = 20;
            this.TBAssignedCounter.TextChanged += new System.EventHandler(this.TBAssignedCounter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "My Total Sales: Tk.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBTotalSales
            // 
            this.TBTotalSales.Location = new System.Drawing.Point(403, 367);
            this.TBTotalSales.Name = "TBTotalSales";
            this.TBTotalSales.ReadOnly = true;
            this.TBTotalSales.Size = new System.Drawing.Size(78, 20);
            this.TBTotalSales.TabIndex = 25;
            // 
            // SPSalesLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBTotalSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBAssignedCounter);
            this.Controls.Add(this.BTDashboard);
            this.Controls.Add(this.BTResetPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTLogout);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BTEditProfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBLsaleslog);
            this.Name = "SPSalesLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPSalesLog";
            this.Load += new System.EventHandler(this.SPSalesLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLsaleslog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TBLsaleslog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTResetPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTLogout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BTEditProfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTDashboard;
        private System.Windows.Forms.TextBox TBAssignedCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBTotalSales;
    }
}