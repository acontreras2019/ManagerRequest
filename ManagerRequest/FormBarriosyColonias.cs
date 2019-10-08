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
    
    public partial class FormBarriosyColonias : Form
    {
        ColoniaBL _coloniaBL;
        public FormBarriosyColonias()
        {
            InitializeComponent();
            _coloniaBL = new ColoniaBL();
            listaColoniaBindingSource.DataSource = _coloniaBL.ObtenerColonia();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


            listaColoniaBindingSource.MoveLast();
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
        }

        private void listaColoniaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            listaColoniaBindingSource.EndEdit();

            var colonia = (Colonia)listaColoniaBindingSource.Current;
            colonia.Usuario = Program.usuario;

            var resultado = _coloniaBL.GuardarColonia(colonia);

            if (resultado == "OK")
            {
                listaColoniaBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("GUARDADO CON EXITO");
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }
    }

}

