namespace WindowsFormsApp_Koodrizi
{
    partial class FinallKoodrizi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinallKoodrizi));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKoodNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKoodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPriceperkilo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKoodOnc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridFinalKood = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Onc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentRoyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saledate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFinalKood)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره کودریزی";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtKoodNumber
            // 
            this.txtKoodNumber.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoodNumber.Location = new System.Drawing.Point(271, 31);
            this.txtKoodNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoodNumber.Name = "txtKoodNumber";
            this.txtKoodNumber.Size = new System.Drawing.Size(118, 26);
            this.txtKoodNumber.TabIndex = 2;
            this.txtKoodNumber.TextChanged += new System.EventHandler(this.TxtKoodNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کودریزی";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtKoodName
            // 
            this.txtKoodName.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoodName.Location = new System.Drawing.Point(497, 31);
            this.txtKoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoodName.Name = "txtKoodName";
            this.txtKoodName.Size = new System.Drawing.Size(114, 26);
            this.txtKoodName.TabIndex = 4;
            this.txtKoodName.TextChanged += new System.EventHandler(this.TxtKoodName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "قیمت هر کیلو";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txPriceperkilo
            // 
            this.txPriceperkilo.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPriceperkilo.Location = new System.Drawing.Point(497, 96);
            this.txPriceperkilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txPriceperkilo.Name = "txPriceperkilo";
            this.txPriceperkilo.Size = new System.Drawing.Size(114, 26);
            this.txPriceperkilo.TabIndex = 6;
            this.txPriceperkilo.TextChanged += new System.EventHandler(this.TxPriceperkilo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "انس کودریزی";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtKoodOnc
            // 
            this.txtKoodOnc.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoodOnc.Location = new System.Drawing.Point(271, 91);
            this.txtKoodOnc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoodOnc.Name = "txtKoodOnc";
            this.txtKoodOnc.Size = new System.Drawing.Size(118, 26);
            this.txtKoodOnc.TabIndex = 8;
            this.txtKoodOnc.TextChanged += new System.EventHandler(this.TxtKoodOnc_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 92);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "افزودن جزئیات کودریزی";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridFinalKood
            // 
            this.dataGridFinalKood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFinalKood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.Weight,
            this.Onc,
            this.PercentRoyat,
            this.Saledate,
            this.DateDue});
            this.dataGridFinalKood.Location = new System.Drawing.Point(22, 161);
            this.dataGridFinalKood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridFinalKood.Name = "dataGridFinalKood";
            this.dataGridFinalKood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridFinalKood.Size = new System.Drawing.Size(663, 219);
            this.dataGridFinalKood.TabIndex = 10;
            this.dataGridFinalKood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 438);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "جمع کل :";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(103, 433);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(22, 433);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "تاریخ کودریزی نهایی";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 438);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "00000";
            // 
            // Customer
            // 
            this.Customer.HeaderText = "مشتری";
            this.Customer.Name = "Customer";
            this.Customer.Width = 150;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "وزن";
            this.Weight.Name = "Weight";
            // 
            // Onc
            // 
            this.Onc.HeaderText = "انس";
            this.Onc.Name = "Onc";
            this.Onc.Width = 50;
            // 
            // PercentRoyat
            // 
            this.PercentRoyat.HeaderText = "درصد رویت";
            this.PercentRoyat.Name = "PercentRoyat";
            // 
            // Saledate
            // 
            this.Saledate.HeaderText = "تاریخ فروش";
            this.Saledate.Name = "Saledate";
            // 
            // DateDue
            // 
            this.DateDue.HeaderText = "تاریخ سررسید";
            this.DateDue.Name = "DateDue";
            // 
            // FinallKoodrizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 503);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridFinalKood);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtKoodOnc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txPriceperkilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKoodNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FinallKoodrizi";
            this.Text = "کودریزی نهایی";
            this.Load += new System.EventHandler(this.FinallKoodrizi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFinalKood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKoodNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKoodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPriceperkilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKoodOnc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridFinalKood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Onc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentRoyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saledate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDue;
    }
}