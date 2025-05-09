using System;

namespace RedSocial.Modelos
{
    public class Usuario
    {

        private int idUsuario;
        private string nombre;
        private string telefono;
        private string correo;
        private string contrasenha;
        private DateTime fechaCreacion;
        private bool administrador;

        public Usuario(int idUsuario, string nombre, string telefono, string correo, string contrasenha, DateTime fechaCreacion, bool administrador)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.contrasenha = contrasenha;
            this.fechaCreacion = fechaCreacion;
            this.administrador = administrador;
        }

        public Usuario(string nombre, string telefono, string correo, string contrasenha)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.contrasenha = contrasenha;
            this.fechaCreacion = DateTime.Now;
            this.administrador = false;
        }

        public Usuario(int idUsuario, string nombre, string telefono, string correo, string contrasenha, bool administrador, DateTime fechaCreacion)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.contrasenha = contrasenha;
            this.administrador = administrador;
            this.fechaCreacion = fechaCreacion;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasenha { get => contrasenha; set => contrasenha = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public bool Administrador { get => administrador; set => administrador = value; }

    }
}

