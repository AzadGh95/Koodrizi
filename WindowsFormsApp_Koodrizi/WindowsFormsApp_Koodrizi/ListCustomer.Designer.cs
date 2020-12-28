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
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedehi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
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
            this.avgdate});
            this.dataGridListCustomer.Location = new System.Drawing.Point(12, 73);
            this.dataGridListCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridListCustomer.Name = "dataGridListCustomer";
            this.dataGridListCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridListCustomer.Size = new System.Drawing.Size(555, 454);
            this.dataGridListCustomer.TabIndex = 0;
            this.dataGridListCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListCustomer_CellContentClick);
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
            this.name.HeaderText = "نام و نام خانوادگی";
            this.name.Name = "name";
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
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(12, 18);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(117, 28);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "جستجو";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(135, 19);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(432, 26);
            this.txtSearchCustomer.TabIndex = 2;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 664);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.dataGridListCustomer);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListCustomer";
            this.Text = "لیست مشتریان";
            this.Load += new System.EventHandler(this.ListCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgdate;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
    }
}