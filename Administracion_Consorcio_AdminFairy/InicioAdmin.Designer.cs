namespace Administracion_Consorcio_AdminFairy
{
    partial class InicioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdmin));
            pnlMenu = new Panel();
            btnCerrarSesion = new Button();
            pnlSubMenu = new Panel();
            btnConvivencia = new Button();
            btnNrosUtiles = new Button();
            btnReclamo = new Button();
            btnComunicados = new Button();
            btnVerVecinos = new Button();
            btnMenu = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            pnlSubMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(255, 200, 221);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(pnlSubMenu);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.ForeColor = Color.FromArgb(64, 0, 64);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 711);
            pnlMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 175, 204);
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(255, 175, 204);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.FromArgb(64, 0, 64);
            btnCerrarSesion.Location = new Point(0, 666);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(220, 45);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "➲ Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pnlSubMenu
            // 
            pnlSubMenu.BackColor = Color.FromArgb(255, 175, 204);
            pnlSubMenu.Controls.Add(btnConvivencia);
            pnlSubMenu.Controls.Add(btnNrosUtiles);
            pnlSubMenu.Controls.Add(btnReclamo);
            pnlSubMenu.Controls.Add(btnComunicados);
            pnlSubMenu.Controls.Add(btnVerVecinos);
            pnlSubMenu.Dock = DockStyle.Top;
            pnlSubMenu.Location = new Point(0, 265);
            pnlSubMenu.Margin = new Padding(2);
            pnlSubMenu.Name = "pnlSubMenu";
            pnlSubMenu.Size = new Size(220, 227);
            pnlSubMenu.TabIndex = 2;
            // 
            // btnConvivencia
            // 
            btnConvivencia.Dock = DockStyle.Top;
            btnConvivencia.FlatAppearance.BorderSize = 0;
            btnConvivencia.FlatStyle = FlatStyle.Flat;
            btnConvivencia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvivencia.ForeColor = Color.FromArgb(64, 0, 64);
            btnConvivencia.Location = new Point(0, 180);
            btnConvivencia.Margin = new Padding(2);
            btnConvivencia.Name = "btnConvivencia";
            btnConvivencia.Padding = new Padding(10, 0, 0, 0);
            btnConvivencia.Size = new Size(220, 45);
            btnConvivencia.TabIndex = 9;
            btnConvivencia.Text = "☑ Convivencia";
            btnConvivencia.TextAlign = ContentAlignment.MiddleLeft;
            btnConvivencia.UseVisualStyleBackColor = true;
            // 
            // btnNrosUtiles
            // 
            btnNrosUtiles.Dock = DockStyle.Top;
            btnNrosUtiles.FlatAppearance.BorderSize = 0;
            btnNrosUtiles.FlatStyle = FlatStyle.Flat;
            btnNrosUtiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNrosUtiles.ForeColor = Color.FromArgb(64, 0, 64);
            btnNrosUtiles.Location = new Point(0, 135);
            btnNrosUtiles.Margin = new Padding(2);
            btnNrosUtiles.Name = "btnNrosUtiles";
            btnNrosUtiles.Padding = new Padding(10, 0, 0, 0);
            btnNrosUtiles.Size = new Size(220, 45);
            btnNrosUtiles.TabIndex = 6;
            btnNrosUtiles.Text = "☎ Números Útiles";
            btnNrosUtiles.TextAlign = ContentAlignment.MiddleLeft;
            btnNrosUtiles.UseVisualStyleBackColor = true;
            btnNrosUtiles.Click += btnNrosUtiles_Click;
            // 
            // btnReclamo
            // 
            btnReclamo.AutoSize = true;
            btnReclamo.Dock = DockStyle.Top;
            btnReclamo.FlatAppearance.BorderSize = 0;
            btnReclamo.FlatStyle = FlatStyle.Flat;
            btnReclamo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReclamo.ForeColor = Color.FromArgb(64, 0, 64);
            btnReclamo.Location = new Point(0, 90);
            btnReclamo.Margin = new Padding(2);
            btnReclamo.Name = "btnReclamo";
            btnReclamo.Padding = new Padding(10, 0, 0, 0);
            btnReclamo.Size = new Size(220, 45);
            btnReclamo.TabIndex = 8;
            btnReclamo.Text = "✉ Ver Reclamo";
            btnReclamo.TextAlign = ContentAlignment.MiddleLeft;
            btnReclamo.UseVisualStyleBackColor = true;
            // 
            // btnComunicados
            // 
            btnComunicados.AutoSize = true;
            btnComunicados.Dock = DockStyle.Top;
            btnComunicados.FlatAppearance.BorderSize = 0;
            btnComunicados.FlatStyle = FlatStyle.Flat;
            btnComunicados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComunicados.ForeColor = Color.FromArgb(64, 0, 64);
            btnComunicados.Location = new Point(0, 45);
            btnComunicados.Margin = new Padding(2);
            btnComunicados.Name = "btnComunicados";
            btnComunicados.Padding = new Padding(10, 0, 0, 0);
            btnComunicados.Size = new Size(220, 45);
            btnComunicados.TabIndex = 4;
            btnComunicados.Text = "✎ Redactar Comunicados";
            btnComunicados.TextAlign = ContentAlignment.MiddleLeft;
            btnComunicados.UseVisualStyleBackColor = true;
            btnComunicados.Click += btnComunicados_Click;
            // 
            // btnVerVecinos
            // 
            btnVerVecinos.AutoSize = true;
            btnVerVecinos.Dock = DockStyle.Top;
            btnVerVecinos.FlatAppearance.BorderSize = 0;
            btnVerVecinos.FlatStyle = FlatStyle.Flat;
            btnVerVecinos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerVecinos.ForeColor = Color.FromArgb(64, 0, 64);
            btnVerVecinos.Location = new Point(0, 0);
            btnVerVecinos.Margin = new Padding(2);
            btnVerVecinos.Name = "btnVerVecinos";
            btnVerVecinos.Padding = new Padding(10, 0, 0, 0);
            btnVerVecinos.RightToLeft = RightToLeft.No;
            btnVerVecinos.Size = new Size(220, 45);
            btnVerVecinos.TabIndex = 3;
            btnVerVecinos.Text = "☛ Listado Vecinos";
            btnVerVecinos.TextAlign = ContentAlignment.MiddleLeft;
            btnVerVecinos.UseVisualStyleBackColor = true;
            btnVerVecinos.Click += btnVerVecinos_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.Purple;
            btnMenu.Location = new Point(0, 215);
            btnMenu.Margin = new Padding(2);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10, 0, 0, 0);
            btnMenu.Size = new Size(220, 50);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "✦ Menú";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Controls.Add(label1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(2);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 215);
            pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // InicioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1334, 711);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "InicioAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioAdmin";
            Load += InicioAdmin_Load;
            pnlMenu.ResumeLayout(false);
            pnlSubMenu.ResumeLayout(false);
            pnlSubMenu.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Panel pnlMenu;
        private Panel pnlSubMenu;
        private Button btnNrosUtiles;
        private Button btnReclamo;
        private Button btnComunicados;
        private Button btnVerVecinos;
        private Button btnMenu;
        private Panel pnlLogo;
        private Label label1;
        private Button btnConvivencia;
        private PictureBox pictureBox1;
        private Button btnCerrarSesion;
    }
}