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
    public partial class AvgPersonModelList : Form
    {
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
        }
    }
}
