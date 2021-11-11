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
    public partial class FrmCondicionAlumnos : Form
    {
        IMateriasService _materiasService;
        public FrmCondicionAlumnos()
        {
            InitializeComponent();
            _materiasService = new ServiceFactoryImp().CrearServiceMaterias();
            dtpAnioCursado.Format = DateTimePickerFormat.Custom;
            dtpAnioCursado.CustomFormat = "yyyy";
            dtpAnioCursado.ShowUpDown = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EntidadGenerica condicion = (EntidadGenerica)cboCondicion.SelectedItem;
            EntidadGenerica materia = (EntidadGenerica)cboMateria.SelectedItem;
            EntidadGenerica curso = (EntidadGenerica)cboCurso.SelectedItem;
            EntidadGenerica carrera = (EntidadGenerica)cboCarrera.SelectedItem;
            Dictionary<string, object> lst = new Dictionary<string, object>();
            AddParametro(lst, "@condicion", condicion);
            AddParametro(lst, "@materia", materia);
            AddParametro(lst, "@curso", curso);
            AddParametro(lst, "@carrera", carrera);
            lst.Add("@aniocursado", dtpAnioCursado.Value.Year.ToString());
            DataTable dt = _materiasService.GetCondicionesAlumnos(lst);
            dgvCondicionAlumnos.DataSource = dt;
        }

        private void AddParametro(Dictionary<string, object> lst, string key, EntidadGenerica entity)
        {
            if (entity is null)
                lst.Add(key, entity);
            else
                lst.Add(key, entity.Descripcion);
        }

        private void FrmCondicionAlumnos_Load(object sender, EventArgs e)
        {
            CargarCombos(cboCondicion, "condiciones");
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvCondicionAlumnos.Rows.Clear();
            dgvCondicionAlumnos.DataSource = null;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.SetToolTip(iconButton3, "SP_CONDICIONES_ALUMNOS: Cantidad de alumnos regulares, libres, por materia, curso, carrera, año de cursado.");
        }
    }
    
}
