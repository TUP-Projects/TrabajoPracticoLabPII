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

namespace AcademikaFront.Presentacion.Consultas
{
    public partial class FrmAlumnosSinCursar : Form
    {
        IMateriasService _materiasService;
        public FrmAlumnosSinCursar()
        {
            InitializeComponent();
            _materiasService = new ServiceFactoryImp().CrearServiceMaterias();
            dtpAnioCursado.Format = DateTimePickerFormat.Custom;
            dtpAnioCursado.CustomFormat = "yyyy";
            dtpAnioCursado.ShowUpDown = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = _materiasService.GetAlumnosSinCursar(dtpAnioCursado.Value.Year);
            dgvAlumnosSinCursar.DataSource = dt;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvAlumnosSinCursar.DataSource = null;
            dgvAlumnosSinCursar.Rows.Clear();


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.SetToolTip(iconButton3, "SP_ALUMNOS_SIN_CURSADA: Alumnos que no han cursado materias en un año.");
        }
    }
}
