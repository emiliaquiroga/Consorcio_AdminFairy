namespace Administracion_Consorcio_AdminFairy
{
    partial class FrmReclamosVecino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReclamosVecino));
            rchtxtReclamo = new RichTextBox();
            lblRedactarReclamo = new Label();
            btnPublicarReclamo = new Button();
            SuspendLayout();
            // 
            // rchtxtReclamo
            // 
            rchtxtReclamo.BackColor = Color.FromArgb(233, 222, 245);
            rchtxtReclamo.BorderStyle = BorderStyle.FixedSingle;
            rchtxtReclamo.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            rchtxtReclamo.Location = new Point(97, 122);
            rchtxtReclamo.Margin = new Padding(2);
            rchtxtReclamo.Name = "rchtxtReclamo";
            rchtxtReclamo.Size = new Size(926, 426);
            rchtxtReclamo.TabIndex = 10;
            rchtxtReclamo.Tag = "Escriba un reclamo por vez...";
            rchtxtReclamo.Text = "";
            // 
            // lblRedactarReclamo
            // 
            lblRedactarReclamo.AutoSize = true;
            lblRedactarReclamo.BackColor = Color.Transparent;
            lblRedactarReclamo.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblRedactarReclamo.Location = new Point(97, 74);
            lblRedactarReclamo.Name = "lblRedactarReclamo";
            lblRedactarReclamo.Size = new Size(237, 28);
            lblRedactarReclamo.TabIndex = 11;
            lblRedactarReclamo.Text = "Redactar reclamo:";
            // 
            // btnPublicarReclamo
            // 
            btnPublicarReclamo.BackColor = Color.FromArgb(192, 192, 255);
            btnPublicarReclamo.FlatStyle = FlatStyle.Popup;
            btnPublicarReclamo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPublicarReclamo.Location = new Point(859, 591);
            btnPublicarReclamo.Name = "btnPublicarReclamo";
            btnPublicarReclamo.Size = new Size(164, 39);
            btnPublicarReclamo.TabIndex = 12;
            btnPublicarReclamo.Text = "Publicar ";
            btnPublicarReclamo.UseVisualStyleBackColor = false;
            // 
            // FrmReclamosVecino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 700);
            Controls.Add(btnPublicarReclamo);
            Controls.Add(lblRedactarReclamo);
            Controls.Add(rchtxtReclamo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReclamosVecino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReclamosVecino";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rchtxtReclamo;
        private Label lblRedactarReclamo;
        private Button btnPublicarReclamo;
    }
}