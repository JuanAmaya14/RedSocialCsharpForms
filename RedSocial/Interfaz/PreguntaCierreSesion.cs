using RedSocial.Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedSocial.Interfaz
{
    public partial class PreguntaCierreSesion : Form
    {
        private InicioSesion inicioSesion;
        private Principal principal;

        public PreguntaCierreSesion(Principal principal, InicioSesion inicioSesion)
        {
            InitializeComponent();
            this.inicioSesion = inicioSesion;
            this.principal = principal;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {

            SesionUsuario.CerrarSesion();
            this.Close();
            this.principal.Hide();
            this.inicioSesion.Show();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
