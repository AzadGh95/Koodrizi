﻿using FarsiLibrary.Utils;
using System;
using System.Windows.Forms;
using WindowsFormsApp_Koodrizi.Repositories;

namespace WindowsFormsApp_Koodrizi
{
    public partial class ListBars : Form
    {
        private PersonRepository _personRepository = new PersonRepository();
        private BarRepository _barRepository = new BarRepository();

        public ListBars()
        {
            InitializeComponent();
        }

        private void DataGridListBars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DialogResult message;
                string text = "آبا می خواهید ، بار  " + dataGridListBars.Rows[e.RowIndex].Cells[1].Value + " را حذف کنید؟";
                message = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);

                if (message == DialogResult.Yes)
                {
                    var result = _barRepository.Delete(int.Parse(dataGridListBars.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    if (result)
                    {
                        dataGridListBars.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("حذف با موفقیت انجام شد");
                    }
                    else
                    {
                        MessageBox.Show("امکان حذف وجود ندارد ");

                    }

           
                }
                else
                {
                }
            }
            if (e.ColumnIndex == 10)
            {
                Program.BarId = int.Parse(dataGridListBars.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (Program.BarId != 0)
                {
                    Bar_Edit bar_Edit = new Bar_Edit();
                    bar_Edit.Show();
                    Close();
                }
            }
        }

        private void ListBars_Load(object sender, EventArgs e)
        {
            var bars = _barRepository.Bars();
            foreach (var prop in bars)
                dataGridListBars.Rows.Add(prop.BarId, prop.Person.Name,
                    PersianDateConverter.ToPersianDate(prop.CreateDate).ToString("yyyy/MM/dd"),
                    prop.Remaining, prop.TotalWeight, prop.DhanBast,
                    prop.Gram, prop.Ounce, prop.Adl);
        }
    }
}
