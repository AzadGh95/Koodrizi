namespace WindowsFormsApp_Koodrizi
{
    partial class Bar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bar));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comCustomerSelection = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.radioKhandan = new System.Windows.Forms.RadioButton();
            this.radioDahanBast = new System.Windows.Forms.RadioButton();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.txtOunce = new System.Windows.Forms.TextBox();
            this.txtAdl = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.faDataTimeCreateDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "وزن بار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "درصد دهن بست";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "گرم مغز";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "انس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "عدل";
            // 
            // comCustomerSelection
            // 
            this.comCustomerSelection.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comCustomerSelection.FormattingEnabled = true;
            this.comCustomerSelection.Location = new System.Drawing.Point(481, 38);
            this.comCustomerSelection.Name = "comCustomerSelection";
            this.comCustomerSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comCustomerSelection.Size = new System.Drawing.Size(163, 27);
            this.comCustomerSelection.TabIndex = 1;
            this.comCustomerSelection.Text = "انتخاب مشتری";
            this.comCustomerSelection.SelectedIndexChanged += new System.EventHandler(this.ComCustomerSelection_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(36, 38);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(121, 26);
            this.txtWeight.TabIndex = 2;
            // 
            // radioKhandan
            // 
            this.radioKhandan.AutoSize = true;
            this.radioKhandan.Checked = true;
            this.radioKhandan.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKhandan.Location = new System.Drawing.Point(585, 101);
            this.radioKhandan.Name = "radioKhandan";
            this.radioKhandan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioKhandan.Size = new System.Drawing.Size(55, 23);
            this.radioKhandan.TabIndex = 9;
            this.radioKhandan.TabStop = true;
            this.radioKhandan.Text = "خندان";
            this.radioKhandan.UseVisualStyleBackColor = true;
            this.radioKhandan.CheckedChanged += new System.EventHandler(this.RadioKhandan_CheckedChanged);
            // 
            // radioDahanBast
            // 
            this.radioDahanBast.AutoSize = true;
            this.radioDahanBast.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDahanBast.Location = new System.Drawing.Point(508, 101);
            this.radioDahanBast.Name = "radioDahanBast";
            this.radioDahanBast.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioDahanBast.Size = new System.Drawing.Size(73, 23);
            this.radioDahanBast.TabIndex = 10;
            this.radioDahanBast.Text = "دهن بست";
            this.radioDahanBast.UseVisualStyleBackColor = true;
            this.radioDahanBast.CheckedChanged += new System.EventHandler(this.RadioDahanBast_CheckedChanged);
            // 
            // txtPercent
            // 
            this.txtPercent.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(241, 100);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(132, 26);
            this.txtPercent.TabIndex = 3;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(36, 100);
            this.comboType.Name = "comboType";
            this.comboType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboType.Size = new System.Drawing.Size(121, 27);
            this.comboType.TabIndex = 4;
            this.comboType.Text = "نوع پسته";
            // 
            // txtGrams
            // 
            this.txtGrams.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrams.Location = new System.Drawing.Point(482, 166);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(119, 26);
            this.txtGrams.TabIndex = 5;
            // 
            // txtOunce
            // 
            this.txtOunce.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOunce.Location = new System.Drawing.Point(241, 166);
            this.txtOunce.Name = "txtOunce";
            this.txtOunce.Size = new System.Drawing.Size(132, 26);
            this.txtOunce.TabIndex = 6;
            // 
            // txtAdl
            // 
            this.txtAdl.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdl.Location = new System.Drawing.Point(36, 166);
            this.txtAdl.Name = "txtAdl";
            this.txtAdl.Size = new System.Drawing.Size(121, 26);
            this.txtAdl.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(117, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(36, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "تاریخ ورود";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(164, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "نوع پسته";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // faDataTimeCreateDate
            // 
            this.faDataTimeCreateDate.IsNull = false;
            this.faDataTimeCreateDate.Location = new System.Drawing.Point(241, 40);
            this.faDataTimeCreateDate.Name = "faDataTimeCreateDate";
            this.faDataTimeCreateDate.SelectedDateTime = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.faDataTimeCreateDate.Size = new System.Drawing.Size(132, 20);
            this.faDataTimeCreateDate.TabIndex = 30;
            this.faDataTimeCreateDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faDataTimeCreateDate.SelectedDateTimeChanged += new System.EventHandler(this.FaDataTimeCreateDate_SelectedDateTimeChanged);
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 288);
            this.Controls.Add(this.faDataTimeCreateDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdl);
            this.Controls.Add(this.txtOunce);
            this.Controls.Add(this.txtGrams);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.radioDahanBast);
            this.Controls.Add(this.radioKhandan);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.comCustomerSelection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bar";
            this.Text = "دفترورودی";
            this.Load += new System.EventHandler(this.Bar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comCustomerSelection;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.RadioButton radioKhandan;
        private System.Windows.Forms.RadioButton radioDahanBast;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.TextBox txtOunce;
        private System.Windows.Forms.TextBox txtAdl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private FarsiLibrary.Win.Controls.FADatePicker faDataTimeCreateDate;
    }
}