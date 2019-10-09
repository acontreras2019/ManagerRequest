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
            List<string> opciones1 = new List<string>();
            opciones1.Add("Transaccion");

            List<string> opciones2 = new List<string>();
            opciones1.Add("Transaccion");
            opciones1.Add("Mantenimiento");
             opciones1.Add("Reporte");

            if(Program.usuario.RolId== 2)// si es usuario Servicio al Cliente
            {
                matenimientoToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                seguridadToolStripMenuItem.Visible = false;
            }

            if (Program.usuario.RolId == 3) // si es usuario de tipo Gerente
            {
                matenimientoToolStripMenuItem.Visible = false;
                seguridadToolStripMenuItem.Visible = false;

            }

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

            var formReporteTransaccion = new FormReporteTipoDeAsunto();
            formReporteTransaccion.MdiParent = this;
            formReporteTransaccion.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formmantenimientousuarios = new Mantenimientousuarios();
            Formmantenimientousuarios.MdiParent = this;
            Formmantenimientousuarios.Show();
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formlogin = new FormLogin();
            formlogin.Closed += (s, args) => this.Close();
            formlogin.Show();
        }

        private void barriosYColoniasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormBarriosyColonia = new FormBarriosyColonias();
            FormBarriosyColonia.MdiParent = this;
            FormBarriosyColonia.Show();

        }

        private void informacionDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mannager Request: Version 1.0");
        }

        private void creadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var FormFoto = new FormFoto();
            FormFoto.MdiParent = this;
            FormFoto.Show();
        }
    }
}
