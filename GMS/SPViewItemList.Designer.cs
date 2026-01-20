namespace GMS
{
    partial class SPViewItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPViewItemList));
            this.BTResetPassword = new System.Windows.Forms.Button();
            this.BTLogout = new System.Windows.Forms.Button();
            this.BTSalesLog = new System.Windows.Forms.Button();
            this.BTEditProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBitemID = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.BTNotify = new System.Windows.Forms.Button();
            this.BTDashboard = new System.Windows.Forms.Button();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TBLitems = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TBQty = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TBLitems)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTResetPassword
            // 
            this.BTResetPassword.BackColor = System.Drawing.Color.SandyBrown;
            this.BTResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BTResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTResetPassword.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTResetPassword.Location = new System.Drawing.Point(23, 160);
            this.BTResetPassword.Name = "BTResetPassword";
            this.BTResetPassword.Size = new System.Drawing.Size(151, 32);
            this.BTResetPassword.TabIndex = 28;
            this.BTResetPassword.Text = " Change Password";
            this.BTResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTResetPassword.UseVisualStyleBackColor = false;
            this.BTResetPassword.Click += new System.EventHandler(this.BTResetPassword_Click);
            // 
            // BTLogout
            // 
            this.BTLogout.BackColor = System.Drawing.Color.Peru;
            this.BTLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BTLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTLogout.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLogout.Location = new System.Drawing.Point(23, 374);
            this.BTLogout.Name = "BTLogout";
            this.BTLogout.Size = new System.Drawing.Size(151, 32);
            this.BTLogout.TabIndex = 26;
            this.BTLogout.Text = "Log Out";
            this.BTLogout.UseVisualStyleBackColor = false;
            this.BTLogout.Click += new System.EventHandler(this.BTLogout_Click);
            // 
            // BTSalesLog
            // 
            this.BTSalesLog.BackColor = System.Drawing.Color.SandyBrown;
            this.BTSalesLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BTSalesLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTSalesLog.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSalesLog.Location = new System.Drawing.Point(23, 84);
            this.BTSalesLog.Name = "BTSalesLog";
            this.BTSalesLog.Size = new System.Drawing.Size(151, 32);
            this.BTSalesLog.TabIndex = 25;
            this.BTSalesLog.Text = " My Sales Log";
            this.BTSalesLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSalesLog.UseVisualStyleBackColor = false;
            this.BTSalesLog.Click += new System.EventHandler(this.BTSalesLog_Click);
            // 
            // BTEditProfile
            // 
            this.BTEditProfile.BackColor = System.Drawing.Color.SandyBrown;
            this.BTEditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BTEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEditProfile.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditProfile.Location = new System.Drawing.Point(23, 122);
            this.BTEditProfile.Name = "BTEditProfile";
            this.BTEditProfile.Size = new System.Drawing.Size(151, 32);
            this.BTEditProfile.TabIndex = 24;
            this.BTEditProfile.Text = " Edit Profile";
            this.BTEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTEditProfile.UseVisualStyleBackColor = false;
            this.BTEditProfile.Click += new System.EventHandler(this.BTEditProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Item ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Category:";
            // 
            // TBitemID
            // 
            this.TBitemID.BackColor = System.Drawing.Color.Linen;
            this.TBitemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBitemID.Location = new System.Drawing.Point(343, 346);
            this.TBitemID.Name = "TBitemID";
            this.TBitemID.Size = new System.Drawing.Size(100, 20);
            this.TBitemID.TabIndex = 37;
            // 
            // TBname
            // 
            this.TBname.BackColor = System.Drawing.Color.Linen;
            this.TBname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBname.Location = new System.Drawing.Point(343, 377);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(100, 20);
            this.TBname.TabIndex = 38;
            // 
            // BTNotify
            // 
            this.BTNotify.BackColor = System.Drawing.Color.DarkOrange;
            this.BTNotify.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNotify.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNotify.Location = new System.Drawing.Point(554, 372);
            this.BTNotify.Name = "BTNotify";
            this.BTNotify.Size = new System.Drawing.Size(234, 66);
            this.BTNotify.TabIndex = 42;
            this.BTNotify.Text = "Notify Low Stock";
            this.BTNotify.UseVisualStyleBackColor = false;
            this.BTNotify.Click += new System.EventHandler(this.BTNotify_Click);
            // 
            // BTDashboard
            // 
            this.BTDashboard.BackColor = System.Drawing.Color.SandyBrown;
            this.BTDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.BTDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTDashboard.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDashboard.Location = new System.Drawing.Point(23, 198);
            this.BTDashboard.Name = "BTDashboard";
            this.BTDashboard.Size = new System.Drawing.Size(151, 32);
            this.BTDashboard.TabIndex = 43;
            this.BTDashboard.Text = " Dashboard";
            this.BTDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTDashboard.UseVisualStyleBackColor = false;
            this.BTDashboard.Click += new System.EventHandler(this.BTDashboard_Click);
            // 
            // CBcategory
            // 
            this.CBcategory.BackColor = System.Drawing.Color.Linen;
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Items.AddRange(new object[] {
            "Drinks",
            "Meats",
            "Fruits",
            "Toiletries",
            "Food",
            "Vegetables"});
            this.CBcategory.Location = new System.Drawing.Point(343, 410);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(100, 21);
            this.CBcategory.TabIndex = 44;
            this.CBcategory.SelectedIndexChanged += new System.EventHandler(this.CBcategory_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBLitems
            // 
            this.TBLitems.BackgroundColor = System.Drawing.Color.Linen;
            this.TBLitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLitems.Location = new System.Drawing.Point(227, 67);
            this.TBLitems.Name = "TBLitems";
            this.TBLitems.Size = new System.Drawing.Size(562, 256);
            this.TBLitems.TabIndex = 46;
            this.TBLitems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TBLitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TBLitems.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TBLitems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(579, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Quantity In Stock:";
            // 
            // TBQty
            // 
            this.TBQty.BackColor = System.Drawing.Color.BurlyWood;
            this.TBQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBQty.Location = new System.Drawing.Point(688, 345);
            this.TBQty.Name = "TBQty";
            this.TBQty.ReadOnly = true;
            this.TBQty.Size = new System.Drawing.Size(100, 20);
            this.TBQty.TabIndex = 48;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SandyBrown;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.BTEditProfile);
            this.panel7.Controls.Add(this.BTResetPassword);
            this.panel7.Controls.Add(this.BTDashboard);
            this.panel7.Controls.Add(this.BTLogout);
            this.panel7.Controls.Add(this.BTSalesLog);
            this.panel7.Location = new System.Drawing.Point(-1, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(213, 441);
            this.panel7.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 50);
            this.label5.TabIndex = 44;
            this.label5.Text = "Available Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(227, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 109);
            this.panel1.TabIndex = 50;
            // 
            // SPViewItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBLitems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBcategory);
            this.Controls.Add(this.BTNotify);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.TBitemID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "SPViewItemList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPViewItemList";
            this.Load += new System.EventHandler(this.SPViewItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLitems)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTResetPassword;
        private System.Windows.Forms.Button BTLogout;
        private System.Windows.Forms.Button BTSalesLog;
        private System.Windows.Forms.Button BTEditProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBitemID;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Button BTNotify;
        private System.Windows.Forms.Button BTDashboard;
        private System.Windows.Forms.ComboBox CBcategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TBLitems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBQty;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}