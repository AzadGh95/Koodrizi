namespace WindowsFormsApp_Koodrizi
{
    partial class Bar_Edit
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
            this.faDataTimeCreateDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAdl = new System.Windows.Forms.TextBox();
            this.txtOunce = new System.Windows.Forms.TextBox();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.radioDahanBast = new System.Windows.Forms.RadioButton();
            this.radioKhandan = new System.Windows.Forms.RadioButton();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPitachioType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // faDataTimeCreateDate
            // 
            this.faDataTimeCreateDate.IsNull = false;
            this.faDataTimeCreateDate.Location = new System.Drawing.Point(230, 34);
            this.faDataTimeCreateDate.Name = "faDataTimeCreateDate";
            this.faDataTimeCreateDate.SelectedDateTime = new System.DateTime(2021, 1, 4, 0, 0, 0, 0);
            this.faDataTimeCreateDate.Size = new System.Drawing.Size(132, 20);
            this.faDataTimeCreateDate.TabIndex = 49;
            this.faDataTimeCreateDate.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faDataTimeCreateDate.SelectedDateTimeChanged += new System.EventHandler(this.FaDataTimeCreateDate_SelectedDateTimeChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "نوع پسته";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "تاریخ ورود";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(25, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(106, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(256, 30);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "ویرایش";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtAdl
            // 
            this.txtAdl.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdl.Location = new System.Drawing.Point(25, 159);
            this.txtAdl.Name = "txtAdl";
            this.txtAdl.Size = new System.Drawing.Size(121, 26);
            this.txtAdl.TabIndex = 42;
            // 
            // txtOunce
            // 
            this.txtOunce.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOunce.Location = new System.Drawing.Point(230, 159);
            this.txtOunce.Name = "txtOunce";
            this.txtOunce.Size = new System.Drawing.Size(132, 26);
            this.txtOunce.TabIndex = 41;
            // 
            // txtGrams
            // 
            this.txtGrams.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrams.Location = new System.Drawing.Point(471, 159);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(119, 26);
            this.txtGrams.TabIndex = 39;
            // 
            // txtPercent
            // 
            this.txtPercent.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(230, 95);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(132, 26);
            this.txtPercent.TabIndex = 36;
            // 
            // radioDahanBast
            // 
            this.radioDahanBast.AutoSize = true;
            this.radioDahanBast.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDahanBast.Location = new System.Drawing.Point(497, 97);
            this.radioDahanBast.Name = "radioDahanBast";
            this.radioDahanBast.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioDahanBast.Size = new System.Drawing.Size(73, 23);
            this.radioDahanBast.TabIndex = 46;
            this.radioDahanBast.Text = "دهن بست";
            this.radioDahanBast.UseVisualStyleBackColor = true;
            this.radioDahanBast.CheckedChanged += new System.EventHandler(this.RadioDahanBast_CheckedChanged_1);
            // 
            // radioKhandan
            // 
            this.radioKhandan.AutoSize = true;
            this.radioKhandan.Checked = true;
            this.radioKhandan.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKhandan.Location = new System.Drawing.Point(578, 97);
            this.radioKhandan.Name = "radioKhandan";
            this.radioKhandan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioKhandan.Size = new System.Drawing.Size(55, 23);
            this.radioKhandan.TabIndex = 44;
            this.radioKhandan.TabStop = true;
            this.radioKhandan.Text = "خندان";
            this.radioKhandan.UseVisualStyleBackColor = true;
            this.radioKhandan.CheckedChanged += new System.EventHandler(this.RadioKhandan_CheckedChanged_1);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(25, 31);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(121, 26);
            this.txtWeight.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "عدل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "انس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "گرم مغز";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "درصد دهن بست";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "وزن بار";
            // 
            // txtPerson
            // 
            this.txtPerson.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerson.Location = new System.Drawing.Point(471, 31);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPerson.Size = new System.Drawing.Size(119, 26);
            this.txtPerson.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(592, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "مشتری";
            // 
            // txtPitachioType
            // 
            this.txtPitachioType.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPitachioType.Location = new System.Drawing.Point(26, 95);
            this.txtPitachioType.Name = "txtPitachioType";
            this.txtPitachioType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPitachioType.Size = new System.Drawing.Size(121, 26);
            this.txtPitachioType.TabIndex = 52;
            // 
            // Bar_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 297);
            this.Controls.Add(this.txtPitachioType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.faDataTimeCreateDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdl);
            this.Controls.Add(this.txtOunce);
            this.Controls.Add(this.txtGrams);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.radioDahanBast);
            this.Controls.Add(this.radioKhandan);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Bar_Edit";
            this.Text = "ویرایش بار";
            this.Load += new System.EventHandler(this.Bar_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarsiLibrary.Win.Controls.FADatePicker faDataTimeCreateDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAdl;
        private System.Windows.Forms.TextBox txtOunce;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.RadioButton radioDahanBast;
        private System.Windows.Forms.RadioButton radioKhandan;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPitachioType;
    }
}