
using RedSocial.Mostrar_Publicaciones;
using System;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class PublicacionesUsuario : Form
    {
        private MostrarPublicaciones mostrarPublicaciones = new MostrarPublicaciones();
        private string nombre;
        private Form formAntearior;


        public PublicacionesUsuario(Form formAntearior, string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.formAntearior = formAntearior;
            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAtras, "Regresa a la pantalla anterior");
        }

        private void PublicacionesUsuario_Load(object sender, EventArgs e)
        {
            mostrarPublicaciones.MostrarPublicacionesFuncion(flpPublicaciones, nombre);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formAntearior.Show();

        }

        private void PublicacionesUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
