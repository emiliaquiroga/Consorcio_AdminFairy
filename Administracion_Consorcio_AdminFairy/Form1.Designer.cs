namespace Administracion_Consorcio_AdminFairy
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
            txtDni = new TextBox();
            txtClave = new TextBox();
            lblMarca = new Label();
            chkMostrarClave = new CheckBox();
            button1 = new Button();
            btnIniciarSesion = new Button();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Location = new Point(328, 195);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese su D.N.I";
            txtDni.Size = new Size(296, 30);
            txtDni.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Location = new Point(328, 257);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Ingrese su Clave";
            txtClave.Size = new Size(296, 30);
            txtClave.TabIndex = 1;
            txtClave.UseSystemPasswordChar = true;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(285, 89);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(391, 60);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "AdminFairy \r\nComplete sus datos para Iniciar";
            lblMarca.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chkMostrarClave
            // 
            chkMostrarClave.AutoSize = true;
            chkMostrarClave.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkMostrarClave.Location = new Point(651, 262);
            chkMostrarClave.Name = "chkMostrarClave";
            chkMostrarClave.Size = new Size(156, 25);
            chkMostrarClave.TabIndex = 3;
            chkMostrarClave.Text = "Mostrar clave";
            chkMostrarClave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(392, 418);
            button1.Name = "button1";
            button1.Size = new Size(171, 45);
            button1.TabIndex = 4;
            button1.Text = "Autocompletar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(328, 327);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(296, 59);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 140, 171);
            ClientSize = new Size(985, 536);
            Controls.Add(btnIniciarSesion);
            Controls.Add(button1);
            Controls.Add(chkMostrarClave);
            Controls.Add(lblMarca);
            Controls.Add(txtClave);
            Controls.Add(txtDni);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmLogin";
            Text = "AdminFairy - Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private TextBox txtClave;
        private Label lblMarca;
        private CheckBox chkMostrarClave;
        private Button button1;
        private Button btnIniciarSesion;
    }
}