using RedSocial.Modelos;
using RedSocial.Mostrar_Publicaciones;
using RedSocial.Sesion;
using System;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class PreguntaBorrarUsuario : Form
    {

        private ControllerUsuario ControllerUsuario = new ControllerUsuario();
        private Usuario usuario;
        private Perfil perfil;
        private InicioSesion inicioSesion;
        private Principal principal;
        private MostrarPublicaciones mostrarPublicaciones = new MostrarPublicaciones();

        public PreguntaBorrarUsuario(Usuario usuario, Perfil perfil, Principal principal, InicioSesion inicioSesion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.perfil = perfil;
            this.inicioSesion = inicioSesion;
            this.principal = principal;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {

            if (SesionUsuario.Administrador && usuario.IdUsuario != SesionUsuario.IdUsuario)
            {
                ControllerUsuario.Eliminar(usuario.IdUsuario);
                MessageBox.Show(usuario.Nombre + " ha sido eliminado correctamente.");

                this.Hide();
                this.perfil.Hide();
                mostrarPublicaciones.MostrarPublicacionesFuncion(principal.flpPublicaciones);
                this.principal.Show();
            }
            else
            {

                ControllerUsuario.Eliminar(usuario.IdUsuario);
                SesionUsuario.CerrarSesion();
                MessageBox.Show(usuario.Nombre + " ha sido eliminado correctamente.");

                this.Hide();
                this.perfil.Hide();
                this.inicioSesion.Show();


            }

        }

        private void PreguntaBorrarUsuario_Load(object sender, EventArgs e)
        {

            if (SesionUsuario.IdUsuario == usuario.IdUsuario)
            {

                lblPregunta.Text = "¿Está seguro que desea eliminar su cuenta?";

            }
            else
            {
                lblPregunta.Text = "¿Está seguro que desea eliminar al usuario " + usuario.Nombre + "?";
            }

        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            this.Hide();

        }
    }
}
