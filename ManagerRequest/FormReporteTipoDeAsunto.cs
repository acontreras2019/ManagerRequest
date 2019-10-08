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
    public partial class FormReporteTipoDeAsunto : Form
    {
        public FormReporteTipoDeAsunto()
        {
            InitializeComponent();
            var tipodeasuntoBL = new AsuntosBL();
            var asuntos = tipodeasuntoBL.ObtenerAsuntos();


            var bindingSource = new BindingSource();
            bindingSource.DataSource = asuntos;

            var reporte = new CrystalReport3();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;


        }


        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        var lista = new List<ModeloReporteTransaccion>();

        //        var transaccionBL = new TransaccionBL();
        //        var transacciones = transaccionBL.ObtenerTransaccionPorEstatus(comboBox1.Text);

        //        foreach (var transaccion in transacciones)
        //        {
        //            var item = new ModeloReporteTransaccion();
        //            item.Nombre = transaccion.UsuarioNombre;
        //            item.Asunto = transaccion.Asunto.Descripcion;
        //            item.Fecha = transaccion.FechaTransaccion;
        //            item.Medio = transaccion.TipoMedio.Descripcion;
        //            item.Status = transaccion.Estatus.Descripcion;
        //            item.Tipo = transaccion.TipoSolicitante.Descripcion;

        //            lista.Add(item);
        //        }


        //    }
        //}

        //class ModeloReporteTransaccion
        //{
        //    public string Nombre { get; set; }
        //    public string Medio { get; set; }
        //    public DateTime Fecha { get; set; }
        //    public string Tipo { get; set; }
        //    public string Status { get; set; }
        //    public string Asunto { get; set; }
        //}
    }
}