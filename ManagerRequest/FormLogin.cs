﻿using Denuncias.BL;
using System;
using System.Windows.Forms;



namespace ManagerRequest
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            var usuarioDB = _seguridad.Autorizar(usuario, contraseña);
        

            if (usuarioDB != null)
            {
                Program.usuario = usuarioDB;
                this.Hide();
                var form = new Form1();
                form.Show();
            }

            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
               && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
              && !string.IsNullOrEmpty(textBox1.Text)
              && !string.IsNullOrEmpty(textBox2.Text))

            {
                Autenticar();
            }

        }

        private void Autenticar()
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            usuario = textBox1.Text;
            contraseña = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Autenticando...";
            Application.DoEvents();


            var usuarioDB = _seguridad.Autorizar(usuario, contraseña);

            if (usuarioDB != null)
            {
                Program.usuario = usuarioDB;
                this.Hide();
                var form = new Form1();
                form.Show();
            }

            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }
        }
    }
}
