using AcademikaBackend.BusinessLayer.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademikaFront.Presentacion.Reportes
{
    class Reporte
    {
        
       
        public static void Load(LocalReport report, IMateriasService servicio)
        {
                

                 DataTable dt = new DataTable();

                dt = servicio.Consulta_PlanEstudios();
                
                string ruta = Path.GetFullPath("..\\..\\..\\Presentacion\\Reportes\\Report.rdlc");

                using var fs = new FileStream(ruta, FileMode.Open);
                ReportDataSource reportDataSource = new ReportDataSource();
                report.LoadReportDefinition(fs);
                
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "dsPlan";
                reportDataSource.Value = dt;
                report.DataSources.Add(reportDataSource);


        }
    }
}
