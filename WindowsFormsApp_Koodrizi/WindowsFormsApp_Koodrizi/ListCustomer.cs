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
    public partial class ListCustomer : Form
    {

        private PersonRepository _personRepository = new PersonRepository();
        private KoodriziRepository _koodriziRepository = new KoodriziRepository();
        private decimal totalBedehi;
        private DateTime Basetime;

        public ListCustomer()
        {
            InitializeComponent();
        }


        private void ListCustomer_Load(object sender, EventArgs e)
        {
            //int row = 1;
            var people = _personRepository.Peoples();
            foreach (var prop in people)
                dataGridListCustomer.Rows.Add(prop.PersonId, prop.Code, prop.Name, prop.Bedehi,
                    PersianDateConverter.ToPersianDate(prop.BaseDate).ToString("yyyy/MM/dd"),
                    PersianDateConverter.ToPersianDate(prop.AvgDate).ToString("yyyy/MM/dd"));
        }



        private void DataGridListCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {

                DialogResult message1;
                string text = "آبا می خواهید   " + dataGridListCustomer.Rows[e.RowIndex].Cells[2].Value + " را حذف کنید؟";
                message1 = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);

                if (message1 == DialogResult.Yes)
                {
                    var result = _personRepository.Delete(int.Parse(dataGridListCustomer.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (result)
                    {
                        dataGridListCustomer.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("حذف با موفقیت انجام شد");
                    }
                    else
                    {
                        MessageBox.Show("امکان حذف وجود ندارد ");

                    }
                }
            }
            if (e.ColumnIndex == 6)
            {
                var pId = int.Parse(dataGridListCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                var person = _personRepository.People(pId);

                ModalBaseTime formBaseTime = new ModalBaseTime();
                if (formBaseTime.ShowDialog() == DialogResult.OK)
                {
                    Basetime = formBaseTime.BaseTime;
                    var avgdate = AvgDateTime(Basetime, pId);

                    person.AvgDate = avgdate;
                    person.BaseDate = Basetime;
                    person.Bedehi = totalBedehi;
                    _personRepository.Update(person, pId);

                    dataGridListCustomer.Rows[e.RowIndex].Cells[3].Value = totalBedehi;//بدهی کل
                    dataGridListCustomer.Rows[e.RowIndex].Cells[4].Value = PersianDateConverter.ToPersianDate(Basetime).ToString("yyyy/MM/dd");//تاریخ مبنا
                    dataGridListCustomer.Rows[e.RowIndex].Cells[5].Value = PersianDateConverter.ToPersianDate(avgdate).ToString("yyyy/MM/dd");//راس تاریخ
                }
            }
            if (e.ColumnIndex == 8)
            {
                var pId = int.Parse(dataGridListCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                Program.PersonId = pId;

                Customer_Edit formCustomer = new Customer_Edit();
                formCustomer.Show();


                Close();
            }
        }
        private DateTime AvgDateTime(DateTime dateTime, int personId)
        {
            var listPersonsKood = _koodriziRepository.PersonsKood(personId);
            var listPersonsKoodModel = new List<PersonsKood>();
            totalBedehi = 0;
            foreach (var item in listPersonsKood)
            {
                totalBedehi += (decimal)((double)item.Price * item.Weight);//بدهی کل برای این مشتری
                listPersonsKoodModel.Add(new PersonsKood()
                {
                    DueDate = item.ArrivedDate,
                    Bedehi = (decimal)((double)item.Price * item.Weight)
                });

            }
            decimal sum = 0;
            foreach (var item in listPersonsKoodModel)
                sum = (decimal)(item.DueDate - Basetime).TotalDays * (item.Bedehi);

            var avg = sum / totalBedehi;
            DateTime avgdatetime = Basetime.AddDays((int)avg);
            return avgdatetime;

        }

    }
}
