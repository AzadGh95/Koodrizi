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
            this.GridIdBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDahanBast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridOnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPercentRoyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSaledate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDateDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridAdl = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fadateTimeDueDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.fadateTimeSell = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFinalKood)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره کودریزی";
            // 
            // txtKoodNumber
            // 
            this.txtKoodNumber.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoodNumber.Location = new System.Drawing.Point(554, 27);
            this.txtKoodNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoodNumber.Name = "txtKoodNumber";
            this.txtKoodNumber.Size = new System.Drawing.Size(84, 26);
            this.txtKoodNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کودریزی";
            // 
            // txtKoodName
            // 
            this.txtKoodName.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKoodName.Location = new System.Drawing.Point(747, 27);
            this.txtKoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKoodName.Name = "txtKoodName";
            this.txtKoodName.Size = new System.Drawing.Size(84, 26);
            this.txtKoodName.TabIndex = 1;
            this.txtKoodName.TextChanged += new System.EventHandler(this.TxtKoodName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(832, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "قیمت پایه";
            // 
            // txPriceperkilo
            // 
            this.txPriceperkilo.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPriceperkilo.Location = new System.Drawing.Point(747, 79);
            this.txPriceperkilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txPriceperkilo.Name = "txPriceperkilo";
            this.txPriceperkilo.Size = new System.Drawing.Size(84, 26);
            this.txPriceperkilo.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 29);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 75);
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
            this.GridIdBar,
            this.GridCustomer,
            this.GridDahanBast,
            this.GridWeight,
            this.GridOnc,
            this.GridPercentRoyat,
            this.GridSaledate,
            this.GridDateDue,
            this.GridAdl,
            this.gridElementPrice,
            this.GridTotalPrice});
            this.dataGridFinalKood.Location = new System.Drawing.Point(22, 136);
            this.dataGridFinalKood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridFinalKood.Name = "dataGridFinalKood";
            this.dataGridFinalKood.ReadOnly = true;
            this.dataGridFinalKood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridFinalKood.Size = new System.Drawing.Size(872, 219);
            this.dataGridFinalKood.TabIndex = 10;
            this.dataGridFinalKood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // GridIdBar
            // 
            this.GridIdBar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GridIdBar.HeaderText = "شماره بار";
            this.GridIdBar.Name = "GridIdBar";
            this.GridIdBar.ReadOnly = true;
            this.GridIdBar.Width = 73;
            // 
            // GridCustomer
            // 
            this.GridCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GridCustomer.HeaderText = "مشتری";
            this.GridCustomer.Name = "GridCustomer";
            this.GridCustomer.ReadOnly = true;
            // 
            // GridDahanBast
            // 
            this.GridDahanBast.HeaderText = "دهن بست";
            this.GridDahanBast.Name = "GridDahanBast";
            this.GridDahanBast.ReadOnly = true;
            // 
            // GridWeight
            // 
            this.GridWeight.HeaderText = "وزن";
            this.GridWeight.Name = "GridWeight";
            this.GridWeight.ReadOnly = true;
            // 
            // GridOnc
            // 
            this.GridOnc.HeaderText = "انس";
            this.GridOnc.Name = "GridOnc";
            this.GridOnc.ReadOnly = true;
            this.GridOnc.Width = 50;
            // 
            // GridPercentRoyat
            // 
            this.GridPercentRoyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GridPercentRoyat.HeaderText = "درصد رویت";
            this.GridPercentRoyat.Name = "GridPercentRoyat";
            this.GridPercentRoyat.ReadOnly = true;
            this.GridPercentRoyat.Width = 83;
            // 
            // GridSaledate
            // 
            this.GridSaledate.HeaderText = "تاریخ فروش";
            this.GridSaledate.Name = "GridSaledate";
            this.GridSaledate.ReadOnly = true;
            this.GridSaledate.Visible = false;
            // 
            // GridDateDue
            // 
            this.GridDateDue.HeaderText = "تاریخ سررسید";
            this.GridDateDue.Name = "GridDateDue";
            this.GridDateDue.ReadOnly = true;
            this.GridDateDue.Visible = false;
            // 
            // GridAdl
            // 
            this.GridAdl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GridAdl.HeaderText = "عدل";
            this.GridAdl.Name = "GridAdl";
            this.GridAdl.ReadOnly = true;
            this.GridAdl.Width = 54;
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
            this.label5.Location = new System.Drawing.Point(503, 454);
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
            this.btnSave.Location = new System.Drawing.Point(104, 446);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(23, 446);
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
            this.label6.Location = new System.Drawing.Point(225, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "تاریخ کودریزی نهایی";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(402, 454);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPrice.Size = new System.Drawing.Size(39, 19);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "00000";
            // 
            // faDateKoodFinal
            // 
            this.faDateKoodFinal.IsNull = false;
            this.faDateKoodFinal.Location = new System.Drawing.Point(132, 82);
            this.faDateKoodFinal.Name = "faDateKoodFinal";
            this.faDateKoodFinal.SelectedDateTime = new System.DateTime(2020, 12, 24, 0, 0, 0, 0);
            this.faDateKoodFinal.Size = new System.Drawing.Size(91, 20);
            this.faDateKoodFinal.TabIndex = 30;
            this.faDateKoodFinal.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // btnCalculateKood
            // 
            this.btnCalculateKood.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateKood.Location = new System.Drawing.Point(210, 372);
            this.btnCalculateKood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculateKood.Name = "btnCalculateKood";
            this.btnCalculateKood.Size = new System.Drawing.Size(684, 34);
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
            this.txtOuncePrice.Location = new System.Drawing.Point(554, 79);
            this.txtOuncePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOuncePrice.Name = "txtOuncePrice";
            this.txtOuncePrice.Size = new System.Drawing.Size(84, 26);
            this.txtOuncePrice.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(641, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "قیمت انس";
            // 
            // txtDahanBastprice
            // 
            this.txtDahanBastprice.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDahanBastprice.Location = new System.Drawing.Point(346, 79);
            this.txtDahanBastprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDahanBastprice.Name = "txtDahanBastprice";
            this.txtDahanBastprice.Size = new System.Drawing.Size(91, 26);
            this.txtDahanBastprice.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "قیمت دهن بست";
            // 
            // lblTtalOunce
            // 
            this.lblTtalOunce.AutoSize = true;
            this.lblTtalOunce.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtalOunce.Location = new System.Drawing.Point(786, 454);
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
            this.label7.Location = new System.Drawing.Point(847, 454);
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
            this.lblTotalWeight.Location = new System.Drawing.Point(614, 454);
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
            this.label10.Location = new System.Drawing.Point(687, 454);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "وزن کل :";
            // 
            // fadateTimeDueDate
            // 
            this.fadateTimeDueDate.IsNull = false;
            this.fadateTimeDueDate.Location = new System.Drawing.Point(132, 30);
            this.fadateTimeDueDate.Name = "fadateTimeDueDate";
            this.fadateTimeDueDate.SelectedDateTime = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.fadateTimeDueDate.Size = new System.Drawing.Size(109, 20);
            this.fadateTimeDueDate.TabIndex = 36;
            this.fadateTimeDueDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // fadateTimeSell
            // 
            this.fadateTimeSell.IsNull = false;
            this.fadateTimeSell.Location = new System.Drawing.Point(346, 30);
            this.fadateTimeSell.Name = "fadateTimeSell";
            this.fadateTimeSell.SelectedDateTime = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.fadateTimeSell.Size = new System.Drawing.Size(91, 20);
            this.fadateTimeSell.TabIndex = 35;
            this.fadateTimeSell.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(256, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "تاریخ سررسید";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(457, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 33;
            this.label11.Text = "تاریخ فروش";
            // 
            // FinallKoodrizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 503);
            this.Controls.Add(this.fadateTimeDueDate);
            this.Controls.Add(this.fadateTimeSell);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
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
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label label10;
        private FarsiLibrary.Win.Controls.FADatePicker fadateTimeDueDate;
        private FarsiLibrary.Win.Controls.FADatePicker fadateTimeSell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridIdBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDahanBast;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridOnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPercentRoyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSaledate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDateDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridAdl;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridElementPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridTotalPrice;
    }
}