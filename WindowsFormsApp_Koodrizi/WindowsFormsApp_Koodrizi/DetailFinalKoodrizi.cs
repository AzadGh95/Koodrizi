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

    public partial class DetailFinalKoodrizi : Form
    {
        FinalKoodriziRepository _finalKoodriziRepository = new FinalKoodriziRepository();
        public DetailFinalKoodrizi()
        {
            InitializeComponent();
        }

        private void DetailFinalKoodrizi_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowListDetailKood_Click(object sender, EventArgs e)
        {
            string search = txtKoodNumber.Text;
            var finalListKood = _finalKoodriziRepository.FinalKoodrizi(search);

            if (finalListKood != null)
            {
                foreach (var item in finalListKood.DetailKoodrizis)
                {
                    dataGridDetailKoods.Rows.Add(item.Bar.Person.Name,
                        item.Bar.Ounce, item.Weight, item.Price.ToString("#,###")
                        , (item.Weight * (double)item.Price).ToString("#,###"));

                }
                lblBasePrice.Text = finalListKood.BasePrice.ToString("#,###");
                lblOunce.Text = finalListKood.TotalOunce.ToString();
                lblWeight.Text = finalListKood.TotalWeight.ToString();
                lblTotalPrice.Text = finalListKood.TotalPrice.ToString("#,###");
            }
            else
            {
                MessageBox.Show("هیچ کودریزی با این شماره پیدا نشد");
            }
        }

        private void DataGridDetailKoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
