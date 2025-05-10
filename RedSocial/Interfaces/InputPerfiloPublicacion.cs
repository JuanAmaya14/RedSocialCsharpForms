using RedSocial.Modelos;
using System;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class InputPerfiloPublicacion : Form
    {

        private ControllerUsuario controllerUsuario = new ControllerUsuario();
        private Usuario usuario;
        private Principal principal;
        private Perfil perfil;
        private PublicacionesUsuario publicacionesUsuario;
        private string form;

        public InputPerfiloPublicacion(Principal principal, string form)
        {
            InitializeComponent();

            this.principal = principal;
            this.form = form;
            ToolTip toolTip = new ToolTip();

            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnBuscar, "Buscar usuario");
            toolTip.SetToolTip(btnCancelar, "Cancelar busqueda");
            toolTip.SetToolTip(txtNombre, "Ingrese el nombre del usuario que desea buscar");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = (string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text).Trim();

            if (nombre == null)
            {
                Utilidad.MostrarMensajeAdvertencia("Ingrese un nombre de usuario válido.");
                return;
            }

            usuario = controllerUsuario.MostrarNombre(nombre);

            if (usuario == null)
            {
                Utilidad.MostrarMensajeInformacion($"No se encontro ningun usuario con el nombre \"{nombre}\".");
                return;
            }

            if (form == "Perfil")
            {
                perfil = new Perfil(principal, usuario.Nombre);
                this.principal.Hide();
                txtNombre.Clear();
                this.Close();
                this.perfil.Show();
            }
            else if (form == "Publicacion")
            {
                publicacionesUsuario = new PublicacionesUsuario(principal, usuario.Nombre);
                this.principal.Hide();
                txtNombre.Clear();
                this.Close();
                this.publicacionesUsuario.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            this.Close();

        }

        private void InputPerfil_Load(object sender, EventArgs e)
        {
            txtNombre.Clear();
        }

    }
}
