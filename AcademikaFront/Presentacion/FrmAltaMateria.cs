using AcademikaBackend.BusinessLayer.Services;
using System;
using System.Text;
using System.Windows.Forms;

namespace Academika.Presentacion
{
    public partial class FrmAltaMateria : Form
    {
        private bool VerAyuda = false;
        private IMateriasService servicio;
        public FrmAltaMateria()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearServiceMaterias();
        }

        private void FrmAltaMateria_Load(object sender, EventArgs e)
        {
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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("- Estado = 0 corresponde a: Deshabilitado");
            _stringBuilder.Append("- Estado = 1 corresponde a: Habilitado");
            rtbAyuda.Text = _stringBuilder.ToString();
            if (VerAyuda)
            {
                VerAyuda = rtbAyuda.Visible = false;
            }
            else
            {
                VerAyuda = rtbAyuda.Visible = true;
            }
        }
    }
}
