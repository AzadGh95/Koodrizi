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
    public partial class Koodrizi : Form
    {
        private KoodriziRepository _koodriziRepo = new KoodriziRepository();
        private FinalKoodriziRepository _finalKoodriziRepo = new FinalKoodriziRepository();
        private PersonRepository _personRepo = new PersonRepository();
        private BarRepository _barRepo = new BarRepository();
        
        public Koodrizi()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
