﻿using Denuncias.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var archivo = openFileDialog1.FileName;
            if (archivo != "")
            {
                var fileinfo = new FileInfo(archivo);
                var filestring = fileinfo.OpenRead();

                fotoPictureBox.Image = Image.FromStream(filestring);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
