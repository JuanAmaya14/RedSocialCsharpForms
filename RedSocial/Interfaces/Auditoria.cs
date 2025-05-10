using RedSocial.Controladores;
using RedSocial.Interfaz;
using RedSocial.Mostrar_Publicaciones;
using System;
using System.Data;
using System.Windows.Forms;

namespace ConexionAMySQL.Interfaces
{
    public partial class Auditorias : Form
    {
        private ControllerAuditoria ControllerAuditoria = new ControllerAuditoria();
        private Principal principal;
        private MostrarPublicaciones mostrarPublicaciones = new MostrarPublicaciones();


        public Auditorias(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;

            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnAtras, "Vuelve a la pantalla principal");
            toolTip.SetToolTip(btnFiltrar, "Filtra las auditorias por ID");
            toolTip.SetToolTip(btnMostrarTodos, "Muestra todas las auditorias");
            toolTip.SetToolTip(txtId, "Ingresa el ID del usuario para filtrar las auditorias");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            this.Hide();
            this.principal.Show();
        }

        private void Auditorias_Load(object sender, EventArgs e)
        {
            txtId.Clear();
            mostrarPublicaciones.MostrarPublicacionesFuncion(principal.flpPublicaciones);
            MostrarAuditorias();
        }

        private void MostrarAuditorias()
        {
            dataGridView1.DataSource = ControllerAuditoria.Mostrar();
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void MostrarAuditoriasPorId(int id)
        {
            DataTable datos = ControllerAuditoria.MostrarPorId(id);

            if (datos.Rows.Count != 0)
            {

                dataGridView1.DataSource = datos;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.AllowUserToAddRows = false;

            }
            else
            {

                Utilidad.MostrarMensajeInformacion($"No se encontro ningun usuario con el ID: {id}.");

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int id = txtId.Text == "" ? 0 : Convert.ToInt32(txtId.Text);

            if (id != 0)
            {

                MostrarAuditoriasPorId(id);

            }
            else
            {

                Utilidad.MostrarMensajeInformacion("El campo del ID esta vacio.");

            }

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            MostrarAuditorias();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Auditorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
