namespace Administracion_Consorcio_AdminFairy
{
    partial class InicioVecino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioVecino));
            pnlMenu = new Panel();
            lblTiempo = new Label();
            btnCerrarSesion = new Button();
            pnlSubMenu = new Panel();
            btnAcuerdoVecinos = new Button();
            btnNrosUtiles = new Button();
            btnReclamo = new Button();
            btnComunicados = new Button();
            btnExpensas = new Button();
            btnMenu = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnlMenu.SuspendLayout();
            pnlSubMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(255, 217, 232);
            pnlMenu.Controls.Add(lblTiempo);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(pnlSubMenu);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.ForeColor = SystemColors.ActiveCaptionText;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 711);
            pnlMenu.TabIndex = 0;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTiempo.ForeColor = Color.DarkViolet;
            lblTiempo.Location = new Point(29, 512);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(103, 28);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "Tiempo";
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
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "➲ Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pnlSubMenu
            // 
            pnlSubMenu.BackColor = Color.FromArgb(255, 175, 204);
            pnlSubMenu.Controls.Add(btnAcuerdoVecinos);
            pnlSubMenu.Controls.Add(btnNrosUtiles);
            pnlSubMenu.Controls.Add(btnReclamo);
            pnlSubMenu.Controls.Add(btnComunicados);
            pnlSubMenu.Controls.Add(btnExpensas);
            pnlSubMenu.Dock = DockStyle.Top;
            pnlSubMenu.Location = new Point(0, 265);
            pnlSubMenu.Name = "pnlSubMenu";
            pnlSubMenu.Size = new Size(220, 225);
            pnlSubMenu.TabIndex = 2;
            // 
            // btnAcuerdoVecinos
            // 
            btnAcuerdoVecinos.Dock = DockStyle.Top;
            btnAcuerdoVecinos.FlatAppearance.BorderSize = 0;
            btnAcuerdoVecinos.FlatStyle = FlatStyle.Flat;
            btnAcuerdoVecinos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcuerdoVecinos.ForeColor = Color.FromArgb(64, 0, 64);
            btnAcuerdoVecinos.Location = new Point(0, 135);
            btnAcuerdoVecinos.Name = "btnAcuerdoVecinos";
            btnAcuerdoVecinos.Padding = new Padding(10, 0, 0, 0);
            btnAcuerdoVecinos.Size = new Size(220, 46);
            btnAcuerdoVecinos.TabIndex = 7;
            btnAcuerdoVecinos.Text = "☑ Convivencia";
            btnAcuerdoVecinos.TextAlign = ContentAlignment.MiddleLeft;
            btnAcuerdoVecinos.UseVisualStyleBackColor = true;
            btnAcuerdoVecinos.Click += btnAcuerdoVecinos_Click;
            // 
            // btnNrosUtiles
            // 
            btnNrosUtiles.Dock = DockStyle.Top;
            btnNrosUtiles.FlatAppearance.BorderSize = 0;
            btnNrosUtiles.FlatStyle = FlatStyle.Flat;
            btnNrosUtiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNrosUtiles.ForeColor = Color.FromArgb(64, 0, 64);
            btnNrosUtiles.Location = new Point(0, 90);
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
            btnReclamo.Dock = DockStyle.Bottom;
            btnReclamo.FlatAppearance.BorderSize = 0;
            btnReclamo.FlatStyle = FlatStyle.Flat;
            btnReclamo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReclamo.ForeColor = Color.FromArgb(64, 0, 64);
            btnReclamo.Location = new Point(0, 180);
            btnReclamo.Name = "btnReclamo";
            btnReclamo.Padding = new Padding(10, 0, 0, 0);
            btnReclamo.Size = new Size(220, 45);
            btnReclamo.TabIndex = 5;
            btnReclamo.Text = "✎ Iniciar Reclamo";
            btnReclamo.TextAlign = ContentAlignment.MiddleLeft;
            btnReclamo.UseVisualStyleBackColor = true;
            btnReclamo.Click += btnReclamo_Click;
            // 
            // btnComunicados
            // 
            btnComunicados.Dock = DockStyle.Top;
            btnComunicados.FlatAppearance.BorderSize = 0;
            btnComunicados.FlatStyle = FlatStyle.Flat;
            btnComunicados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComunicados.ForeColor = Color.FromArgb(64, 0, 64);
            btnComunicados.Location = new Point(0, 45);
            btnComunicados.Name = "btnComunicados";
            btnComunicados.Padding = new Padding(10, 0, 0, 0);
            btnComunicados.Size = new Size(220, 45);
            btnComunicados.TabIndex = 4;
            btnComunicados.Text = "✉ Ver comunicados";
            btnComunicados.TextAlign = ContentAlignment.MiddleLeft;
            btnComunicados.UseVisualStyleBackColor = true;
            btnComunicados.Click += btnComunicados_Click;
            // 
            // btnExpensas
            // 
            btnExpensas.Dock = DockStyle.Top;
            btnExpensas.FlatAppearance.BorderSize = 0;
            btnExpensas.FlatStyle = FlatStyle.Flat;
            btnExpensas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExpensas.ForeColor = Color.FromArgb(64, 0, 64);
            btnExpensas.Location = new Point(0, 0);
            btnExpensas.Name = "btnExpensas";
            btnExpensas.Padding = new Padding(10, 0, 0, 0);
            btnExpensas.Size = new Size(220, 45);
            btnExpensas.TabIndex = 3;
            btnExpensas.Text = "$$ Ver expensas";
            btnExpensas.TextAlign = ContentAlignment.MiddleLeft;
            btnExpensas.UseVisualStyleBackColor = true;
            btnExpensas.Click += btnExpensas_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(255, 217, 232);
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.Purple;
            btnMenu.Location = new Point(0, 215);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10, 0, 0, 0);
            btnMenu.Size = new Size(220, 50);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "✦ Menú";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(255, 217, 232);
            pnlLogo.BackgroundImage = (Image)resources.GetObject("pnlLogo.BackgroundImage");
            pnlLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 215);
            pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 217, 232);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.GIF_ICON;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // InicioVecino
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1334, 711);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "InicioVecino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFairy - Inicio ";
            Load += InicioVecino_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlSubMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnMenu;
        private Panel pnlSubMenu;
        private Button btnNrosUtiles;
        private Button btnReclamo;
        private Button btnComunicados;
        private Button btnExpensas;
        private Button btnAcuerdoVecinos;
        private Button btnCerrarSesion;
        private Label lblTiempo;
        private Panel pnlLogo;
        private PictureBox pictureBox1;
        //private Panel pnlPrincipal;
    }
}