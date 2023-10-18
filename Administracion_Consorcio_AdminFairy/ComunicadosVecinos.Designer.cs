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
            rchtxtComunicado = new RichTextBox();
            SuspendLayout();
            // 
            // lblComunicados
            // 
            lblComunicados.AutoSize = true;
            lblComunicados.BackColor = Color.Transparent;
            lblComunicados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblComunicados.Location = new Point(365, 47);
            lblComunicados.Name = "lblComunicados";
            lblComunicados.Size = new Size(212, 30);
            lblComunicados.TabIndex = 8;
            lblComunicados.Text = "COMUNICADOS:";
            // 
            // rchtxtComunicado
            // 
            rchtxtComunicado.BorderStyle = BorderStyle.FixedSingle;
            rchtxtComunicado.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rchtxtComunicado.Location = new Point(165, 107);
            rchtxtComunicado.Name = "rchtxtComunicado";
            rchtxtComunicado.ReadOnly = true;
            rchtxtComunicado.Size = new Size(582, 377);
            rchtxtComunicado.TabIndex = 9;
            rchtxtComunicado.Text = "";
            rchtxtComunicado.TextChanged += rchtxtComunicado_TextChanged;
            // 
            // ComunicadosVecinos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(966, 539);
            Controls.Add(rchtxtComunicado);
            Controls.Add(lblComunicados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComunicadosVecinos";
            Text = "ComunicadosVecinos";
            Load += ComunicadosVecinos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblComunicados;
        private RichTextBox rchtxtComunicado;
    }
}