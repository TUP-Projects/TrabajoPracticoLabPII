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

        private async Task Cargar_CombosAsync(ComboBox combo, string entidad, int estado)
        {
            
            string urlBase = "https://localhost:44365/api/MateriasDetalle/";
            string url = urlBase + entidad;
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
            Cargar_CombosAsync(cboAdj, "docentes", (int)Estado.Habilitado);
            Cargar_CombosAsync(cboMateria, "materias", (int)Estado.Habilitado);
            Cargar_CombosAsync(cboAyud, "docentes", (int)Estado.Habilitado);
            Cargar_CombosAsync(cboJefe, "docentes", (int)Estado.Habilitado);
            Cargar_CombosAsync(cboCarrera, "carreras", (int)Estado.Habilitado);
            Cargar_CombosAsync(cboCurso, "cursos", (int)Estado.Habilitado);
        }

        private void cboDictado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDictado.Text == "Anual")
            {

                cboCuatrimestre.Enabled = false;
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

            materia.Id_Materia = (int)cboMateria.SelectedValue;
            materia.NombreMateria = cboMateria.SelectedText;
            mxc.Materia = materia;

            if (cboCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una carrera", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCarrera.Focus();
                return;

            }
            mxc.Carrera.Id_Carrera = (int)cboCarrera.SelectedValue;
            mxc.AnioDictado = Convert.ToInt32(rtbAnio.Text);
            mxc.CargaHoraria = Convert.ToInt32(nudCarga.Text);
            mxc.Dictado = cboDictado.Text;
            if (cboCuatrimestre.SelectedIndex != -1)
                mxc.Cuatrimestre = Convert.ToInt32(cboCuatrimestre.Text);
            else
                mxc.Cuatrimestre = 0;

            curso.Id_Curso = (cboCurso.SelectedIndex != 1) ? (int)cboCurso.SelectedValue : 1;
            curso.NombreCurso = (cboCurso.SelectedIndex != 1) ? cboCurso.SelectedText.ToString() : "Sin curso";
            
           

            List<DocentesXMateria> lstDocentes = new List<DocentesXMateria>();
            Docente jefe = new Docente();
            Docente adjunto = new Docente();
            Docente ayudante = new Docente();
            jefe.Id_Docente = (int)cboJefe.SelectedValue;
            adjunto.Id_Docente = (int)cboAdj.SelectedValue;
            ayudante.Id_Docente = (int)cboAyud.SelectedValue;
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

            mxc.Id_Materias_x_Carrera = (int)(long)dgvResultado.CurrentRow.Cells["IdMateriaCarrera"].Value;
            mxc.Dictado = (string)dgvResultado.CurrentRow.Cells["Dictado"].Value;
            mxc.AnioDictado = (int)(long)dgvResultado.CurrentRow.Cells["AnioDictado"].Value;
            mxc.CargaHoraria = (int)(long)dgvResultado.CurrentRow.Cells["Carga"].Value;
            mxc.Cuatrimestre = (int)(long)dgvResultado.CurrentRow.Cells["Cuatrimestre"].Value;

            if (servicio.ActualizaDatosMateriasxCarrera(mxc))
                MessageBox.Show("Se editó el campo deseado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Consultar_DetalleMateriaAsync(materia.Id_Materia);

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
