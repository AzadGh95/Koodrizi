﻿namespace WindowsFormsApp_Koodrizi
{
    partial class DetailFinalKoodrizi
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
            this.dataGridDetailKoods = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOunce = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dahanbast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailKoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDetailKoods
            // 
            this.dataGridDetailKoods.AllowUserToAddRows = false;
            this.dataGridDetailKoods.AllowUserToDeleteRows = false;
            this.dataGridDetailKoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailKoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dahanbast,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridDetailKoods.Location = new System.Drawing.Point(12, 22);
            this.dataGridDetailKoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridDetailKoods.Name = "dataGridDetailKoods";
            this.dataGridDetailKoods.ReadOnly = true;
            this.dataGridDetailKoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridDetailKoods.Size = new System.Drawing.Size(705, 380);
            this.dataGridDetailKoods.TabIndex = 2;
            this.dataGridDetailKoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDetailKoods_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "انس پایه";
            // 
            // lblOunce
            // 
            this.lblOunce.AutoSize = true;
            this.lblOunce.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOunce.Location = new System.Drawing.Point(627, 423);
            this.lblOunce.Name = "lblOunce";
            this.lblOunce.Size = new System.Drawing.Size(21, 19);
            this.lblOunce.TabIndex = 6;
            this.lblOunce.Text = "----";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(495, 423);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(21, 19);
            this.lblBasePrice.TabIndex = 8;
            this.lblBasePrice.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "قیمت پایه";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(212, 423);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(21, 19);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "قیمت کل";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(368, 423);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(21, 19);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "----";
            this.lblWeight.Click += new System.EventHandler(this.LblWeight_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "وزن";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "بستن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(93, 451);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "مشتری";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dahanbast
            // 
            this.dahanbast.HeaderText = "دهن بست";
            this.dahanbast.Name = "dahanbast";
            this.dahanbast.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "انس";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "وزن";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "قیمت هر کیلو";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "قیمت کل";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DetailFinalKoodrizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 510);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOunce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridDetailKoods);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailFinalKoodrizi";
            this.Text = "نمایش جزئیات هر کودریزی";
            this.Load += new System.EventHandler(this.DetailFinalKoodrizi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailKoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridDetailKoods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOunce;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dahanbast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}