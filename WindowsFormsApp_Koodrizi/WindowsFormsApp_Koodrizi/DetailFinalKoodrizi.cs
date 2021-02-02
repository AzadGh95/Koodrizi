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
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{

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
                        item.Bar.Ounce, item.Weight, item.Price.ToString("#,###")
                        , (item.Weight * (double)item.Price).ToString("#,###"));

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


            StiReport report = new StiReport();
            report.Load(Application.StartupPath + @"\report.mrt");

            report.Dictionary.Variables["DateTimeNow"].Value =
                PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");
           // report.RegBusinessObject("DetailFinalKoodrizi", detailFinalKoodrizi);
            report.Compile();
            report.Show();
        }
    }
}
