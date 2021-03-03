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
    /// <summary>
    /// نمایش کودریزی 
    /// </summary>
    public partial class ShowFinalKoodRizi : Form
    {
        public ShowFinalKoodRizi()
        {
            InitializeComponent();
        }
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private BarRepository _barRepo = new BarRepository();
        private KoodriziRepository _koodRepo = new KoodriziRepository();

        private void ShowFinalKoodRizi_Load(object sender, EventArgs e)
        {
            var collection = _finalKoodriziRepo.FinalKoodrizis();
            foreach (var item in collection)
            {
                var o = decimal.Parse(item.TotalOunce).ToString("#.##");
                dataGridView1.Rows.Add(item.KoodNumber, item.KoodName, o
                    , item.TotalWeight, item.TotalPrice.ToString("#,###"));
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DetailFinalKoodrizi detailFinalKoodrizi = new DetailFinalKoodrizi();
            detailFinalKoodrizi.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                //حذف
                var numberFinalKood = dataGridView1.Rows[e.RowIndex].Cells["gridNumber"].Value.ToString();
                var text = "آیا مطمئن هستید که میخواهید " + numberFinalKood + " را حذف کنید ؟";
                DialogResult message;
                message = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    //بعد از حذف باید جزئیات هم حذف شوند .
                    //و مقدار وزن و عدل بار ها به قبل برگردد
                    var finalKood = _finalKoodriziRepo.FinalKoodrizi(numberFinalKood);
                    foreach (var item in finalKood.DetailKoodrizis)
                    {
                        var bar = item.Bar;
                        bar.AdlRem = bar.AdlRem + item.Adl;
                        bar.Remaining = bar.Remaining + item.Weight;
                        //update
                        var result1 = _barRepo.Update(bar, bar.BarId);
                        if (!result1)
                        {
                            MessageBox.Show("حذف با مشکل مواجه شد", "خطا");
                        }

                        //حذف جزئیات
                        var result2 = _koodRepo.Delete(item.DId);
                        if (!result2)
                        {
                            MessageBox.Show("حذف با مشکل مواجه شد", "خطا");
                        }

                    }
                    var result3 = _finalKoodriziRepo.Delete(numberFinalKood);

                    if (result3)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("حذف با موفقیت انجام شد");
                    }
                }
            }
            if (e.ColumnIndex == 6)
            {
                //نمایش جزئیات
                Program.numberFinalKood = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DetailFinalKoodrizi detailFinalKoodrizi = new DetailFinalKoodrizi();
                detailFinalKoodrizi.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
