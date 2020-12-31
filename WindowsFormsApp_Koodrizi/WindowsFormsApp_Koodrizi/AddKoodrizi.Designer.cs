namespace WindowsFormsApp_Koodrizi
{
    partial class AddKoodrizi
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
            this.DataGridAddKood = new System.Windows.Forms.DataGridView();
            this.txtKoodNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKoodName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GridBarPerson = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GridPercentRoyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSellDate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GridDueDate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GridPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAddKood)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridAddKood
            // 
            this.DataGridAddKood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAddKood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridBarPerson,
            this.GridPercentRoyat,
            this.GridWeight,
            this.GridSellDate,
            this.GridDueDate,
            this.GridPrice,
            this.GridTotalPrice});
            this.DataGridAddKood.Location = new System.Drawing.Point(26, 78);
            this.DataGridAddKood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridAddKood.Name = "DataGridAddKood";
            this.DataGridAddKood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGridAddKood.Size = new System.Drawing.Size(851, 263);
            this.DataGridAddKood.TabIndex = 0;
            // 
            // txtKoodNumber
            // 
            this.txtKoodNumber.Location = new System.Drawing.Point(639, 22);
            this.txtKoodNumber.Name = "txtKoodNumber";
            this.txtKoodNumber.Size = new System.Drawing.Size(100, 26);
            this.txtKoodNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "شماره کودریزی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام کودریزی";
            // 
            // txtKoodName
            // 
            this.txtKoodName.Location = new System.Drawing.Point(358, 22);
            this.txtKoodName.Name = "txtKoodName";
            this.txtKoodName.Size = new System.Drawing.Size(100, 26);
            this.txtKoodName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "لغو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(101, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "انس کودریزی";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(69, 22);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 26);
            this.txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "قیمت کل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "جمع کل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "0000";
            // 
            // GridBarPerson
            // 
            this.GridBarPerson.HeaderText = "بار مشتری";
            this.GridBarPerson.Name = "GridBarPerson";
            this.GridBarPerson.Width = 300;
            // 
            // GridPercentRoyat
            // 
            this.GridPercentRoyat.HeaderText = "درصدرویت";
            this.GridPercentRoyat.Name = "GridPercentRoyat";
            // 
            // GridWeight
            // 
            this.GridWeight.HeaderText = "وزن";
            this.GridWeight.Name = "GridWeight";
            // 
            // GridSellDate
            // 
            this.GridSellDate.HeaderText = "تاریخ فروش";
            this.GridSellDate.Name = "GridSellDate";
            // 
            // GridDueDate
            // 
            this.GridDueDate.HeaderText = "تاریخ سررسید";
            this.GridDueDate.Name = "GridDueDate";
            // 
            // GridPrice
            // 
            this.GridPrice.HeaderText = "قیمت هرکیلو";
            this.GridPrice.Name = "GridPrice";
            this.GridPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GridTotalPrice
            // 
            this.GridTotalPrice.HeaderText = "قیمت کل";
            this.GridTotalPrice.Name = "GridTotalPrice";
            this.GridTotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTotalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddKoodrizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKoodNumber);
            this.Controls.Add(this.DataGridAddKood);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddKoodrizi";
            this.Text = "افزودن کودریزی جدید";
            this.Load += new System.EventHandler(this.AddKoodrizi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAddKood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAddKood;
        private System.Windows.Forms.TextBox txtKoodNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKoodName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewComboBoxColumn GridBarPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPercentRoyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridWeight;
        private System.Windows.Forms.DataGridViewButtonColumn GridSellDate;
        private System.Windows.Forms.DataGridViewButtonColumn GridDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridTotalPrice;
    }
}