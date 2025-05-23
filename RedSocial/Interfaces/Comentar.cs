﻿using RedSocial.Modelos;
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

            InitializeTooltips();
        }

        private void InitializeTooltips()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(btnPublicarComentario, "Publicar comentario");
            toolTip.SetToolTip(btnCancelar, "Cancelar publicación");
            toolTip.SetToolTip(txtComentario, "Escribe tu comentario aquí");

        }

        private void btnPublicarComentario_Click(object sender, EventArgs e)
        {
            string contenido = string.IsNullOrWhiteSpace(txtComentario.Text) ? null : txtComentario.Text;
            if (string.IsNullOrWhiteSpace(contenido))
            {
                MessageBoxes.MostrarMensajeAdvertencia("Por favor complete el contenido del comentario.");
                return;
            }

            bool mensaje = controllerComentario.Insertar(new Comentario(idPublicacion, SesionUsuario.IdUsuario, contenido));


            if (mensaje)
            {
                txtComentario.Clear();
                this.Close();
            }
            else
            {
                return;
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
