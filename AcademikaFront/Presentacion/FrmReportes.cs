using AcademikaFront.Presentacion.Reportes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academika.Presentacion
{
    public partial class FrmReportes : Form
    {
		private readonly ReportViewer reportViewer;
		public FrmReportes()
        {
            InitializeComponent();
			reportViewer = new ReportViewer();
			reportViewer.Dock = DockStyle.Fill;
			
			
			Controls.Add(reportViewer);


		}

		protected override void OnLoad(EventArgs e)
		{
			Reporte.Load(reportViewer.LocalReport);
			reportViewer.RefreshReport();
			base.OnLoad(e);
		}
	}
}
