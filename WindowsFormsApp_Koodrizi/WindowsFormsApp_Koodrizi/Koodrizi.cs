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
    public partial class Koodrizi : Form
    {
        private KoodriziRepository _koodriziRepo = new KoodriziRepository();
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private PersonRepository _personRepo = new PersonRepository();
        private BarRepository _barRepo = new BarRepository();
        private BarRepository _barRepository = new BarRepository();

        private int BarId;

        public Koodrizi()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtAdl.Text = "";
            txtAsOunce.Text = "";
            txtAsWeight.Text = "";
            txtDahanBast.Text = "";
            txtGrams.Text = "";
            txtToOunce.Text = "";
            txtToOunce.Text = "";

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] token = comCustomerBar.Text.Split('>');
                var a = token[0].ToString();
                Koodrizi_model = new Models.DKood()
                {
                    BarId = int.Parse(a),
                    ArrivedDate = fadateTimeDueDate.SelectedDateTime,
                    SellDate = fadateTimeSell.SelectedDateTime,
                    Weight = double.Parse(txtWeightBar.Text),
                    PercentRoyat = double.Parse(txtPercentageOfVisibility.Text),
                    Adl = double.Parse(txtadlbar.Text),

                };

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ثبت با مشکل مواجه شد");
                //throw;
            }
        }


        public Models.DKood Koodrizi_model { get; set; }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                comCustomerBar.Items.Clear();
                var bars = _barRepo.SearchBar(double.Parse(txtAsWeight.Text), double.Parse(txtToWeight.Text),
                    double.Parse(txtAsOunce.Text), double.Parse(txtToOunce.Text),
                    double.Parse(txtAdl.Text), double.Parse(txtGrams.Text), double.Parse(txtDahanBast.Text));
                if (bars.Count == 0)
                {
                    MessageBox.Show("هیچ باری با این مشخصات موجود نیست.");
                }
                foreach (var bar in bars)
                {
                    comCustomerBar.Items.Add(bar.BarId + ">  " + bar.Person.Name + " | انس: " + bar.Ounce + " | موجودی:" + bar.Remaining
                        + " | گرم:" + bar.Gram + " | نوع پسته:" + bar.PistachioName + " | درصددهن بست:" +
                        bar.DhanBast + " | عدل: " + bar.Adl);
                }
                if (bars.Count() > 0)
                {
                    comCustomerBar.Enabled = true;
                    txtWeightBar.Enabled = true;
                    txtPercentageOfVisibility.Enabled = true;
                    //dateTimeSell.Enabled = true;
                    //dateTimeDueDate.Enabled = true;
                    btnSave.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ComCustomerBar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Koodrizi_Load(object sender, EventArgs e)
        {

        }

        private void TxtPercentageOfVisibility_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
