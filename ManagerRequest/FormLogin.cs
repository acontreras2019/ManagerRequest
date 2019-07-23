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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (usuario == "admin" && contraseña == "123")
            {
                this.Hide();
                var form = new Form1();
                form.Show();

            }
            else
            {
                if (usuario == "user" && contraseña == "456")
                {
                    this.Hide();
                    var form = new Form1();
                    form.Show();
                }
                else{
                    MessageBox.Show("usuario o contraseña incorrecta");
                }
                
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
