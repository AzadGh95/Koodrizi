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
        //0
        //شماره کودریزی

        //1
        //نام کودریزی

        //2
        //ArrivedDate

        //3
        //تاریخ سررسید

        //4
        //وزن

        //5
        //قیمت هرکیلو
    public partial class CalculateAvgPerson : Form
    {
        private KoodriziRepository _koodriziRepo = new KoodriziRepository();
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private PersonRepository _personRepo = new PersonRepository();
        private BarRepository _barRepo = new BarRepository();
        private BarRepository _barRepository = new BarRepository();
        public CalculateAvgPerson()
        {
            InitializeComponent();
        }

        private void CalculateAvgPerson_Load(object sender, EventArgs e)
        {
            var person = _personRepo.People(Program.PersonId);
            // lblCustomerName.Text = person.Name + " - " + person.Code;
            var koods = _finalKoodriziRepo.FinalKoodrizis();
            koods.Where(x => x.DetailKoodrizis
            .Any(y => y.Bar.Person.PersonId == Program.PersonId));

            foreach (var item in koods)
            {
                foreach (var item2 in item.DetailKoodrizis)
                {
                    var listDetailsKood = comboListDetailKoods.Items.Add(
                    item2.DId + "-" +
                    "شماره : " + item.KoodNumber +
                    " , نام کودریزی: " + item.KoodName +
                    ", وزن: " + item2.Weight +
                    ", تاریخ سررسید:" + PersianDateConverter.ToPersianDate(item2.ArrivedDate).ToString("yyyy/MM/dd") +
                    ", قیمت هرکیلو:" + item2.Price
                    );
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

            dataGridView1.Rows.Add(
                finalKood.KoodNumber,
                finalKood.KoodName,
                kood.ArrivedDate,
                PersianDateConverter.ToPersianDate(kood.ArrivedDate).ToString("yyyy/MM/dd"),
                kood.Weight,
                kood.Price);
        }

        private void BtnCalculateAvg_Click(object sender, EventArgs e)
        {
            DateTime Basetime = faDatePicker1.SelectedDateTime;//تاریخ مبدا
            decimal totalBedehi;
            var listPersonsKoodModel = new List<PersonsKood>();
            totalBedehi = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
            //}
            var arrivedDate = DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            var weight = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            var price = decimal.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());

            //foreach (var item in listPersonsKood)
            //{

                totalBedehi += (decimal)((double)price * weight);//بدهی کل برای این مشتری
                listPersonsKoodModel.Add(new PersonsKood()
                {
                    DueDate = arrivedDate,
                    Bedehi = (decimal)((double)price * weight)
                });
            }
            decimal sum = 0;
            foreach (var item in listPersonsKoodModel)
                sum = +(decimal)(item.DueDate - Basetime).TotalDays * (item.Bedehi);

            var avg = sum / totalBedehi;
            DateTime avgdatetime = Basetime.AddDays((int)avg);
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
        }
    }
}
