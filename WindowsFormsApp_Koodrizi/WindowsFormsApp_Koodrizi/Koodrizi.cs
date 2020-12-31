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



            string[] token = comCustomerBar.Text.Split('>');



            FinallKoodrizi finallKoodrizi = new FinallKoodrizi();

            //  finallKoodrizi.WeightKood = double.Parse(txtWeightBar.Text);
            // finallKoodrizi.PersentRoyat = double.Parse(txtPercentageOfVisibility.Text);
            // finallKoodrizi.BarId = int.Parse(token[0]);
            //   finallKoodrizi.SellDate = DateTime.Parse(dateTimeSell.Text);
            //  finallKoodrizi.DueDate = DateTime.Parse(dateTimeDueDate.Text);

            Program.BarId = int.Parse(token[0]);
            Program.DueDate = DateTime.Parse(dateTimeDueDate.Text);
            Program.SellDate = DateTime.Parse(dateTimeSell.Text);
            Program.PersentRoyat = double.Parse(txtPercentageOfVisibility.Text);
            Program.WeightKood = double.Parse(txtWeightBar.Text);


            var bar = _barRepository.Bar(Program.BarId);
            finallKoodrizi.dataGridFinalKood.Rows.Add(bar.Person.Name,
                Program.WeightKood, bar.Ounce,
                 Program.PersentRoyat, Program.SellDate.ToString("YYYY/MM/DD"),
                Program.DueDate.ToString("YYYY/MM/DD"));
            Close();
            //finallKoodrizi.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                comCustomerBar.Items.Clear();
                var bars = _barRepo.SearchBar(double.Parse(txtAsWeight.Text), double.Parse(txtToWeight.Text),
                    double.Parse(txtAsOunce.Text), double.Parse(txtToOunce.Text),
                    double.Parse(txtAdl.Text), double.Parse(txtGrams.Text), double.Parse(txtDahanBast.Text));
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
                    dateTimeSell.Enabled = true;
                    dateTimeDueDate.Enabled = true;
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
    }
}
