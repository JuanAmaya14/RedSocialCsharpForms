using ConexionAMySQL.Interfaces;
using RedSocial.Mostrar_Publicaciones;
using RedSocial.Sesion;
using System;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class Principal : Form
    {

        private MostrarPublicaciones mostrarPublicaciones = new MostrarPublicaciones();
        private InicioSesion inicioSesion;

        public Principal(InicioSesion inicioSesion)
        {
            InitializeComponent();
            this.inicioSesion = inicioSesion;

            menuStrip1.ShowItemToolTips = true;

            nuevoPostToolStripMenuItem.ToolTipText = "Crea una nueva publicacion";
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            mostrarPublicaciones.MostrarPublicacionesFuncion(flpPublicaciones);

            if (SesionUsuario.Administrador)
            {
                administradorToolStripMenuItem.Visible = true;
            }
            else
            {
                administradorToolStripMenuItem.Visible = false;
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PreguntaCierreSesion preguntaCierreSesion = new PreguntaCierreSesion(this, inicioSesion);
            preguntaCierreSesion.ShowDialog();

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nuevoPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearPost crearPost = new CrearPost(this);
            this.Hide();
            crearPost.Show();
        }

        private void buscarPublicacionDeUnUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPerfil inputPerfil = new InputPerfil(this);
            inputPerfil.ShowDialog();
        }

        private void auditoriasUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auditorias auditorias = new Auditorias(this);
            this.Hide();
            auditorias.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(this, SesionUsuario.Nombre, inicioSesion);
            this.Hide();
            perfil.Show();
        }
    }
}
