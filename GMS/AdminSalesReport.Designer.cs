namespace GMS
{
    partial class AdminSalesReport
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.DTFrom = new System.Windows.Forms.DateTimePicker();
            this.DTTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBBySalesperson = new System.Windows.Forms.CheckBox();
            this.BTRun = new System.Windows.Forms.Button();
            this.gMSDataSet11 = new GMS.GMSDataSet11();
            this.salesLogDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesLogDBTableAdapter = new GMS.GMSDataSet11TableAdapters.salesLogDBTableAdapter();
            this.salesLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldByUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesLogDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesLogIDDataGridViewTextBoxColumn,
            this.cartIDDataGridViewTextBoxColumn,
            this.soldByUserIDDataGridViewTextBoxColumn,
            this.salesDTDataGridViewTextBoxColumn,
            this.salesTotalDataGridViewTextBoxColumn});
            this.dgvReport.DataSource = this.salesLogDBBindingSource;
            this.dgvReport.Location = new System.Drawing.Point(12, 27);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(438, 241);
            this.dgvReport.TabIndex = 0;
            // 
            // DTFrom
            // 
            this.DTFrom.Location = new System.Drawing.Point(527, 45);
            this.DTFrom.Name = "DTFrom";
            this.DTFrom.Size = new System.Drawing.Size(200, 22);
            this.DTFrom.TabIndex = 1;
            // 
            // DTTo
            // 
            this.DTTo.Location = new System.Drawing.Point(527, 88);
            this.DTTo.Name = "DTTo";
            this.DTTo.Size = new System.Drawing.Size(200, 22);
            this.DTTo.TabIndex = 2;
            this.DTTo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // CBBySalesperson
            // 
            this.CBBySalesperson.AutoSize = true;
            this.CBBySalesperson.Location = new System.Drawing.Point(527, 138);
            this.CBBySalesperson.Name = "CBBySalesperson";
            this.CBBySalesperson.Size = new System.Drawing.Size(109, 20);
            this.CBBySalesperson.TabIndex = 5;
            this.CBBySalesperson.Text = "Salesperson ";
            this.CBBySalesperson.UseVisualStyleBackColor = true;
            this.CBBySalesperson.CheckedChanged += new System.EventHandler(this.CBBySalesperson_CheckedChanged);
            // 
            // BTRun
            // 
            this.BTRun.Location = new System.Drawing.Point(80, 321);
            this.BTRun.Name = "BTRun";
            this.BTRun.Size = new System.Drawing.Size(75, 23);
            this.BTRun.TabIndex = 6;
            this.BTRun.Text = "Run";
            this.BTRun.UseVisualStyleBackColor = true;
            this.BTRun.Click += new System.EventHandler(this.BTRun_Click);
            // 
            // gMSDataSet11
            // 
            this.gMSDataSet11.DataSetName = "GMSDataSet11";
            this.gMSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesLogDBBindingSource
            // 
            this.salesLogDBBindingSource.DataMember = "salesLogDB";
            this.salesLogDBBindingSource.DataSource = this.gMSDataSet11;
            // 
            // salesLogDBTableAdapter
            // 
            this.salesLogDBTableAdapter.ClearBeforeFill = true;
            // 
            // salesLogIDDataGridViewTextBoxColumn
            // 
            this.salesLogIDDataGridViewTextBoxColumn.DataPropertyName = "salesLogID";
            this.salesLogIDDataGridViewTextBoxColumn.HeaderText = "salesLogID";
            this.salesLogIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesLogIDDataGridViewTextBoxColumn.Name = "salesLogIDDataGridViewTextBoxColumn";
            this.salesLogIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesLogIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartIDDataGridViewTextBoxColumn
            // 
            this.cartIDDataGridViewTextBoxColumn.DataPropertyName = "cartID";
            this.cartIDDataGridViewTextBoxColumn.HeaderText = "cartID";
            this.cartIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cartIDDataGridViewTextBoxColumn.Name = "cartIDDataGridViewTextBoxColumn";
            this.cartIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // soldByUserIDDataGridViewTextBoxColumn
            // 
            this.soldByUserIDDataGridViewTextBoxColumn.DataPropertyName = "soldByUserID";
            this.soldByUserIDDataGridViewTextBoxColumn.HeaderText = "soldByUserID";
            this.soldByUserIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soldByUserIDDataGridViewTextBoxColumn.Name = "soldByUserIDDataGridViewTextBoxColumn";
            this.soldByUserIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesDTDataGridViewTextBoxColumn
            // 
            this.salesDTDataGridViewTextBoxColumn.DataPropertyName = "salesDT";
            this.salesDTDataGridViewTextBoxColumn.HeaderText = "salesDT";
            this.salesDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesDTDataGridViewTextBoxColumn.Name = "salesDTDataGridViewTextBoxColumn";
            this.salesDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // salesTotalDataGridViewTextBoxColumn
            // 
            this.salesTotalDataGridViewTextBoxColumn.DataPropertyName = "salesTotal";
            this.salesTotalDataGridViewTextBoxColumn.HeaderText = "salesTotal";
            this.salesTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesTotalDataGridViewTextBoxColumn.Name = "salesTotalDataGridViewTextBoxColumn";
            this.salesTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdminSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTRun);
            this.Controls.Add(this.CBBySalesperson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTTo);
            this.Controls.Add(this.DTFrom);
            this.Controls.Add(this.dgvReport);
            this.Name = "AdminSalesReport";
            this.Text = "AdminSalesReport";
            this.Load += new System.EventHandler(this.AdminSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesLogDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DateTimePicker DTFrom;
        private System.Windows.Forms.DateTimePicker DTTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBBySalesperson;
        private System.Windows.Forms.Button BTRun;
        private GMSDataSet11 gMSDataSet11;
        private System.Windows.Forms.BindingSource salesLogDBBindingSource;
        private GMSDataSet11TableAdapters.salesLogDBTableAdapter salesLogDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesLogIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldByUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesTotalDataGridViewTextBoxColumn;
    }
}