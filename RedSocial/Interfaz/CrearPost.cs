using RedSocial.Modelos;
using RedSocial.Mostrar_Publicaciones;
using RedSocial.Sesion;
using System;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class CrearPost : Form
    {
        private MostrarPublicaciones mostrarPublicaciones = new MostrarPublicaciones();
        private ControllerPublicacion controllerPublicacion = new ControllerPublicacion();
        private Principal principal;

        public CrearPost(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;

            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnPublicar, "Para publicar tu publicacion");
            toolTip.SetToolTip(btAtras, "Para regresar a la pantalla principal");
            toolTip.SetToolTip(txtContenido, "Escribe el contenido de tu publicacion");
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            string contenido = string.IsNullOrWhiteSpace(txtContenido.Text) ? null : txtContenido.Text;

            if (string.IsNullOrWhiteSpace(contenido))
            {
                MessageBox.Show("Por favor, complete el contenido del post.");
                return;
            }

            string mensaje = controllerPublicacion.Insertar(new Publicacion(SesionUsuario.IdUsuario, contenido));

            MessageBox.Show(mensaje);
            txtContenido.Clear();
            this.Hide();
            mostrarPublicaciones.MostrarPublicacionesFuncion(principal.flpPublicaciones);
            this.principal.Show();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            
            txtContenido.Clear();
            this.Hide();
            mostrarPublicaciones.MostrarPublicacionesFuncion(principal.flpPublicaciones);
            this.principal.Show();

        }

        private void CrearPost_Load(object sender, EventArgs e)
        {
            txtContenido.Clear();
        }

        private void CrearPost_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
