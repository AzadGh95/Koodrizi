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
using WindowsFormsApp_Koodrizi.Models;
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
    public partial class Bar_Edit : Form
    {
        public Bar_Edit()
        {
            InitializeComponent();
        }
        private BarRepository _barRepository = new BarRepository();
        private PersonRepository _personRepository = new PersonRepository();
        private BarModel oldBar { get; set; }
        private void Bar_Edit_Load(object sender, EventArgs e)
        {



            if (Program.BarId != 0)
            {
                faDataTimeCreateDate.Text =
                     PersianDateConverter.ToPersianDate(DateTime.UtcNow).ToString("yyyy/MM/dd");

                oldBar = _barRepository.Bar(Program.BarId);
                txtPerson.Text = oldBar.Person.Name + " [" + oldBar.Person.Code + "] ";
                txtPerson.Enabled = false;
                txtAdl.Text = oldBar.Adl.ToString();
                txtGrams.Text = oldBar.Gram.ToString();
                txtPercent.Text = oldBar.DhanBast.ToString();
                txtWeight.Text = oldBar.TotalWeight.ToString();
                txtOunce.Text = oldBar.Ounce.ToString();
                txtPitachioType.Text = oldBar.PistachioName;
                txtPitachioType.Enabled = false;
                if (oldBar.PistachioType)
                {
                    radioKhandan.Checked = true;
                    radioDahanBast.Checked = false;
                }
                else
                {
                    radioKhandan.Checked = false;
                    radioDahanBast.Checked = true;
                }

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string[] token = txtPerson.Text.Split('[');
            var a = token[1].ToString();
            string[] token2 = a.Split(']');
            a = token2[0].ToString();
            var personId = _personRepository.People(a);

            oldBar.IdPerson = personId;

            if (txtPercent.Text == "")
                oldBar.DhanBast = 0.0;
            else
                oldBar.DhanBast = double.Parse(txtPercent.Text);

            if (txtOunce.Text == "")
                oldBar.Ounce = 0.0;
            else
                oldBar.Ounce = double.Parse(txtOunce.Text);


            if (txtAdl.Text == "")
            {
                oldBar.Adl = 0.0;
                oldBar.AdlRem = 0.0;
            }
            else
            {
                oldBar.Adl = double.Parse(txtAdl.Text);
                oldBar.AdlRem = double.Parse(txtAdl.Text);
            }

            oldBar.Remaining = double.Parse(txtWeight.Text);
            oldBar.TotalWeight = double.Parse(txtWeight.Text);
            oldBar.CreateDate = faDataTimeCreateDate.SelectedDateTime;
            oldBar.PistachioName = txtPitachioType.Text;
            oldBar.PistachioType = radioKhandan.Checked;

            if (txtGrams.Text == "")
                oldBar.Gram = 0.0;
            else
                oldBar.Gram = double.Parse(txtGrams.Text);

            var result = _barRepository.Update(oldBar, Program.BarId);
            if (result)
            {
                MessageBox.Show("ویرایش با موفقیت انجام شد .");
                ListBars listBars = new ListBars();
                listBars.Show();
                Close();
            }
            else
            {
                MessageBox.Show("خطا در انجام عملیات");
            }


        }

        private void FaDataTimeCreateDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {

        }

        private void RadioKhandan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioDahanBast_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void RadioDahanBast_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPercent.Enabled = false;
            txtPercent.Text = "100";
            txtGrams.Enabled = true;
        }

        private void RadioKhandan_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPercent.Enabled = true;
            txtPercent.Text = "0";
            txtGrams.Text = "0";
            txtGrams.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ListBars listBars = new ListBars();
            listBars.Show();
            Close();
        }
    }
}
