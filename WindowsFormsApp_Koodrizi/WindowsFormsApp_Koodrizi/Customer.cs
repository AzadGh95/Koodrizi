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
    public partial class Customer : Form
    {
        private PersonRepository _personRepo = new PersonRepository();
        public Customer()
        {
            InitializeComponent();


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person()
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
                }
                else
                    MessageBox.Show("خطا در ذخیره سازی، لطفا مجددا تلاش کنید", "خطا");
            }
            catch (Exception ex)
            {
            //    MessageBox.Show(ex.Message);
                MessageBox.Show("خطا در ذخیره سازی، لطفا مجددا تلاش کنید", "خطا");
                throw;
            }


        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
