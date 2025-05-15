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
            this.checkBoxContrasenhaConf = new System.Windows.Forms.CheckBox();
            this.checkBoxContrasenha = new System.Windows.Forms.CheckBox();
            this.radioContraNo = new System.Windows.Forms.RadioButton();
            this.radioContraSi = new System.Windows.Forms.RadioButton();
            this.checkBoxContraActual = new System.Windows.Forms.CheckBox();
            this.groupBoxAdministrador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Navy;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(369, 559);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 63);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Navy;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(12, 8);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(128, 40);
            this.btnAtras.TabIndex = 54;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtContrasenhaNueva
            // 
            this.txtContrasenhaNueva.BackColor = System.Drawing.SystemColors.Control;
            this.txtContrasenhaNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenhaNueva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenhaNueva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenhaNueva.ForeColor = System.Drawing.Color.Black;
            this.txtContrasenhaNueva.Location = new System.Drawing.Point(206, 97);
            this.txtContrasenhaNueva.MaxLength = 255;
            this.txtContrasenhaNueva.Name = "txtContrasenhaNueva";
            this.txtContrasenhaNueva.Size = new System.Drawing.Size(209, 31);
            this.txtContrasenhaNueva.TabIndex = 65;
            // 
            // lblContrasenhaNueva
            // 
            this.lblContrasenhaNueva.AutoSize = true;
            this.lblContrasenhaNueva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenhaNueva.ForeColor = System.Drawing.Color.White;
            this.lblContrasenhaNueva.Location = new System.Drawing.Point(202, 71);
            this.lblContrasenhaNueva.Name = "lblContrasenhaNueva";
            this.lblContrasenhaNueva.Size = new System.Drawing.Size(197, 23);
            this.lblContrasenhaNueva.TabIndex = 64;
            this.lblContrasenhaNueva.Text = "Contraseña nueva:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(147, 191);
            this.txtCorreo.MaxLength = 255;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(310, 31);
            this.txtCorreo.TabIndex = 63;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label3.Location = new System.Drawing.Point(32, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(147, 133);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(209, 31);
            this.txtTelefono.TabIndex = 61;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(147, 72);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 31);
            this.txtNombre.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nombre:";
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmarContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmarContra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContra.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmarContra.Location = new System.Drawing.Point(483, 97);
            this.txtConfirmarContra.MaxLength = 255;
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(209, 31);
            this.txtConfirmarContra.TabIndex = 67;
            // 
            // lblConfirmarContraNueva
            // 
            this.lblConfirmarContraNueva.AutoSize = true;
            this.lblConfirmarContraNueva.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraNueva.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarContraNueva.Location = new System.Drawing.Point(479, 71);
            this.lblConfirmarContraNueva.Name = "lblConfirmarContraNueva";
            this.lblConfirmarContraNueva.Size = new System.Drawing.Size(307, 23);
            this.lblConfirmarContraNueva.TabIndex = 66;
            this.lblConfirmarContraNueva.Text = "Confirmar contraseña nueva:";
            // 
            // txtContrasenhaActual
            // 
            this.txtContrasenhaActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContrasenhaActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenhaActual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenhaActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenhaActual.ForeColor = System.Drawing.Color.White;
            this.txtContrasenhaActual.Location = new System.Drawing.Point(231, 496);
            this.txtContrasenhaActual.MaxLength = 255;
            this.txtContrasenhaActual.Name = "txtContrasenhaActual";
            this.txtContrasenhaActual.Size = new System.Drawing.Size(209, 31);
            this.txtContrasenhaActual.TabIndex = 69;
            // 
            // lblContrasenhaActual
            // 
            this.lblContrasenhaActual.AutoSize = true;
            this.lblContrasenhaActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenhaActual.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblContrasenhaActual.Location = new System.Drawing.Point(4, 498);
            this.lblContrasenhaActual.Name = "lblContrasenhaActual";
            this.lblContrasenhaActual.Size = new System.Drawing.Size(208, 23);
            this.lblContrasenhaActual.TabIndex = 68;
            this.lblContrasenhaActual.Text = "Contraseña actual:";
            // 
            // btnPublicaciones
            // 
            this.btnPublicaciones.BackColor = System.Drawing.Color.Navy;
            this.btnPublicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPublicaciones.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicaciones.ForeColor = System.Drawing.Color.White;
            this.btnPublicaciones.Location = new System.Drawing.Point(624, 12);
            this.btnPublicaciones.Name = "btnPublicaciones";
            this.btnPublicaciones.Size = new System.Drawing.Size(230, 48);
            this.btnPublicaciones.TabIndex = 70;
            this.btnPublicaciones.Text = "Ver publicaciones";
            this.btnPublicaciones.UseVisualStyleBackColor = false;
            this.btnPublicaciones.Click += new System.EventHandler(this.btnPublicaciones_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblFecha.Location = new System.Drawing.Point(375, 108);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(171, 20);
            this.lblFecha.TabIndex = 71;
            this.lblFecha.Text = "Fecha de creacion:";
            // 
            // btnBorrarUsuario
            // 
            this.btnBorrarUsuario.BackColor = System.Drawing.Color.Navy;
            this.btnBorrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarUsuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBorrarUsuario.Location = new System.Drawing.Point(399, 12);
            this.btnBorrarUsuario.Name = "btnBorrarUsuario";
            this.btnBorrarUsuario.Size = new System.Drawing.Size(219, 48);
            this.btnBorrarUsuario.TabIndex = 72;
            this.btnBorrarUsuario.Text = "Borrar Usuario";
            this.btnBorrarUsuario.UseVisualStyleBackColor = false;
            this.btnBorrarUsuario.Click += new System.EventHandler(this.btnBorrarUsuario_Click);
            // 
            // groupBoxAdministrador
            // 
            this.groupBoxAdministrador.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBoxAdministrador.Controls.Add(this.radioAdminNo);
            this.groupBoxAdministrador.Controls.Add(this.radioAdminSi);
            this.groupBoxAdministrador.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdministrador.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdministrador.Location = new System.Drawing.Point(537, 196);
            this.groupBoxAdministrador.Name = "groupBoxAdministrador";
            this.groupBoxAdministrador.Size = new System.Drawing.Size(195, 83);
            this.groupBoxAdministrador.TabIndex = 73;
            this.groupBoxAdministrador.TabStop = false;
            this.groupBoxAdministrador.Text = "Administrador";
            // 
            // radioAdminNo
            // 
            this.radioAdminNo.AutoSize = true;
            this.radioAdminNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioAdminNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdminNo.Location = new System.Drawing.Point(109, 39);
            this.radioAdminNo.Name = "radioAdminNo";
            this.radioAdminNo.Size = new System.Drawing.Size(53, 27);
            this.radioAdminNo.TabIndex = 1;
            this.radioAdminNo.TabStop = true;
            this.radioAdminNo.Text = "No";
            this.radioAdminNo.UseVisualStyleBackColor = true;
            // 
            // radioAdminSi
            // 
            this.radioAdminSi.AutoSize = true;
            this.radioAdminSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioAdminSi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdminSi.Location = new System.Drawing.Point(28, 39);
            this.radioAdminSi.Name = "radioAdminSi";
            this.radioAdminSi.Size = new System.Drawing.Size(53, 27);
            this.radioAdminSi.TabIndex = 0;
            this.radioAdminSi.TabStop = true;
            this.radioAdminSi.Text = "Si";
            this.radioAdminSi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkMagenta;
            this.groupBox1.Controls.Add(this.checkBoxContrasenhaConf);
            this.groupBox1.Controls.Add(this.checkBoxContrasenha);
            this.groupBox1.Controls.Add(this.radioContraNo);
            this.groupBox1.Controls.Add(this.radioContraSi);
            this.groupBox1.Controls.Add(this.lblConfirmarContraNueva);
            this.groupBox1.Controls.Add(this.lblContrasenhaNueva);
            this.groupBox1.Controls.Add(this.txtContrasenhaNueva);
            this.groupBox1.Controls.Add(this.txtConfirmarContra);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 174);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar contraseña";
            // 
            // checkBoxContrasenhaConf
            // 
            this.checkBoxContrasenhaConf.AutoSize = true;
            this.checkBoxContrasenhaConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxContrasenhaConf.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxContrasenhaConf.ForeColor = System.Drawing.Color.White;
            this.checkBoxContrasenhaConf.Location = new System.Drawing.Point(483, 134);
            this.checkBoxContrasenhaConf.Name = "checkBoxContrasenhaConf";
            this.checkBoxContrasenhaConf.Size = new System.Drawing.Size(109, 27);
            this.checkBoxContrasenhaConf.TabIndex = 69;
            this.checkBoxContrasenhaConf.Text = "Mostrar";
            this.checkBoxContrasenhaConf.UseVisualStyleBackColor = true;
            this.checkBoxContrasenhaConf.CheckedChanged += new System.EventHandler(this.checkBoxContrasenhaConf_CheckedChanged);
            // 
            // checkBoxContrasenha
            // 
            this.checkBoxContrasenha.AutoSize = true;
            this.checkBoxContrasenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxContrasenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxContrasenha.ForeColor = System.Drawing.Color.White;
            this.checkBoxContrasenha.Location = new System.Drawing.Point(206, 134);
            this.checkBoxContrasenha.Name = "checkBoxContrasenha";
            this.checkBoxContrasenha.Size = new System.Drawing.Size(109, 27);
            this.checkBoxContrasenha.TabIndex = 68;
            this.checkBoxContrasenha.Text = "Mostrar";
            this.checkBoxContrasenha.UseVisualStyleBackColor = true;
            this.checkBoxContrasenha.CheckedChanged += new System.EventHandler(this.checkBoxContrasenha_CheckedChanged);
            // 
            // radioContraNo
            // 
            this.radioContraNo.AutoSize = true;
            this.radioContraNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioContraNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioContraNo.ForeColor = System.Drawing.Color.White;
            this.radioContraNo.Location = new System.Drawing.Point(147, 34);
            this.radioContraNo.Name = "radioContraNo";
            this.radioContraNo.Size = new System.Drawing.Size(53, 27);
            this.radioContraNo.TabIndex = 1;
            this.radioContraNo.TabStop = true;
            this.radioContraNo.Text = "No";
            this.radioContraNo.UseVisualStyleBackColor = true;
            this.radioContraNo.CheckedChanged += new System.EventHandler(this.radioContraNo_CheckedChanged);
            // 
            // radioContraSi
            // 
            this.radioContraSi.AutoSize = true;
            this.radioContraSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioContraSi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioContraSi.ForeColor = System.Drawing.Color.White;
            this.radioContraSi.Location = new System.Drawing.Point(26, 34);
            this.radioContraSi.Name = "radioContraSi";
            this.radioContraSi.Size = new System.Drawing.Size(53, 27);
            this.radioContraSi.TabIndex = 0;
            this.radioContraSi.TabStop = true;
            this.radioContraSi.Text = "Si";
            this.radioContraSi.UseVisualStyleBackColor = true;
            this.radioContraSi.CheckedChanged += new System.EventHandler(this.radioContraSi_CheckedChanged);
            // 
            // checkBoxContraActual
            // 
            this.checkBoxContraActual.AutoSize = true;
            this.checkBoxContraActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxContraActual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxContraActual.ForeColor = System.Drawing.Color.MediumOrchid;
            this.checkBoxContraActual.Location = new System.Drawing.Point(446, 500);
            this.checkBoxContraActual.Name = "checkBoxContraActual";
            this.checkBoxContraActual.Size = new System.Drawing.Size(109, 27);
            this.checkBoxContraActual.TabIndex = 75;
            this.checkBoxContraActual.Text = "Mostrar";
            this.checkBoxContraActual.UseVisualStyleBackColor = true;
            this.checkBoxContraActual.CheckedChanged += new System.EventHandler(this.checkBoxContraActual_CheckedChanged);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(866, 647);
            this.Controls.Add(this.checkBoxContraActual);
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
            this.ForeColor = System.Drawing.Color.MediumOrchid;
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
        private System.Windows.Forms.CheckBox checkBoxContrasenhaConf;
        private System.Windows.Forms.CheckBox checkBoxContrasenha;
        private System.Windows.Forms.CheckBox checkBoxContraActual;
    }
}