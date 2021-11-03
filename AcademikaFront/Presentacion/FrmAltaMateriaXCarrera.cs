using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
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

        MateriasXCurso mxcur;

        int mostrarAyuda = 0;
        public FrmAltaMateriaXCarrera()
        {
            InitializeComponent();
            
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
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

        private void Inicia() {

            rtbAnio.Text = DateTime.Now.Year.ToString();
            ConsultaID();
            CargaCombo(cboAdj, "docentes");
            CargaCombo(cboMateria, "materias");
            CargaCombo(cboAyud, "docentes");
            CargaCombo(cboJefe, "docentes");
            CargaCombo(cboCarrera, "carreras");
            CargaCombo(cboCurso, "cursos");

            dgvResultado.Columns[1].ReadOnly = true;
            dgvResultado.Columns[3].ReadOnly = true;
            dgvResultado.Columns[4].ReadOnly = true;
            dgvResultado.Columns[5].ReadOnly = true;
            dgvResultado.Columns[7].ReadOnly = true;
            dgvResultado.Columns[8].ReadOnly = true;

        }

        private void cboDictado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDictado.Text == "Anual")
            {

                cboCuatrimestre.Enabled = false;
            }

        }

        private void CargaCombo(ComboBox cbo, string nombreEntidad) {

            List<EntidadGenerica> lst = new List<EntidadGenerica>();

            lst = servicio.CargaCombos(nombreEntidad);
            
            cbo.DataSource = lst;

            cbo.ValueMember = "IDEntidad";
            cbo.DisplayMember = "NombreEntidad";

            cbo.SelectedIndex = -1;
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            materia = new Materia();
            mxc = new MateriasXCarrera();
            mxcur = new MateriasXCurso();

            if (cboMateria.SelectedIndex == -1) {

                MessageBox.Show("Debe seleccionar una materia", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();
                return;
            }
            
            materia.Id_Materia = (int)cboMateria.SelectedValue;
            materia.NombreMateria = cboMateria.SelectedText;
            mxc.Materia = materia;

            if (cboCarrera.SelectedIndex == -1) {
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


            mxcur.Materia = materia;

            if (cboCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCurso.Focus();
                return;

            }
            mxcur.Curso.Id_Curso = (int)cboCurso.SelectedValue;
            mxcur.Curso.NombreCurso = cboCurso.SelectedText;



            List<DocentesXMateria> lstDocentes = new List<DocentesXMateria>();
            Docente jefe = new Docente();
            Docente adjunto = new Docente();
            Docente ayudante = new Docente();
            jefe.Id_Docente = (int)cboJefe.SelectedValue;
            adjunto.Id_Docente = (int)cboAdj.SelectedValue;
            ayudante.Id_Docente = (int)cboAyud.SelectedValue;
            lstDocentes.Add(new DocentesXMateria(adjunto, mxcur, "Adjunto"));
            lstDocentes.Add(new DocentesXMateria(ayudante, mxcur, "Ayudante"));
            lstDocentes.Add(new DocentesXMateria(jefe, mxcur, "Jefe"));

            

            if (servicio.InsertarMateria(materia, mxc, mxcur, lstDocentes))
            {
                MessageBox.Show("Se agregó la materia al plan de estudios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
                
            }
            else
            {
                MessageBox.Show("Error al intentar grabar la materia. Revise no estar duplicando valores en la tabla siguiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
            }
            
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mxc = new MateriasXCarrera();

            mxc.Id_Materias_x_Carrera = (int)dgvResultado.CurrentRow.Cells["IdMateriaCarrera"].Value;
            mxc.Dictado = (string)dgvResultado.CurrentRow.Cells["Dictado"].Value;
            mxc.AnioDictado = (int)dgvResultado.CurrentRow.Cells["AnioDictado"].Value;
            mxc.CargaHoraria = (int)dgvResultado.CurrentRow.Cells["Carga"].Value;
            //mxc.Cuatrimestre = (int)dgvResultado.CurrentRow.Cells["Cuatrimestre"].Value;

            if (servicio.ActualizaDatosMateriasxCarrera(mxc))
                MessageBox.Show("Se agregó la materia al plan de estudios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            materia = new Materia();

            if (cboMateria.SelectedIndex == -1)
            {

                MessageBox.Show("Debe seleccionar una materia", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMateria.Focus();
                return;
            }

            materia.Id_Materia = (int)cboMateria.SelectedValue;

            dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
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

            dxm.Docente.Id_Docente = (int)dgvResultado.CurrentRow.Cells["IdDocente"].Value;
            dxm.Mxcur.Id_Materias_x_Curso = (int)dgvResultado.CurrentRow.Cells["IdMateriaCurso"].Value;

            //mxc.Cuatrimestre = (int)dgvResultado.CurrentRow.Cells["Cuatrimestre"].Value;

            if (servicio.EliminaDocxMateria(dxm))
            {
                MessageBox.Show("Se eliminó el registro seleccionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
            }
            else
            {
                MessageBox.Show("Error al intentar borrar la materia. Revise no estar duplicando valores en la tabla siguiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvResultado.DataSource = servicio.ConsultaMateria(materia.Id_Materia);
            }
        }
    }
    
}
