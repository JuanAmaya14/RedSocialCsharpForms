﻿namespace RedSocial.Interfaz
{
    partial class CrearPost
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btAtras = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(103, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contenido:";
            // 
            // txtContenido
            // 
            this.txtContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContenido.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.ForeColor = System.Drawing.Color.White;
            this.txtContenido.Location = new System.Drawing.Point(108, 116);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(569, 262);
            this.txtContenido.TabIndex = 1;
            // 
            // btAtras
            // 
            this.btAtras.BackColor = System.Drawing.Color.Navy;
            this.btAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAtras.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.ForeColor = System.Drawing.Color.White;
            this.btAtras.Location = new System.Drawing.Point(12, 12);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(123, 54);
            this.btAtras.TabIndex = 9;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = false;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.Color.Navy;
            this.btnPublicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPublicar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicar.ForeColor = System.Drawing.Color.White;
            this.btnPublicar.Location = new System.Drawing.Point(311, 384);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(154, 57);
            this.btnPublicar.TabIndex = 10;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // CrearPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrearPost";
            this.Text = "Crear publicacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearPost_FormClosing);
            this.Load += new System.EventHandler(this.CrearPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btnPublicar;
    }
}