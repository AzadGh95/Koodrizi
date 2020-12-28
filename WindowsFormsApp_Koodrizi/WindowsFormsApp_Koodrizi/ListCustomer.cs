using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Koodrizi
{
    public partial class ListCustomer : Form
    {
        public ListCustomer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            int row = 1;
            dataGridListCustomer.Rows.Add(row,0120,"نیکی کریمی",210500, DateTime.UtcNow);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
     
        private void DataGridListCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
