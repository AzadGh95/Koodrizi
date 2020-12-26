namespace WindowsFormsApp_Koodrizi
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnListPerson = new System.Windows.Forms.Button();
            this.btnListBar = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnFinalKoodrizi = new System.Windows.Forms.Button();
            this.btnListKoodrizi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerson
            // 
            this.btnPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPerson.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerson.Location = new System.Drawing.Point(424, 24);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(146, 39);
            this.btnPerson.TabIndex = 0;
            this.btnPerson.Text = "افزودن مشتری";
            this.btnPerson.UseVisualStyleBackColor = false;
            this.btnPerson.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnListPerson
            // 
            this.btnListPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListPerson.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPerson.Location = new System.Drawing.Point(424, 69);
            this.btnListPerson.Name = "btnListPerson";
            this.btnListPerson.Size = new System.Drawing.Size(146, 38);
            this.btnListPerson.TabIndex = 1;
            this.btnListPerson.Text = "لیست تمام مشتری ها";
            this.btnListPerson.UseVisualStyleBackColor = false;
            // 
            // btnListBar
            // 
            this.btnListBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListBar.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBar.Location = new System.Drawing.Point(262, 69);
            this.btnListBar.Name = "btnListBar";
            this.btnListBar.Size = new System.Drawing.Size(146, 38);
            this.btnListBar.TabIndex = 3;
            this.btnListBar.Text = "لیست بارها";
            this.btnListBar.UseVisualStyleBackColor = false;
            // 
            // btnBar
            // 
            this.btnBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBar.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBar.Location = new System.Drawing.Point(262, 24);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(146, 39);
            this.btnBar.TabIndex = 2;
            this.btnBar.Text = "افزودن بار";
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.BtnBar_Click);
            // 
            // btnFinalKoodrizi
            // 
            this.btnFinalKoodrizi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalKoodrizi.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalKoodrizi.Location = new System.Drawing.Point(98, 24);
            this.btnFinalKoodrizi.Name = "btnFinalKoodrizi";
            this.btnFinalKoodrizi.Size = new System.Drawing.Size(146, 39);
            this.btnFinalKoodrizi.TabIndex = 4;
            this.btnFinalKoodrizi.Text = "افزودن کودریزی نهایی";
            this.btnFinalKoodrizi.UseVisualStyleBackColor = false;
            this.btnFinalKoodrizi.Click += new System.EventHandler(this.BtnFinalKoodrizi_Click);
            // 
            // btnListKoodrizi
            // 
            this.btnListKoodrizi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListKoodrizi.Font = new System.Drawing.Font("Vazir FD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListKoodrizi.Location = new System.Drawing.Point(98, 69);
            this.btnListKoodrizi.Name = "btnListKoodrizi";
            this.btnListKoodrizi.Size = new System.Drawing.Size(146, 38);
            this.btnListKoodrizi.TabIndex = 5;
            this.btnListKoodrizi.Text = "لیست کود ریزی های نهایی";
            this.btnListKoodrizi.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 407);
            this.Controls.Add(this.btnListKoodrizi);
            this.Controls.Add(this.btnFinalKoodrizi);
            this.Controls.Add(this.btnListBar);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnListPerson);
            this.Controls.Add(this.btnPerson);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnListPerson;
        private System.Windows.Forms.Button btnListBar;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnFinalKoodrizi;
        private System.Windows.Forms.Button btnListKoodrizi;
    }
}