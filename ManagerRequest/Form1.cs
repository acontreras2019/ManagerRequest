using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void TransaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Program.usuario.UsuarioNombre;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void NuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNueva = new FormNueva();
            formNueva.MdiParent = this;
            formNueva.Show();
        }

        private void ClasificacionDeAsuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClasificacionAsunto = new FormClasificacionAsunto();
            formClasificacionAsunto.MdiParent = this;
            formClasificacionAsunto.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTipoTransaccion = new FormTipoTransaccion();
            formTipoTransaccion.MdiParent = this;
            formTipoTransaccion.Show();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTipoTransaccion = new FormCiudad();
            formTipoTransaccion.MdiParent = this;
            formTipoTransaccion.Show();
        }

        private void reporteDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var formReporteAsunto = new FormReporteAsunto();
            formReporteAsunto.MdiParent = this;
            formReporteAsunto.Show();
        }

        private void reporteDeTransaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var formReporteTransaccion = new FormReporteTransaccion();
            formReporteTransaccion.MdiParent = this;
            formReporteTransaccion.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formmantenimientousuarios = new Mantenimientousuarios();
            Formmantenimientousuarios.MdiParent = this;
            Formmantenimientousuarios.Show();
        }
    }
}
