using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Koodrizi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void BtnBar_Click(object sender, EventArgs e)
        {
            Bar bar = new Bar();
            bar.Show();
        }

        private void BtnFinalKoodrizi_Click(object sender, EventArgs e)
        {
            FinallKoodrizi formFinalKoodrizi = new FinallKoodrizi();
            formFinalKoodrizi.Show();
            //AddKoodrizi addKood = new AddKoodrizi();
            //addKood.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblTime.Text = "dualp.ir";
        }

        private void BtnListPerson_Click(object sender, EventArgs e)
        {
            ListCustomer listCustomer = new ListCustomer();
            listCustomer.Show();
        }

        private void BtnListBar_Click(object sender, EventArgs e)
        {
            ListBars listBars = new ListBars();
            listBars.Show();
        }

        private void BtnListKoodrizi_Click(object sender, EventArgs e)
        {
            //DetailFinalKoodrizi detailFinalKoodrizi = new DetailFinalKoodrizi();
            //detailFinalKoodrizi.Show();
            ShowFinalKoodRizi showFinalKoodRizi = new ShowFinalKoodRizi();
            showFinalKoodRizi.Show();
        }
    }
}
