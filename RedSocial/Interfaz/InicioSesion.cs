using RedSocial.Interfaz;
using RedSocial.Modelos;
using RedSocial.Sesion;
using System;
using System.Windows.Forms;

namespace RedSocial
{
    public partial class InicioSesion : Form
    {
        private ControllerUsuario controllerUsuario = new ControllerUsuario();

        public InicioSesion()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnInicioSesion, "Inicia sesion si los datos son correctos");
            toolTip.SetToolTip(btnRegistrarse, "Te envia a la pantalla de registro");
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            string nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text;
            string contrasenha = string.IsNullOrWhiteSpace(txtContrasenha.Text) ? null : txtContrasenha.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contrasenha))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            Usuario usuario = controllerUsuario.IniciarSesion(txtNombre.Text, txtContrasenha.Text);

            if (usuario != null)
            {
                SesionUsuario.IniciarSesion(usuario);
                MessageBox.Show("Bienvenido " + usuario.Nombre);
                txtNombre.Clear();
                txtContrasenha.Clear();
                this.Hide();
                Principal principal = new Principal(this);
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtContrasenha.Clear();
                txtNombre.Clear();
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(this);
            this.Hide();
            registro.Show();
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
