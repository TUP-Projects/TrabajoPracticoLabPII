using Academika.Client;
using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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

        private async Task ConsultaID()
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

        private async void FrmAltaTecni_Load(object sender, EventArgs e)
        {
            await Inicia();
        }

        private async Task Inicia()
        {
            await ConsultaID();
            await CargarDgvAsync();
        }

        private async Task CargarDgvAsync()
        {
            string urlBase = "https://localhost:44365/api/Carreras/Consulta/";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(urlBase);
            List<Carrera> Carreras = JsonConvert.DeserializeObject<List<Carrera>>(resultado);
            dgvTecnicatura.DataSource = Carreras;
        }
        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txt_NombreCarrera.Text.Trim()))
            {
                MessageBox.Show("Se debe ingresar un nombre de la carrera", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(Nup_Duracion.Value.ToString().Trim()))
            {
                MessageBox.Show("Se debe ingresar una duracion de la carrera", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            Carrera carrera = new()
            {
                NombreCarrera = txt_NombreCarrera.Text,
                Duracion = Nup_Duracion.Value.ToString()
            };
            string data = JsonConvert.SerializeObject(carrera);


            bool success = await GrabarCarreraAsync(data);
            if (success)
            {
                MessageBox.Show("Carrera registrada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LimpiarCamposAsync();
            }
            else
            {
                MessageBox.Show("La carrera ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> GrabarCarreraAsync(string data)
        {
            string urlBase = "https://localhost:44365/api/Carreras/";
            bool resultado = Convert.ToBoolean(await ClienteSingleton.GetInstancia().PostAsync(urlBase, data));
            return resultado;
        }

        private async Task LimpiarCamposAsync()
        {
            txt_NombreCarrera.Text = "";
            Nup_Duracion.Value = 1;
            await Inicia();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async Task<bool> BorrarCarreraAsync(int idCurso)
        {
            string urlBase = "https://localhost:44365/api/Carreras/" + idCurso;
            bool resultado = Convert.ToBoolean(await ClienteSingleton.GetInstancia().DeleteAsync(urlBase));
            return resultado;
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int idCurso;
            if (dgvTecnicatura.RowCount > 0)
            {
                idCurso = Convert.ToInt32(dgvTecnicatura.CurrentRow.Cells["ID"].Value);
                bool success = await BorrarCarreraAsync(idCurso);

                if (success)
                {
                    MessageBox.Show("Se eliminó el registro seleccionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarDgvAsync();
                }
                else
                {
                    MessageBox.Show("Error al intentar borrar la carrera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a borrar", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTecnicatura.CurrentRow != null)
            {
                FrmEdit frmEdit = new FrmEdit();
                AddOwnedForm(frmEdit);
                int idCarrera = Convert.ToInt32(dgvTecnicatura.CurrentRow.Cells["ID"].Value);
                frmEdit.CargarDatos(Forms.Carrera, idCarrera);
                frmEdit.ShowDialog();
                Inicia();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_NombreCarrera_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txt_NombreCarrera.Text = "";
        }
    }
}
