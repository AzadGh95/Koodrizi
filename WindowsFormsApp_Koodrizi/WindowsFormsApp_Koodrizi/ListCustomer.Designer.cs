﻿namespace WindowsFormsApp_Koodrizi
{
    partial class ListCustomer
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
            this.dataGridListCustomer = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListCustomer
            // 
            this.dataGridListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row,
            this.code,
            this.name,
            this.bedehi,
            this.avgdate,
            this.btnDelete});
            this.dataGridListCustomer.Location = new System.Drawing.Point(22, 13);
            this.dataGridListCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridListCustomer.Name = "dataGridListCustomer";
            this.dataGridListCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridListCustomer.Size = new System.Drawing.Size(593, 264);
            this.dataGridListCustomer.TabIndex = 0;
            this.dataGridListCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListCustomer_CellContentClick_1);
            // 
            // row
            // 
            this.row.HeaderText = "ردیف";
            this.row.Name = "row";
            this.row.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "کدمشتری";
            this.code.Name = "code";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "نام و نام خانوادگی";
            this.name.Name = "name";
            this.name.Width = 113;
            // 
            // bedehi
            // 
            this.bedehi.HeaderText = "بدهی کل";
            this.bedehi.Name = "bedehi";
            // 
            // avgdate
            // 
            this.avgdate.HeaderText = " راس تاریخ";
            this.avgdate.Name = "avgdate";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnDelete.HeaderText = "حذف";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Width = 38;
            // 
            // ListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 302);
            this.Controls.Add(this.dataGridListCustomer);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListCustomer";
            this.Text = "لیست مشتریان";
            this.Load += new System.EventHandler(this.ListCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}