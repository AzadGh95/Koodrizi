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

    public partial class Bar : Form
    {
        private BarRepository _barRepo = new BarRepository();
        private PersonRepository _personRepository = new PersonRepository();
        private int personId;
        public Bar()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Bar bar = new Models.Bar()
                {
                    Ounce = txtOunce.Text,
                    Adl = double.Parse(txtAdl.Text),
                    Remaining = double.Parse(txtWeight.Text),
                    TotalWeight = double.Parse(txtWeight.Text),
                    CreateDate = dateTimeCreateDate.Value,
                    IdPerson = personId,
                    PistachioName = comboType.Text,
                    PistachioType = radioKhandan.Checked,
                    Gram = double.Parse(txtGrams.Text),

                };
                var result = _barRepo.Insert(bar);

                txtOunce.Text = "";
                txtAdl.Text = "";
                txtWeight.Text = "";
                txtWeight.Text = "";
                txtGrams.Text = "";

                if (result)
                    MessageBox.Show("بار جدید با موفقیت ثبت شد.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا");
                //MessageBox.Show("خطا در ذخیره سازی بار جدید", "خطا");
                throw;
            }



        }

        private void ComCustomerSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bar_Load(object sender, EventArgs e)
        {
            try
            {
                if (radioKhandan.Checked == true)
                {

                }
                if (radioDahanBast.Checked)
                {
                    txtPercent.Enabled = false;
                }

                var listPeople = _personRepository.Peoples();
                foreach (var person in listPeople)
                {
                    comCustomerSelection.Items.Add(person.Name + " [" + person.Code + "]");
                    personId = person.PersonId;
                }

                List<string> listPistachio = new List<string>() {
                "کله قوچی",
                "احمدآقایی",
                "فندقی",
                "اکبری",
                //"",
            };

                foreach (var pistah in listPistachio)
                {
                    comboType.Items.Add(pistah);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void RadioKhandan_CheckedChanged(object sender, EventArgs e)
        {
            txtPercent.Enabled = true;
        }

        private void RadioDahanBast_CheckedChanged(object sender, EventArgs e)
        {
            txtPercent.Enabled = false;
        }
    }
}
