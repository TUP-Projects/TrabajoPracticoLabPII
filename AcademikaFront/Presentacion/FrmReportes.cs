using AcademikaBackend.BusinessLayer.Services;
using AcademikaFront.Presentacion.Reportes;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Academika.Presentacion
{
    public partial class FrmReportes : Form
    {
        private readonly ReportViewer reportViewer;

        private IMateriasService servicio;
        public FrmReportes()
        {
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
            InitializeComponent();
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);

        }

        protected override void OnLoad(EventArgs e)
        {
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            Reporte.Load(reportViewer.LocalReport, servicio, 0);
            cboReporte.DataSource = servicio.CargaCombos("carreras");
            cboReporte.DisplayMember = "Descripcion";
            cboReporte.ValueMember = "ID";
            this.reportViewer.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboReporte.SelectedIndex != -1)
            {

                Reporte.Load(reportViewer.LocalReport, servicio, (int)cboReporte.SelectedValue);

                reportViewer.RefreshReport();

            }
            else
            {
                MessageBox.Show
                ("Elija un torneo para generar el informe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
