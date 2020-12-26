namespace PersianCalender
{
    partial class Form1
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
            this.PersianCalender = new BehComponents.MonthCalendarX();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PersianCalender
            // 
            this.PersianCalender.BoldedDayForeColor = System.Drawing.Color.Blue;
            this.PersianCalender.BorderColor = System.Drawing.Color.CadetBlue;
            this.PersianCalender.CalendarType = BehComponents.CalendarTypes.Persian;
            this.PersianCalender.DayRectTickness = 2F;
            this.PersianCalender.DaysBackColor = System.Drawing.Color.White;
            this.PersianCalender.DaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalender.DaysForeColor = System.Drawing.Color.Black;
            this.PersianCalender.EnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.PersianCalender.EnglishBoldedDates = new System.DateTime[0];
            this.PersianCalender.EnglishHolidayDates = new System.DateTime[0];
            this.PersianCalender.EnglishMonthlyBoldedDates = new System.DateTime[0];
            this.PersianCalender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersianCalender.HolidayForeColor = System.Drawing.Color.Red;
            this.PersianCalender.HolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.PersianCalender.LineWeekColor = System.Drawing.Color.Black;
            this.PersianCalender.Location = new System.Drawing.Point(24, 19);
            this.PersianCalender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersianCalender.Name = "PersianCalender";
            this.PersianCalender.PersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.PersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.PersianCalender.ShowToday = true;
            this.PersianCalender.ShowTodayRect = true;
            this.PersianCalender.ShowToolTips = false;
            this.PersianCalender.ShowTrailing = true;
            this.PersianCalender.Size = new System.Drawing.Size(233, 246);
            this.PersianCalender.Style_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.PersianCalender.Style_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.PersianCalender.Style_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.PersianCalender.Style_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.PersianCalender.TabIndex = 0;
            this.PersianCalender.TitleBackColor = System.Drawing.Color.White;
            this.PersianCalender.TitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.PersianCalender.TitleForeColor = System.Drawing.Color.Black;
            this.PersianCalender.TodayBackColor = System.Drawing.Color.White;
            this.PersianCalender.TodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PersianCalender.TodayForeColor = System.Drawing.Color.Black;
            this.PersianCalender.TodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PersianCalender.TodayRectTickness = 2F;
            this.PersianCalender.TrailingForeColor = System.Drawing.Color.DarkGray;
            this.PersianCalender.WeekDaysBackColor = System.Drawing.Color.White;
            this.PersianCalender.WeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.PersianCalender.WeekDaysForeColor = System.Drawing.Color.Blue;
            this.PersianCalender.WeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.PersianCalender.SelectedDateChanged += new BehComponents.MonthCalendarX.OnSelectedDateChanged(this.PersianCalender_SelectedDateChanged);
            this.PersianCalender.Load += new System.EventHandler(this.PersianCalender_Load);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Vazir FD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.Location = new System.Drawing.Point(24, 272);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(233, 29);
            this.txtDate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 312);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.PersianCalender);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BehComponents.MonthCalendarX PersianCalender;
        private System.Windows.Forms.TextBox txtDate;
    }
}

