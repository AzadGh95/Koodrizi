using FarsiLibrary.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Koodrizi.Models;
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
    /// <summary>
    /// محاسبه ی کودریزی براساس به کودریزی انتخابی
    /// </summary>
    public partial class CalculateAvgPerson : Form
    {
        private KoodriziRepository _koodriziRepo = new KoodriziRepository();
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private PersonRepository _personRepo = new PersonRepository();
        private AvgPersonRepository _avgPersonRepo = new AvgPersonRepository();
        //private AvgPersonModel model = new AvgPersonModel() { };
        public DateTime avgdatetime;
        private int koodId;
        public DateTime Basetime;
        public CalculateAvgPerson()
        {
            InitializeComponent();
        }

        private void CalculateAvgPerson_Load(object sender, EventArgs e)
        {
            var person = _personRepo.People(Program.PersonId);
            var koods = _finalKoodriziRepo.FinalKoodrizis();

            var kooddetai = koods.Where(x => x.DetailKoodrizis
              .Any(y => y.Bar.Person.PersonId == Program.PersonId)).ToList();

            foreach (var item in kooddetai)
            {
                foreach (var item2 in item.DetailKoodrizis)
                {
                    if (item2.Bar.IdPerson == Program.PersonId)
                    {
                        comboListDetailKoods.Items.Add(
                        item2.DId + "-" +
                        //       " مشتری: " + item2.Bar.Person.Name +
                        " شماره : " + item.KoodNumber +
                        " , نام کودریزی: " + item.KoodName +
                        ", وزن: " + item2.Weight +
                        ", تاریخ سررسید:" + PersianDateConverter.ToPersianDate(item2.ArrivedDate).ToString("yyyy/MM/dd") +
                        ", قیمت هرکیلو:" + item2.Price
                        );
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var txt = comboListDetailKoods.Text;
            string[] token = txt.Split('-');
            var a = token[0].ToString();

            var kood = _koodriziRepo.Koodrizi(int.Parse(a));
            var finalKood = kood.FinalKoodrizi;
            //  koodId = int.Parse(a);//==
            //  koodId = kood.DId;
            dataGridView1.Rows.Add(
                kood.DId,
                finalKood.KoodNumber,
                finalKood.KoodName,
                kood.ArrivedDate,//تاریخ سررسید
                PersianDateConverter.ToPersianDate(kood.ArrivedDate).ToString("yyyy/MM/dd"),
                kood.Weight,
                kood.Price);
        }

        private void BtnCalculateAvg_Click(object sender, EventArgs e)
        {
            Basetime = faDatePicker1.SelectedDateTime;//تاریخ مبدا
            decimal totalBedehi;
            var listPersonsKoodModel = new List<PersonsKood>();
            totalBedehi = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //}
                var arrivedDate = DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                var weight = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                var price = decimal.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());

                //foreach (var item in listPersonsKood)
                //{

                totalBedehi += (decimal)((double)price * weight);//بدهی کل برای این مشتری
                listPersonsKoodModel.Add(new PersonsKood()
                {
                    DueDate = arrivedDate,//تاریخ سررسید
                    Bedehi = (decimal)((double)price * weight)//بدهی
                });
            }
            decimal sum = 0;
            double per = 0;
            foreach (var item in listPersonsKoodModel)
            {
                per = Math.Round((item.DueDate - Basetime).TotalDays);
                if (per == 0 || per < 0)
                {
                    per = 1;
                }

                sum += ((decimal)per * (item.Bedehi));
            }

            var avg = Math.Floor(sum / totalBedehi);
            avgdatetime = Basetime.AddDays((int)avg);
            //show in lables
            lblBedehi.Text = totalBedehi.ToString("#,###");
            lblAvgDate.Text = PersianDateConverter.ToPersianDate(avgdatetime).ToString("yyyy/MM/dd");

        }

        private void LblAvgDate_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا می‌خواهید این فرم را بدون ذخیره کردن ببندید ؟", "هشدار", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AvgPersonModelList avgPersonModelList = new AvgPersonModelList();
                avgPersonModelList.Show();
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //save in AvgPersonModel
            AvgPersonModel model = new AvgPersonModel()
            {
                //IdPerson = Program.PersonId,
                Bedehi = decimal.Parse(lblBedehi.Text),
                AvgDate = avgdatetime,
                CreatDate = Basetime
            };
            var avgId = _avgPersonRepo.Insert(model);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool r = _koodriziRepo.AddAvg(
                    int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                    avgId);
                if (!r)
                {
                    MessageBox.Show("خطا در انجام ذخیره سازی");
                }
            }

            if (avgId != 0)
            {
                MessageBox.Show("محاسبات با موفقیت ثبت شدند");
                AvgPersonModelList avgPersonModelList = new AvgPersonModelList();
                avgPersonModelList.Show();
                Close();
            }
        }
    }
}
