namespace Administracion_Consorcio_AdminFairy
{
    partial class FrmComunicados
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
            lblAdmin = new Label();
            btnPublicarComunicado = new Button();
            rtbComunicadoAdmin = new RichTextBox();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.FromArgb(192, 192, 255);
            lblAdmin.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblAdmin.Location = new Point(437, 82);
            lblAdmin.Margin = new Padding(2, 0, 2, 0);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(245, 28);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = "Emitir Comunicado";
            // 
            // btnPublicarComunicado
            // 
            btnPublicarComunicado.BackColor = Color.FromArgb(192, 192, 255);
            btnPublicarComunicado.FlatAppearance.BorderColor = Color.FromArgb(255, 175, 204);
            btnPublicarComunicado.FlatAppearance.BorderSize = 5;
            btnPublicarComunicado.FlatStyle = FlatStyle.Popup;
            btnPublicarComunicado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPublicarComunicado.Location = new Point(832, 602);
            btnPublicarComunicado.Margin = new Padding(2);
            btnPublicarComunicado.Name = "btnPublicarComunicado";
            btnPublicarComunicado.Size = new Size(186, 53);
            btnPublicarComunicado.TabIndex = 4;
            btnPublicarComunicado.Text = "Publicar";
            btnPublicarComunicado.UseVisualStyleBackColor = false;
            btnPublicarComunicado.Click += btnPublicarComunicado_Click;
            // 
            // rtbComunicadoAdmin
            // 
            rtbComunicadoAdmin.BackColor = Color.FromArgb(233, 222, 245);
            rtbComunicadoAdmin.BorderStyle = BorderStyle.FixedSingle;
            rtbComunicadoAdmin.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rtbComunicadoAdmin.Location = new Point(63, 134);
            rtbComunicadoAdmin.Margin = new Padding(2);
            rtbComunicadoAdmin.Name = "rtbComunicadoAdmin";
            rtbComunicadoAdmin.ReadOnly = true;
            rtbComunicadoAdmin.Size = new Size(955, 426);
            rtbComunicadoAdmin.TabIndex = 10;
            rtbComunicadoAdmin.Text = "";
            // 
            // FrmComunicados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 700);
            Controls.Add(rtbComunicadoAdmin);
            Controls.Add(btnPublicarComunicado);
            Controls.Add(lblAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmComunicados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comunicados";
            Load += FrmComunicados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAdmin;
        private Button btnPublicarComunicado;
        private RichTextBox rtbComunicadoAdmin;
    }
}