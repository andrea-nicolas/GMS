namespace GMS
{
    partial class SPEditCart
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
            this.button3 = new System.Windows.Forms.Button();
            this.TBLcart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBitemID = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.TBunitPrice = new System.Windows.Forms.TextBox();
            this.TBtotalPrice = new System.Windows.Forms.TextBox();
            this.TBCartTotalPrice = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            this.TBLitems = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NUDqty = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBLcart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLitems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDqty)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 26);
            this.button3.TabIndex = 22;
            this.button3.Text = "Back to Dashboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TBLcart
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 173);
            this.dataGridView1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Available Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Category:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Unit Price:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Discount ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 21);
            this.button1.TabIndex = 30;
            this.button1.Text = "Apply Discount";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 44);
            this.button2.TabIndex = 31;
            this.button2.Text = "Complete Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cart Total Price:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total After Discount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total after 10% VAT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total Price:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 37;
            // 
            this.TBitemID.Location = new System.Drawing.Point(644, 83);
            this.TBitemID.Name = "TBitemID";
            this.TBitemID.Size = new System.Drawing.Size(121, 20);
            this.TBitemID.TabIndex = 37;
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 38;
            // 
            this.TBname.Location = new System.Drawing.Point(644, 109);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(121, 20);
            this.TBname.TabIndex = 38;
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 292);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 39;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            this.TBunitPrice.Location = new System.Drawing.Point(644, 161);
            this.TBunitPrice.Name = "TBunitPrice";
            this.TBunitPrice.ReadOnly = true;
            this.TBunitPrice.Size = new System.Drawing.Size(121, 20);
            this.TBunitPrice.TabIndex = 40;
            // 
            this.textBox4.Location = new System.Drawing.Point(93, 319);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 40;
            // 
            this.TBtotalPrice.Location = new System.Drawing.Point(427, 332);
            this.TBtotalPrice.Name = "TBtotalPrice";
            this.TBtotalPrice.ReadOnly = true;
            this.TBtotalPrice.Size = new System.Drawing.Size(120, 20);
            this.TBtotalPrice.TabIndex = 42;
            // 
            this.textBox5.Location = new System.Drawing.Point(93, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 41;
            // 
            this.TBCartTotalPrice.Location = new System.Drawing.Point(670, 288);
            this.TBCartTotalPrice.Name = "TBCartTotalPrice";
            this.TBCartTotalPrice.ReadOnly = true;
            this.TBCartTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.TBCartTotalPrice.TabIndex = 43;
            // 
            this.textBox6.Location = new System.Drawing.Point(93, 384);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 42;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(519, 228);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 43;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(519, 253);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(132, 22);
            this.textBox8.TabIndex = 44;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(520, 281);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(132, 22);
            this.textBox9.TabIndex = 45;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(519, 307);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(132, 22);
            this.textBox10.TabIndex = 46;
            // 
            // CBcategory
            // 
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Items.AddRange(new object[] {
            "Drinks",
            "Meats",
            "Fruits",
            "Toiletries",
            "Food",
            "Vegetables"});
            this.CBcategory.Location = new System.Drawing.Point(644, 138);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(121, 21);
            this.CBcategory.TabIndex = 47;
            // 
            // TBLitems
            // 
            this.TBLitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLitems.Location = new System.Drawing.Point(12, 39);
            this.TBLitems.Name = "TBLitems";
            this.TBLitems.Size = new System.Drawing.Size(552, 214);
            this.TBLitems.TabIndex = 48;
            this.TBLitems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.TBLitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.TBLitems.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.TBLitems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cart Items";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 50;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 27);
            this.button4.TabIndex = 51;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NUDqty
            // 
            this.NUDqty.Location = new System.Drawing.Point(427, 306);
            this.NUDqty.Name = "NUDqty";
            this.NUDqty.Size = new System.Drawing.Size(120, 20);
            this.NUDqty.TabIndex = 52;
            this.NUDqty.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 40);
            this.button5.TabIndex = 53;
            this.button5.Text = "Remove from Cart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(360, 411);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 27);
            this.button6.TabIndex = 54;
            this.button6.Text = "Update Cart Quantity";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // SPEditCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.TBCartTotalPrice);
            this.Controls.Add(this.TBtotalPrice);
            this.Controls.Add(this.TBunitPrice);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.TBitemID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBLcart);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SPEditCart";
            this.Text = "SPEditCart";
            this.Load += new System.EventHandler(this.SPEditCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLcart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBLitems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDqty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView TBLcart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBitemID;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.TextBox TBunitPrice;
        private System.Windows.Forms.TextBox TBtotalPrice;
        private System.Windows.Forms.TextBox TBCartTotalPrice;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox CBcategory;
        private System.Windows.Forms.DataGridView TBLitems;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown NUDqty;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}