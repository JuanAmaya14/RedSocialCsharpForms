using System;

namespace RedSocial.Modelos
{
    class Comentario
    {

        private int idCometario;
        private int idPublicacion;
        private int idAutor;
        private string contenido;
        private DateTime fechaCreacion;

        public Comentario(int idPublicacion, int idAutor, string contenido)
        {
            this.idPublicacion = idPublicacion;
            this.idAutor = idAutor;
            this.contenido = contenido;
            this.fechaCreacion = DateTime.Now;
        }

        public Comentario(int idCometario, int idPublicacion, int idAutor, string contenido)
        {
            this.idCometario = idCometario;
            this.idPublicacion = idPublicacion;
            this.idAutor = idAutor;
            this.contenido = contenido;
        }

        public int IdPublicacion { get => idPublicacion; set => idPublicacion = value; }
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}

