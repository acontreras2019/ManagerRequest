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
    public partial class FormReporteAsunto : Form
    {
        public FormReporteAsunto()
        {
            InitializeComponent();

            //var _asuntosBL = new AsuntosBL();
            //var bindingSourse = new BindingSource();
            //bindingSourse.DataSource = _asuntosBL.ObtenerAsuntos();

            //var _companyBL = new CompanyBL();
            //bindingSourse.DataSource = _companyBL.ObtenerCompanies();

            //var _ciudadBL = new CiudadBL();
            //bindingSourse.DataSource = _ciudadBL.ObtenerCiudad();

            //var reporte = new CrystalReport2();
            //reporte.SetDataSource(bindingSourse);

            //crystalReportViewer1.ReportSource = reporte;
            //crystalReportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)

        {
            var lista = new List<ModeloReporteAsuntos>();

            var transaccionBL = new TransaccionBL();
            var transacciones = transaccionBL.ObtenerTransaccionPorEstatus(comboBox1.Text);

            foreach (var transaccion in transacciones)
            {
                var item = new ModeloReporteAsuntos();
                item.Nombre = transaccion.UsuarioNombre;
                item.Asunto = transaccion.Asunto.Descripcion;
                item.Fecha = transaccion.FechaTransaccion;
                item.Medio = transaccion.TipoMedio.Descripcion;
                item.Status = transaccion.Estatus.Descripcion;
                item.Tipo = transaccion.TipoSolicitante.Descripcion;

                lista.Add(item);
            }
            var bindingSource = new BindingSource();
            bindingSource.DataSource = lista;

            var reporte = new ReporteTransaccion();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
        }

        private void FormReporteAsunto_Load(object sender, EventArgs e)
        {

        }

        class ModeloReporteAsuntos
        {
            public string Nombre { get; set; }
            public string Medio { get; set; }
            public DateTime Fecha { get; set; }
            public string Tipo { get; set; }
            public string Status { get; set; }
            public string Asunto { get; set; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}