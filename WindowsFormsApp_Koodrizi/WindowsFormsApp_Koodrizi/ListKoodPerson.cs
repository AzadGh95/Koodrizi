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
    /// لیست کودهای متعلق به مشتریان
    /// </summary>
    public partial class ListKoodPerson : Form
    {
        PersonRepository _personRepository = new PersonRepository();
        KoodriziRepository _koodriziRepository = new KoodriziRepository();
        FinalKoodriziRepository _finalKoodriziRepository = new FinalKoodriziRepository();

        public ListKoodPerson()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ListBarCustomer_Load(object sender, EventArgs e)
        {
            var person = _personRepository.People(Program.PersonId);
            lblCustomerName.Text = person.Name + " - " + person.Code ;
            var koods = _finalKoodriziRepository.FinalKoodrizis();
            koods.Where(x => x.DetailKoodrizis
            .Any(y => y.Bar.Person.PersonId == Program.PersonId));
            foreach (var item1 in koods)
            {
                foreach (var item2 in item1.DetailKoodrizis)
                {
                    dataGridView1.Rows.Add(
                        PersianDateConverter.ToPersianDate(item2.CreateDate)
                        .ToString("yyyy/MM/dd"),
                        PersianDateConverter.ToPersianDate(item2.ArrivedDate)
                        .ToString("yyyy/MM/dd"),
                        item2.Weight, item2.PercentRoyat, item2.Bar.DhanBast,
                        item2.Bar.Gram, item2.Bar.Ounce.ToString("#.##"), item2.Bar.Adl,
                        item2.Price.ToString("#,###"), ((double)item2.Price * item2.Weight).ToString("#,###"));
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var person = _personRepository.People(Program.PersonId);

            var koods = _finalKoodriziRepository.FinalKoodrizis();
            koods.Where(x => x.DetailKoodrizis
            .Any(y => y.Bar.Person.PersonId == Program.PersonId));

            List<DetailKood> detailKood = new List<DetailKood>();
            foreach (var item1 in koods)
            {
                foreach (var item2 in item1.DetailKoodrizis)
                {
                    detailKood.Add(new DetailKood()
                    {
                        CreateDate = PersianDateConverter.ToPersianDate(item2.CreateDate)
                        .ToString("yyyy/MM/dd"),
                        ArrivedDate = PersianDateConverter.ToPersianDate(item2.ArrivedDate)
                        .ToString("yyyy/MM/dd"),
                        Adl = item2.Adl,
                        Weight = item2.Weight,
                        DhanBast = item2.Bar.DhanBast,
                        Gram = item2.Bar.Gram,
                        Ounce = item2.Bar.Ounce,
                        PercentRoyat = item2.PercentRoyat,
                        Price = item2.Price,
                        TotalPrice = (double)item2.Price * item2.Weight
                    });

                }
            }

            StiReport report = new StiReport();
            report.Load(Application.StartupPath + @"\Reports\mrt\personKood.mrt");

            report.Dictionary.Variables["TitleReport"].Value = "پروژه کودریزی";
            report.Dictionary.Variables["TitleBusiness"].Value = "گزارش کودریزی های  متعلق به شخص";
            report.Dictionary.Variables["TitlePerson"].Value = person.Name + " - " + person.Code;
            report.Dictionary.Variables["DateReport"].Value =
                PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");

            report.RegBusinessObject("DetailKood", detailKood);
            report.Compile();
            report.Show();

        }

        private void LblCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
