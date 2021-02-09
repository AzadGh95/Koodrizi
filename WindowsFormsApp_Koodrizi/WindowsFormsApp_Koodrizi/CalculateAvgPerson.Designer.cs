namespace WindowsFormsApp_Koodrizi
{
    partial class CalculateAvgPerson
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboListDetailKoods = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBedehi = new System.Windows.Forms.Label();
            this.lblAvgDate = new System.Windows.Forms.Label();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculateAvg = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.ArrivedDate,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(709, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شماره کودریزی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "نام کودریزی";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ArrivedDate
            // 
            this.ArrivedDate.HeaderText = "ArrivedDate";
            this.ArrivedDate.Name = "ArrivedDate";
            this.ArrivedDate.ReadOnly = true;
            this.ArrivedDate.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "تاریخ سررسید";
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
            this.Column4.HeaderText = "قیمت هرکیلو";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // comboListDetailKoods
            // 
            this.comboListDetailKoods.FormattingEnabled = true;
            this.comboListDetailKoods.Location = new System.Drawing.Point(93, 34);
            this.comboListDetailKoods.Name = "comboListDetailKoods";
            this.comboListDetailKoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboListDetailKoods.Size = new System.Drawing.Size(628, 27);
            this.comboListDetailKoods.TabIndex = 1;
            this.comboListDetailKoods.Text = "کودریزی مورد نظر را انتخاب کنید";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "بدهی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "تاریخ راس";
            // 
            // lblBedehi
            // 
            this.lblBedehi.AutoSize = true;
            this.lblBedehi.Location = new System.Drawing.Point(606, 405);
            this.lblBedehi.Name = "lblBedehi";
            this.lblBedehi.Size = new System.Drawing.Size(21, 19);
            this.lblBedehi.TabIndex = 5;
            this.lblBedehi.Text = "....";
            // 
            // lblAvgDate
            // 
            this.lblAvgDate.AutoSize = true;
            this.lblAvgDate.Location = new System.Drawing.Point(322, 405);
            this.lblAvgDate.Name = "lblAvgDate";
            this.lblAvgDate.Size = new System.Drawing.Size(21, 19);
            this.lblAvgDate.TabIndex = 6;
            this.lblAvgDate.Text = "....";
            this.lblAvgDate.Click += new System.EventHandler(this.LblAvgDate_Click);
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faDatePicker1.Location = new System.Drawing.Point(500, 335);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(154, 20);
            this.faDatePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "تاریخ مبدا";
            // 
            // btnCalculateAvg
            // 
            this.btnCalculateAvg.Location = new System.Drawing.Point(12, 323);
            this.btnCalculateAvg.Name = "btnCalculateAvg";
            this.btnCalculateAvg.Size = new System.Drawing.Size(250, 32);
            this.btnCalculateAvg.TabIndex = 9;
            this.btnCalculateAvg.Text = "محاسبه راس گیری";
            this.btnCalculateAvg.UseVisualStyleBackColor = true;
            this.btnCalculateAvg.Click += new System.EventHandler(this.BtnCalculateAvg_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CalculateAvgPerson
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(733, 464);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalculateAvg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.faDatePicker1);
            this.Controls.Add(this.lblAvgDate);
            this.Controls.Add(this.lblBedehi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboListDetailKoods);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CalculateAvgPerson";
            this.Text = "محاسبه راس گیری";
            this.Load += new System.EventHandler(this.CalculateAvgPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboListDetailKoods;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBedehi;
        private System.Windows.Forms.Label lblAvgDate;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculateAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}