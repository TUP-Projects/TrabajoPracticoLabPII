using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademikaFront.Presentacion.Consultas
{
    public partial class FrmPromedioAlumno : Form
    {
        IMateriasService _materiasService;
        public FrmPromedioAlumno()
        {
            InitializeComponent();
            _materiasService = new ServiceFactoryImp().CrearServiceMaterias();
            dtpAnioCursado.Format = DateTimePickerFormat.Custom;
            dtpAnioCursado.CustomFormat = "yyyy";
            dtpAnioCursado.ShowUpDown = true;
        }

        private void FrmPromedioAlumno_Load(object sender, EventArgs e)
        {
            CargarCombos(cboLegajo, "alumnos");
            CargarCombos(cboMateria, "materias");
            CargarCombos(cboCurso, "cursos");
            CargarCombos(cboCarrera, "carreras");
        }

        private void CargarCombos(RJComboBox combo, string entidad)
        {
            List<EntidadGenerica> lstEntidad = _materiasService.CargaCombos(entidad);
            combo.DataSource = lstEntidad;
            combo.ValueMember = "ID";
            combo.DisplayMember = "Descripcion";
            combo.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EntidadGenerica legajo = (EntidadGenerica)cboLegajo.SelectedItem;
            EntidadGenerica materia = (EntidadGenerica)cboMateria.SelectedItem;
            EntidadGenerica curso = (EntidadGenerica)cboCurso.SelectedItem;
            EntidadGenerica carrera = (EntidadGenerica)cboCarrera.SelectedItem;
            Dictionary<string, object> lst = new Dictionary<string, object>();
            AddParametro(lst, "@legajo", legajo);
            AddParametro(lst, "@idmateria", materia);
            AddParametro(lst, "@idcurso", curso);
            AddParametro(lst, "@idcarrera", carrera);
            lst.Add("@aniocursado", dtpAnioCursado.Value.Year);
            DataTable dt = _materiasService.GetCondiciones(lst);
            dgvPromedioAlumnos.DataSource = dt;
        }

        private void AddParametro(Dictionary<string, object> lst, string key, EntidadGenerica entity)
        {
            if (entity is null)
                lst.Add(key, entity);
            else
                lst.Add(key, entity.ID);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvPromedioAlumnos.DataSource = null;
            dgvPromedioAlumnos.Rows.Clear();
            cboLegajo.SelectedIndex = -1;
            cboMateria.SelectedIndex = -1;
            cboCurso.SelectedIndex = -1;
            cboCarrera.SelectedIndex = -1;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.SetToolTip(iconButton3, "SP_PROMEDIO_NOTAS: Muestra Promedio de notas por alumno, materia, año, curso, etc.");
        }
    }
}
