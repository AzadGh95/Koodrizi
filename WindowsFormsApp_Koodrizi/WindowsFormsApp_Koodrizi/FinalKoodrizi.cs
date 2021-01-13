using FarsiLibrary.Utils;
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
        private List<Models.DKood> detailkoods = new List<Models.DKood>();
        private double sumPrice = 0;
        private double sumOunce = 0;
        private double sumDahanBst = 0;
        private double sumPercentRoyat = 0;
        private double sumWeight = 0;
        private KoodriziRepository _koodriziRepo = new KoodriziRepository();
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private PersonRepository _personRepo = new PersonRepository();
        private BarRepository _barRepository = new BarRepository();

        private string nameKood;
        private string numberKood;
        private DateTime dateTimeKood;
        private double ounceKood;
        private decimal priceKood;
        private decimal basePriceCalculate;


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
            btnSave.Enabled = false;
            txtKoodNumber.Enabled = false;
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //save to db

            var finalkood = new Models.FinalKoodriziModel()
            {
                KoodNumber = txtKoodNumber.Text,
                KoodName = txtKoodName.Text,
                TotalOunce = lblTtalOunce.Text,
                TotalWeight = sumWeight,
                TotalPrice = (decimal)sumPrice,
                BasePrice = decimal.Parse(txPriceperkilo.Text),
                PriceOunce = decimal.Parse(txtOuncePrice.Text),
                PriceDahanBast = decimal.Parse(txtDahanBastprice.Text),

            };
            _finalKoodriziRepo.Insert(finalkood);

            foreach (var item in detailkoods)
            {
                item.FinalKoodId = _finalKoodriziRepo.LastIdFinalKoodrizi() /*+ 1*/;
                _koodriziRepo.Insert(item);
                var bar = _barRepository.Bar(item.BarId);
                bar.Remaining -= item.Weight;
                bar.AdlRem -= item.Adl;
                _barRepository.Update(bar, item.BarId);
            }

            MessageBox.Show("کود ریزی نهایی با موفقیت ثبت شد .");
            Close();

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
                newRow.Cells[7].Value = formKoodrizi.Koodrizi_model.Adl;
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
            btnSave.Enabled = true;
            detailkoods.Clear();
            btnCalculateKood.Enabled = false;
            btnClear.Enabled = false;
            double priceOunce = double.Parse(txtOuncePrice.Text);
            double priceDahanBast = double.Parse(txtDahanBastprice.Text);
            nameKood = txtKoodName.Text;
            numberKood = txtKoodNumber.Text;
            dateTimeKood = faDateKoodFinal.SelectedDateTime;
            //ounceKood = double.Parse(txtKoodOnc.Text);
            priceKood = decimal.Parse(txPriceperkilo.Text);

            for (int i = 0; i < dataGridFinalKood.RowCount; i++)
            {
                detailkoods.Add(new Models.DKood()
                {
                    BarId = int.Parse(dataGridFinalKood.Rows[i].Cells[0].Value.ToString()),
                    Weight = double.Parse(dataGridFinalKood.Rows[i].Cells[2].Value.ToString()),
                    PercentRoyat = double.Parse(dataGridFinalKood.Rows[i].Cells[4].Value.ToString()),
                    SellDate = DateTime.Parse(dataGridFinalKood.Rows[i].Cells[5].Value.ToString()),
                    ArrivedDate = DateTime.Parse(dataGridFinalKood.Rows[i].Cells[6].Value.ToString()),
                    Adl = double.Parse(dataGridFinalKood.Rows[i].Cells[7].ToString()),
                });
            }

            ////////محاسبه
            //ضریب
            //انس پایه

            int j = 0;


            foreach (var item in detailkoods)
            {
                var bar = _barRepository.Bar(item.BarId);
                item.Zarib = Zarib(detailkoods, item.Weight);
                item.BaseOunce = bar.Ounce * item.Zarib;
                item.BaseDahanBast = bar.DhanBast * item.Zarib;
                item.BasePercentRoyat = item.PercentRoyat * item.Zarib;

                sumPercentRoyat += item.BasePercentRoyat;
                sumWeight += item.Weight;

                sumOunce += item.BaseOunce;
                sumDahanBst += item.BaseDahanBast;
            }
            //sumPrice *= sumWeight;
            basePriceCalculate = (decimal)(double.Parse(txPriceperkilo.Text) *
                (1 - sumPercentRoyat));

            foreach (var item in detailkoods)
            {
                var bar = _barRepository.Bar(item.BarId);
                var priceElement = CalculateKoodRizi(basePriceCalculate, item.PercentRoyat, sumOunce,
                     sumDahanBst, bar.Ounce, bar.DhanBast, priceOunce, priceDahanBast);
                item.Price = (decimal)priceElement;
                dataGridFinalKood.Rows[j].Cells[8].Value = priceElement.ToString("#,###");
                dataGridFinalKood.Rows[j].Cells[9].Value = (item.Weight * priceElement).ToString("#,###");
                j++;


                sumPrice += (item.Weight * priceElement);

            }

            lblTotalPrice.Text = sumPrice.ToString("#,###");
            lblTtalOunce.Text = sumOunce.ToString();

        }
        private double Zarib(List<Models.DKood> koodmodel, double weightBar)
        {
            double sum = 0;

            foreach (var item in koodmodel)
            {
                sum += item.Weight;
            }
            var result = weightBar / sum;
            return result;
        }

        private double CalculateKoodRizi(decimal bacePriceCalculate, double percentRoyat, double baceOunce,
            double baseDahanBast, double ounce, double dahanBast, double priceOunce, double priceDahanBast)
        {
            var price = ((percentRoyat / 100) + 1) *
                ((double)bacePriceCalculate - ((ounce - baceOunce) * priceOunce)
                +
                ((baseDahanBast - dahanBast) * priceDahanBast));
            return price;
        }
    }
}
