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
            lblTitulo = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            txtDireccion = new TextBox();
            grpDatos = new GroupBox();
            lblFechaNac = new Label();
            dtpFechaNac = new DateTimePicker();
            radDuenio = new RadioButton();
            radInquilino = new RadioButton();
            txtConfirmeClave = new TextBox();
            txtEmail = new TextBox();
            txtClaveReg = new TextBox();
            lstCiudad = new ListBox();
            txtPiso = new TextBox();
            txtDepto = new TextBox();
            grpDepto = new GroupBox();
            btnRegistro = new Button();
            btnSalir = new Button();
            btnBorrarInfo = new Button();
            lblInicio = new LinkLabel();
            grpDatos.SuspendLayout();
            grpDepto.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(172, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(424, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Completá los siguientes datos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(309, 31);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(20, 137);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(309, 31);
            txtApellido.TabIndex = 2;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(20, 229);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "D.N.I";
            txtDocumento.Size = new Size(309, 31);
            txtDocumento.TabIndex = 3;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(19, 87);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese calle y numeración";
            txtDireccion.Size = new Size(309, 31);
            txtDireccion.TabIndex = 4;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblFechaNac);
            grpDatos.Controls.Add(dtpFechaNac);
            grpDatos.Controls.Add(radDuenio);
            grpDatos.Controls.Add(radInquilino);
            grpDatos.Controls.Add(txtConfirmeClave);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(txtClaveReg);
            grpDatos.Controls.Add(txtDocumento);
            grpDatos.Controls.Add(txtApellido);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Location = new Point(43, 94);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(342, 445);
            grpDatos.TabIndex = 5;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos Personales";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(20, 361);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(177, 25);
            lblFechaNac.TabIndex = 15;
            lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(20, 389);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(309, 31);
            dtpFechaNac.TabIndex = 14;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            // 
            // radDuenio
            // 
            radDuenio.AutoSize = true;
            radDuenio.Location = new Point(204, 43);
            radDuenio.Name = "radDuenio";
            radDuenio.Size = new Size(125, 29);
            radDuenio.TabIndex = 13;
            radDuenio.TabStop = true;
            radDuenio.Text = "Soy Dueño";
            radDuenio.UseVisualStyleBackColor = true;
            // 
            // radInquilino
            // 
            radInquilino.AutoSize = true;
            radInquilino.Location = new Point(20, 43);
            radInquilino.Name = "radInquilino";
            radInquilino.Size = new Size(141, 29);
            radInquilino.TabIndex = 12;
            radInquilino.TabStop = true;
            radInquilino.Text = "Soy Inquilino";
            radInquilino.UseVisualStyleBackColor = true;
            // 
            // txtConfirmeClave
            // 
            txtConfirmeClave.Location = new Point(20, 326);
            txtConfirmeClave.Name = "txtConfirmeClave";
            txtConfirmeClave.PlaceholderText = "Confirme su clave";
            txtConfirmeClave.Size = new Size(309, 31);
            txtConfirmeClave.TabIndex = 11;
            txtConfirmeClave.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo Electrónico";
            txtEmail.Size = new Size(309, 31);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtClaveReg
            // 
            txtClaveReg.Location = new Point(20, 276);
            txtClaveReg.Name = "txtClaveReg";
            txtClaveReg.PlaceholderText = "Clave";
            txtClaveReg.Size = new Size(309, 31);
            txtClaveReg.TabIndex = 10;
            txtClaveReg.TextChanged += txtClaveReg_TextChanged;
            // 
            // lstCiudad
            // 
            lstCiudad.FormattingEnabled = true;
            lstCiudad.ItemHeight = 25;
            lstCiudad.Items.AddRange(new object[] { "Ciudad Autónoma de Buenos Aires", "La Plata", "Córdoba", "Santa Fé ", "Rosario", "Posadas", "Paraná", "Formosa", "Mendoza", "Santiago del Estero", "San Luis", "Salta", "San Fernando del Valle de Catamarca", "San Salvador de Jujuy", "San Miguel de Tucumán" });
            lstCiudad.Location = new Point(19, 43);
            lstCiudad.Name = "lstCiudad";
            lstCiudad.Size = new Size(309, 29);
            lstCiudad.TabIndex = 6;
            lstCiudad.SelectedIndexChanged += lstCiudad_SelectedIndexChanged;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(19, 137);
            txtPiso.Name = "txtPiso";
            txtPiso.PlaceholderText = "N° Piso";
            txtPiso.Size = new Size(125, 31);
            txtPiso.TabIndex = 7;
            txtPiso.TextChanged += txtPiso_TextChanged;
            // 
            // txtDepto
            // 
            txtDepto.Location = new Point(203, 137);
            txtDepto.Name = "txtDepto";
            txtDepto.PlaceholderText = "Departamento";
            txtDepto.Size = new Size(125, 31);
            txtDepto.TabIndex = 8;
            txtDepto.TextChanged += txtDepto_TextChanged;
            // 
            // grpDepto
            // 
            grpDepto.Controls.Add(txtDepto);
            grpDepto.Controls.Add(txtPiso);
            grpDepto.Controls.Add(lstCiudad);
            grpDepto.Controls.Add(txtDireccion);
            grpDepto.Location = new Point(420, 94);
            grpDepto.Name = "grpDepto";
            grpDepto.Size = new Size(348, 184);
            grpDepto.TabIndex = 9;
            grpDepto.TabStop = false;
            grpDepto.Text = "Datos de la Vivienda";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(420, 327);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(348, 74);
            btnRegistro.TabIndex = 10;
            btnRegistro.Text = "REGISTRARME";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(603, 420);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 60);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBorrarInfo
            // 
            btnBorrarInfo.Location = new Point(420, 420);
            btnBorrarInfo.Name = "btnBorrarInfo";
            btnBorrarInfo.Size = new Size(165, 60);
            btnBorrarInfo.TabIndex = 12;
            btnBorrarInfo.Text = "BORRAR TODO";
            btnBorrarInfo.UseVisualStyleBackColor = true;
            btnBorrarInfo.Click += btnCancelar_Click;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(646, 514);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(122, 25);
            lblInicio.TabIndex = 13;
            lblInicio.TabStop = true;
            lblInicio.Text = "Volver a Inicio";
            lblInicio.LinkClicked += lblInicio_LinkClicked;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 569);
            Controls.Add(lblInicio);
            Controls.Add(btnBorrarInfo);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistro);
            Controls.Add(grpDepto);
            Controls.Add(grpDatos);
            Controls.Add(lblTitulo);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpDepto.ResumeLayout(false);
            grpDepto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private TextBox txtDireccion;
        private GroupBox grpDatos;
        private ListBox lstCiudad;
        private TextBox txtEmail;
        private TextBox txtPiso;
        private TextBox txtDepto;
        private GroupBox grpDepto;
        private TextBox txtClaveReg;
        private TextBox txtConfirmeClave;
        private RadioButton radDuenio;
        private RadioButton radInquilino;
        private Button btnRegistro;
        private Label lblFechaNac;
        private DateTimePicker dtpFechaNac;
        private Button btnSalir;
        private Button btnBorrarInfo;
        private LinkLabel lblInicio;
    }
}