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
    /// <summary>
    /// لیست جزئیات کودریزی
    /// </summary>
    public partial class DetailFinalKoodrizi : Form
    {
        FinalKoodriziRepository _finalKoodriziRepository = new FinalKoodriziRepository();
        public DetailFinalKoodrizi()
        {
            InitializeComponent();
        }

        private void DetailFinalKoodrizi_Load(object sender, EventArgs e)
        {
            var finalListKood = _finalKoodriziRepository.FinalKoodrizi(Program.numberFinalKood);

            foreach (var item in finalListKood.DetailKoodrizis)
            {
                dataGridDetailKoods.Rows.Add(item.Bar.Person.Name,
                    item.Bar.DhanBast, item.Bar.Ounce, item.Weight,
                    item.Price.ToString("#,###"),
                    (item.Weight * (double)item.Price).ToString("#,###"));
            }

            lblBasePrice.Text = finalListKood.BasePrice.ToString("#,###");
            lblOunce.Text = finalListKood.TotalOunce.ToString();
            lblWeight.Text = finalListKood.TotalWeight.ToString();
            lblTotalPrice.Text = finalListKood.TotalPrice.ToString("#,###");
        }

        private void BtnShowListDetailKood_Click(object sender, EventArgs e)
        {

        }

        private void DataGridDetailKoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var finalKoodrizi = _finalKoodriziRepository.FinalKoodrizi(Program.numberFinalKood);
            var DetailFinalKoodrizi = finalKoodrizi.DetailKoodrizis;
            List<listDetailFinalKoodrizi> listDetailFinalKoodrizi = new List<listDetailFinalKoodrizi>();
            foreach (var item in DetailFinalKoodrizi)
            {
                listDetailFinalKoodrizi.Add(new listDetailFinalKoodrizi()
                {

                    Person = item.Bar.Person.Name,
                    Code = item.Bar.Person.Code,
                    Adl = item.Adl.ToString("#.##"),
                    Ounce = item.Bar.Ounce.ToString("#.##"),
                    Weight = item.Weight.ToString("#.##"),
                    DahanBast = item.Bar.DhanBast.ToString("#.##"),
                });
            }

            StiReport report = new StiReport();
            report.Load(Application.StartupPath + @"\Reports\mrt\detailKoodForKeeper.mrt");

            report.Dictionary.Variables["TitleReport"].Value = "پروژه کودریزی";
            report.Dictionary.Variables["TitleBusiness"].Value = "گزارش جزئیات کودریزی مختص مسئول انبار";
            report.Dictionary.Variables["DateReport"].Value =
                PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");
            report.Dictionary.Variables["TotalWeight"].Value = finalKoodrizi.TotalWeight.ToString("#.##");
            report.Dictionary.Variables["TotalOunce"].Value = finalKoodrizi.TotalOunce;
            report.Dictionary.Variables["KoodNumber"].Value = finalKoodrizi.KoodNumber;
            report.Dictionary.Variables["KoodName"].Value = finalKoodrizi.KoodName;

            report.RegBusinessObject("listDetailFinalKoodrizi", listDetailFinalKoodrizi);
            report.Compile();
            report.Show();
        }

        private void LblWeight_Click(object sender, EventArgs e)
        {

        }
    }
}
