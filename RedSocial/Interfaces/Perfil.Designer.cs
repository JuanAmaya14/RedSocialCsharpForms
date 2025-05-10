namespace RedSocial.Interfaz
{
    partial class Perfil
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtContrasenhaNueva = new System.Windows.Forms.TextBox();
            this.lblContrasenhaNueva = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraNueva = new System.Windows.Forms.Label();
            this.txtContrasenhaActual = new System.Windows.Forms.TextBox();
            this.lblContrasenhaActual = new System.Windows.Forms.Label();
            this.btnPublicaciones = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBorrarUsuario = new System.Windows.Forms.Button();
            this.groupBoxAdministrador = new System.Windows.Forms.GroupBox();
            this.radioAdminNo = new System.Windows.Forms.RadioButton();
            this.radioAdminSi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioContraNo = new System.Windows.Forms.RadioButton();
            this.radioContraSi = new System.Windows.Forms.RadioButton();
            this.groupBoxAdministrador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(354, 561);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 52);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(12, 8);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(128, 39);
            this.btnAtras.TabIndex = 54;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtContrasenhaNueva
            // 
            this.txtContrasenhaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenhaNueva.Location = new System.Drawing.Point(236, 97);
            this.txtContrasenhaNueva.MaxLength = 255;
            this.txtContrasenhaNueva.Name = "txtContrasenhaNueva";
            this.txtContrasenhaNueva.PasswordChar = '*';
            this.txtContrasenhaNueva.Size = new System.Drawing.Size(209, 30);
            this.txtContrasenhaNueva.TabIndex = 65;
            // 
            // lblContrasenhaNueva
            // 
            this.lblContrasenhaNueva.AutoSize = true;
            this.lblContrasenhaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenhaNueva.Location = new System.Drawing.Point(231, 69);
            this.lblContrasenhaNueva.Name = "lblContrasenhaNueva";
            this.lblContrasenhaNueva.Size = new System.Drawing.Size(196, 25);
            this.lblContrasenhaNueva.TabIndex = 64;
            this.lblContrasenhaNueva.Text = "Contraseña nueva:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(147, 191);
            this.txtCorreo.MaxLength = 255;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(310, 30);
            this.txtCorreo.TabIndex = 63;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(147, 133);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(209, 30);
            this.txtTelefono.TabIndex = 61;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(147, 72);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 30);
            this.txtNombre.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nombre:";
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContra.Location = new System.Drawing.Point(511, 97);
            this.txtConfirmarContra.MaxLength = 255;
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.PasswordChar = '*';
            this.txtConfirmarContra.Size = new System.Drawing.Size(209, 30);
            this.txtConfirmarContra.TabIndex = 67;
            // 
            // lblConfirmarContraNueva
            // 
            this.lblConfirmarContraNueva.AutoSize = true;
            this.lblConfirmarContraNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraNueva.Location = new System.Drawing.Point(506, 69);
            this.lblConfirmarContraNueva.Name = "lblConfirmarContraNueva";
            this.lblConfirmarContraNueva.Size = new System.Drawing.Size(291, 25);
            this.lblConfirmarContraNueva.TabIndex = 66;
            this.lblConfirmarContraNueva.Text = "Confirmar contraseña nueva:";
            // 
            // txtContrasenhaActual
            // 
            this.txtContrasenhaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenhaActual.Location = new System.Drawing.Point(216, 495);
            this.txtContrasenhaActual.MaxLength = 255;
            this.txtContrasenhaActual.Name = "txtContrasenhaActual";
            this.txtContrasenhaActual.PasswordChar = '*';
            this.txtContrasenhaActual.Size = new System.Drawing.Size(209, 30);
            this.txtContrasenhaActual.TabIndex = 69;
            // 
            // lblContrasenhaActual
            // 
            this.lblContrasenhaActual.AutoSize = true;
            this.lblContrasenhaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenhaActual.Location = new System.Drawing.Point(4, 498);
            this.lblContrasenhaActual.Name = "lblContrasenhaActual";
            this.lblContrasenhaActual.Size = new System.Drawing.Size(195, 25);
            this.lblContrasenhaActual.TabIndex = 68;
            this.lblContrasenhaActual.Text = "Contraseña actual:";
            // 
            // btnPublicaciones
            // 
            this.btnPublicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicaciones.Location = new System.Drawing.Point(640, 12);
            this.btnPublicaciones.Name = "btnPublicaciones";
            this.btnPublicaciones.Size = new System.Drawing.Size(214, 39);
            this.btnPublicaciones.TabIndex = 70;
            this.btnPublicaciones.Text = "Ver publicaciones";
            this.btnPublicaciones.UseVisualStyleBackColor = true;
            this.btnPublicaciones.Click += new System.EventHandler(this.btnPublicaciones_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(376, 76);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(170, 20);
            this.lblFecha.TabIndex = 71;
            this.lblFecha.Text = "Fecha de creacion:";
            // 
            // btnBorrarUsuario
            // 
            this.btnBorrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUsuario.Location = new System.Drawing.Point(442, 12);
            this.btnBorrarUsuario.Name = "btnBorrarUsuario";
            this.btnBorrarUsuario.Size = new System.Drawing.Size(190, 39);
            this.btnBorrarUsuario.TabIndex = 72;
            this.btnBorrarUsuario.Text = "Borrar Usuario";
            this.btnBorrarUsuario.UseVisualStyleBackColor = true;
            this.btnBorrarUsuario.Click += new System.EventHandler(this.btnBorrarUsuario_Click);
            // 
            // groupBoxAdministrador
            // 
            this.groupBoxAdministrador.Controls.Add(this.radioAdminNo);
            this.groupBoxAdministrador.Controls.Add(this.radioAdminSi);
            this.groupBoxAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdministrador.Location = new System.Drawing.Point(496, 133);
            this.groupBoxAdministrador.Name = "groupBoxAdministrador";
            this.groupBoxAdministrador.Size = new System.Drawing.Size(195, 139);
            this.groupBoxAdministrador.TabIndex = 73;
            this.groupBoxAdministrador.TabStop = false;
            this.groupBoxAdministrador.Text = "Administrador";
            // 
            // radioAdminNo
            // 
            this.radioAdminNo.AutoSize = true;
            this.radioAdminNo.Location = new System.Drawing.Point(27, 88);
            this.radioAdminNo.Name = "radioAdminNo";
            this.radioAdminNo.Size = new System.Drawing.Size(60, 29);
            this.radioAdminNo.TabIndex = 1;
            this.radioAdminNo.TabStop = true;
            this.radioAdminNo.Text = "No";
            this.radioAdminNo.UseVisualStyleBackColor = true;
            // 
            // radioAdminSi
            // 
            this.radioAdminSi.AutoSize = true;
            this.radioAdminSi.Location = new System.Drawing.Point(27, 42);
            this.radioAdminSi.Name = "radioAdminSi";
            this.radioAdminSi.Size = new System.Drawing.Size(53, 29);
            this.radioAdminSi.TabIndex = 0;
            this.radioAdminSi.TabStop = true;
            this.radioAdminSi.Text = "Si";
            this.radioAdminSi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioContraNo);
            this.groupBox1.Controls.Add(this.radioContraSi);
            this.groupBox1.Controls.Add(this.lblConfirmarContraNueva);
            this.groupBox1.Controls.Add(this.lblContrasenhaNueva);
            this.groupBox1.Controls.Add(this.txtContrasenhaNueva);
            this.groupBox1.Controls.Add(this.txtConfirmarContra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 145);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar contraseña";
            // 
            // radioContraNo
            // 
            this.radioContraNo.AutoSize = true;
            this.radioContraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioContraNo.Location = new System.Drawing.Point(147, 34);
            this.radioContraNo.Name = "radioContraNo";
            this.radioContraNo.Size = new System.Drawing.Size(60, 29);
            this.radioContraNo.TabIndex = 1;
            this.radioContraNo.TabStop = true;
            this.radioContraNo.Text = "No";
            this.radioContraNo.UseVisualStyleBackColor = true;
            this.radioContraNo.CheckedChanged += new System.EventHandler(this.radioContraNo_CheckedChanged);
            // 
            // radioContraSi
            // 
            this.radioContraSi.AutoSize = true;
            this.radioContraSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioContraSi.Location = new System.Drawing.Point(26, 34);
            this.radioContraSi.Name = "radioContraSi";
            this.radioContraSi.Size = new System.Drawing.Size(53, 29);
            this.radioContraSi.TabIndex = 0;
            this.radioContraSi.TabStop = true;
            this.radioContraSi.Text = "Si";
            this.radioContraSi.UseVisualStyleBackColor = true;
            this.radioContraSi.CheckedChanged += new System.EventHandler(this.radioContraSi_CheckedChanged);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAdministrador);
            this.Controls.Add(this.btnBorrarUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnPublicaciones);
            this.Controls.Add(this.txtContrasenhaActual);
            this.Controls.Add(this.lblContrasenhaActual);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Perfil_FormClosing);
            this.groupBoxAdministrador.ResumeLayout(false);
            this.groupBoxAdministrador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtContrasenhaNueva;
        private System.Windows.Forms.Label lblContrasenhaNueva;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Label lblConfirmarContraNueva;
        private System.Windows.Forms.TextBox txtContrasenhaActual;
        private System.Windows.Forms.Label lblContrasenhaActual;
        private System.Windows.Forms.Button btnPublicaciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBorrarUsuario;
        private System.Windows.Forms.GroupBox groupBoxAdministrador;
        private System.Windows.Forms.RadioButton radioAdminNo;
        private System.Windows.Forms.RadioButton radioAdminSi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioContraNo;
        private System.Windows.Forms.RadioButton radioContraSi;
    }
}