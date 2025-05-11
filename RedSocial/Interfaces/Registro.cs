using RedSocial.Modelos;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class Registro : Form
    {

        private ControllerUsuario controllerUsuario = new ControllerUsuario();
        private InicioSesion inicioSesion;
        private string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public Registro(InicioSesion inicioSesion)
        {
            InitializeComponent();
            this.inicioSesion = inicioSesion;

            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAtras, "Vuelves a la pantalla de inicio de sesion");
            toolTip.SetToolTip(btnRegistrar, "Te registras si los datos son correctos");
            toolTip.SetToolTip(txtNombre, "Escribe tu nombre");
            toolTip.SetToolTip(txtTelefono, "Escribe tu telefono");
            toolTip.SetToolTip(txtCorreo, "Escribe tu correo");
            toolTip.SetToolTip(txtContrasenha, "Escribe tu contraseña");
            toolTip.SetToolTip(txtConfirmarContra, "Escribe tu contraseña de nuevo");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text;
            string telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text;
            string correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text;
            string contrasenha = string.IsNullOrWhiteSpace(txtContrasenha.Text) ? null : txtContrasenha.Text;
            string confirmarContrasenha = string.IsNullOrWhiteSpace(txtConfirmarContra.Text) ? null : txtConfirmarContra.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasenha) || string.IsNullOrWhiteSpace(confirmarContrasenha))
            {
                MessageBoxes.MostrarMensajeAdvertencia("Por favor, complete todos los campos.");
                return;
            }

            if (!Regex.IsMatch(correo, patronCorreo))
            {
                MessageBoxes.MostrarMensajeAdvertencia("El correo no es valido");
                return;
            }

            if (contrasenha != confirmarContrasenha)
            {
                MessageBoxes.MostrarMensajeAdvertencia("Las contraseñas no coinciden.");
                return;
            }

            string contrasenhaEncriptada = BCrypt.Net.BCrypt.HashPassword(contrasenha);

            bool resultado = controllerUsuario.Insertar(new Usuario(nombre, telefono, correo, contrasenhaEncriptada));

            if (resultado)
            {
                this.Hide();
                this.inicioSesion.Show();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.inicioSesion.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContrasenha.Clear();
            txtConfirmarContra.Clear();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(correo, patronCorreo))
            {
                txtCorreo.BackColor = Color.LightGreen;
            }
            else
            {
                txtCorreo.BackColor = Color.LightCoral;
            }
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
