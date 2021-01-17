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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) {
                //حذف
                var numberFinalKood = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                var text = "آیا مطمئن هستید که میخواهید " + numberFinalKood+" را حذف کنید ؟";
                DialogResult message;
                message = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    var result = _finalKoodriziRepo.Delete(numberFinalKood);
                    //بعد از حذف باید جزئیات هم حذف شوند .
                    //و مقدار وزن و عدل بار ها به قبل برگردد
                    if (result)
                    {
                        MessageBox.Show("حذف با موفقیت انجام شد");
                        

                    }
                }
            }
            if (e.ColumnIndex == 6) {
                //نمایش جزئیات
            }
        }
    }
}
