using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apparcial2.Model;

namespace apparcial2
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }
        usuarios usalo = new usuarios();

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin logg = new frmLogin();
            logg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (gobEntities db = new gobEntities())
            {
                if (txtIngresarDUI.Text == usalo.DUI)
                {

                    labBeneficiario.Visible = true;
                }
                else
                {
                    labResultado.Text = "No eres beneficiado";
                }
            }
        }
    }
}
