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
    public partial class FrmAltaMateriaXCarrera : Form
    {
        private IMateriasService servicio;
        Materia materia;
        MateriasXCarrera mxc;
        Curso curso;
        
        int mostrarAyuda = 0;
        public FrmAltaMateriaXCarrera()
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

        private async Task Consultar_DetalleMateriaAsync(int idMateria) {


            string urlBase = "https://localhost:44365/api/MateriasDetalle/Consulta/";
            string url = urlBase + idMateria.ToString();

            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(resultado, (typeof(DataTable)));
            
            dgvResultado.DataSource = dt;

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

        
        private void ConsultaID()
        {

            lblId.Text = "ID Materia - Carrera: " + servicio.ObtenerProxId("MATERIASxCARRERA").ToString();
        }

        private void Inicia()
        {
            ConsultaID();
            Cargar_CombosAsync(cboAdj, "docentes");
            Cargar_CombosAsync(cboMateria, "materias");
            Cargar_CombosAsync(cboAyud, "docentes");
            Cargar_CombosAsync(cboJefe, "docentes");
            Cargar_CombosAsync(cboCarrera, "carreras");
            Cargar_CombosAsync(cboCurso, "cursos");
        }

        private void cboDictado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDictado.Text == "Anual")
            {

                cboCuatrimestre.Enabled = false;
            }
            else {
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
            else {
                mxc.Carrera.Id_Carrera = (int)cboCarrera.SelectedValue;

            }
                
            if (!String.IsNullOrEmpty(rtbAnio.Text))
            {
                mxc.AnioDictado = Convert.ToInt32(rtbAnio.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un año dictado", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbAnio.Focus();
                return;

            }
            if (!String.IsNullOrEmpty(nudCarga.Text))
                mxc.CargaHoraria = Convert.ToInt32(nudCarga.Text);
            else {
                MessageBox.Show("Debe seleccionar una carga horaria", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudCarga.Focus();
                return;
            }
            if (!String.IsNullOrEmpty(cboDictado.Text))
            {
                mxc.Dictado = cboDictado.Text;
            }
            else {
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

            else {
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
            else {
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

            lstDocentes.Add(new DocentesXMateria(adjunto, mxc ,"Adjunto", curso));
            lstDocentes.Add(new DocentesXMateria(ayudante, mxc, "Ayudante", curso));
            lstDocentes.Add(new DocentesXMateria(jefe, mxc, "Jefe", curso));



            if (servicio.InsertarMateria(materia, mxc, lstDocentes))
            {
                MessageBox.Show("Se agregó la materia al plan de estudios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Consultar_DetalleMateriaAsync(materia.Id_Materia);


            }
            else
            {
                MessageBox.Show("Error al intentar grabar la materia. Revise no estar duplicando valores en la tabla siguiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Consultar_DetalleMateriaAsync(materia.Id_Materia);

            }
            ConsultaID();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mxc = new MateriasXCarrera();
            if (dgvResultado.RowCount > 0)
            {
                mxc.Id_Materias_x_Carrera = (int)(long)dgvResultado.CurrentRow.Cells["IdMateriaCarrera"].Value;
                mxc.Dictado = (string)dgvResultado.CurrentRow.Cells["Dictado"].Value;
                mxc.AnioDictado = (int)(long)dgvResultado.CurrentRow.Cells["AnioDictado"].Value;
                mxc.CargaHoraria = (int)(long)dgvResultado.CurrentRow.Cells["Carga"].Value;
                mxc.Cuatrimestre = (int)(long)dgvResultado.CurrentRow.Cells["Cuatrimestre"].Value;


                if (servicio.ActualizaDatosMateriasxCarrera(mxc))
                    MessageBox.Show("Se editó el campo deseado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Consultar_DetalleMateriaAsync(materia.Id_Materia);
            }
            else {
                MessageBox.Show("Debe seleccionar un registro a editar", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            materia = new Materia();

            if (cboMateria.SelectedIndex == -1)
            {

                MessageBox.Show("Debe seleccionar una materia", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();

            }
            else
            {
                materia.Id_Materia = (int)cboMateria.SelectedValue;
            }

             Consultar_DetalleMateriaAsync(materia.Id_Materia);
        
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
            else {
                mostrarAyuda = 0;
                rtbAyuda.Visible = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DocentesXMateria dxm = new DocentesXMateria();
            

            dxm.Curso.Id_Curso = (int)(long)dgvResultado.CurrentRow.Cells["IdCurso"].Value;
            dxm.Mxcar.Id_Materias_x_Carrera = (int)(long)dgvResultado.CurrentRow.Cells["IdMateriaCarrera"].Value;


            if (servicio.BajaCursoMateriaDocente(dxm))
              {
                  MessageBox.Show("Se eliminó el registro seleccionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
              }
              else
              {
                  MessageBox.Show("Error al intentar borrar la materia. Revise no estar duplicando valores en la tabla siguiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
              }

            ConsultaID();
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
            DataTable DT = (DataTable)dgvResultado.DataSource;
            if (DT != null)
                DT.Clear();
        }
    }
    
}
