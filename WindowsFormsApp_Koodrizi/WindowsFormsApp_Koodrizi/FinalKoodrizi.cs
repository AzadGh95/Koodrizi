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
    public partial class FinallKoodrizi : Form
    {
        private BarRepository _barRepository = new BarRepository();
        public int BarId;
        public double WeightKood;
        public double PersentRoyat;
        public DateTime SellDate;
        public DateTime DueDate;

        public FinallKoodrizi()
        {
            InitializeComponent();
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void FinallKoodrizi_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

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
            formKoodrizi.Show();

            //var bar = _barRepository.Bar(BarId);

            //dataGridFinalKood.Rows.Add(bar.Person.Name,
            //    bar.Remaining, WeightKood, bar.Ounce,
            //    PercentRoyat, SellDate.ToString("YYYY/MM/DD"),
            //    DueDate.ToString("YYYY/MM/DD"));
        }

        private void TxtKoodOnc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxPriceperkilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtKoodNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
