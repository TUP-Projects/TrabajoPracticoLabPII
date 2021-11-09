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
        public static void Load(LocalReport report)
        {

            string rvConnection = @"Data Source = .\SQLEXPRESS; Initial Catalog = Academika; Integrated Security = True";
            using (SqlConnection sqlConn = new SqlConnection(rvConnection))
            using (SqlDataAdapter da = new SqlDataAdapter("select * from dbo.vw_plan_estudios", rvConnection))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
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
}
