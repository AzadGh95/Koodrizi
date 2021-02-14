using FarsiLibrary.Utils;
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
    public partial class AvgPersonModelList : Form
    {

        AvgPersonRepository _avgPersonRepository = new AvgPersonRepository();
        PersonRepository _personRepository = new PersonRepository();
        public AvgPersonModelList()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNewAvg_Click(object sender, EventArgs e)
        {
            CalculateAvgPerson calculateAvgPerson = new CalculateAvgPerson();
            calculateAvgPerson.Show();
            Close();
        }

        private void AvgPersonModelList_Load(object sender, EventArgs e)
        {
            var listAvgPerson = _avgPersonRepository.AvgPersonModels(Program.PersonId);
            var person = _personRepository.People(Program.PersonId);
            lblPersonName.Text = person.Name;
            foreach (var item in listAvgPerson)
            {
                dataGridViewAvg.Rows.Add(
                    item.Id,
                    PersianDateConverter.ToPersianDate(item.CreatDate).ToString("yyyy/MM/dd"),
                    PersianDateConverter.ToPersianDate(item.AvgDate).ToString("yyyy/MM/dd"),
                    item.Bedehi.ToString("#,###"));
            }

        }

        private void DataGridViewAvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult message1;
                string text = "آبا مطمئن هستید؟";
                message1 = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);

                if (message1 == DialogResult.Yes)
                {
                    var result = _avgPersonRepository.DeleteAvgPerson
                        (int.Parse(dataGridViewAvg.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (result)
                    {
                        dataGridViewAvg.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("حذف با موفقیت انجام شد");
                    }
                    else
                    {
                        MessageBox.Show("امکان حذف وجود ندارد ");

                    }
                }
            }
        }
    }
}
