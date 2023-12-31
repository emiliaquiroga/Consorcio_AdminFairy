﻿namespace Administracion_Consorcio_AdminFairy
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtDni = new TextBox();
            txtClave = new TextBox();
            lblMarca = new Label();
            chkMostrarClave = new CheckBox();
            btnIniciarSesion = new Button();
            btnAutocompletar = new Button();
            pictureBox1 = new PictureBox();
            lblRegistro = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Location = new Point(71, 213);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su D.N.I";
            txtDni.Size = new Size(296, 20);
            txtDni.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Location = new Point(71, 259);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Ingrese su Clave";
            txtClave.Size = new Size(296, 20);
            txtClave.TabIndex = 1;
            txtClave.UseSystemPasswordChar = true;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.FromArgb(168, 183, 204);
            lblMarca.Location = new Point(85, 135);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(257, 42);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "·AdminFairy· \r\nComplete sus datos para Iniciar";
            lblMarca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkMostrarClave
            // 
            chkMostrarClave.AutoSize = true;
            chkMostrarClave.BackColor = Color.FromArgb(168, 183, 204);
            chkMostrarClave.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkMostrarClave.Location = new Point(71, 295);
            chkMostrarClave.Name = "chkMostrarClave";
            chkMostrarClave.Size = new Size(110, 21);
            chkMostrarClave.TabIndex = 3;
            chkMostrarClave.Text = "Mostrar clave";
            chkMostrarClave.UseVisualStyleBackColor = false;
            chkMostrarClave.CheckedChanged += chkMostrarClave_CheckedChanged;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(85, 440);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(257, 58);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnAutocompletar
            // 
            btnAutocompletar.BackColor = Color.FromArgb(168, 183, 204);
            btnAutocompletar.FlatStyle = FlatStyle.Popup;
            btnAutocompletar.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutocompletar.Location = new Point(132, 332);
            btnAutocompletar.Name = "btnAutocompletar";
            btnAutocompletar.Size = new Size(171, 45);
            btnAutocompletar.TabIndex = 6;
            btnAutocompletar.Text = "Autocompletar";
            btnAutocompletar.UseVisualStyleBackColor = false;
            btnAutocompletar.Click += btnAutocompletar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-57, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistro.Location = new Point(132, 523);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(147, 19);
            lblRegistro.TabIndex = 8;
            lblRegistro.TabStop = true;
            lblRegistro.Text = "¡Quiero Registrarme!";
            lblRegistro.LinkClicked += lblRegistro_LinkClicked_1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 140, 171);
            ClientSize = new Size(434, 593);
            Controls.Add(lblRegistro);
            Controls.Add(btnAutocompletar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(chkMostrarClave);
            Controls.Add(lblMarca);
            Controls.Add(txtClave);
            Controls.Add(txtDni);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFairy - Log In";
            FormClosed += FrmLogin_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private TextBox txtClave;
        private Label lblMarca;
        private CheckBox chkMostrarClave;
        private Button btnIniciarSesion;
        private Button btnAutocompletar;
        private PictureBox pictureBox1;
        private LinkLabel lblRegistro;
    }
}