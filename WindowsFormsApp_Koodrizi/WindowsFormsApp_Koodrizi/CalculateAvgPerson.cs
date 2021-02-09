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
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
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
    }
}
