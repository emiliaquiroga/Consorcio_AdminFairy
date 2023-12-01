namespace Administracion_Consorcio_AdminFairy
{
    partial class ComunicadosVecinos
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
            lblComunicados = new Label();
            rtbComunicado = new RichTextBox();
            SuspendLayout();
            // 
            // lblComunicados
            // 
            lblComunicados.AutoSize = true;
            lblComunicados.BackColor = Color.Transparent;
            lblComunicados.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblComunicados.Location = new Point(88, 57);
            lblComunicados.Margin = new Padding(2, 0, 2, 0);
            lblComunicados.Name = "lblComunicados";
            lblComunicados.Size = new Size(305, 28);
            lblComunicados.TabIndex = 8;
            lblComunicados.Text = "Muro de comunicados : ";
            // 
            // rtbComunicado
            // 
            rtbComunicado.BackColor = Color.FromArgb(233, 222, 245);
            rtbComunicado.BorderStyle = BorderStyle.FixedSingle;
            rtbComunicado.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rtbComunicado.Location = new Point(88, 113);
            rtbComunicado.Margin = new Padding(2);
            rtbComunicado.Name = "rtbComunicado";
            rtbComunicado.ReadOnly = true;
            rtbComunicado.Size = new Size(926, 426);
            rtbComunicado.TabIndex = 9;
            rtbComunicado.Text = "";
            rtbComunicado.TextChanged += rchtxtComunicado_TextChanged;
            // 
            // ComunicadosVecinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 624);
            Controls.Add(rtbComunicado);
            Controls.Add(lblComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ComunicadosVecinos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComunicadosVecinos";
            Load += ComunicadosVecinos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblComunicados;
        private RichTextBox rtbComunicado;
    }
}