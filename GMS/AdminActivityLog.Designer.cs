using System;

namespace GMS
{
    partial class AdminActivityLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gMSDataSet2 = new GMS.GMSDataSet2();
            this.activityLogDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityLogDBTableAdapter = new GMS.GMSDataSet2TableAdapters.activityLogDBTableAdapter();
            this.activityLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneByUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDiscountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityLogDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activityLogIDDataGridViewTextBoxColumn,
            this.doneByUserIDDataGridViewTextBoxColumn,
            this.targetItemIDDataGridViewTextBoxColumn,
            this.activityDTDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.targetUserIDDataGridViewTextBoxColumn,
            this.targetDiscountIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.activityLogDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gMSDataSet2
            // 
            this.gMSDataSet2.DataSetName = "GMSDataSet2";
            this.gMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activityLogDBBindingSource
            // 
            this.activityLogDBBindingSource.DataMember = "activityLogDB";
            this.activityLogDBBindingSource.DataSource = this.gMSDataSet2;
            // 
            // activityLogDBTableAdapter
            // 
            this.activityLogDBTableAdapter.ClearBeforeFill = true;
            // 
            // activityLogIDDataGridViewTextBoxColumn
            // 
            this.activityLogIDDataGridViewTextBoxColumn.DataPropertyName = "activityLogID";
            this.activityLogIDDataGridViewTextBoxColumn.HeaderText = "activityLogID";
            this.activityLogIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityLogIDDataGridViewTextBoxColumn.Name = "activityLogIDDataGridViewTextBoxColumn";
            this.activityLogIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityLogIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // doneByUserIDDataGridViewTextBoxColumn
            // 
            this.doneByUserIDDataGridViewTextBoxColumn.DataPropertyName = "doneByUserID";
            this.doneByUserIDDataGridViewTextBoxColumn.HeaderText = "doneByUserID";
            this.doneByUserIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doneByUserIDDataGridViewTextBoxColumn.Name = "doneByUserIDDataGridViewTextBoxColumn";
            this.doneByUserIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // targetItemIDDataGridViewTextBoxColumn
            // 
            this.targetItemIDDataGridViewTextBoxColumn.DataPropertyName = "targetItemID";
            this.targetItemIDDataGridViewTextBoxColumn.HeaderText = "targetItemID";
            this.targetItemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.targetItemIDDataGridViewTextBoxColumn.Name = "targetItemIDDataGridViewTextBoxColumn";
            this.targetItemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // activityDTDataGridViewTextBoxColumn
            // 
            this.activityDTDataGridViewTextBoxColumn.DataPropertyName = "activityDT";
            this.activityDTDataGridViewTextBoxColumn.HeaderText = "activityDT";
            this.activityDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityDTDataGridViewTextBoxColumn.Name = "activityDTDataGridViewTextBoxColumn";
            this.activityDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // targetUserIDDataGridViewTextBoxColumn
            // 
            this.targetUserIDDataGridViewTextBoxColumn.DataPropertyName = "targetUserID";
            this.targetUserIDDataGridViewTextBoxColumn.HeaderText = "targetUserID";
            this.targetUserIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.targetUserIDDataGridViewTextBoxColumn.Name = "targetUserIDDataGridViewTextBoxColumn";
            this.targetUserIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // targetDiscountIDDataGridViewTextBoxColumn
            // 
            this.targetDiscountIDDataGridViewTextBoxColumn.DataPropertyName = "targetDiscountID";
            this.targetDiscountIDDataGridViewTextBoxColumn.HeaderText = "targetDiscountID";
            this.targetDiscountIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.targetDiscountIDDataGridViewTextBoxColumn.Name = "targetDiscountIDDataGridViewTextBoxColumn";
            this.targetDiscountIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdminActivityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminActivityLog";
            this.Text = "AdminActivityLog";
            this.Load += new System.EventHandler(this.AdminActivityLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityLogDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private GMSDataSet2 gMSDataSet2;
        private System.Windows.Forms.BindingSource activityLogDBBindingSource;
        private GMSDataSet2TableAdapters.activityLogDBTableAdapter activityLogDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityLogIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doneByUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDiscountIDDataGridViewTextBoxColumn;
    }
}