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
            this.button3.Location = new System.Drawing.Point(488, 339);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 21);
            this.button3.TabIndex = 22;
            this.button3.Text = "Back to Dashboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TBLcart
            // 
            this.TBLcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBLcart.Location = new System.Drawing.Point(20, 32);
            this.TBLcart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBLcart.Name = "TBLcart";
            this.TBLcart.Size = new System.Drawing.Size(565, 141);
            this.TBLcart.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Available Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Category:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Unit Price:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Discount ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 36);
            this.button2.TabIndex = 31;
            this.button2.Text = "Complete Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cart Total Price:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total After Discount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 252);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total after 10% VAT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 318);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total Price:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TBitemID
            // 
            this.TBitemID.Location = new System.Drawing.Point(483, 67);
            this.TBitemID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBitemID.Name = "TBitemID";
            this.TBitemID.Size = new System.Drawing.Size(92, 20);
            this.TBitemID.TabIndex = 37;
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(483, 89);
            this.TBname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(92, 20);
            this.TBname.TabIndex = 38;
            // 
            // TBunitPrice
            // 
            this.TBunitPrice.Location = new System.Drawing.Point(483, 131);
            this.TBunitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBunitPrice.Name = "TBunitPrice";
            this.TBunitPrice.ReadOnly = true;
            this.TBunitPrice.Size = new System.Drawing.Size(92, 20);
            this.TBunitPrice.TabIndex = 40;
            // 
            // TBtotalPrice
            // 
            this.TBtotalPrice.Location = new System.Drawing.Point(83, 255);
            this.TBtotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBtotalPrice.Name = "TBtotalPrice";
            this.TBtotalPrice.ReadOnly = true;
            this.TBtotalPrice.Size = new System.Drawing.Size(91, 20);
            this.TBtotalPrice.TabIndex = 42;
            // 
            // TBCartTotalPrice
            // 
            this.TBCartTotalPrice.Location = new System.Drawing.Point(502, 234);
            this.TBCartTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBCartTotalPrice.Name = "TBCartTotalPrice";
            this.TBCartTotalPrice.ReadOnly = true;
            this.TBCartTotalPrice.Size = new System.Drawing.Size(76, 20);
            this.TBCartTotalPrice.TabIndex = 43;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(286, 209);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 44;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(390, 228);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 45;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(98, 224);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}