﻿using System;
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
                Models.Bar bar = new Models.Bar() { };

                string[] token = comCustomerSelection.Text.Split('[');
                var a = token[1].ToString();
                string[] token2 = a.Split(']');
                a = token2[0].ToString();
                personId =_personRepository.People(a);


                bar.DhanBast = double.Parse(txtPercent.Text);
                bar.Ounce = double.Parse(txtOunce.Text);
                bar.Adl = double.Parse(txtAdl.Text);
                bar.Remaining = double.Parse(txtWeight.Text);
                bar.TotalWeight = double.Parse(txtWeight.Text);
                bar.CreateDate = faDataTimeCreateDate.SelectedDateTime;
                bar.IdPerson = personId;
                bar.PistachioName = comboType.Text;
                bar.PistachioType = radioKhandan.Checked;
                bar.Gram = double.Parse(txtGrams.Text);

                var result = _barRepo.Insert(bar);

                txtOunce.Text = "";
                txtAdl.Text = "";
                txtWeight.Text = "";
                txtWeight.Text = "";
                txtGrams.Text = "";
                txtPercent.Text = "";

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
            txtPercent.Text = "100";
        }
    }
}
