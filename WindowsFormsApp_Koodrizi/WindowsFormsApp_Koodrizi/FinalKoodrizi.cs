using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
    public partial class FinallKoodrizi : Form
    {
        public int BarId;
        public double WeightKood;
        public double PersentRoyat;
        public DateTime SellDate;
        public DateTime DueDate;
        private List<Models.Koodrizi> detailkoods = new List<Models.Koodrizi>();
        private double sumPrice = 0;
        private double sumOunce = 0;
        private KoodriziRepository _koodriziRepo = new KoodriziRepository();
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private PersonRepository _personRepo = new PersonRepository();
        private BarRepository _barRepository = new BarRepository();

        private string nameKood;
        private string numberKood;
        private DateTime dateTimeKood;
        private double ounceKood;
        private decimal priceKood;


        public FinallKoodrizi()
        {
            InitializeComponent();
            //Application.CurrentCulture = new CultureInfo("fa-IR");
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TxtKoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinallKoodrizi_Load(object sender, EventArgs e)
        {
            txtKoodNumber.Text = "K-" + DateTime.UtcNow.ToString("dMmss");
            txtKoodNumber.Enabled = false;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //save to db
            foreach (var item in detailkoods)
            {
                _koodriziRepo.Insert(item);
            }
            _finalKoodriziRepo.Insert(new Models.FinalKoodrizi()
            {
               KoodNumber = txtKoodNumber.Text,
               KoodName = txtKoodName.Text,
              /////////////////////////////////////////////////////////////////////countinue
            });
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Koodrizi formKoodrizi = new Koodrizi();


            if (formKoodrizi.ShowDialog() == DialogResult.OK)
            {
                var bar = _barRepository.Bar(formKoodrizi.Koodrizi_model.BarId);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridFinalKood);
                newRow.Cells[0].Value = formKoodrizi.Koodrizi_model.BarId;
                newRow.Cells[1].Value = bar.Person.Name + " [" + bar.Person.Code + "] ";
                newRow.Cells[2].Value = formKoodrizi.Koodrizi_model.Weight;
                newRow.Cells[3].Value = bar.Ounce;
                newRow.Cells[4].Value = formKoodrizi.Koodrizi_model.PercentRoyat;
                newRow.Cells[5].Value = formKoodrizi.Koodrizi_model.SellDate;
                newRow.Cells[6].Value = formKoodrizi.Koodrizi_model.ArrivedDate;
                dataGridFinalKood.Rows.Add(newRow);

            }

        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult message;
            message = MessageBox.Show("آیا مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                dataGridFinalKood.Rows.Clear();
            }
        }

        private void BtnCalculateKood_Click(object sender, EventArgs e)
        {
            double priceOunce = double.Parse(txtOuncePrice.Text);
            double priceDahanBast = double.Parse(txtDahanBastprice.Text);
            nameKood = txtKoodName.Text;
            numberKood = txtKoodNumber.Text;
            dateTimeKood = faDateKoodFinal.SelectedDateTime;
            //ounceKood = double.Parse(txtKoodOnc.Text);
            priceKood = decimal.Parse(txPriceperkilo.Text);

            for (int i = 0; i < dataGridFinalKood.RowCount; i++)
            {
                detailkoods.Add(new Models.Koodrizi()
                {
                    BarId = int.Parse(dataGridFinalKood.Rows[i].Cells[0].Value.ToString()),
                    Weight = double.Parse(dataGridFinalKood.Rows[i].Cells[2].Value.ToString()),
                    PercentRoyat = double.Parse(dataGridFinalKood.Rows[i].Cells[4].Value.ToString()),
                    SellDate = DateTime.Parse(dataGridFinalKood.Rows[i].Cells[5].Value.ToString()),
                    ArrivedDate = DateTime.Parse(dataGridFinalKood.Rows[i].Cells[6].Value.ToString()),
                });
            }

            ////////محاسبه
            //ضریب
            //انس پایه

            int j = 0;


            foreach (var item in detailkoods)
            {
                var zarib = Zarib(detailkoods, item.Weight);
                var baseOunce = BaseOunce(detailkoods, zarib);
                var baseDahanBast = BaseDahanBast(detailkoods, zarib);
                var bar = _barRepository.Bar(item.BarId);
                var priceElement = CalculateKoodRizi(priceKood, item.PercentRoyat, baseOunce,
                     baseDahanBast, bar.Ounce, bar.DhanBast, priceOunce, priceDahanBast);
                item.Price = (decimal)priceElement;
                dataGridFinalKood.Rows[j].Cells[7].Value = priceElement.ToString("#,###");
                dataGridFinalKood.Rows[j].Cells[8].Value = (item.Weight * priceElement).ToString("#,###");
                j++;

                //ذخیره کردن در مدل ها

                sumOunce += baseOunce;
                sumPrice += priceElement;

            }

            lblTotalPrice.Text = sumPrice.ToString("#,###");
            lblTtalOunce.Text = sumOunce.ToString();
            //ذخیره در لیست مدل
            //کم کردن از موجودی

        }
        private double Zarib(List<Models.Koodrizi> koodmodel, double weightBar)
        {
            double sum = 0;

            foreach (var item in koodmodel)
            {
                sum += item.Weight;
            }
            return weightBar / sum;
        }

        private double BaseOunce(List<Models.Koodrizi> detailKood, double zarib)
        {
            double sum = 0;
            foreach (var item in detailKood)
            {
                var bar = _barRepository.Bar(item.BarId);
                sum += bar.Ounce;
            }
            return sum * zarib;
        }

        private double BaseDahanBast(List<Models.Koodrizi> detailKood, double zarib)
        {
            double sum = 0;
            foreach (var item in detailKood)
            {
                var bar = _barRepository.Bar(item.BarId);
                sum += bar.DhanBast;
            }
            return sum * zarib;
        }
        private double CalculateKoodRizi(decimal bacePrice, double percentRoyat,
            double baceOunce, double baseDahanBast, double ounce, double dahanBast, double priceOunce,
            double priceDahanBast)
        {
            var price = (percentRoyat / 100) *
                (double.Parse(bacePrice.ToString()) - (ounce - baceOunce) * priceOunce + (dahanBast - baseDahanBast));
            return price;
        }
    }
}
