﻿namespace WindowsFormsApp_Koodrizi
{
    partial class ListBars
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
            this.dataGridListBars = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DahanBast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ounce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditBar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShwKhandan = new System.Windows.Forms.Button();
            this.btnShowDahanBast = new System.Windows.Forms.Button();
            this.btnPrintDahanBast = new System.Windows.Forms.Button();
            this.btnPrintKhandan = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListBars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListBars
            // 
            this.dataGridListBars.AllowUserToAddRows = false;
            this.dataGridListBars.AllowUserToDeleteRows = false;
            this.dataGridListBars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListBars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row,
            this.Customer,
            this.DateEnter,
            this.Reminig,
            this.weightBar,
            this.DahanBast,
            this.Gram,
            this.Ounce,
            this.Adl,
            this.btnDelete,
            this.EditBar});
            this.dataGridListBars.Location = new System.Drawing.Point(12, 58);
            this.dataGridListBars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridListBars.Name = "dataGridListBars";
            this.dataGridListBars.ReadOnly = true;
            this.dataGridListBars.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridListBars.Size = new System.Drawing.Size(1003, 345);
            this.dataGridListBars.TabIndex = 0;
            this.dataGridListBars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListBars_CellContentClick);
            // 
            // row
            // 
            this.row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.row.HeaderText = "ردیف";
            this.row.Name = "row";
            this.row.ReadOnly = true;
            this.row.Visible = false;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.HeaderText = "مشتری";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // DateEnter
            // 
            this.DateEnter.HeaderText = "تاریخ ورود";
            this.DateEnter.Name = "DateEnter";
            this.DateEnter.ReadOnly = true;
            // 
            // Reminig
            // 
            this.Reminig.HeaderText = "موجودی";
            this.Reminig.Name = "Reminig";
            this.Reminig.ReadOnly = true;
            // 
            // weightBar
            // 
            this.weightBar.HeaderText = "وزن بار";
            this.weightBar.Name = "weightBar";
            this.weightBar.ReadOnly = true;
            // 
            // DahanBast
            // 
            this.DahanBast.HeaderText = "درصد دهن بست";
            this.DahanBast.Name = "DahanBast";
            this.DahanBast.ReadOnly = true;
            // 
            // Gram
            // 
            this.Gram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gram.HeaderText = "گرم";
            this.Gram.Name = "Gram";
            this.Gram.ReadOnly = true;
            this.Gram.Width = 50;
            // 
            // Ounce
            // 
            this.Ounce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ounce.HeaderText = "انس";
            this.Ounce.Name = "Ounce";
            this.Ounce.ReadOnly = true;
            this.Ounce.Width = 54;
            // 
            // Adl
            // 
            this.Adl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Adl.HeaderText = "عدل";
            this.Adl.Name = "Adl";
            this.Adl.ReadOnly = true;
            this.Adl.Width = 54;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnDelete.HeaderText = "حذف";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Width = 57;
            // 
            // EditBar
            // 
            this.EditBar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EditBar.HeaderText = "ویرایش";
            this.EditBar.Name = "EditBar";
            this.EditBar.ReadOnly = true;
            this.EditBar.Width = 49;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(940, 12);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 32);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "همه";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // btnShwKhandan
            // 
            this.btnShwKhandan.Location = new System.Drawing.Point(859, 12);
            this.btnShwKhandan.Name = "btnShwKhandan";
            this.btnShwKhandan.Size = new System.Drawing.Size(75, 32);
            this.btnShwKhandan.TabIndex = 2;
            this.btnShwKhandan.Text = "خندان";
            this.btnShwKhandan.UseVisualStyleBackColor = true;
            this.btnShwKhandan.Click += new System.EventHandler(this.BtnShwKhandan_Click);
            // 
            // btnShowDahanBast
            // 
            this.btnShowDahanBast.Location = new System.Drawing.Point(778, 12);
            this.btnShowDahanBast.Name = "btnShowDahanBast";
            this.btnShowDahanBast.Size = new System.Drawing.Size(75, 32);
            this.btnShowDahanBast.TabIndex = 3;
            this.btnShowDahanBast.Text = "دهن بست";
            this.btnShowDahanBast.UseVisualStyleBackColor = true;
            this.btnShowDahanBast.Click += new System.EventHandler(this.BtnShowDahanBast_Click);
            // 
            // btnPrintDahanBast
            // 
            this.btnPrintDahanBast.Location = new System.Drawing.Point(12, 12);
            this.btnPrintDahanBast.Name = "btnPrintDahanBast";
            this.btnPrintDahanBast.Size = new System.Drawing.Size(113, 32);
            this.btnPrintDahanBast.TabIndex = 6;
            this.btnPrintDahanBast.Text = "چاپ دهن بست ها";
            this.btnPrintDahanBast.UseVisualStyleBackColor = true;
            this.btnPrintDahanBast.Click += new System.EventHandler(this.BtnPrintDahanBast_Click);
            // 
            // btnPrintKhandan
            // 
            this.btnPrintKhandan.Location = new System.Drawing.Point(131, 12);
            this.btnPrintKhandan.Name = "btnPrintKhandan";
            this.btnPrintKhandan.Size = new System.Drawing.Size(97, 32);
            this.btnPrintKhandan.TabIndex = 5;
            this.btnPrintKhandan.Text = "چاپ خندان ها";
            this.btnPrintKhandan.UseVisualStyleBackColor = true;
            this.btnPrintKhandan.Click += new System.EventHandler(this.BtnPrintKhandan_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(234, 12);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(75, 32);
            this.btnPrintAll.TabIndex = 4;
            this.btnPrintAll.Text = "چاپ همه";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.BtnPrintAll_Click);
            // 
            // ListBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 417);
            this.Controls.Add(this.btnPrintDahanBast);
            this.Controls.Add(this.btnPrintKhandan);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnShowDahanBast);
            this.Controls.Add(this.btnShwKhandan);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridListBars);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListBars";
            this.Text = "لیست بار های مشتریان";
            this.Load += new System.EventHandler(this.ListBars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListBars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListBars;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reminig;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DahanBast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ounce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adl;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn EditBar;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShwKhandan;
        private System.Windows.Forms.Button btnShowDahanBast;
        private System.Windows.Forms.Button btnPrintDahanBast;
        private System.Windows.Forms.Button btnPrintKhandan;
        private System.Windows.Forms.Button btnPrintAll;
    }
}