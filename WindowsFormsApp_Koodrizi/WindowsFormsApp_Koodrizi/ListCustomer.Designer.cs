namespace WindowsFormsApp_Koodrizi
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
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculateAvg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BarReport = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListCustomer
            // 
            this.dataGridListCustomer.AllowUserToAddRows = false;
            this.dataGridListCustomer.AllowUserToDeleteRows = false;
            this.dataGridListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.code,
            this.name,
            this.bedehi,
            this.Column1,
            this.avgdate,
            this.CalculateAvg,
            this.delete,
            this.editGrid,
            this.BarReport,
            this.Column3});
            this.dataGridListCustomer.Location = new System.Drawing.Point(12, 61);
            this.dataGridListCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridListCustomer.Name = "dataGridListCustomer";
            this.dataGridListCustomer.ReadOnly = true;
            this.dataGridListCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridListCustomer.Size = new System.Drawing.Size(1050, 418);
            this.dataGridListCustomer.TabIndex = 0;
            this.dataGridListCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListCustomer_CellContentClick_1);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(94, 32);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "مشتری جدید";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.BtnNewCustomer_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ای دی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // code
            // 
            this.code.HeaderText = "کدمشتری";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "نام و نام خانوادگی";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // bedehi
            // 
            this.bedehi.HeaderText = "بدهی کل";
            this.bedehi.Name = "bedehi";
            this.bedehi.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "تاریخ مبنا";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // avgdate
            // 
            this.avgdate.HeaderText = " راس تاریخ";
            this.avgdate.Name = "avgdate";
            this.avgdate.ReadOnly = true;
            // 
            // CalculateAvg
            // 
            this.CalculateAvg.HeaderText = "محاسبه راس گیری";
            this.CalculateAvg.Name = "CalculateAvg";
            this.CalculateAvg.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.delete.HeaderText = "حذف";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 38;
            // 
            // editGrid
            // 
            this.editGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.editGrid.HeaderText = "ویرایش";
            this.editGrid.Name = "editGrid";
            this.editGrid.ReadOnly = true;
            this.editGrid.Width = 49;
            // 
            // BarReport
            // 
            this.BarReport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BarReport.HeaderText = "گزارش کودریزی ها";
            this.BarReport.Name = "BarReport";
            this.BarReport.ReadOnly = true;
            this.BarReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BarReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BarReport.Text = null;
            this.BarReport.Width = 115;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "گزارش بارها";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 492);
            this.Controls.Add(this.btnNewCustomer);
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
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgdate;
        private System.Windows.Forms.DataGridViewButtonColumn CalculateAvg;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn editGrid;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewButtonXColumn BarReport;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}