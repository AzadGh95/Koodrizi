using FarsiLibrary.Utils;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp_Koodrizi.Reports.Models;
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
    /// <summary>
    /// لیست بارها
    /// </summary>
    public partial class ListBars : Form
    {
        private PersonRepository _personRepository = new PersonRepository();
        private BarRepository _barRepository = new BarRepository();

        public ListBars()
        {
            InitializeComponent();
        }

        private void DataGridListBars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DialogResult message;
                string text = "آبا می خواهید ، بار  " + dataGridListBars.Rows[e.RowIndex].Cells[1].Value + " را حذف کنید؟";
                message = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);

                if (message == DialogResult.Yes)
                {
                    var result = _barRepository.Delete(int.Parse(dataGridListBars.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (result)
                    {
                        dataGridListBars.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("حذف با موفقیت انجام شد");
                    }
                    else
                    {
                        MessageBox.Show("امکان حذف وجود ندارد ");
                    }
                }
                else
                {
                }
            }
            if (e.ColumnIndex == 10)
            {
                Program.BarId = int.Parse(dataGridListBars.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (Program.BarId != 0)
                {
                    Bar_Edit bar_Edit = new Bar_Edit();
                    bar_Edit.Show();
                    Close();
                }
            }
        }

        private void ListBars_Load(object sender, EventArgs e)
        {
            var bars = _barRepository.Bars();
            foreach (var prop in bars)
                dataGridListBars.Rows.Add(prop.BarId, prop.Person.Name,
                    PersianDateConverter.ToPersianDate(prop.CreateDate)
                    .ToString("yyyy/MM/dd"),
                    prop.Remaining, prop.TotalWeight, prop.DhanBast,
                    prop.Gram, prop.Ounce, prop.Adl);
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            dataGridListBars.Rows.Clear();
            var bars = _barRepository.Bars();
            foreach (var prop in bars)
                dataGridListBars.Rows.Add(prop.BarId, prop.Person.Name,
                    PersianDateConverter.ToPersianDate(prop.CreateDate).ToString("yyyy/MM/dd"),
                    prop.Remaining, prop.TotalWeight, prop.DhanBast,
                    prop.Gram, prop.Ounce.ToString("#.##"), prop.Adl);
        }

        private void BtnShwKhandan_Click(object sender, EventArgs e)
        {
            dataGridListBars.Rows.Clear();
            var bars = _barRepository.Bars();
            foreach (var prop in bars)
                if (prop.PistachioType)
                {
                    dataGridListBars.Rows.Add(prop.BarId, prop.Person.Name,
                        PersianDateConverter.ToPersianDate(prop.CreateDate).ToString("yyyy/MM/dd"),
                        prop.Remaining, prop.TotalWeight, prop.DhanBast,
                        prop.Gram, prop.Ounce.ToString("#.##"), prop.Adl);
                }
        }

        private void BtnShowDahanBast_Click(object sender, EventArgs e)
        {
            dataGridListBars.Rows.Clear();
            var bars = _barRepository.Bars();
            foreach (var prop in bars)
                if (!prop.PistachioType)
                {
                    dataGridListBars.Rows.Add(prop.BarId, prop.Person.Name,
                        PersianDateConverter.ToPersianDate(prop.CreateDate).ToString("yyyy/MM/dd"),
                        prop.Remaining, prop.TotalWeight, prop.DhanBast,
                        prop.Gram, prop.Ounce.ToString("#.##"), prop.Adl);
                }
        }

        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            var bars = _barRepository.Bars();
            List<ListBarsModel> listBars = new List<ListBarsModel>();
            foreach (var prop in bars)
               
                    listBars.Add(new ListBarsModel()
                    {
                        Person = prop.Person.Name,
                        Adl = prop.Adl,
                        DahanBast = prop.DhanBast,
                        DateTime = PersianDateConverter.ToPersianDate(prop.CreateDate).ToString("yyyy/MM/dd"),
                        Gram = prop.Gram,
                        Ounce = prop.Ounce,
                        RemWeight = prop.Remaining,
                        Weight = prop.TotalWeight,

                    });
            


            StiReport report = new StiReport();
            report.Load(Application.StartupPath + @"\Reports\mrt\bars.mrt");

            report.Dictionary.Variables["TitleReport"].Value = "پروژه کودریزی";
            report.Dictionary.Variables["TitleBusiness"].Value = "گزارش بار های پسته";
            report.Dictionary.Variables["DateReport"].Value =
                PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");

            report.RegBusinessObject("ListBars", listBars);
            report.Compile();
            report.Show();
        }

        private void BtnPrintKhandan_Click(object sender, EventArgs e)
        {
            var bars = _barRepository.Bars();
            List<ListBarsModel> listBars = new List<ListBarsModel>();
            foreach (var prop in bars)
                if (prop.PistachioType)
                {
                    listBars.Add(new ListBarsModel()
                    {
                        Person = prop.Person.Name,
                        Adl = prop.Adl,
                        DahanBast = prop.DhanBast,
                        DateTime = PersianDateConverter.ToPersianDate(prop.CreateDate).ToString("yyyy/MM/dd"),
                        Gram = prop.Gram,
                        Ounce = prop.Ounce,
                        RemWeight = prop.Remaining,
                        Weight = prop.TotalWeight,

                    });
                }


            StiReport report = new StiReport();
            report.Load(Application.StartupPath + @"\Reports\mrt\bars.mrt");

            report.Dictionary.Variables["TitleReport"].Value = "پروژه کودریزی";
            report.Dictionary.Variables["TitleBusiness"].Value = "گزارش بار پسته های خندان ";
            report.Dictionary.Variables["DateReport"].Value =
                PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");

            report.RegBusinessObject("ListBars", listBars);
            report.Compile();
            report.Show();
        }

        private void BtnPrintDahanBast_Click(object sender, EventArgs e)
        {
            var bars = _barRepository.Bars();
            List<ListBarsModel> listBars = new List<ListBarsModel>();
            foreach (var prop in bars)
                if (!prop.PistachioType)
                {
                    listBars.Add(new ListBarsModel()
                    {
                        Person = prop.Person.Name,
                        Adl = prop.Adl,
                        DahanBast = prop.DhanBast,
                        DateTime = PersianDateConverter.ToPersianDate(prop.CreateDate).ToString("yyyy/MM/dd") ,
                        Gram = prop.Gram,
                        Ounce = prop.Ounce,
                        RemWeight = prop.Remaining,
                        Weight = prop.TotalWeight,

                    });
                }


            StiReport report = new StiReport();
            report.Load(Application.StartupPath + @"\Reports\mrt\bars.mrt");

            report.Dictionary.Variables["TitleReport"].Value = "پروژه کودریزی";
            report.Dictionary.Variables["TitleBusiness"].Value = "گزارش بار پسته های دهن بست";
            report.Dictionary.Variables["DateReport"].Value =
                PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");

            report.RegBusinessObject("ListBars", listBars);
            report.Compile();
            report.Show();
        }
    }
}
