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

namespace Koodrizi
{
    public partial class Customer : Form
    {
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
                    Name = txtName.Text,
                    PhoneNumber = txtPhone.Text,
                    Code = txtCod.Text,
                };
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در ذخیره سازی، لطفا مجددا تلاش کنید", "خطا");
                throw;
            }


        }
    }
}
