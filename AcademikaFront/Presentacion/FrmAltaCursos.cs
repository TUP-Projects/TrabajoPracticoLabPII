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
using System.Text.RegularExpressions;
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

        public async Task Inicia()
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
            nombreCurso.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(nombreCurso.Text.Trim()))
            {
                MessageBox.Show("Se debe ingresar un nombre de curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;
            
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
        private async Task<bool> BorrarCursoAsync(int idCurso)
        {
            string urlBase = "https://localhost:44365/api/Cursos/" + idCurso;
            bool resultado = Convert.ToBoolean(await ClienteSingleton.GetInstancia().DeleteAsync(urlBase));
            return resultado;
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int idCurso;
            if (dgvCursos.RowCount > 0)
            {
                idCurso = Convert.ToInt32(dgvCursos.CurrentRow.Cells["ID"].Value);
                bool success = await BorrarCursoAsync(idCurso);

                if (success)
                {
                    MessageBox.Show("Se eliminó el registro seleccionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarDgvAsync();
                }
                else
                {
                    MessageBox.Show("Error al intentar borrar el curso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a borrar", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentRow != null)
            {
                FrmEdit frmEdit = new FrmEdit();
                AddOwnedForm(frmEdit);
                int idCurso = Convert.ToInt32(dgvCursos.CurrentRow.Cells["ID"].Value);
                frmEdit.CargarDatos(Forms.Curso, idCurso);
                frmEdit.ShowDialog();
                Inicia();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nombreCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar) || Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
