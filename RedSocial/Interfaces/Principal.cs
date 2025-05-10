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

            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            menuStrip1.ShowItemToolTips = true;

            nuevoPostToolStripMenuItem.ToolTipText = "Crea una nueva publicacion";
            perfilToolStripMenuItem.ToolTipText = "Muestra tu perfil";
            buscarPublicacionDeUnUsuarioToolStripMenuItem.ToolTipText = "Busca publicaciones de un usuario";
            buscarUsuarioToolStripMenuItem.ToolTipText = "Busca un usuario";
            auditoriasUsuarioToolStripMenuItem.ToolTipText = "Muestra las auditorias de un usuario";
            cerrarSesionToolStripMenuItem.ToolTipText = "Cierra la sesion actual";
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
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                SesionUsuario.CerrarSesion();
                this.Hide();
                inicioSesion.Show();
            }
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
            InputPerfiloPublicacion inputPerfil = new InputPerfiloPublicacion(this, "Publicacion");
            inputPerfil.ShowDialog();


        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPerfiloPublicacion inputPerfiloPublicacion = new InputPerfiloPublicacion(this, "Perfil");
            inputPerfiloPublicacion.ShowDialog();
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
