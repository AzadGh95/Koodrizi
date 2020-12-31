namespace WindowsFormsApp_Koodrizi
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
            this.comboFinalKoods = new System.Windows.Forms.ComboBox();
            this.btnShowListDetailKood = new System.Windows.Forms.Button();
            this.dataGridDetailKoods = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailKoods)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFinalKoods
            // 
            this.comboFinalKoods.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFinalKoods.FormattingEnabled = true;
            this.comboFinalKoods.Location = new System.Drawing.Point(133, 23);
            this.comboFinalKoods.Name = "comboFinalKoods";
            this.comboFinalKoods.Size = new System.Drawing.Size(393, 27);
            this.comboFinalKoods.TabIndex = 0;
            // 
            // btnShowListDetailKood
            // 
            this.btnShowListDetailKood.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowListDetailKood.Location = new System.Drawing.Point(12, 23);
            this.btnShowListDetailKood.Name = "btnShowListDetailKood";
            this.btnShowListDetailKood.Size = new System.Drawing.Size(115, 27);
            this.btnShowListDetailKood.TabIndex = 1;
            this.btnShowListDetailKood.Text = "نمایش جزئیات";
            this.btnShowListDetailKood.UseVisualStyleBackColor = true;
            // 
            // dataGridDetailKoods
            // 
            this.dataGridDetailKoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailKoods.Location = new System.Drawing.Point(12, 70);
            this.dataGridDetailKoods.Name = "dataGridDetailKoods";
            this.dataGridDetailKoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridDetailKoods.Size = new System.Drawing.Size(514, 260);
            this.dataGridDetailKoods.TabIndex = 2;
            // 
            // DetailFinalKoodrizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 359);
            this.Controls.Add(this.dataGridDetailKoods);
            this.Controls.Add(this.btnShowListDetailKood);
            this.Controls.Add(this.comboFinalKoods);
            this.Name = "DetailFinalKoodrizi";
            this.Text = "نمایش جزئیات هر کودریزی";
            this.Load += new System.EventHandler(this.DetailFinalKoodrizi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailKoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFinalKoods;
        private System.Windows.Forms.Button btnShowListDetailKood;
        private System.Windows.Forms.DataGridView dataGridDetailKoods;
    }
}