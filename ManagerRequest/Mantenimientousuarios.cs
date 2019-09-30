using Denuncias.BL;
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
    public partial class Mantenimientousuarios : Form
    {
        SeguridadBL _seguridadBL;

        public Mantenimientousuarios()
        {
            InitializeComponent();

            _seguridadBL = new SeguridadBL();
            listaUsuariosBindingSource.DataSource = _seguridadBL.ObtenerUsuarios();
        }

        private void usuarioNombreLabel_Click(object sender, EventArgs e)
        {

        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _seguridadBL.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false);
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
            //toolStripButtonCancelar.Visible = !valor;
        }

        private void listaUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            listaUsuariosBindingSource.EndEdit();
            var usuarion = (Usuario)listaUsuariosBindingSource.Current;
            var resultado = _seguridadBL.GuardarUsuario(usuarion);
         

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario Guardado Exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al añadir usuario");
            }
        }

        private void Mantenimientousuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
