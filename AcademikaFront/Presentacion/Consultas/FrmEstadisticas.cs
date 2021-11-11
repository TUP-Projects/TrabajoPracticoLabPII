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
    public partial class FrmEstadisticas : Form
    {
        IMateriasService materiasService;
        public FrmEstadisticas()
        {
            InitializeComponent();
            materiasService = new ServiceFactoryImp().CrearServiceMaterias();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cboFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un filtro");
                return;
            }
            string Filtro = cboFiltro.SelectedItem.ToString();
            DataTable lst = materiasService.GetCondiciones(Filtro);
            dgvEstadisticas.DataSource = lst;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvEstadisticas.Rows.Clear();
            dgvEstadisticas.DataSource = null;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.SetToolTip(iconButton3, "SP_ESTADISTICAS_ALUMNOS: Cantidades de alumnos (promedio de notas, cantidad de materias regulares y aprobadas) por edades, estado civil, situación habitacional y laboral, etc.");
        }
    }
}
