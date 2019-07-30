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

            }
            else{
                MessageBox.Show("Ocurrio un error al guardar el asunto");
            }

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _asuntos.AgregarAsunto();
            listaAsuntosBindingSource.MoveLast();
        }
    }
}
