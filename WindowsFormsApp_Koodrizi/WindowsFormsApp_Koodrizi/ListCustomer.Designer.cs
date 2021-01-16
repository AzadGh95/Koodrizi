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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CalculateAvg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editGrid = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.btnDelete,
            this.CalculateAvg,
            this.editGrid});
            this.dataGridListCustomer.Location = new System.Drawing.Point(14, 12);
            this.dataGridListCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridListCustomer.Name = "dataGridListCustomer";
            this.dataGridListCustomer.ReadOnly = true;
            this.dataGridListCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridListCustomer.Size = new System.Drawing.Size(860, 336);
            this.dataGridListCustomer.TabIndex = 0;
            this.dataGridListCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListCustomer_CellContentClick_1);
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
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnDelete.HeaderText = "حذف";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Visible = false;
            // 
            // CalculateAvg
            // 
            this.CalculateAvg.HeaderText = "محاسبه راس گیری";
            this.CalculateAvg.Name = "CalculateAvg";
            this.CalculateAvg.ReadOnly = true;
            // 
            // editGrid
            // 
            this.editGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.editGrid.HeaderText = "ویرایش";
            this.editGrid.Name = "editGrid";
            this.editGrid.ReadOnly = true;
            this.editGrid.Width = 49;
            // 
            // ListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn CalculateAvg;
        private System.Windows.Forms.DataGridViewButtonColumn editGrid;
    }
}