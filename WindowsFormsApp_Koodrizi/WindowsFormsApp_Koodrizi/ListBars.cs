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
    public partial class ListBars : Form
    {
        private PersonRepository _personRepository = new PersonRepository();
        private  BarRepository _barRepository = new BarRepository();

        public ListBars()
        {
            InitializeComponent();
        }

        private void DataGridListBars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DialogResult message;
                string text = "آبا می خواهید ، " + dataGridListBars.Rows[e.RowIndex].Cells[2].Value + " را حذف کنید؟";
                message = MessageBox.Show(text, "هشدار", MessageBoxButtons.YesNo);

                if (message == DialogResult.Yes)
                {
                    _barRepository.Delete(int.Parse(dataGridListBars.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    dataGridListBars.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                }
            }
        }

        private void ListBars_Load(object sender, EventArgs e)
        {
            var bars = _barRepository.Bars();
            foreach (var prop in bars)
                dataGridListBars.Rows.Add(prop.BarId, prop.Person.Name, prop.CreateDate.ToString("yyyy/MM/dd") , prop.Remaining , 
                    prop.TotalWeight , prop.DhanBast,prop.Gram,prop.Ounce,prop.Adl);


        }
    }
}
