﻿using System;
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
    public partial class ListCustomer : Form
    {
        private PersonRepository _personRepository = new PersonRepository();
        public ListCustomer()
        {
            InitializeComponent();
        }


        private void ListCustomer_Load(object sender, EventArgs e)
        {
            //int row = 1;
            var people = _personRepository.Peoples();
            foreach (var prop in people)
                dataGridListCustomer.Rows.Add(prop.PersonId, prop.Code, prop.Name, prop.Total, prop.AvgDate.ToString("yyyy/MM/dd"));



            //DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            //dataGridListCustomer.Columns.Add(btnDelete);
            //btnDelete.HeaderText = "حذف";
            //btnDelete.Text = "حذف";
            //btnDelete.Name = "btnDelete";
            //btnDelete.UseColumnTextForButtonValue = true;
            //btnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ////................
            //DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            //dataGridListCustomer.Columns.Add(btnEdit);
            //btnEdit.HeaderText = "ویرایش";
            //btnEdit.Text = "ویرایش";
            //btnEdit.Name = "btnEdit";
            //btnEdit.UseColumnTextForButtonValue = true;
            //btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }



        private void DataGridListCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DialogResult message;
                string text = "آبا می خواهید ، " + dataGridListCustomer.Rows[e.RowIndex].Cells[2].Value + " را حذف کنید؟";
                message = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);

                if (message == DialogResult.Yes)
                {
                    _personRepository.Delete(int.Parse(dataGridListCustomer.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    dataGridListCustomer.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                }
            }

        
        }


    }
}
