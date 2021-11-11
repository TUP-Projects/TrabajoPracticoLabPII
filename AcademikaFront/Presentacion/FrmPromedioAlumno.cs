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

namespace AcademikaFront.Presentacion
{
    public partial class FrmPromedioAlumno : Form
    {
        IMateriasService _materiasService;
        public FrmPromedioAlumno()
        {
            InitializeComponent();
            _materiasService = new ServiceFactoryImp().CrearServiceMaterias();
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
            if(legajo is null)
                lst.Add("@legajo", legajo);
            else
                lst.Add("@legajo", legajo.ID);

            if (materia is null)
                lst.Add("@idmateria", materia);
            else
                lst.Add("@idmateria", materia.ID);

            if (curso is null)
                lst.Add("@idcurso", curso);
            else
                lst.Add("@idcurso", curso.ID);

            if (carrera is null)
                lst.Add("@idcarrera", carrera);
            else
                lst.Add("@idcarrera", carrera.ID);

            lst.Add("@aniocursado", dtpAnioCursado.Value.Year);
            DataTable dt = _materiasService.GetCondiciones(lst);
            dgvPromedioAlumnos.DataSource = dt;
        }
    }
}
