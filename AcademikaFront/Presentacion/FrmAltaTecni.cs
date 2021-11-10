using Academika.Client;
using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academika.Presentacion
{
    public partial class FrmAltaTecni : Form
    {
        private bool VerAyuda = false;
        private IMateriasService servicio;

        public FrmAltaTecni()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
        }

        private void ConsultaID()
        {
            lblLegajoDocente.Text = "ID Tecnicatura: " + servicio.ObtenerProxId("CARRERAS").ToString();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("- Estado = 0 corresponde a: Deshabilitado");
            _stringBuilder.Append("- Estado = 1 corresponde a: Habilitado");
            rtbAyuda.Text = _stringBuilder.ToString();
           if (VerAyuda)
            VerAyuda = rtbAyuda.Visible = false;
           else
              VerAyuda = rtbAyuda.Visible = true;
        }

        private void FrmAltaTecni_Load(object sender, EventArgs e)
        {
            Inicia();
        }

        private void Inicia()
        {
            ConsultaID();
            _ = CargarDgvAsync();
        }

        private async Task CargarDgvAsync()
        {
            string urlBase = "https://localhost:44365/api/Carreras/Consulta/";

            var resultado = await ClienteSingleton.GetInstancia().GetAsync(urlBase);
            List<Carrera> Carreras = JsonConvert.DeserializeObject<List<Carrera>>(resultado);
            dgvTecnicatura.DataSource = Carreras;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
