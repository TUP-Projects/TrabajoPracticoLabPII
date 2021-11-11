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

namespace AcademikaFront.Presentacion
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
    }
}
