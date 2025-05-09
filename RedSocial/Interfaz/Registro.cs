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
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!Regex.IsMatch(correo, patronCorreo))
            {
                MessageBox.Show("Correo invalido.");
                return;
            }

            if (contrasenha != confirmarContrasenha)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string contrasenhaEncriptada = BCrypt.Net.BCrypt.HashPassword(contrasenha);

            string mensaje = controllerUsuario.Insertar(new Usuario(nombre, telefono, correo, contrasenhaEncriptada));

            MessageBox.Show(mensaje);

            if (mensaje == "Usuario registrado correctamente, por favor inicie sesion")
            {
                this.Hide();
                this.inicioSesion.Show();
            }
        }

        private void btAtras_Click(object sender, EventArgs e)
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
