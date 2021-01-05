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
            int i = 0;
            if (finalListKood != null)
            {
                foreach (var item in finalListKood.DetailKoodrizis)
                {
                    dataGridDetailKoods.Rows[i].Cells[0].Value = item.Bar.Person.Name + " [" + item.Bar.Person.Code + "] ";
                    dataGridDetailKoods.Rows[i].Cells[1].Value = item.Bar.Ounce;
                    dataGridDetailKoods.Rows[i].Cells[2].Value = item.Weight;
                    dataGridDetailKoods.Rows[i].Cells[3].Value = item.Price;
                    dataGridDetailKoods.Rows[i].Cells[4].Value = ((double)item.Price * item.Weight).ToString("#,###");

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
    }
}
