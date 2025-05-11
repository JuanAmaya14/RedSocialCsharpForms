namespace RedSocial.Interfaz
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpPublicaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.publicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriasUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPublicaciones
            // 
            this.flpPublicaciones.AutoScroll = true;
            this.flpPublicaciones.Location = new System.Drawing.Point(0, 30);
            this.flpPublicaciones.Name = "flpPublicaciones";
            this.flpPublicaciones.Size = new System.Drawing.Size(934, 466);
            this.flpPublicaciones.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicarToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // publicarToolStripMenuItem
            // 
            this.publicarToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.publicarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPostToolStripMenuItem});
            this.publicarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.publicarToolStripMenuItem.Name = "publicarToolStripMenuItem";
            this.publicarToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.publicarToolStripMenuItem.Text = "Publicar";
            // 
            // nuevoPostToolStripMenuItem
            // 
            this.nuevoPostToolStripMenuItem.BackColor = System.Drawing.Color.MediumBlue;
            this.nuevoPostToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoPostToolStripMenuItem.Name = "nuevoPostToolStripMenuItem";
            this.nuevoPostToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.nuevoPostToolStripMenuItem.Text = "Nuevo post";
            this.nuevoPostToolStripMenuItem.Click += new System.EventHandler(this.nuevoPostToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.BackColor = System.Drawing.Color.MediumBlue;
            this.perfilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // buscarPublicacionDeUnUsuarioToolStripMenuItem
            // 
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MediumBlue;
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem.Name = "buscarPublicacionDeUnUsuarioToolStripMenuItem";
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem.Text = "Buscar publicacion de un usuario";
            this.buscarPublicacionDeUnUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarPublicacionDeUnUsuarioToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarUsuarioToolStripMenuItem,
            this.auditoriasUsuarioToolStripMenuItem});
            this.administradorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MediumBlue;
            this.buscarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.buscarUsuarioToolStripMenuItem.Text = "Buscar usuario";
            this.buscarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarUsuarioToolStripMenuItem_Click);
            // 
            // auditoriasUsuarioToolStripMenuItem
            // 
            this.auditoriasUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.MediumBlue;
            this.auditoriasUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.auditoriasUsuarioToolStripMenuItem.Name = "auditoriasUsuarioToolStripMenuItem";
            this.auditoriasUsuarioToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.auditoriasUsuarioToolStripMenuItem.Text = "Auditorias usuario";
            this.auditoriasUsuarioToolStripMenuItem.Click += new System.EventHandler(this.auditoriasUsuarioToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.cerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(934, 496);
            this.Controls.Add(this.flpPublicaciones);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPublicacionDeUnUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriasUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        internal System.Windows.Forms.FlowLayoutPanel flpPublicaciones;
    }
}