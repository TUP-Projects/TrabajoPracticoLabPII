using Academika.Client;
using AcademikaBackend.BusinessLayer.Services;
using Newtonsoft.Json;
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
    public partial class FrmAltaCursos : Form
    {

        private bool VerAyuda = false;
        private ICursosService servicio;
        public FrmAltaCursos()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceCursos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ConsultaID()
        {
            lblLegajoDocente.Text = "ID Curso: " + servicio.ObtenerProxId("CURSOS").ToString();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("- Estado = 0 corresponde a: Deshabilitado");
            _stringBuilder.Append("- Estado = 1 corresponde a: Habilitado");
            rtbAyuda.Text = _stringBuilder.ToString();
            if (VerAyuda)
            {
                VerAyuda = rtbAyuda.Visible = false;
            }
            else
            {
                VerAyuda = rtbAyuda.Visible = true;
            }
        }

        private void Inicia()
        {
            ConsultaID();
            CargarDgvAsync();
        }
        private async Task CargarDgvAsync()
        {
            string urlBase = "https://localhost:44365/api/Cursos/Consulta/";

            var resultado = await ClienteSingleton.GetInstancia().GetAsync(urlBase);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(resultado, (typeof(DataTable)));

            dgvCursos.DataSource = dt;
        }
    }
}
