using RedSocial.Modelos;
using System;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class InputPerfil : Form
    {

        private ControllerUsuario controllerUsuario = new ControllerUsuario();
        private Usuario usuario;
        private Principal principal;
        private Perfil perfil;

        public InputPerfil(Principal principal)
        {
            InitializeComponent();

            this.principal = principal;

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
                MessageBox.Show("Ingrese un nombre de usuario válido.");
                return;
            }

            usuario = controllerUsuario.MostrarNombre(nombre);
            if (usuario == null)
            {
                MessageBox.Show("No se encontró el usuario.");
                return;
            }

            this.perfil = new Perfil(principal, usuario.Nombre);
            this.principal.Hide();
            txtNombre.Clear();
            this.Hide();
            this.perfil.Show();

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
