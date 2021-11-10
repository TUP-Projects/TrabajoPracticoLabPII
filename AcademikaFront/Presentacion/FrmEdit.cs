using Academika.Client;
using AcademikaBackend.BusinessLayer.Entities;
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

        private async void FrmAltaCursos_Load(object sender, EventArgs e)
        {
            await Inicia();
        }

        private async Task ConsultaID()
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
                VerAyuda = rtbAyuda.Visible = false;
            else
                VerAyuda = rtbAyuda.Visible = true;
        }

        private async Task Inicia()
        {
            await ConsultaID();
            await CargarDgvAsync();
        }

        private async Task CargarDgvAsync()
        {
            string urlBase = "https://localhost:44365/api/Cursos/Consulta/";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(urlBase);
            List<Curso> Cursos = JsonConvert.DeserializeObject<List<Curso>>(resultado);
            dgvCursos.DataSource = Cursos;
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

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            Curso curso = new()
            {
                NombreCurso = nombreCurso.Text
            };
            string data = JsonConvert.SerializeObject(curso);
            

            bool success = await GrabarCursoAsync(data);
            if (success)
            {
                MessageBox.Show("Curso registrado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LimpiarCamposAsync();
            }
            else
            {
                MessageBox.Show("El curso ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> GrabarCursoAsync(string data)
        {
            string urlBase = "https://localhost:44365/api/Cursos/";
            bool resultado = Convert.ToBoolean(await ClienteSingleton.GetInstancia().PostAsync(urlBase, data));
            return resultado;
        }

        private async Task LimpiarCamposAsync()
        {
            nombreCurso.Text = "";
            await Inicia();
        }

    }
}
