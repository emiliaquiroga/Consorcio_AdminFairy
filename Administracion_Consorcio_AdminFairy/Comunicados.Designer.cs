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
            rchtxtAdmi = new RichTextBox();
            rchtxtComunicado = new RichTextBox();
            SuspendLayout();
            // 
            // rchtxtAdmi
            // 
            rchtxtAdmi.Location = new Point(12, 219);
            rchtxtAdmi.Name = "rchtxtAdmi";
            rchtxtAdmi.Size = new Size(352, 284);
            rchtxtAdmi.TabIndex = 0;
            rchtxtAdmi.Text = "";
            // 
            // rchtxtComunicado
            // 
            rchtxtComunicado.Location = new Point(434, 55);
            rchtxtComunicado.Name = "rchtxtComunicado";
            rchtxtComunicado.Size = new Size(479, 425);
            rchtxtComunicado.TabIndex = 1;
            rchtxtComunicado.Text = "";
            // 
            // FrmComunicados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 515);
            Controls.Add(rchtxtComunicado);
            Controls.Add(rchtxtAdmi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComunicados";
            Text = "Comunicados";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rchtxtAdmi;
        private RichTextBox rchtxtComunicado;
    }
}