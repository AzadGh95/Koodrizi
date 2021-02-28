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
    /// لیست بار مشتریان
    /// </summary>
    public partial class ListBarPerson : Form
    {
        PersonRepository _personRepository = new PersonRepository();
        KoodriziRepository _koodriziRepository = new KoodriziRepository();
        FinalKoodriziRepository _finalKoodriziRepository = new FinalKoodriziRepository();
        BarRepository _barRepository = new BarRepository();

        public ListBarPerson()
        {
            InitializeComponent();
        }

        private void ListBarPerson_Load(object sender, EventArgs e)
        {
            var person = _personRepository.People(Program.PersonId);
            lblCustomerName.Text = person.Name + " - " + person.Code ;
            var bars = _barRepository.Bars();
            var ListPersonBar = bars.Where(x => x.IdPerson == Program.PersonId);

            foreach (var item2 in ListPersonBar)
            {
                //    PersianDateConverter.ToPersianDate(item2.CreateDate)
                dataGridView1.Rows.Add(
                       PersianDateConverter.ToPersianDate(item2.CreateDate).ToString("yyyy/MM/dd"),
                       item2.TotalWeight , item2.Remaining , item2.DhanBast , item2.Gram,
                       item2.Ounce , item2.Adl
                    );
            }
        }

        private void LblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var bars = _barRepository.Bars();
            var ListPersonBar = bars.Where(x => x.IdPerson == Program.PersonId);
            List<DetailKood> detailKood = new List<DetailKood>();
            foreach (var item in ListPersonBar)
            {
                detailKood.Add(new Reports.Models.DetailKood() {
                    Adl = item.Adl ,
                    CreateDate = PersianDateConverter.ToPersianDate(item.CreateDate).ToString("yyyy/MM/dd") ,
                    Weight = item.TotalWeight,
                    DhanBast = item.DhanBast,
                    RemWeight = item.Remaining,
                    Gram = item.Gram,
                    Ounce = item.Ounce,
                });
            }


            var person = _personRepository.People(Program.PersonId);
            StiReport report = new StiReport();
            report.Load(Application.StartupPath + @"\Reports\mrt\personBar.mrt");

            report.Dictionary.Variables["TitleReport"].Value = "پروژه کودریزی";
            report.Dictionary.Variables["TitleBusiness"].Value = "گزارش بارهای  متعلق به شخص";
            report.Dictionary.Variables["TitlePerson"].Value = person.Name + " - " + person.Code;
            report.Dictionary.Variables["DateReport"].Value =
                PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");

            report.RegBusinessObject("DetailKood", detailKood);
            report.Compile();
            report.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
