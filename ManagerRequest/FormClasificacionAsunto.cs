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
        CompanyBL _company;
        public FormClasificacionAsunto()
        {
            InitializeComponent();
            _asuntos = new AsuntosBL();
            _company = new CompanyBL();
            listaAsuntosBindingSource.DataSource = _asuntos.ObtenerAsuntos();
            listaCompanyBindingSource.DataSource = _company.ObtenerCompanies();
        }

        private void ListaAsuntosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaAsuntosBindingSource.EndEdit();
            var asunto = (Asunto)listaAsuntosBindingSource.Current;
            asunto.Usuario= Program.usuario;
            var resultado = _asuntos.GuardarAsunto(asunto);
            int ii =0;
            if(int.TryParse(resultado, out ii)){

                listaAsuntosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                 MessageBox.Show("Guardado Correctamente: " + resultado);

            }
            else{
                MessageBox.Show("Ocurrio un error al guardar el asunto: " + resultado);
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
            
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;  
            DialogResult accion = MessageBox.Show("Esta seguro que desea ELIMINAR este registro?", "Manager Request", buttons);
             
             //"Esta seguro que desea ELIMINAR este registro?"
             if(accion.ToString() =="Cancel"){
                return;
             }
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

        private void listaAsuntosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listaAsuntosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void descripcionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listaCompanyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void companyIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void companyIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormClasificacionAsunto_Load(object sender, EventArgs e)
        {

        }
    }
}


