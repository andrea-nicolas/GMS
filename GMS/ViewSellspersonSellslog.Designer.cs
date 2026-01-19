namespace GMS
{
    partial class ViewSellspersonSellslog
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvViewSellspersonSellslog = new System.Windows.Forms.DataGridView();
            this.dgvSellsLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSellerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSallesDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSellsTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSellspersonSellslog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(275, 20);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(615, 22);
            this.txtSearch.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 54);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvViewSellspersonSellslog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, -4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 563);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvViewSellspersonSellslog
            // 
            this.dgvViewSellspersonSellslog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSellspersonSellslog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSellsLogID,
            this.dgvItemName,
            this.dgvSellerName,
            this.dgvSallesDT,
            this.dgvSellsTotal});
            this.dgvViewSellspersonSellslog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewSellspersonSellslog.Location = new System.Drawing.Point(3, 63);
            this.dgvViewSellspersonSellslog.Name = "dgvViewSellspersonSellslog";
            this.dgvViewSellspersonSellslog.RowHeadersWidth = 51;
            this.dgvViewSellspersonSellslog.RowTemplate.Height = 24;
            this.dgvViewSellspersonSellslog.Size = new System.Drawing.Size(1290, 497);
            this.dgvViewSellspersonSellslog.TabIndex = 0;
            this.dgvViewSellspersonSellslog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellContentClick);
            // 
            // dgvSellsLogID
            // 
            this.dgvSellsLogID.DataPropertyName = "salesLogID";
            this.dgvSellsLogID.HeaderText = "Sells Log ID";
            this.dgvSellsLogID.MinimumWidth = 6;
            this.dgvSellsLogID.Name = "dgvSellsLogID";
            this.dgvSellsLogID.Width = 125;
            // 
            // dgvItemName
            // 
            this.dgvItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvItemName.DataPropertyName = "itemName";
            this.dgvItemName.HeaderText = "Item Name";
            this.dgvItemName.MinimumWidth = 6;
            this.dgvItemName.Name = "dgvItemName";
            // 
            // dgvSellerName
            // 
            this.dgvSellerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSellerName.DataPropertyName = "username";
            this.dgvSellerName.HeaderText = "Seller Name";
            this.dgvSellerName.MinimumWidth = 6;
            this.dgvSellerName.Name = "dgvSellerName";
            // 
            // dgvSallesDT
            // 
            this.dgvSallesDT.DataPropertyName = "salesDT";
            this.dgvSallesDT.HeaderText = "Sells Date";
            this.dgvSallesDT.MinimumWidth = 6;
            this.dgvSallesDT.Name = "dgvSallesDT";
            this.dgvSallesDT.Width = 125;
            // 
            // dgvSellsTotal
            // 
            this.dgvSellsTotal.DataPropertyName = "salesTotal";
            this.dgvSellsTotal.HeaderText = "Total Sell";
            this.dgvSellsTotal.MinimumWidth = 6;
            this.dgvSellsTotal.Name = "dgvSellsTotal";
            this.dgvSellsTotal.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ViewSellspersonSellslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewSellspersonSellslog";
            this.Text = "ViewSellspersonSellslog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewSellspersonSellslog_FormClosed);
            this.Load += new System.EventHandler(this.ViewSellspersonSellslog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSellspersonSellslog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvViewSellspersonSellslog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSellsLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSellerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSallesDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSellsTotal;
    }
}