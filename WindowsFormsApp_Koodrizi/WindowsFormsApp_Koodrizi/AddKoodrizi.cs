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
    public partial class AddKoodrizi : Form
    {
        private KoodriziRepository _koodriziRepo = new KoodriziRepository();
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private PersonRepository _personRepo = new PersonRepository();
        private BarRepository _barRepository = new BarRepository();

        public AddKoodrizi()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void AddKoodrizi_Load(object sender, EventArgs e)
        {


            // var peoples = _personRepo.Peoples();
            var peoplesBar = _barRepository.Bars();

            foreach (var p in peoplesBar)
                this.GridBarPerson.Items.Add(p.Person.Name + "  [" + p.Person.Code + "] " +
                    " نام پسته: " + p.PistachioName
                    + " انس: " + p.Ounce
                    + " گرم: " + p.Gram
                    + " درصددهن بست:" + p.DhanBast
                    + " عدل: " + p.Adl
                    + "موجودی : " + p.Remaining);

        }

        private void DataGridAddKood_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            //var barid = 
            var percentRoyat = DataGridAddKood.Rows[e.RowIndex].Cells[1].Value;//درصد رویت
            var weight = DataGridAddKood.Rows[e.RowIndex].Cells[2].Value;//وزن
            var sellDate = DataGridAddKood.Rows[e.RowIndex].Cells[3].Value;//تاریخ فروش
            var dueDate = DataGridAddKood.Rows[e.RowIndex].Cells[4].Value;//تاریخ سررسید
            var price = DataGridAddKood.Rows[e.RowIndex].Cells[5].Value;//قیمت کل
            var totalPrice = DataGridAddKood.Rows[e.RowIndex].Cells[6].Value;//قیمت کل

        }
    }
}
