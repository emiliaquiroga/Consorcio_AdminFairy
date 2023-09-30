namespace Administracion_Consorcio_AdminFairy
{
    partial class SeleccionarUsuario
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
            lblPreguntarUsuario = new Label();
            rdoAdmin = new RadioButton();
            rdoVecino = new RadioButton();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblPreguntarUsuario
            // 
            lblPreguntarUsuario.AutoSize = true;
            lblPreguntarUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblPreguntarUsuario.Location = new Point(79, 19);
            lblPreguntarUsuario.Name = "lblPreguntarUsuario";
            lblPreguntarUsuario.Size = new Size(97, 38);
            lblPreguntarUsuario.TabIndex = 0;
            lblPreguntarUsuario.Text = "¡Hola!  \r\n¿quién sos?";
            lblPreguntarUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // rdoAdmin
            // 
            rdoAdmin.AutoSize = true;
            rdoAdmin.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdoAdmin.Location = new Point(38, 90);
            rdoAdmin.Name = "rdoAdmin";
            rdoAdmin.Size = new Size(176, 24);
            rdoAdmin.TabIndex = 1;
            rdoAdmin.TabStop = true;
            rdoAdmin.Text = "¡Soy el Administador!";
            rdoAdmin.UseVisualStyleBackColor = true;
            rdoAdmin.CheckedChanged += rdoAdmin_CheckedChanged;
            // 
            // rdoVecino
            // 
            rdoVecino.AutoSize = true;
            rdoVecino.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdoVecino.Location = new Point(38, 131);
            rdoVecino.Name = "rdoVecino";
            rdoVecino.Size = new Size(138, 24);
            rdoVecino.TabIndex = 2;
            rdoVecino.TabStop = true;
            rdoVecino.Text = "¡Soy un vecino!";
            rdoVecino.UseVisualStyleBackColor = true;
            rdoVecino.CheckedChanged += rdoVecino_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(172, 179);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 24);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += button1_Click;
            // 
            // SeleccionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(138, 159, 187);
            ClientSize = new Size(271, 215);
            Controls.Add(btnCancelar);
            Controls.Add(rdoVecino);
            Controls.Add(rdoAdmin);
            Controls.Add(lblPreguntarUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeleccionarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPreguntarUsuario;
        private RadioButton rdoAdmin;
        private RadioButton rdoVecino;
        private Button btnCancelar;
    }
}