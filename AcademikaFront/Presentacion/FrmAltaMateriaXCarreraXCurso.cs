using Academika.Client;
using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
using AcademikaFront;
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

    public partial class FrmAltaMateriaXCarreraXCurso : Form
    {
        private IMateriasService servicio;
        Materia materia;
        MateriasXCarrera mxc;
        Curso curso;
        DocentesXMateria dxm;
        private Form currentChildForm;

        int mostrarAyuda = 0;
        public FrmAltaMateriaXCarreraXCurso()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();

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

        private async Task Consultar_DetalleMateriaAsync(int idMateria)
        {


            string urlBase = "https://localhost:44365/api/MateriasDetalle/Consulta/";
            string url = urlBase + idMateria.ToString();

            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(resultado, (typeof(DataTable)));
            if (dt.Rows.Count > 0)
            {
                dgvResultado.DataSource = dt;
            }


        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAltaMaterias_Load(object sender, EventArgs e)
        {
            Inicia();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Inicia()
        {
            _ = Cargar_CombosAsync(cboAdj, "docentes");
            _ = Cargar_CombosAsync(cboMateria, "materias");
            _ = Cargar_CombosAsync(cboAyud, "docentes");
            _ = Cargar_CombosAsync(cboJefe, "docentes");
            _ = Cargar_CombosAsync(cboCarrera, "carreras");
            _ = Cargar_CombosAsync(cboCurso, "cursos");
        }

        private void cboDictado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDictado.Text == "Anual")
            {

                cboCuatrimestre.Enabled = false;
            }
            else
            {
                cboCuatrimestre.Enabled = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            materia = new Materia();
            mxc = new MateriasXCarrera();
            curso = new Curso();


            if (cboMateria.SelectedIndex == -1)
            {

                MessageBox.Show("Debe seleccionar una materia", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();
                return;
            }
            else
            {
                materia.Id_Materia = (int)cboMateria.SelectedValue;
                materia.NombreMateria = cboMateria.SelectedText;
                mxc.Materia = materia;
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
            if (cboCurso.SelectedIndex == -1)
            {

                MessageBox.Show("Debe seleccionar un curso", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCurso.Focus();
                return;

            }

            else
            {
                curso.Id_Curso = (int)cboCurso.SelectedValue;
                curso.NombreCurso = cboCurso.SelectedText.ToString();
            }



            List<DocentesXMateria> lstDocentes = new List<DocentesXMateria>();
            Docente jefe = new Docente();
            Docente adjunto = new Docente();
            Docente ayudante = new Docente();
            if (cboJefe.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un jefe de cátedra", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboJefe.Focus();
                return;
            }
            else
            {
                jefe.Id_Docente = (int)cboJefe.SelectedValue;
            }
            if (cboAdj.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un profesor adjunto", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAdj.Focus();
                return;
            }
            else
            {
                adjunto.Id_Docente = (int)cboAdj.SelectedValue;
            }
            if (cboAyud.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un ayudante", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAdj.Focus();
                return;

            }
            else
            {
                ayudante.Id_Docente = (int)cboAyud.SelectedValue;
            }

            lstDocentes.Add(new DocentesXMateria(adjunto, mxc, "Adjunto", curso));
            lstDocentes.Add(new DocentesXMateria(ayudante, mxc, "Ayudante", curso));
            lstDocentes.Add(new DocentesXMateria(jefe, mxc, "Jefe", curso));



            if (servicio.InsertarMateria(materia, mxc, lstDocentes))
            {
                MessageBox.Show("Se agregó la materia al plan de estudios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ = Consultar_DetalleMateriaAsync(materia.Id_Materia);


            }
            else
            {
                MessageBox.Show("Error al intentar grabar la materia. Revise no estar duplicando valores en la tabla siguiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = Consultar_DetalleMateriaAsync(materia.Id_Materia);

            }
    
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mxc = new MateriasXCarrera();
            curso = new Curso();


            string nombreJefe; string nombreAyud; string nombreAdj;


            if (dgvResultado.RowCount > 0)
            {
                mxc.Id_Materias_x_Carrera = Convert.ToInt32(dgvResultado.CurrentRow.Cells["IdMateriaCarrera"].Value);
                mxc.Materia.Id_Materia = Convert.ToInt32(dgvResultado.CurrentRow.Cells["IdMateria"].Value);
                mxc.Dictado = (string)dgvResultado.CurrentRow.Cells["Dictado"].Value;
                mxc.Materia.NombreMateria = (string)dgvResultado.CurrentRow.Cells["NombreMat"].Value;
                mxc.Carrera.NombreCarrera = (string)dgvResultado.CurrentRow.Cells["Carrera"].Value;
                mxc.AnioDictado = Convert.ToInt32(dgvResultado.CurrentRow.Cells["AnioDictado"].Value);
                mxc.CargaHoraria = Convert.ToInt32(dgvResultado.CurrentRow.Cells["Carga"].Value);
                mxc.Cuatrimestre = Convert.ToInt32(dgvResultado.CurrentRow.Cells["Cuatrimestre"].Value);
                curso.Id_Curso = Convert.ToInt32(dgvResultado.CurrentRow.Cells["IdCurso"].Value);
                curso.NombreCurso = (string)(dgvResultado.CurrentRow.Cells["NomCurso"].Value);
                nombreJefe = dgvResultado.CurrentRow.Cells["JefedeCatedra"].Value.ToString();
                nombreAyud = dgvResultado.CurrentRow.Cells["AyudantePrimera"].Value.ToString();
                nombreAdj = dgvResultado.CurrentRow.Cells["ProfesorAdjunto"].Value.ToString();

                new FrmAltaMateriaXCarreraXCursoUpdate(mxc, curso, nombreJefe, nombreAdj, nombreAyud).ShowDialog();
                _ = Consultar_DetalleMateriaAsync(mxc.Materia.Id_Materia);



            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro a editar", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            if (cboMateria.SelectedIndex == -1)
            {

                MessageBox.Show("Debe seleccionar una materia", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();

            }
            else
            {
                materia = new Materia();
                materia.Id_Materia = (int)cboMateria.SelectedValue;
                _ = Consultar_DetalleMateriaAsync(materia.Id_Materia);
            }



        }
        private void iconButton3_Click(object sender, EventArgs e)
        {

            rtbAyuda.Text = " - Utilice el icono de buscar para revisar el detalle de una materia.\n" +
                        "- Sólo podrá editar los campos: Dictado, Carga Horaria, Cuatrimestre y Año. Para lo demás debe borrar y volver a insertar.\n" +
                        "- Edite con los datos deseados y luego pulse el botón de editar.\n" +
                        "- Utilice el botón Guardar para guardar los datos del formulario.\n" +
                        "- Utilice el botón Cancelar para limpiar el formulario.";

            if (mostrarAyuda == 0)
            {
                mostrarAyuda = 1;
                rtbAyuda.Visible = true;
            }
            else
            {
                mostrarAyuda = 0;
                rtbAyuda.Visible = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DocentesXMateria dxm = new DocentesXMateria();

            if (dgvResultado.RowCount > 0)
            {
                dxm.Curso.Id_Curso = Convert.ToInt32(dgvResultado.CurrentRow.Cells["IdCurso"].Value);
                dxm.Mxcar.Id_Materias_x_Carrera = Convert.ToInt32(dgvResultado.CurrentRow.Cells["IdMateriaCarrera"].Value);


                if (servicio.BajaCursoMateriaDocente(dxm))
                {
                    MessageBox.Show("Se eliminó el registro seleccionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
                }
                else
                {
                    MessageBox.Show("Error al intentar borrar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
                }
            }
            else
            {

                MessageBox.Show("Debe seleccionar un registro a borrar", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

   
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboAdj.SelectedIndex = -1;
            cboAyud.SelectedIndex = -1;
            cboCarrera.SelectedIndex = -1;
            cboCuatrimestre.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;
            cboDictado.SelectedIndex = -1;
            cboJefe.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            cboAnio.SelectedIndex = -1;
            nudCarga.Value = 0;
            DataTable DT = (DataTable)dgvResultado.DataSource;
            if (DT != null)
                DT.Clear();
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvResultado.AutoGenerateColumns = false;
        }
    }
}
