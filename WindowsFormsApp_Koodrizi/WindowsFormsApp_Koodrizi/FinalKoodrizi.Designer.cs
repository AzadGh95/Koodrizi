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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKoodNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKoodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPriceperkilo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridFinalKood = new System.Windows.Forms.DataGridView();
            this.IdBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Onc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentRoyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saledate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridElementPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.faDateKoodFinal = new FarsiLibrary.Win.Controls.FADatePicker();
            this.btnCalculateKood = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOuncePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDahanBastprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTtalOunce = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFinalKood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره کودریزی";
            // 
            // txtKoodNumber
            // 
            this.txtKoodNumber.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoodNumber.Location = new System.Drawing.Point(342, 33);
            this.txtKoodNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoodNumber.Name = "txtKoodNumber";
            this.txtKoodNumber.Size = new System.Drawing.Size(118, 26);
            this.txtKoodNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(779, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کودریزی";
            // 
            // txtKoodName
            // 
            this.txtKoodName.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoodName.Location = new System.Drawing.Point(656, 33);
            this.txtKoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoodName.Name = "txtKoodName";
            this.txtKoodName.Size = new System.Drawing.Size(114, 26);
            this.txtKoodName.TabIndex = 1;
            this.txtKoodName.TextChanged += new System.EventHandler(this.TxtKoodName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "قیمت پایه";
            // 
            // txPriceperkilo
            // 
            this.txPriceperkilo.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPriceperkilo.Location = new System.Drawing.Point(656, 79);
            this.txPriceperkilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txPriceperkilo.Name = "txPriceperkilo";
            this.txPriceperkilo.Size = new System.Drawing.Size(114, 26);
            this.txPriceperkilo.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 79);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 27);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "افزودن جزئیات کودریزی";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridFinalKood
            // 
            this.dataGridFinalKood.AllowUserToAddRows = false;
            this.dataGridFinalKood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFinalKood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBar,
            this.Customer,
            this.Weight,
            this.Onc,
            this.PercentRoyat,
            this.Saledate,
            this.DateDue,
            this.adl,
            this.gridElementPrice,
            this.GridTotalPrice});
            this.dataGridFinalKood.Location = new System.Drawing.Point(22, 136);
            this.dataGridFinalKood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridFinalKood.Name = "dataGridFinalKood";
            this.dataGridFinalKood.ReadOnly = true;
            this.dataGridFinalKood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridFinalKood.Size = new System.Drawing.Size(826, 219);
            this.dataGridFinalKood.TabIndex = 10;
            this.dataGridFinalKood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // IdBar
            // 
            this.IdBar.HeaderText = "شماره بار";
            this.IdBar.Name = "IdBar";
            this.IdBar.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.HeaderText = "مشتری";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "وزن";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // Onc
            // 
            this.Onc.HeaderText = "انس";
            this.Onc.Name = "Onc";
            this.Onc.ReadOnly = true;
            this.Onc.Width = 50;
            // 
            // PercentRoyat
            // 
            this.PercentRoyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PercentRoyat.HeaderText = "درصد رویت";
            this.PercentRoyat.Name = "PercentRoyat";
            this.PercentRoyat.ReadOnly = true;
            this.PercentRoyat.Width = 83;
            // 
            // Saledate
            // 
            this.Saledate.HeaderText = "تاریخ فروش";
            this.Saledate.Name = "Saledate";
            this.Saledate.ReadOnly = true;
            this.Saledate.Visible = false;
            // 
            // DateDue
            // 
            this.DateDue.HeaderText = "تاریخ سررسید";
            this.DateDue.Name = "DateDue";
            this.DateDue.ReadOnly = true;
            this.DateDue.Visible = false;
            // 
            // adl
            // 
            this.adl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.adl.HeaderText = "عدل";
            this.adl.Name = "adl";
            this.adl.ReadOnly = true;
            this.adl.Width = 54;
            // 
            // gridElementPrice
            // 
            this.gridElementPrice.HeaderText = "قیمت هرکیلو";
            this.gridElementPrice.Name = "gridElementPrice";
            this.gridElementPrice.ReadOnly = true;
            // 
            // GridTotalPrice
            // 
            this.GridTotalPrice.HeaderText = "قیمت کل بار";
            this.GridTotalPrice.Name = "GridTotalPrice";
            this.GridTotalPrice.ReadOnly = true;
            this.GridTotalPrice.Width = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 474);
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
            this.btnSave.Location = new System.Drawing.Point(103, 476);
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
            this.btnCancel.Location = new System.Drawing.Point(22, 476);
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
            this.label6.Location = new System.Drawing.Point(140, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "تاریخ کودریزی نهایی";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(734, 474);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPrice.Size = new System.Drawing.Size(39, 19);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "00000";
            // 
            // faDateKoodFinal
            // 
            this.faDateKoodFinal.IsNull = false;
            this.faDateKoodFinal.Location = new System.Drawing.Point(25, 36);
            this.faDateKoodFinal.Name = "faDateKoodFinal";
            this.faDateKoodFinal.SelectedDateTime = new System.DateTime(2020, 12, 24, 0, 0, 0, 0);
            this.faDateKoodFinal.Size = new System.Drawing.Size(112, 20);
            this.faDateKoodFinal.TabIndex = 30;
            this.faDateKoodFinal.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // btnCalculateKood
            // 
            this.btnCalculateKood.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateKood.Location = new System.Drawing.Point(210, 372);
            this.btnCalculateKood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculateKood.Name = "btnCalculateKood";
            this.btnCalculateKood.Size = new System.Drawing.Size(638, 34);
            this.btnCalculateKood.TabIndex = 11;
            this.btnCalculateKood.Text = "محاسبه کودریزی";
            this.btnCalculateKood.UseVisualStyleBackColor = true;
            this.btnCalculateKood.Click += new System.EventHandler(this.BtnCalculateKood_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(22, 372);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 34);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "پاک کردن لیست";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtOuncePrice
            // 
            this.txtOuncePrice.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOuncePrice.Location = new System.Drawing.Point(472, 79);
            this.txtOuncePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOuncePrice.Name = "txtOuncePrice";
            this.txtOuncePrice.Size = new System.Drawing.Size(72, 26);
            this.txtOuncePrice.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "قیمت انس";
            // 
            // txtDahanBastprice
            // 
            this.txtDahanBastprice.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDahanBastprice.Location = new System.Drawing.Point(262, 79);
            this.txtDahanBastprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDahanBastprice.Name = "txtDahanBastprice";
            this.txtDahanBastprice.Size = new System.Drawing.Size(72, 26);
            this.txtDahanBastprice.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "قیمت دهن بست";
            // 
            // lblTtalOunce
            // 
            this.lblTtalOunce.AutoSize = true;
            this.lblTtalOunce.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtalOunce.Location = new System.Drawing.Point(734, 433);
            this.lblTtalOunce.Name = "lblTtalOunce";
            this.lblTtalOunce.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTtalOunce.Size = new System.Drawing.Size(39, 19);
            this.lblTtalOunce.TabIndex = 24;
            this.lblTtalOunce.Text = "00000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(795, 433);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "انس کل :";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(574, 433);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalWeight.Size = new System.Drawing.Size(39, 19);
            this.lblTotalWeight.TabIndex = 32;
            this.lblTotalWeight.Text = "00000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(635, 433);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "وزن کل :";
            // 
            // FinallKoodrizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 528);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTtalOunce);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDahanBastprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOuncePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateKood);
            this.Controls.Add(this.faDateKoodFinal);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridFinalKood);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txPriceperkilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKoodNumber);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKoodNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKoodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPriceperkilo;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dataGridFinalKood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalPrice;
        private FarsiLibrary.Win.Controls.FADatePicker faDateKoodFinal;
        private System.Windows.Forms.Button btnCalculateKood;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOuncePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDahanBastprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTtalOunce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Onc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentRoyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saledate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn adl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridElementPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridTotalPrice;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label label10;
    }
}