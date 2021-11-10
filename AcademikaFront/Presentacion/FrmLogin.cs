using Academika.Client;
using AcademikaBackend.BusinessLayer.Entities;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academika.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text=="")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario.
            if ((txtUser.Text == ""))
            {
                msgError("Por favor ingrese usuario");
            }

            //Validamos que se haya ingresado una password
            if ((txtPass.Text == ""))
            {
                msgError("Por favor ingrese contraseña");
            }

            _ = IniciarSesion();
        }

        private async Task IniciarSesion()
        {
            Usuario oUsuario = new Usuario();
            oUsuario.NombreUsuario = txtUser.Text;
            oUsuario.Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPass.Text), Base64FormattingOptions.None);

            string data = JsonConvert.SerializeObject(oUsuario);

            string urlBase = "https://localhost:44365/api/Login/";
            var resultado = await ClienteSingleton.GetInstancia().PostAsync(urlBase, data);
            var IdUser = Convert.ToInt32(resultado);
            
            if (IdUser != 0)
            {
                MessageBox.Show("Bienvenido a Academika!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain nuevo = new(txtUser.Text);
                nuevo.Show();
                Hide();
            }
            else
            {
                msgError("Usuario y/o contraseña incorrecta !");
            }
        }

        private void msgError(string msg)
        {
            lblMessageError.Text = "      " + msg;
            lblMessageError.Visible = true;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
