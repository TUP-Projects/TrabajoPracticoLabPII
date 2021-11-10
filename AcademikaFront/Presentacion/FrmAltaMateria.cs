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
    public partial class FrmAltaMateria : Form
    {
        private bool VerAyuda = false;
        private IMateriasService servicio;
        public FrmAltaMateria()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
        }

        private async void FrmAltaMateria_Load(object sender, EventArgs e)
        {
            await Inicia();
        }

        private async Task Inicia()
        {
            await ConsultaID();
            await CargarDgvAsync();
        }

        private async Task ConsultaID()
        {
            lblLegajoDocente.Text = "ID Materia: " + servicio.ObtenerProxId("MATERIAS").ToString();
        }

        private async Task CargarDgvAsync()
        {
            string urlBase = "https://localhost:44365/api/MateriasDetalle/Consulta/";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(urlBase);
            List<Materia> Materias = JsonConvert.DeserializeObject<List<Materia>>(resultado);
            dgvMaterias.DataSource = Materias;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txtNombreMateria.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private async Task<bool> GrabarMateriaAsync(string data)
        {
            string urlBase = "https://localhost:44365/api/MateriasDetalle/AgregarMateria";
            bool resultado = Convert.ToBoolean(await ClienteSingleton.GetInstancia().PostAsync(urlBase, data));
            return resultado;
        }

        private async Task LimpiarCamposAsync()
        {
            txtSearch.Text = "";
            await Inicia();
        }

        private async void btn_Guardar_Click(object sender, EventArgs e)
        {
            Materia materia = new()
            {
                NombreMateria = txtNombreMateria.Text
            };

            string data = JsonConvert.SerializeObject(materia);
            bool success = await GrabarMateriaAsync(data);
            if (success)
            {
                MessageBox.Show("Materia registrada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LimpiarCamposAsync();
            }
            else
            {
                MessageBox.Show("La materia ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> BorrarMateriaAsync(int idCurso)
        {
            string urlBase = "https://localhost:44365/api/MateriasDetalle/" + idCurso;
            bool resultado = Convert.ToBoolean(await ClienteSingleton.GetInstancia().DeleteAsync(urlBase));
            return resultado;
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int idMaterias;
            if (dgvMaterias.RowCount > 0)
            {
                idMaterias = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["ID"].Value);
                bool success = await BorrarMateriaAsync(idMaterias);

                if (success)
                {
                    MessageBox.Show("Se eliminó el registro seleccionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarDgvAsync();
                }
                else
                {
                    MessageBox.Show("Error al intentar borrar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a borrar", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow != null)
            {
                FrmEdit frmEdit = new FrmEdit();
                AddOwnedForm(frmEdit);
                int idMateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["ID"].Value);
                frmEdit.CargarDatos(Forms.Materia, idMateria);
                frmEdit.ShowDialog();
                Inicia();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
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
