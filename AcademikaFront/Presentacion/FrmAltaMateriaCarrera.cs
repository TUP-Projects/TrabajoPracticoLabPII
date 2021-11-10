using Academika.Client;
using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academika.Presentacion
{
    public partial class FrmAltaMateriaCarrera : Form
    {
        private bool VerAyuda = false;
        private IMateriasService servicio;
        private MateriasXCarrera mxc;
        public FrmAltaMateriaCarrera()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
        }

        private void FrmAltaMateria_Load(object sender, EventArgs e)
        {
            Inicia();
        }

        private void Inicia()
        {
            ConsultaID();
            _ = CargarDgvAsync();
            _ = Cargar_CombosAsync(cboMateria, "materias");
            _ = Cargar_CombosAsync(cboCarrera, "carreras");
            
        }

        private void ConsultaID()
        {
            lblMateriaCarrera.Text = "ID Materia - Carrera: " + servicio.ObtenerProxId("MATERIASxCarrera").ToString();
        }

        private async Task CargarDgvAsync(int idcarrera=0, int idmateria=0)
        {
            string urlBase = "https://localhost:44365/api/MateriasDetalle/RelacionCarreras/";
            string url = urlBase + idcarrera.ToString() + "/" + idmateria.ToString();
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(resultado, (typeof(DataTable)));
            if (dt.Rows.Count > 0)
            {
                dgvMaterias.DataSource = dt;
            }
            dgvMaterias.DataSource = dt;
        }

        private async Task Cargar_CombosAsync(ComboBox combo, string entidad)
        {
            string url = "https://localhost:44365/api/MateriasDetalle/" + entidad;
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<EntidadGenerica> lstEntidad = JsonConvert.DeserializeObject<List<EntidadGenerica>>(resultado);
            combo.DataSource = lstEntidad;

            combo.ValueMember = "ID";
            combo.DisplayMember = "Descripcion";
            combo.SelectedIndex = -1;
        }

        private async Task<bool> GrabarMateriaCarreraAsync(string data)
        {
            string urlBase = "https://localhost:44365/api/MateriasDetalle/";
            bool resultado = Convert.ToBoolean(await ClienteSingleton.GetInstancia().PostAsync(urlBase, data));
            return resultado;
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cboCarrera.SelectedIndex != -1 && cboMateria.SelectedIndex != -1)
                _ = CargarDgvAsync((int)cboCarrera.SelectedValue, (int)cboMateria.SelectedValue);
            else if (cboMateria.SelectedIndex != -1)
                _ = CargarDgvAsync(0, (int)cboMateria.SelectedValue);
            else if (cboCarrera.SelectedIndex != -1)
                _ = CargarDgvAsync((int)cboCarrera.SelectedValue, 0);
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private async void btnGuardar_ClickAsync(object sender, EventArgs e)
        {
            mxc = new MateriasXCarrera();
            if (cboMateria.SelectedIndex == -1)
            {

                MessageBox.Show("Debe seleccionar una materia", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();
                return;
            }
            else
            {
                mxc.Materia.Id_Materia = (int)cboMateria.SelectedValue;
                mxc.Materia.NombreMateria = cboMateria.SelectedText;
               
            }


            if (cboCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una carrera", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCarrera.Focus();
                return;
            }
            else
            {
                mxc.Carrera.Id_Carrera = (int)cboCarrera.SelectedValue;

            }

            if (cboAnio.SelectedIndex != -1)
            {
                mxc.AnioDictado = Convert.ToInt32(cboAnio.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un año dictado", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAnio.Focus();
                return;

            }
            if (!String.IsNullOrEmpty(nudCarga.Text))
                mxc.CargaHoraria = Convert.ToInt32(nudCarga.Text);
            else
            {
                MessageBox.Show("Debe seleccionar una carga horaria", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudCarga.Focus();
                return;
            }
            if (!String.IsNullOrEmpty(cboDictado.Text))
            {
                mxc.Dictado = cboDictado.Text;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un dictado", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDictado.Focus();
                return;
            }

            if (cboCuatrimestre.SelectedIndex != -1)
                mxc.Cuatrimestre = Convert.ToInt32(cboCuatrimestre.Text);
            else
                mxc.Cuatrimestre = 0;

            if (ExisteMateriaCarrera((int)cboMateria.SelectedValue, (int)cboCarrera.SelectedValue))
            {

                MessageBox.Show("Ya existe la relación Materia-Carrera", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {
                string data = JsonConvert.SerializeObject(mxc);
                bool success = await GrabarMateriaCarreraAsync(data);

                if (success)
                {
                    MessageBox.Show("Se agregó la relación materia-carrera!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ = CargarDgvAsync();
                }
                else
                {
                    MessageBox.Show("Error al intentar grabar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ = CargarDgvAsync();

                }
            }

            ConsultaID();

        }

        private bool ExisteMateriaCarrera(int idmateria, int idcarrera)
        {
            foreach (DataGridViewRow fila in dgvMaterias.Rows)
            {
                if (fila.Cells["id_materia"].Value.ToString() == idmateria.ToString() && fila.Cells["id_carrera"].Value.ToString() == idcarrera.ToString())
                    return true;
            }
            return false;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            int idMateriaCarrera;
            if (dgvMaterias.RowCount > 0)
            {
                
                idMateriaCarrera = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["ID"].Value);


                if (servicio.BajaMateriaCarrera(idMateriaCarrera))
                {
                    MessageBox.Show("Se eliminó el registro seleccionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ = CargarDgvAsync();
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

        private void iconButton7_Click(object sender, EventArgs e)
        {
            mxc = new MateriasXCarrera();
         


            if (dgvMaterias.RowCount > 0)
            {
                mxc.Id_Materias_x_Carrera = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["ID"].Value);
                mxc.Dictado = (string)dgvMaterias.CurrentRow.Cells["Dictado"].Value;
                mxc.Materia.NombreMateria = (string)dgvMaterias.CurrentRow.Cells["materia"].Value;
                mxc.Carrera.NombreCarrera = (string)dgvMaterias.CurrentRow.Cells["Carrera"].Value;
                mxc.AnioDictado = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["anio_dictado"].Value);
                mxc.CargaHoraria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["cargahs"].Value);
                mxc.Cuatrimestre = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["Cuatrimestre"].Value);
                
                new FrmAltaMateriaXCarreraUpdate(mxc).ShowDialog();



            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a editar", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
