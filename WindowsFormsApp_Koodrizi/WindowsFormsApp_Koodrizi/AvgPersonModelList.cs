using FarsiLibrary.Utils;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Koodrizi.Reports.Models;
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
    public partial class AvgPersonModelList : Form
    {

        AvgPersonRepository _avgPersonRepository = new AvgPersonRepository();
        PersonRepository _personRepository = new PersonRepository();
        KoodriziRepository _koodriziRepository = new KoodriziRepository();
        public AvgPersonModelList()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNewAvg_Click(object sender, EventArgs e)
        {
            CalculateAvgPerson calculateAvgPerson = new CalculateAvgPerson();
            calculateAvgPerson.Show();
            Close();
        }

        private void AvgPersonModelList_Load(object sender, EventArgs e)
        {
            var listAvgPerson = _avgPersonRepository.AvgPersonModels(Program.PersonId);
            var person = _personRepository.People(Program.PersonId);
            lblPersonName.Text = person.Name;
            foreach (var item in listAvgPerson)
            {
                dataGridViewAvg.Rows.Add(
                    item.Id,
                    PersianDateConverter.ToPersianDate(item.CreatDate).ToString("yyyy/MM/dd"),
                    PersianDateConverter.ToPersianDate(item.AvgDate).ToString("yyyy/MM/dd"),
                    item.Bedehi.ToString("#,###"));
            }

        }

        private void DataGridViewAvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult message1;
                string text = "آبا مطمئن هستید؟";
                message1 = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);

                if (message1 == DialogResult.Yes)
                {
                    var result = _avgPersonRepository.DeleteAvgPerson
                        (int.Parse(dataGridViewAvg.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (result)
                    {
                        dataGridViewAvg.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("حذف با موفقیت انجام شد");
                    }
                    else
                    {
                        MessageBox.Show("امکان حذف وجود ندارد ");

                    }
                }
            }
            if (e.ColumnIndex == 5)
            {
                int avgId = int.Parse(dataGridViewAvg.Rows[e.RowIndex].Cells[0].Value.ToString());
                var avgPerson = _avgPersonRepository.AvgPersonModel(avgId);

                var listDeailKood = _koodriziRepository.KoodrizisByAvgId(avgId);

                List<DetailKood> detailKoods = new List<DetailKood>();
                foreach (var item in listDeailKood)
                {
                    detailKoods.Add(new DetailKood()
                    {
                        KoodName = item.FinalKoodrizi.KoodName,
                        KoodNumber = item.FinalKoodrizi.KoodNumber,
                        ArrivedDate =
                        PersianDateConverter.ToPersianDate(item.ArrivedDate).ToString("yyyy/MM/dd"),
                        Weight = item.Weight,
                        Price = item.Price,
                        TotalPrice = item.Weight * (double)item.Price
                    });
                }

                StiReport report = new StiReport();
                report.Load(Application.StartupPath + @"\Reports\mrt\avgPerson.mrt");

                report.Dictionary.Variables["TitleReport"].Value = "پروژه کودریزی";
                report.Dictionary.Variables["TitleBusiness"].Value = "گزارش راس گیری کودریزی ها";
                report.Dictionary.Variables["PersonName"].Value = listDeailKood.FirstOrDefault().Bar.Person.Name;
                report.Dictionary.Variables["Bedehi"].Value = avgPerson.Bedehi.ToString("#,###");
                report.Dictionary.Variables["AvgDate"].Value =
                     PersianDateConverter.ToPersianDate(avgPerson.AvgDate).ToString("yyyy/MM/dd");
                report.Dictionary.Variables["CreateDate"].Value =
                     PersianDateConverter.ToPersianDate(avgPerson.CreatDate).ToString("yyyy/MM/dd");
                report.Dictionary.Variables["DateReport"].Value =
                    PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");

                report.RegBusinessObject("AvgPersonModel", detailKoods);
                report.Compile();
                report.Show();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
