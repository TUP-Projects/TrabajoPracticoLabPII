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
    public partial class FrmAlumnosSinAprobar : Form
    {
        IMateriasService _materiasService;
        public FrmAlumnosSinAprobar()
        {
            InitializeComponent();
            _materiasService = new ServiceFactoryImp().CrearServiceMaterias();
            dtpAnioCursado.Format = DateTimePickerFormat.Custom;
            dtpAnioCursado.CustomFormat = "yyyy";
            dtpAnioCursado.ShowUpDown = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = _materiasService.GetAlumnosSinAprobar(dtpAnioCursado.Value.Year);
            dgvAlumnosSinAprobar.DataSource = dt;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvAlumnosSinAprobar.Rows.Clear();
            dgvAlumnosSinAprobar.DataSource = null;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.SetToolTip(iconButton3, "SP_ALUMNOS_SIN_APROBADAS: Alumnos que no han rendido (o no han aprobado) ninguna materia en los últimos año.");
        }
    }
}
