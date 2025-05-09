using RedSocial.Modelos;
using RedSocial.Sesion;
using System;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class Comentar : Form
    {
        private ControllerComentario controllerComentario = new ControllerComentario();
        private int idPublicacion;

        public Comentar(int idPublicacion)
        {
            InitializeComponent();

            this.idPublicacion = idPublicacion;
        }

        private void btnPublicarComentario_Click(object sender, EventArgs e)
        {
            string contenido = string.IsNullOrWhiteSpace(txtComentario.Text) ? null : txtComentario.Text;
            if (string.IsNullOrWhiteSpace(contenido))
            {
                MessageBox.Show("Por favor, complete el contenido del comentario.");
                return;
            }

            string mensaje = controllerComentario.Insertar(new Comentario(idPublicacion, SesionUsuario.IdUsuario, contenido));


            if (mensaje == "El comentario fue publicado correctamente")
            {
                MessageBox.Show(mensaje);
                txtComentario.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al publicar el comentario: " + mensaje);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtComentario.Clear();
            this.Close();
        }

        private void Comentar_Load(object sender, EventArgs e)
        {
            txtComentario.Clear();
        }
    }
}
