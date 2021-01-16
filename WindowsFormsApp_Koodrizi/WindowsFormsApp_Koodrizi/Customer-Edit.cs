﻿using System;
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
    public partial class Customer_Edit : Form
    {
        public int PersonID { get; set; }
        private PersonRepository _personRepo = new PersonRepository();
        public PersonModel oldPersonInfo { get; set; }
        public Customer_Edit()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           var result = _personRepo.Update(oldPersonInfo, Program.PersonId);
            if (result)
            {
                MessageBox.Show("ویرایش با موفقیت انجام شد");
            }
            else
            {
                MessageBox.Show("ویرایش با خظا مواجه شد","هشدار");
            }
        }

        private void Customer_Edit_Load(object sender, EventArgs e)
        {

            if (Program.PersonId != 0)
            {
                btnSave.Text = "ویرایش";
                oldPersonInfo = _personRepo.People(Program.PersonId);
                txtCod.Text = oldPersonInfo.Code;
                txtName.Text = oldPersonInfo.Name;
                txtPhone.Text = oldPersonInfo.PhoneNumber;
            }
        }
    }
}
