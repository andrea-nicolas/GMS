namespace GMS
{
    partial class SPDashboard
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
            this.BTResetPassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTCreateCart = new System.Windows.Forms.Button();
            this.BTItemList = new System.Windows.Forms.Button();
            this.BTPendingCarts = new System.Windows.Forms.Button();
            this.BTLogout = new System.Windows.Forms.Button();
            this.BTSalesLog = new System.Windows.Forms.Button();
            this.BTEditProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.TBAssignedCounter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTResetPassword
            // 
            this.BTResetPassword.Location = new System.Drawing.Point(31, 207);
            this.BTResetPassword.Name = "BTResetPassword";
            this.BTResetPassword.Size = new System.Drawing.Size(100, 44);
            this.BTResetPassword.TabIndex = 17;
            this.BTResetPassword.Text = "Change Password";
            this.BTResetPassword.UseVisualStyleBackColor = true;
            this.BTResetPassword.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Assigned Counter:";
            // 
            // BTCreateCart
            // 
            this.BTCreateCart.Location = new System.Drawing.Point(261, 183);
            this.BTCreateCart.Name = "BTCreateCart";
            this.BTCreateCart.Size = new System.Drawing.Size(100, 32);
            this.BTCreateCart.TabIndex = 15;
            this.BTCreateCart.Text = "Create Cart";
            this.BTCreateCart.UseVisualStyleBackColor = true;
            this.BTCreateCart.Click += new System.EventHandler(this.button6_Click);
            // 
            // BTItemList
            // 
            this.BTItemList.Location = new System.Drawing.Point(624, 183);
            this.BTItemList.Name = "BTItemList";
            this.BTItemList.Size = new System.Drawing.Size(100, 32);
            this.BTItemList.TabIndex = 14;
            this.BTItemList.Text = "Item List";
            this.BTItemList.UseVisualStyleBackColor = true;
            this.BTItemList.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTPendingCarts
            // 
            this.BTPendingCarts.Location = new System.Drawing.Point(452, 183);
            this.BTPendingCarts.Name = "BTPendingCarts";
            this.BTPendingCarts.Size = new System.Drawing.Size(100, 32);
            this.BTPendingCarts.TabIndex = 13;
            this.BTPendingCarts.Text = "Pending Carts";
            this.BTPendingCarts.UseVisualStyleBackColor = true;
            this.BTPendingCarts.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTLogout
            // 
            this.BTLogout.Location = new System.Drawing.Point(41, 404);
            this.BTLogout.Name = "BTLogout";
            this.BTLogout.Size = new System.Drawing.Size(70, 21);
            this.BTLogout.TabIndex = 12;
            this.BTLogout.Text = "Log Out";
            this.BTLogout.UseVisualStyleBackColor = true;
            this.BTLogout.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTSalesLog
            // 
            this.BTSalesLog.Location = new System.Drawing.Point(31, 108);
            this.BTSalesLog.Name = "BTSalesLog";
            this.BTSalesLog.Size = new System.Drawing.Size(100, 32);
            this.BTSalesLog.TabIndex = 11;
            this.BTSalesLog.Text = "My Sales Log";
            this.BTSalesLog.UseVisualStyleBackColor = true;
            this.BTSalesLog.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTEditProfile
            // 
            this.BTEditProfile.Location = new System.Drawing.Point(31, 157);
            this.BTEditProfile.Name = "BTEditProfile";
            this.BTEditProfile.Size = new System.Drawing.Size(100, 32);
            this.BTEditProfile.TabIndex = 10;
            this.BTEditProfile.Text = "Edit Profile";
            this.BTEditProfile.UseVisualStyleBackColor = true;
            this.BTEditProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome, ";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(31, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 28);
            this.button8.TabIndex = 18;
            this.button8.Text = "Dashboard";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // TBAssignedCounter
            // 
            this.TBAssignedCounter.Location = new System.Drawing.Point(127, 47);
            this.TBAssignedCounter.Name = "TBAssignedCounter";
            this.TBAssignedCounter.ReadOnly = true;
            this.TBAssignedCounter.Size = new System.Drawing.Size(36, 20);
            this.TBAssignedCounter.TabIndex = 19;
            this.TBAssignedCounter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SPDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBAssignedCounter);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.BTResetPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTCreateCart);
            this.Controls.Add(this.BTItemList);
            this.Controls.Add(this.BTPendingCarts);
            this.Controls.Add(this.BTLogout);
            this.Controls.Add(this.BTSalesLog);
            this.Controls.Add(this.BTEditProfile);
            this.Controls.Add(this.label1);
            this.Name = "SPDashboard";
            this.Text = "SPDashboard";
            this.Load += new System.EventHandler(this.SPDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTResetPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTCreateCart;
        private System.Windows.Forms.Button BTItemList;
        private System.Windows.Forms.Button BTPendingCarts;
        private System.Windows.Forms.Button BTLogout;
        private System.Windows.Forms.Button BTSalesLog;
        private System.Windows.Forms.Button BTEditProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox TBAssignedCounter;
    }
}