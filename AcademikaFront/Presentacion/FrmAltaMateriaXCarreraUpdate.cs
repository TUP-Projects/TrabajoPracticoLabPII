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
    public partial class FrmAltaMateriaXCarreraUpdate : Form
    {
        private IMateriasService servicio;
        
        MateriasXCarrera mxcAnt;
        Curso cursoAnt;
        string jefePreCargado;
        string profPreCargado;
        string ayudPreCargado;
     
        public FrmAltaMateriaXCarreraUpdate()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
            
        }

        public FrmAltaMateriaXCarreraUpdate(MateriasXCarrera matxcar, Curso cur, string jefe, string prof, string ayud) {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
            this.mxcAnt = matxcar;
            this.cursoAnt = cur;
            this.jefePreCargado = jefe;
            this.profPreCargado = prof;
            this.ayudPreCargado = ayud;
        
        }

        private async Task Cargar_CombosAsync(ComboBox combo, string entidad)
        {
            string url = "https://localhost:44365/api/MateriasDetalle/" + entidad;
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(url);
            List<EntidadGenerica> lstEntidad = JsonConvert.DeserializeObject<List<EntidadGenerica>>(resultado);
            combo.DataSource = lstEntidad;
            
            combo.ValueMember = "ID";
            combo.DisplayMember = "Descripcion";

            setCombos();
        }


        private void FrmAltaMaterias_Load(object sender, EventArgs e)
        {
            Inicia();
           

        }

        private void ConsultaID()
        {

            lblId.Text = "ID Materia - Carrera: " + servicio.ObtenerProxId("MATERIASxCARRERA").ToString();
        }

        private void Inicia()
        {
            ConsultaID();
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
            else {
                cboCuatrimestre.Enabled = true;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)

        {

            
            List<MateriasXCarrera> lstMatxCarrera = new List<MateriasXCarrera>();
            List<Curso> lstCurso = new List<Curso>();
            MateriasXCarrera mxc = new MateriasXCarrera();

            Curso curso = new Curso();
            

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
            else {

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

            lstMatxCarrera.Add(mxcAnt);
            lstMatxCarrera.Add(mxc);
            lstCurso.Add(cursoAnt);
            lstCurso.Add(curso);

            
            if (servicio.ActualizaDatosMateriasxCarrera(lstMatxCarrera, lstDocentes, lstCurso))
            {
                MessageBox.Show("Se agregó la materia al plan de estudios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                MessageBox.Show("Error al intentar grabar la materia. Revise no estar duplicando valores en la tabla siguiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }
            ConsultaID();

        }







        private void setCombos() {

            cboAdj.SelectedIndex = cboAdj.FindString(profPreCargado);
            cboAyud.SelectedIndex = cboAyud.FindString(ayudPreCargado);
            cboJefe.SelectedIndex = cboJefe.FindString(jefePreCargado);
            cboMateria.SelectedIndex = cboMateria.FindString(mxcAnt.Materia.NombreMateria.ToString());
            cboCarrera.SelectedIndex = cboCarrera.FindString(mxcAnt.Carrera.NombreCarrera.ToString());
            cboCuatrimestre.SelectedIndex = cboCuatrimestre.FindString(mxcAnt.Cuatrimestre.ToString());
            nudCarga.Value = Convert.ToInt32(mxcAnt.CargaHoraria);
            cboDictado.SelectedIndex = cboDictado.FindString(mxcAnt.Dictado.ToString());
            cboAnio.SelectedIndex = cboAnio.Items.IndexOf(mxcAnt.AnioDictado.ToString());
            cboCurso.SelectedIndex = cboCurso.FindString(cursoAnt.NombreCurso.ToString());

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
          
        }
    }
    
}
