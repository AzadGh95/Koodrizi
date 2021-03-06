﻿using System;
using System.Windows.Forms;
using WindowsFormsApp_Koodrizi.Models;
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
    /// <summary>
    /// مشتری جدید
    /// </summary>
    public partial class Customer : Form
    {

        private PersonRepository _personRepo = new PersonRepository();
        public Customer()
        {
            InitializeComponent();


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "ویرایش")
            {
                //_personRepo.Update();
            }
            else
            {
                try
                {
                    if (_personRepo.IsExist(txtCod.Text))
                    {
                        MessageBox.Show("کد وارد شده تکراری است");
                    }
                    else
                    {
                        PersonModel person = new PersonModel()
                        {
                            CreateDate = DateTime.UtcNow,
                            Name = txtName.Text,
                            PhoneNumber = txtPhone.Text,
                            Code = txtCod.Text,
                        };
                        var result = _personRepo.Insert(person);
                        if (result)
                        {
                            MessageBox.Show("مشتری با موفقیت ذخیره شد", "");
                            txtName.Text = "";
                            txtCod.Text = "";
                            txtPhone.Text = "";
                            Close();


                        }
                        else
                            MessageBox.Show("خطا در ذخیره سازی، لطفا مجددا تلاش کنید", "خطا");
                    }
                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                    MessageBox.Show("خطا در ذخیره سازی، لطفا مجددا تلاش کنید", "خطا");
                    throw;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
          


        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
