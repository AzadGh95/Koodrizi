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
    public partial class ShowFinalKoodRizi : Form
    {
        public ShowFinalKoodRizi()
        {
            InitializeComponent();
        }
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();

        private void ShowFinalKoodRizi_Load(object sender, EventArgs e)
        {
         var collection=   _finalKoodriziRepo.FinalKoodrizis();
            foreach (var item in collection)
            {
                dataGridView1.Rows.Add(item.KoodNumber, item.KoodName, item.TotalOunce, item.TotalWeight, item.TotalPrice.ToString("#,###"));
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DetailFinalKoodrizi detailFinalKoodrizi = new DetailFinalKoodrizi();
            detailFinalKoodrizi.Show();
        }
    }
}
