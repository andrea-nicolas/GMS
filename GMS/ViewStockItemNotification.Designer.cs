namespace GMS
{
    partial class ViewStockItemNotification
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
            this.dgvViewStockItemNotification = new System.Windows.Forms.DataGridView();
            this.dgvStockNotificationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStockNotificationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStockItemNotification)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewStockItemNotification
            // 
            this.dgvViewStockItemNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStockItemNotification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStockNotificationID,
            this.dgvItemName,
            this.dgvStockNotificationStatus});
            this.dgvViewStockItemNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewStockItemNotification.Location = new System.Drawing.Point(3, 63);
            this.dgvViewStockItemNotification.Name = "dgvViewStockItemNotification";
            this.dgvViewStockItemNotification.RowHeadersWidth = 51;
            this.dgvViewStockItemNotification.RowTemplate.Height = 24;
            this.dgvViewStockItemNotification.Size = new System.Drawing.Size(1290, 497);
            this.dgvViewStockItemNotification.TabIndex = 0;
            // 
            // dgvStockNotificationID
            // 
            this.dgvStockNotificationID.DataPropertyName = "stockNotificationID";
            this.dgvStockNotificationID.HeaderText = "Stock Notification ID";
            this.dgvStockNotificationID.MinimumWidth = 6;
            this.dgvStockNotificationID.Name = "dgvStockNotificationID";
            this.dgvStockNotificationID.Width = 125;
            // 
            // dgvItemName
            // 
            this.dgvItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvItemName.DataPropertyName = "itemName";
            this.dgvItemName.HeaderText = "Item Name";
            this.dgvItemName.MinimumWidth = 6;
            this.dgvItemName.Name = "dgvItemName";
            // 
            // dgvStockNotificationStatus
            // 
            this.dgvStockNotificationStatus.DataPropertyName = "stockNotificationStatus";
            this.dgvStockNotificationStatus.HeaderText = "Stock Notification Status";
            this.dgvStockNotificationStatus.MinimumWidth = 6;
            this.dgvStockNotificationStatus.Name = "dgvStockNotificationStatus";
            this.dgvStockNotificationStatus.Width = 125;
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
            this.btnRefresh.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Info;
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
            this.panel1.BackColor = System.Drawing.Color.Snow;
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
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Beige;
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
            this.tableLayoutPanel1.Controls.Add(this.dgvViewStockItemNotification, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1296, 563);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ViewStockItemNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewStockItemNotification";
            this.Text = "ViewStockItemNotification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewStockItemNotification_FormClosed);
            this.Load += new System.EventHandler(this.ViewStockItemNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStockItemNotification)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewStockItemNotification;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStockNotificationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStockNotificationStatus;
    }
}