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
    public partial class frmInformacion : Form
    {
        public frmInformacion()
        {
            InitializeComponent();
        }
        usuarios usalo = new usuarios();


        private void button3_Click(object sender, EventArgs e)
        {
            using (gobEntities db = new gobEntities())
            {
                //var Usuarios = db.usuarios;

                //foreach(var interarr in Usuarios)
                //{
                //    dtvInformacion.Rows.Add(interarr.id, interarr.nombre, interarr.DUI);
                //}

                dtvInformacion.DataSource = db.usuarios.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (gobEntities db = new gobEntities())
            {

                           
                usalo.nombre = txtNombre.Text;
                usalo.DUI = txtDUI.Text;

                db.usuarios.Add(usalo);
                db.SaveChanges();

             


            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            using (gobEntities db = new gobEntities())
            {

                String id = dtvInformacion.CurrentRow.Cells[0].Value.ToString();
                usalo = db.usuarios.Find(int.Parse(id));
                db.usuarios.Remove(usalo);
                db.SaveChanges();
            }
        }




    }
}
