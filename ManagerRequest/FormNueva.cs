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
    public partial class FormNueva : Form
    {
        TipoSolicitanteBL _tiposolicitanteBL;
        TransaccionBL _transaccionBL;
        ColoniaBL _coloniaBL;
        CiudadBL _ciudadBL;
        TipodeDocumentoBL _tipodedocumentoBL;
        AsuntosBL _asuntoBL;
        TipoMedioBL _tipoMedioBL;
        EstatusBL _estatusBL;


        public FormNueva()
        {
            InitializeComponent();

            _transaccionBL = new TransaccionBL();
            listaTransaccionBindingSource.DataSource = _transaccionBL.ObtenerTransaccion();

            _coloniaBL = new ColoniaBL();
            listaColoniaBindingSource.DataSource = _coloniaBL.ObtenerColonia();

            _ciudadBL = new CiudadBL();
            listaCiudadBindingSource.DataSource = _ciudadBL.ObtenerCiudad();

            _tipodedocumentoBL = new TipodeDocumentoBL();
            listatipoDocumentoBindingSource.DataSource = _tipodedocumentoBL.Obtenertipodedocumento();


            _tipoMedioBL = new TipoMedioBL();
            listamedioBindingSource.DataSource = _tipoMedioBL.Obtenermedios();

            _asuntoBL = new AsuntosBL();
            listaAsuntosBindingSource.DataSource = _asuntoBL.ObtenerAsuntos();

            _tiposolicitanteBL = new TipoSolicitanteBL();
            listasolicitantesBindingSource.DataSource = _tiposolicitanteBL.ObtenerSolicitantes();

            _estatusBL = new EstatusBL();
            listaEstatusBindingSource.DataSource = _estatusBL.ObtenerEstatus();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void FormNueva_Load(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _transaccionBL.AgregarTransacciom();
            listaTransaccionBindingSource.MoveLast();

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

        private void listaTransaccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaTransaccionBindingSource.EndEdit();

            var transaccion = (Transaccion)listaTransaccionBindingSource.Current;
            transaccion.Usuario = Program.usuario;

            var resultado = _transaccionBL.GuardarTransaccion(transaccion);

            if (resultado == "OK")
            {
                listaTransaccionBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("GUARDADO CON EXITO");
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);

        }

        private void toolStripButtonCancelar_Click_1(object sender, EventArgs e)
        {
            _transaccionBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show(" ¿Desea Anular Esta Transaccion?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _transaccionBL.AnularTransaccion(id);
            if (resultado == true)
            {
                listaTransaccionBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Problema al Anular la Transaccion");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtfiltro_Click(object sender, EventArgs e)
        {
            asuntosDataGridView.CurrentCell = null;
            if (txtfiltro.Text != "")
            {
                foreach (DataGridViewRow r in asuntosDataGridView.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in asuntosDataGridView.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtfiltro.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;

                        }
                        else
                        {
                            MessageBox.Show("No se encongr+o el Registro");
                        }

                    }
                }
            }
        }
    }
}

