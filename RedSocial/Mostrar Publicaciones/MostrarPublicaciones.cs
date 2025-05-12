using RedSocial.Interfaz;
using RedSocial.Modelos;
using RedSocial.Sesion;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RedSocial.Mostrar_Publicaciones
{
    public class MostrarPublicaciones
    {
        private ControllerComentario controllerComentario = new ControllerComentario();
        private ControllerPublicacion controllerPublicacion = new ControllerPublicacion();
        private static int tamanhoPanel = 650;
        private readonly Font fuenteConsolas = new Font("Consolas", 9, FontStyle.Bold);

        internal void MostrarPublicacionesFuncion(FlowLayoutPanel flpPublicaciones, string nombreUsuario = null)
        {
            DataTable publicaciones = string.IsNullOrEmpty(nombreUsuario)
                ? controllerPublicacion.Mostrar()
                : controllerPublicacion.MostrarNombre(nombreUsuario);

            DataTable comentarios = controllerComentario.Mostrar();

            flpPublicaciones.Controls.Clear();

            var publicacionesOrdenadas = publicaciones.AsEnumerable()
                .OrderByDescending(f => Convert.ToDateTime(f["fechaCreacion"]));

            foreach (DataRow fila in publicacionesOrdenadas)
            {
                Panel panel = new Panel
                {
                    Width = tamanhoPanel,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    BackColor = Color.Black,
                    AutoSize = true,
                    Font = fuenteConsolas
                };

                Label lblEncabezado = new Label
                {
                    Text = $"{fila["nombreAutor"]} - {Convert.ToDateTime(fila["fechaCreacion"]).ToString("g")}",
                    Font = fuenteConsolas,
                    AutoSize = true,
                    Location = new Point(10, 10),
                    ForeColor = Color.MediumOrchid
                };

                Label lblContenido = new Label
                {
                    Text = fila["contenido"].ToString(),
                    Font = fuenteConsolas,
                    Location = new Point(10, 35),
                    Size = new Size(panel.Width - 20, 40),
                    ForeColor = Color.MediumOrchid
                };

                Button btnComentar = CrearBoton("Comentar", new Point(10, 80), 30, 80, (s, e) =>
                {
                    Comentar comentar = new Comentar(Convert.ToInt32(fila["idPublicacion"]));
                    comentar.ShowDialog();
                    MostrarPublicacionesFuncion(flpPublicaciones);
                });

                panel.Controls.Add(lblEncabezado);
                panel.Controls.Add(lblContenido);
                panel.Controls.Add(btnComentar);

                if (Convert.ToInt32(fila["idAutor"]) == SesionUsuario.IdUsuario)
                {
                    Button btnEditar = CrearBoton("Editar", new Point(190, 80), 30, 80, (s, e) =>
                    {
                        EditarContenido(fila["contenido"].ToString(), nuevoTexto =>
                        {
                            var result = controllerPublicacion.Editar(new Publicacion
                            {
                                IdPublicacion = Convert.ToInt32(fila["idPublicacion"]),
                                Contenido = nuevoTexto
                            });

                            MostrarResultado(result, "Publicación", flpPublicaciones);
                        });
                    });

                    panel.Controls.Add(btnEditar);
                }

                if (Convert.ToInt32(fila["idAutor"]) == SesionUsuario.IdUsuario || SesionUsuario.Administrador)
                {
                    Button btnEliminar = CrearBoton("Eliminar", new Point(100, 80), 30, 80, (s, e) =>
                    {
                        var confirm = MessageBox.Show("¿Estás seguro de eliminar esta publicación?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            controllerPublicacion.Eliminar(Convert.ToInt32(fila["idPublicacion"]));
                            MostrarPublicacionesFuncion(flpPublicaciones);
                        }
                    });

                    panel.Controls.Add(btnEliminar);
                }

                FlowLayoutPanel panelComentarios = new FlowLayoutPanel
                {
                    Location = new Point(10, 120),
                    Width = panel.Width - 20,
                    AutoSize = true,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    Font = fuenteConsolas,
                };

                var comentariosFiltrados = comentarios.AsEnumerable()
                    .Where(c => Convert.ToInt32(c["idPublicacion"]) == Convert.ToInt32(fila["idPublicacion"]));

                foreach (var comentario in comentariosFiltrados)
                {
                    panelComentarios.Controls.Add(CrearComentarioPanel(comentario, flpPublicaciones));
                }

                panel.Controls.Add(panelComentarios);
                flpPublicaciones.Controls.Add(panel);
            }
        }

        private Button CrearBoton(string texto, Point ubicacion, int alto, int ancho, EventHandler evento)
        {
            Button boton = new Button
            {
                Text = texto,
                Location = ubicacion,
                Height = alto,
                Width = ancho,
                Font = fuenteConsolas,
                BackColor = Color.Navy,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Popup
            };
            boton.FlatAppearance.BorderSize = 0;
            boton.Click += evento;
            return boton;
        }
        private void EditarContenido(string contenidoActual, Action<string> onSave)
        {
            while (true)
            {
                string nuevoTexto = Microsoft.VisualBasic.Interaction.InputBox("Editar contenido:", "Editar", contenidoActual);

                if (nuevoTexto == "" && !string.IsNullOrWhiteSpace(contenidoActual))
                {
                    return;
                }

                if (nuevoTexto == contenidoActual || string.IsNullOrWhiteSpace(nuevoTexto))
                {
                    MessageBox.Show("El contenido no puede estar vacío o igual al anterior.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                onSave(nuevoTexto);
                break;
            }
        }


        private void MostrarResultado((string, bool) resultado, string tipo, FlowLayoutPanel flpPublicaciones)
        {
            if (resultado.Item2)
            {
                MessageBoxes.MostrarMensajeConfirmacion($"{tipo} editado correctamente");
                MostrarPublicacionesFuncion(flpPublicaciones);
            }
            else
            {
                MessageBoxes.MostrarMensajeError($"{tipo} no editado: {resultado.Item1}");
            }
        }

        private Panel CrearComentarioPanel(DataRow comentario, FlowLayoutPanel flpPublicaciones)
        {
            Panel panel = new Panel
            {
                Width = tamanhoPanel,
                Height = 60,
                BackColor = Color.FromArgb(30, 30, 30),
                Margin = new Padding(3),
                Font = fuenteConsolas
            };

            Label lblComentario = new Label
            {
                Text = $"{comentario["nombreAutor"]}: {comentario["contenido"]}",
                AutoSize = true,
                Location = new Point(5, 5),
                Font = fuenteConsolas,
                ForeColor = Color.Plum
            };

            panel.Controls.Add(lblComentario);

            int idAutor = Convert.ToInt32(comentario["idAutor"]);

            if (idAutor == SesionUsuario.IdUsuario)
            {
                panel.Controls.Add(CrearBoton("Editar", new Point(5, 30), 25, 60, (s, e) =>
                {
                    EditarContenido(comentario["contenido"].ToString(), nuevoTexto =>
                    {
                        var result = controllerComentario.Editar(new Publicacion
                        {
                            IdPublicacion = Convert.ToInt32(comentario["idComentario"]),
                            Contenido = nuevoTexto
                        });
                        MostrarResultado(result, "Comentario", flpPublicaciones);
                    });
                }));
            }

            if (idAutor == SesionUsuario.IdUsuario || SesionUsuario.Administrador)
            {
                panel.Controls.Add(CrearBoton("Eliminar", new Point(70, 30), 25, 80, (s, e) =>
                {
                    var confirm = MessageBox.Show("¿Estás seguro de eliminar este comentario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        controllerComentario.Eliminar(Convert.ToInt32(comentario["idComentario"]));
                        MostrarPublicacionesFuncion(flpPublicaciones);
                    }
                }));
            }

            return panel;
        }
    }
}
