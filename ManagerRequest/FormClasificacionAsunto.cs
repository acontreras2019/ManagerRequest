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
        public FormClasificacionAsunto()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;
            var descripcion = textBox2.Text;

            checkedListBox1.Items.Add(descripcion);

        }
    }
}
