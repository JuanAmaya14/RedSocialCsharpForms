using RedSocial.Modelos;
using RedSocial.Mostrar_Publicaciones;
using RedSocial.Sesion;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class Perfil : Form
    {
        private ControllerUsuario ControllerUsuario = new ControllerUsuario();
        private Usuario usuario, usuarioModificado;
        private string nombre;
        private Principal principal;
        private InicioSesion inicioSesion = null;
        private string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        private MostrarPublicaciones mostrarPublicaciones = new MostrarPublicaciones();

        public Perfil(Principal principal, string nombre, InicioSesion inicioSesion = null)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.principal = principal;
            this.inicioSesion = inicioSesion;
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            if (this.nombre == SesionUsuario.Nombre)
            {
                usuario = new Usuario(SesionUsuario.IdUsuario, SesionUsuario.Nombre, SesionUsuario.Telefono, SesionUsuario.Correo, SesionUsuario.Contrasenha, SesionUsuario.Administrador, SesionUsuario.FechaCreacion);
            }
            else
            {

                usuario = ControllerUsuario.MostrarNombre(this.nombre);

            }

            txtContrasenhaActual.Visible = false;
            lblContrasenhaActual.Visible = false;
            txtConfirmarContra.Visible = false;
            lblConfirmarContraNueva.Visible = false;
            radioContraNo.Enabled = true;

            CompletarDatos();

            lblFecha.Text = "Fecha de creación: " + usuario.FechaCreacion;

        }

        private void CompletarDatos()
        {

            txtNombre.Text = usuario.Nombre;
            txtTelefono.Text = usuario.Telefono;
            txtCorreo.Text = usuario.Correo;
            if (usuario.Administrador)
            {

                radioAdminSi.Checked = true;
                radioAdminNo.Checked = false;

            }
            else
            {
                radioAdminNo.Checked = true;
                radioAdminSi.Checked = false;

            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            mostrarPublicaciones.MostrarPublicacionesFuncion(principal.flpPublicaciones);
            this.principal.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasenhaActual = txtContrasenhaActual.Text;
            string contrasenhaNueva = txtContrasenhaNueva.Text;
            string contrasenhaNuevaConfirmacion = txtConfirmarContra.Text;
            bool administrador = radioAdminSi.Checked;

            bool hayCambios = nombre != usuario.Nombre || telefono != usuario.Telefono || correo != usuario.Correo ||
                      !string.IsNullOrWhiteSpace(contrasenhaNueva) || administrador != usuario.Administrador;


            if (!hayCambios)
            {
                MessageBox.Show("No se han realizado cambios en los datos del usuario");
                txtContrasenhaActual.Clear();
                return;
            }

            if (!Regex.IsMatch(correo, patronCorreo))
            {
                MessageBox.Show("Correo invalido.");
                return;
            }

            if (!SesionUsuario.Administrador || nombre == SesionUsuario.Nombre)
            {
                if (string.IsNullOrWhiteSpace(contrasenhaActual))
                {
                    MessageBox.Show("Debes ingresar tu contraseña actual para guardar los cambios.");
                    txtContrasenhaActual.Clear();
                    return;
                }

                bool contrasenhaCorrecta = BCrypt.Net.BCrypt.Verify(contrasenhaActual, SesionUsuario.Contrasenha);
                if (!contrasenhaCorrecta)
                {
                    MessageBox.Show("La contraseña actual no es correcta.");
                    txtContrasenhaActual.Clear();
                    return;
                }
            }

            string nuevaContrasenhaFinal = SesionUsuario.Contrasenha;
            if (!string.IsNullOrWhiteSpace(contrasenhaNueva))
            {
                if (contrasenhaNueva != contrasenhaNuevaConfirmacion)
                {
                    MessageBox.Show("La nueva contraseña y su confirmación no coinciden.");
                    txtContrasenhaActual.Clear();
                    return;
                }

                nuevaContrasenhaFinal = BCrypt.Net.BCrypt.HashPassword(contrasenhaNueva);
            }

            usuarioModificado = new Usuario(usuario.IdUsuario, nombre, telefono, correo, nuevaContrasenhaFinal, administrador, usuario.FechaCreacion);

            btnModificar.Visible = false;
            lblPregunta.Text = "¿Está seguro que desea modificar tus datos?";
            lblPregunta.Visible = true;
            btnSi.Visible = true;
            btnNo.Visible = true;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            var resultado = ControllerUsuario.Editar(usuarioModificado);

            if (resultado.Item2)
            {
                if (usuario.IdUsuario == SesionUsuario.IdUsuario)
                {
                    SesionUsuario.IniciarSesion(usuarioModificado);
                }

                OcultarPregunta();
                MessageBox.Show(resultado.Item1);
                txtContrasenhaActual.Clear();
                txtConfirmarContra.Clear();
                txtContrasenhaNueva.Clear();
            }
            else
            {
                usuarioModificado = usuario;
                CompletarDatos();
                OcultarPregunta();
                MessageBox.Show(resultado.Item1);
                txtContrasenhaActual.Clear();
                txtConfirmarContra.Clear();
                txtContrasenhaNueva.Clear();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            OcultarPregunta();
        }

        private void btnPublicaciones_Click(object sender, EventArgs e)
        {
            PublicacionesUsuario publicacionesUsuario = new PublicacionesUsuario(this, this.nombre);
            this.Hide();
            publicacionesUsuario.Show();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            PreguntaBorrarUsuario preguntaBorrarUsuario = new PreguntaBorrarUsuario(usuario, this, principal, inicioSesion);
            preguntaBorrarUsuario.ShowDialog();
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
            string correo = txtCorreo.Text.Trim();

            if (Regex.IsMatch(correo, patronCorreo))
            {
                txtCorreo.BackColor = Color.LightGreen;
            }
            else
            {
                txtCorreo.BackColor = Color.LightCoral;
            }
        }

        private void Perfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioContraSi_CheckedChanged(object sender, EventArgs e)
        {

            txtContrasenhaActual.Visible = true;
            lblContrasenhaActual.Visible = true;
            txtConfirmarContra.Visible = true;
            lblConfirmarContraNueva.Visible = true;
        }

        private void radioContraNo_CheckedChanged(object sender, EventArgs e)
        {

            txtContrasenhaActual.Visible = false;
            lblContrasenhaActual.Visible = false;
            txtConfirmarContra.Visible = false;
            lblConfirmarContraNueva.Visible = false;
        }

        private void OcultarPregunta()
        {
            btnModificar.Visible = true;
            lblPregunta.Visible = false;
            btnSi.Visible = false;
            btnNo.Visible = false;
        }
    }
}
