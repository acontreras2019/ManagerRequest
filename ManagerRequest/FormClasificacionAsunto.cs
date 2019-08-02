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
    public partial class FormClasificacionAsunto : Form
    {
        AsuntosBL _asuntos;
        public FormClasificacionAsunto()
        {
            InitializeComponent();
            _asuntos = new AsuntosBL();
            listaAsuntosBindingSource.DataSource = _asuntos.ObtenerAsuntos();
        }

        private void ListaAsuntosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaAsuntosBindingSource.EndEdit();
            var asunto = (Asunto)listaAsuntosBindingSource.Current;
            var resultado = _asuntos.GuardarAsunto(asunto);

            if(resultado==true){

                listaAsuntosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);

            }
            else{
                MessageBox.Show("Ocurrio un error al guardar el asunto");
            }

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _asuntos.AgregarAsunto();
            listaAsuntosBindingSource.MoveLast();

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
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var id = Convert.ToInt32(idTextBox.Text);
                Eliminar(id);
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _asuntos.EliminarAsunto(id);

            if (resultado == true)
            {
                listaAsuntosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Eliminar el Asunto");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
