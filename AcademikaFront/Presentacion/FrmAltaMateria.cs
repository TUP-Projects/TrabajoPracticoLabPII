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
    public partial class FrmAltaMateria : Form
    {
        private IMateriasService servicio;
        public FrmAltaMateria()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
        }
        private void FrmAltaMateria_Load(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = servicio.CargaDgvEntidad("materias");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    
    }
}
