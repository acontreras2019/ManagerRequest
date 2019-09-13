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

        TransaccionBL _transaccionBL;
        ColoniaBL _coloniaBL;
        CiudadBL _ciudadBL;
       TipodeDocumentoBL _tipodedocumentoBL;
        AsuntosBL _asuntoBL;


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

            _asuntoBL = new AsuntosBL();
            listaAsuntosBindingSource.DataSource = _asuntoBL.ObtenerAsuntos();
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
         
        }
    }
}
