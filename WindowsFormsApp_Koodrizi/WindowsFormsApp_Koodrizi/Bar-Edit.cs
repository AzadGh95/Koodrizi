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
    public partial class Bar_Edit : Form
    {
        public Bar_Edit()
        {
            InitializeComponent();
        }
        private BarRepository _barRepository = new BarRepository();
        private void Bar_Edit_Load(object sender, EventArgs e)
        {
            if (Program.BarId != 0)
            {
                var bar = _barRepository.Bar(Program.BarId);
                comCustomerSelection.Text = bar.Person.Name;
            }
        }
    }
}
