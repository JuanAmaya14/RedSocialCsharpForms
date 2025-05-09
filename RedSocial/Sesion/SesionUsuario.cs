using RedSocial.Modelos;
using System;

namespace RedSocial.Sesion
{
    public static class SesionUsuario
    {
        public static int IdUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Telefono { get; set; }
        public static string Correo { get; set; }
        public static string Contrasenha { get; set; }
        public static DateTime FechaCreacion { get; set; }
        public static bool Administrador { get; set; }

        public static void IniciarSesion(Usuario usuario)
        {
            IdUsuario = usuario.IdUsuario;
            Nombre = usuario.Nombre;
            Correo = usuario.Correo;
            Contrasenha = usuario.Contrasenha;
            Telefono = usuario.Telefono;
            FechaCreacion = usuario.FechaCreacion;
            Administrador = usuario.Administrador;
        }
        public static void CerrarSesion()
        {
            IdUsuario = 0;
            Nombre = null;
            Correo = null;
            Contrasenha = null;
            Telefono = null;
            FechaCreacion = DateTime.MinValue;
            Administrador = false;
        }

    }
}
