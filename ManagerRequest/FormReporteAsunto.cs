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

            var _asuntosBL = new AsuntosBL();
            var bindingSourse = new BindingSource();
            bindingSourse.DataSource = _asuntosBL.ObtenerAsuntos();

            var _companyBL = new CompanyBL();
            bindingSourse.DataSource = _companyBL.ObtenerCompanies();

            var _ciudadBL = new CiudadBL();
            bindingSourse.DataSource = _ciudadBL.ObtenerCiudad();

            var reporte = new CrystalReport2();
            reporte.SetDataSource(bindingSourse);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }

    }
}
