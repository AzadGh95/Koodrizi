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
                dataGridListCustomer.Rows.Add(prop.PersonId, prop.Code, prop.Name, prop.Total,
                    prop.BaseDate.ToString("yyyy/MM/dd"), prop.AvgDate.ToString("yyyy/MM/dd"));
        }



        private void DataGridListCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DialogResult message;
                string text = "آیا می خواهید ، " + dataGridListCustomer.Rows[e.RowIndex].Cells[2].Value + " را حذف کنید؟";
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

            if (e.ColumnIndex == 7)
            {
                var pId = int.Parse(dataGridListCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
                var person =_personRepository.People(pId);
                ModalBaseTime formBaseTime = new ModalBaseTime();
                var basetime = formBaseTime.BaseTime;
                var avgdate=AvgDateTime(basetime, pId);

                person.AvgDate = avgdate;
                person.BaseDate = basetime;
                _personRepository.Update(person, pId);

                
                //ویرایش گرید ویو
                //dataGridview.clear();
                //نمایش داده های جدید
            }

        }
        private DateTime AvgDateTime(DateTime dateTime, int id)
        {
            return dateTime;
        }

    }
}
