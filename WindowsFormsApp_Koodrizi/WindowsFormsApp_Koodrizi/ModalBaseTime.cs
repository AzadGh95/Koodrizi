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
    public partial class ModalBaseTime : Form
    {
        public ModalBaseTime()
        {
            InitializeComponent();
        }
        public DateTime BaseTime;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            BaseTime = faDatePicker1.SelectedDateTime;
            Close();
        }
    }
}
