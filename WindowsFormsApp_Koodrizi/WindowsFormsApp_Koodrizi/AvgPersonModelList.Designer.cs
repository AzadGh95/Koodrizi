namespace WindowsFormsApp_Koodrizi
{
    partial class AvgPersonModelList
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
            this.dataGridViewAvg = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNewAvg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvg
            // 
            this.dataGridViewAvg.AllowUserToAddRows = false;
            this.dataGridViewAvg.AllowUserToDeleteRows = false;
            this.dataGridViewAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvg.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewAvg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewAvg.Name = "dataGridViewAvg";
            this.dataGridViewAvg.ReadOnly = true;
            this.dataGridViewAvg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewAvg.Size = new System.Drawing.Size(776, 315);
            this.dataGridViewAvg.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "چاپ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNewAvg
            // 
            this.btnNewAvg.Location = new System.Drawing.Point(129, 12);
            this.btnNewAvg.Name = "btnNewAvg";
            this.btnNewAvg.Size = new System.Drawing.Size(161, 27);
            this.btnNewAvg.TabIndex = 3;
            this.btnNewAvg.Text = "افزودن راس گیری جدید";
            this.btnNewAvg.UseVisualStyleBackColor = true;
            this.btnNewAvg.Click += new System.EventHandler(this.BtnNewAvg_Click);
            // 
            // AvgPersonModelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.btnNewAvg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewAvg);
            this.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AvgPersonModelList";
            this.Text = "لیست راس های کودریزی شده";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNewAvg;
    }
}