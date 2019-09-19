using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Denuncias.BL;

namespace ManagerRequest
{
    public partial class FormCiudad : Form
    {
        CiudadBL _ciudadBL;
        public FormCiudad()
        {
            InitializeComponent();
            _ciudadBL = new CiudadBL();
            listaCiudadBindingSource.DataSource = _ciudadBL.ObtenerCiudad();

        }

        private void ciudadNombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormCiudad_Load(object sender, EventArgs e)
        {

        }

        private void listaCiudadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaCiudadBindingSource.EndEdit();
            var ciudad = (Ciudad)listaCiudadBindingSource.Current;
            ciudad.Usuario = Program.usuario;
            var resultado = _ciudadBL.GuardarCiudad(ciudad);
            int ii = 0;
            if (int.TryParse(resultado, out ii))
            {

                listaCiudadBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Guardado Correctamente: " + resultado);

            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar el asunto: " + resultado);
            }
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        private void Eliminar(int id)
        {

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult accion = MessageBox.Show("Esta seguro que desea ELIMINAR este registro?", "Manager Request", buttons);

            //"Esta seguro que desea ELIMINAR este registro?"
            if (accion.ToString() == "Cancel")
            {
                return;
            }
            var resultado = _ciudadBL.EliminarCiudad(id);

            if (resultado == true)
            {
                listaCiudadBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Eliminar el Asunto");
            }

        }
        

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _ciudadBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
}
