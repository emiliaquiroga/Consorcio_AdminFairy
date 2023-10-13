namespace Administracion_Consorcio_AdminFairy
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            lblTitulo = new Label();
            lstCiudad = new ListBox();
            grpDepto = new GroupBox();
            dmUpDownUnidad = new DomainUpDown();
            dmUpDownPiso = new DomainUpDown();
            lstTorre = new ListBox();
            btnRegistro = new Button();
            btnSalir = new Button();
            btnBorrarInfo = new Button();
            lblInicio = new LinkLabel();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            txtClaveReg = new TextBox();
            txtEmail = new TextBox();
            txtConfirmeClave = new TextBox();
            radInquilino = new RadioButton();
            radDuenio = new RadioButton();
            lblError = new Label();
            grpDatos = new GroupBox();
            grpSituacion = new GroupBox();
            grpDepto.SuspendLayout();
            grpDatos.SuspendLayout();
            grpSituacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(120, 11);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(277, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Completá los siguientes datos:";
            // 
            // lstCiudad
            // 
            lstCiudad.AllowDrop = true;
            lstCiudad.FormattingEnabled = true;
            lstCiudad.ItemHeight = 15;
            lstCiudad.Items.AddRange(new object[] { "Ciudad Autónoma de Buenos Aires", "La Plata", "Córdoba", "Santa Fé " });
            lstCiudad.Location = new Point(13, 25);
            lstCiudad.Margin = new Padding(2);
            lstCiudad.Name = "lstCiudad";
            lstCiudad.Size = new Size(218, 19);
            lstCiudad.TabIndex = 6;
            lstCiudad.SelectedIndexChanged += lstCiudades_SelectedIndexChanged;
            // 
            // grpDepto
            // 
            grpDepto.BackColor = Color.Transparent;
            grpDepto.Controls.Add(dmUpDownUnidad);
            grpDepto.Controls.Add(dmUpDownPiso);
            grpDepto.Controls.Add(lstTorre);
            grpDepto.Controls.Add(lstCiudad);
            grpDepto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grpDepto.ForeColor = Color.Black;
            grpDepto.Location = new Point(294, 56);
            grpDepto.Margin = new Padding(2);
            grpDepto.Name = "grpDepto";
            grpDepto.Padding = new Padding(2);
            grpDepto.Size = new Size(244, 110);
            grpDepto.TabIndex = 9;
            grpDepto.TabStop = false;
            grpDepto.Text = "Datos de la Vivienda";
            // 
            // dmUpDownUnidad
            // 
            dmUpDownUnidad.AllowDrop = true;
            dmUpDownUnidad.Items.Add("A");
            dmUpDownUnidad.Items.Add("B");
            dmUpDownUnidad.Items.Add("C");
            dmUpDownUnidad.Items.Add("D");
            dmUpDownUnidad.Location = new Point(145, 88);
            dmUpDownUnidad.Margin = new Padding(2);
            dmUpDownUnidad.Name = "dmUpDownUnidad";
            dmUpDownUnidad.Size = new Size(85, 23);
            dmUpDownUnidad.TabIndex = 10;
            dmUpDownUnidad.Text = "Unidad";
            // 
            // dmUpDownPiso
            // 
            dmUpDownPiso.AllowDrop = true;
            dmUpDownPiso.Items.Add("PB");
            dmUpDownPiso.Items.Add("1");
            dmUpDownPiso.Items.Add("2");
            dmUpDownPiso.Items.Add("3");
            dmUpDownPiso.Items.Add("4");
            dmUpDownPiso.Items.Add("5");
            dmUpDownPiso.Items.Add("6");
            dmUpDownPiso.Items.Add("7");
            dmUpDownPiso.Items.Add("8");
            dmUpDownPiso.Items.Add("9");
            dmUpDownPiso.Items.Add("10");
            dmUpDownPiso.Location = new Point(13, 88);
            dmUpDownPiso.Margin = new Padding(2);
            dmUpDownPiso.Name = "dmUpDownPiso";
            dmUpDownPiso.Size = new Size(85, 23);
            dmUpDownPiso.TabIndex = 9;
            dmUpDownPiso.Text = "N° Piso";
            // 
            // lstTorre
            // 
            lstTorre.FormattingEnabled = true;
            lstTorre.ItemHeight = 15;
            lstTorre.Location = new Point(13, 55);
            lstTorre.Margin = new Padding(2);
            lstTorre.Name = "lstTorre";
            lstTorre.Size = new Size(218, 19);
            lstTorre.TabIndex = 7;
            // 
            // btnRegistro
            // 
            btnRegistro.BackgroundImage = (Image)resources.GetObject("btnRegistro.BackgroundImage");
            btnRegistro.Location = new Point(294, 196);
            btnRegistro.Margin = new Padding(2);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(244, 44);
            btnRegistro.TabIndex = 10;
            btnRegistro.Text = "REGISTRARME";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.Location = new Point(422, 252);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 36);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBorrarInfo
            // 
            btnBorrarInfo.BackgroundImage = (Image)resources.GetObject("btnBorrarInfo.BackgroundImage");
            btnBorrarInfo.Location = new Point(294, 252);
            btnBorrarInfo.Margin = new Padding(2);
            btnBorrarInfo.Name = "btnBorrarInfo";
            btnBorrarInfo.Size = new Size(116, 36);
            btnBorrarInfo.TabIndex = 12;
            btnBorrarInfo.Text = "BORRAR TODO";
            btnBorrarInfo.UseVisualStyleBackColor = true;
            btnBorrarInfo.Click += btnBorrarInfo_Click_1;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = Color.Transparent;
            lblInicio.Location = new Point(452, 308);
            lblInicio.Margin = new Padding(2, 0, 2, 0);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(80, 15);
            lblInicio.TabIndex = 13;
            lblInicio.TabStop = true;
            lblInicio.Text = "Volver a Inicio";
            lblInicio.LinkClicked += lblInicio_LinkClicked;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 61);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(14, 92);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(218, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(14, 153);
            txtDocumento.Margin = new Padding(2);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "D.N.I";
            txtDocumento.Size = new Size(218, 23);
            txtDocumento.TabIndex = 3;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // txtClaveReg
            // 
            txtClaveReg.Location = new Point(14, 185);
            txtClaveReg.Margin = new Padding(2);
            txtClaveReg.Name = "txtClaveReg";
            txtClaveReg.PlaceholderText = "Clave";
            txtClaveReg.Size = new Size(218, 23);
            txtClaveReg.TabIndex = 10;
            txtClaveReg.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 124);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo Electrónico";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtConfirmeClave
            // 
            txtConfirmeClave.Location = new Point(14, 213);
            txtConfirmeClave.Margin = new Padding(2);
            txtConfirmeClave.Name = "txtConfirmeClave";
            txtConfirmeClave.PasswordChar = '*';
            txtConfirmeClave.PlaceholderText = "Confirme su clave";
            txtConfirmeClave.Size = new Size(218, 23);
            txtConfirmeClave.TabIndex = 11;
            txtConfirmeClave.UseSystemPasswordChar = true;
            // 
            // radInquilino
            // 
            radInquilino.AutoSize = true;
            radInquilino.Location = new Point(4, 14);
            radInquilino.Margin = new Padding(2);
            radInquilino.Name = "radInquilino";
            radInquilino.Size = new Size(94, 19);
            radInquilino.TabIndex = 12;
            radInquilino.TabStop = true;
            radInquilino.Text = "Soy Inquilino";
            radInquilino.UseVisualStyleBackColor = true;
            // 
            // radDuenio
            // 
            radDuenio.AutoSize = true;
            radDuenio.Location = new Point(116, 14);
            radDuenio.Margin = new Padding(2);
            radDuenio.Name = "radDuenio";
            radDuenio.Size = new Size(82, 19);
            radDuenio.TabIndex = 13;
            radDuenio.TabStop = true;
            radDuenio.Text = "Soy Dueño";
            radDuenio.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(14, 237);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(32, 15);
            lblError.TabIndex = 14;
            lblError.Text = "Error";
            // 
            // grpDatos
            // 
            grpDatos.BackColor = Color.Transparent;
            grpDatos.Controls.Add(grpSituacion);
            grpDatos.Controls.Add(lblError);
            grpDatos.Controls.Add(txtConfirmeClave);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(txtClaveReg);
            grpDatos.Controls.Add(txtDocumento);
            grpDatos.Controls.Add(txtApellido);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.ForeColor = Color.Black;
            grpDatos.Location = new Point(29, 56);
            grpDatos.Margin = new Padding(2);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(2);
            grpDatos.Size = new Size(239, 278);
            grpDatos.TabIndex = 5;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos Personales";
            // 
            // grpSituacion
            // 
            grpSituacion.Controls.Add(radInquilino);
            grpSituacion.Controls.Add(radDuenio);
            grpSituacion.Cursor = Cursors.Hand;
            grpSituacion.FlatStyle = FlatStyle.Popup;
            grpSituacion.Location = new Point(14, 18);
            grpSituacion.Margin = new Padding(2);
            grpSituacion.Name = "grpSituacion";
            grpSituacion.Padding = new Padding(2);
            grpSituacion.Size = new Size(216, 35);
            grpSituacion.TabIndex = 14;
            grpSituacion.TabStop = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(556, 341);
            Controls.Add(lblInicio);
            Controls.Add(btnBorrarInfo);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistro);
            Controls.Add(grpDepto);
            Controls.Add(grpDatos);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            grpDepto.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpSituacion.ResumeLayout(false);
            grpSituacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ListBox lstCiudad;
        private GroupBox grpDepto;
        private Button btnRegistro;
        private Button btnSalir;
        private Button btnBorrarInfo;
        private LinkLabel lblInicio;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private TextBox txtClaveReg;
        private TextBox txtEmail;
        private TextBox txtConfirmeClave;
        private RadioButton radInquilino;
        private RadioButton radDuenio;
        private Label lblError;
        private GroupBox grpDatos;
        private GroupBox grpSituacion;
        private ListBox lstTorre;
        private DomainUpDown dmUpDownUnidad;
        private DomainUpDown dmUpDownPiso;
    }
}