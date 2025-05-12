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
        private ControllerUsuario controllerUsuario = new ControllerUsuario();
        private Usuario usuario;
        private Usuario usuarioModificado;
        private string nombre;
        private Principal principal;
        private string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        private MostrarPublicaciones mostrarPublicaciones = new MostrarPublicaciones();
        private InicioSesion inicioSesion;

        public Perfil(Principal principal, string nombre, InicioSesion inicioSesion = null)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.principal = principal;
            this.inicioSesion = inicioSesion;

            radioContraNo.Checked = true;

            usuario = controllerUsuario.MostrarNombre(nombre);

            if (usuario == null)
            {
                MessageBoxes.MostrarMensajeInformacion("No se encontro el usuario en la base de datos.");
                return;
            }

            CompletarDatos();

            if (SesionUsuario.Administrador && usuario.Nombre == SesionUsuario.Nombre)
            {
                groupBoxAdministrador.Visible = false;
            }

            if (!SesionUsuario.Administrador)
            {
                groupBoxAdministrador.Visible = false;
            }

            lblFecha.Text = $"Fecha de creación: {usuario.FechaCreacion}";

            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnModificar, "Guarda los cambios realizados");
            toolTip.SetToolTip(btnAtras, "Regresa a la pantalla anterior");
            toolTip.SetToolTip(btnPublicaciones, "Muestra las publicaciones del usuario");
            toolTip.SetToolTip(btnBorrarUsuario, "Elimina el usuario de la base de datos");
            toolTip.SetToolTip(txtNombre, "Escribe el nuevo nombre de usuario");
            toolTip.SetToolTip(txtTelefono, "Escribe el nuevo teléfono");
            toolTip.SetToolTip(txtCorreo, "Escribe el nuevo correo");
            toolTip.SetToolTip(txtContrasenhaActual, "Escribe tu contraseña actual");
            toolTip.SetToolTip(txtContrasenhaNueva, "Escribe la nueva contraseña");
            toolTip.SetToolTip(txtConfirmarContra, "Escribe la nueva contraseña nuevamente");
        }

        private void CompletarDatos()
        {
            txtNombre.Text = usuario.Nombre;
            txtTelefono.Text = usuario.Telefono;
            txtCorreo.Text = usuario.Correo;
            radioAdminSi.Checked = usuario.Administrador;
            radioAdminNo.Checked = !usuario.Administrador;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Hide();
            mostrarPublicaciones.MostrarPublicacionesFuncion(principal.flpPublicaciones);
            principal.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string actual = txtContrasenhaActual.Text;
            string nueva = radioContraSi.Checked ? txtContrasenhaNueva.Text : string.Empty;
            string confirmacion = radioContraSi.Checked ? txtConfirmarContra.Text : string.Empty;
            bool admin = radioAdminSi.Checked;

            if (!HayCambios(nombre, telefono, correo, nueva, admin))
            {
                MessageBoxes.MostrarMensajeInformacion("No se han realizado cambios en los datos del usuario");
                return;
            }

            if (!ValidarCorreo(correo)) return;

            if (!ValidarContraseña(actual)) return;

            string nuevaHash = usuario.Contrasenha;
            if (radioContraSi.Checked && !string.IsNullOrWhiteSpace(nueva))
            {
                if (nueva != confirmacion)
                {
                    MessageBoxes.MostrarMensajeInformacion("Por favor, verifica que ambas contraseñas sean iguales.");
                    return;
                }
                nuevaHash = BCrypt.Net.BCrypt.HashPassword(nueva);
            }

            if (ConfirmarModificacion())
            {
                usuarioModificado = new Usuario(usuario.IdUsuario, nombre, telefono, correo, nuevaHash, admin, usuario.FechaCreacion);
                bool resultado = controllerUsuario.Editar(usuarioModificado);
                if (resultado)
                {
                    if (usuario.IdUsuario == SesionUsuario.IdUsuario)
                        SesionUsuario.IniciarSesion(usuarioModificado);
                }
                else
                {
                    usuarioModificado = usuario;
                    CompletarDatos();
                }
            }
        }

        private bool ValidarCorreo(string correo)
        {
            if (!Regex.IsMatch(correo, patronCorreo))
            {
                MessageBoxes.MostrarMensajeAdvertencia("El correo ingresado no es válido. Por favor, verifica el formato.");
                return false;
            }
            return true;
        }

        private bool ValidarContraseña(string actual)
        {
            bool esPropioPerfil = usuario.IdUsuario == SesionUsuario.IdUsuario;
            string mensaje = esPropioPerfil
                ? "Debes ingresar tu contraseña actual para guardar los cambios."
                : "Debes ingresar tu contraseña de administrador para confirmar los cambios de otro usuario.";

            if (string.IsNullOrWhiteSpace(actual))
            {
                MessageBoxes.MostrarMensajeAdvertencia(mensaje);
                LimpiarCampos();
                return false;
            }

            if (!BCrypt.Net.BCrypt.Verify(actual, SesionUsuario.Contrasenha))
            {
                MessageBoxes.MostrarMensajeError("La contraseña actual no es correcta.");
                LimpiarCampos();
                return false;
            }
            return true;
        }

        private bool ConfirmarModificacion()
        {
            return MessageBox.Show("¿Está seguro que desea modificar los datos?",
                                   "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private bool HayCambios(string nombre, string telefono, string correo, string nueva, bool admin)
        {
            return nombre != usuario.Nombre || telefono != usuario.Telefono || correo != usuario.Correo ||
                   !string.IsNullOrWhiteSpace(nueva) || admin != usuario.Administrador;
        }

        private void LimpiarCampos()
        {
            txtContrasenhaActual.Clear();
            txtConfirmarContra.Clear();
            txtContrasenhaNueva.Clear();
        }

        private void btnPublicaciones_Click(object sender, EventArgs e)
        {
            PublicacionesUsuario publicacionesUsuario = new PublicacionesUsuario(this, nombre);
            Hide();
            publicacionesUsuario.Show();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            string mensaje = usuario.IdUsuario == SesionUsuario.IdUsuario
                ? "¿Está seguro que desea eliminar su cuenta?"
                : $"¿Está seguro que desea eliminar al usuario {usuario.Nombre}?";

            DialogResult result = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SesionUsuario.Administrador && usuario.IdUsuario != SesionUsuario.IdUsuario)
                {
                    controllerUsuario.Eliminar(usuario.IdUsuario);
                    MessageBox.Show($"{usuario.Nombre} ha sido eliminado correctamente.");

                    this.Hide();
                    mostrarPublicaciones.MostrarPublicacionesFuncion(principal.flpPublicaciones);
                    this.principal.Show();
                }
                else
                {
                    controllerUsuario.Eliminar(usuario.IdUsuario);
                    SesionUsuario.CerrarSesion();
                    MessageBox.Show($"{usuario.Nombre} ha sido eliminado correctamente.");

                    this.Hide();
                    this.inicioSesion.Show();
                }
            }
        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            txtCorreo.BackColor = Regex.IsMatch(txtCorreo.Text.Trim(), patronCorreo)
                ? Color.LightGreen
                : Color.LightCoral;
        }

        private void Perfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioContraSi_CheckedChanged(object sender, EventArgs e)
        {
            ToggleContraseñaVisibility(true);
        }

        private void radioContraNo_CheckedChanged(object sender, EventArgs e)
        {
            ToggleContraseñaVisibility(false);
        }

        private void ToggleContraseñaVisibility(bool isVisible)
        {
            txtContrasenhaNueva.Visible = isVisible;
            lblContrasenhaNueva.Visible = isVisible;
            txtConfirmarContra.Visible = isVisible;
            lblConfirmarContraNueva.Visible = isVisible;
        }
    }
}
