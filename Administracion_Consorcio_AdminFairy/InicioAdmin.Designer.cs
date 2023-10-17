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
            pnlSubMenu = new Panel();
            btnAcuerdoVecinos = new Button();
            btnNrosUtiles = new Button();
            btnReclamo = new Button();
            btnComunicados = new Button();
            btnVerVecinos = new Button();
            btnMenu = new Button();
            pnlLogo = new Panel();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            pnlSubMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(255, 200, 221);
            pnlMenu.Controls.Add(pnlSubMenu);
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 640);
            pnlMenu.TabIndex = 2;
            // 
            // pnlSubMenu
            // 
            pnlSubMenu.BackColor = Color.FromArgb(255, 175, 204);
            pnlSubMenu.Controls.Add(btnAcuerdoVecinos);
            pnlSubMenu.Controls.Add(btnNrosUtiles);
            pnlSubMenu.Controls.Add(btnReclamo);
            pnlSubMenu.Controls.Add(btnComunicados);
            pnlSubMenu.Controls.Add(btnVerVecinos);
            pnlSubMenu.Dock = DockStyle.Top;
            pnlSubMenu.Location = new Point(0, 218);
            pnlSubMenu.Name = "pnlSubMenu";
            pnlSubMenu.Size = new Size(220, 225);
            pnlSubMenu.TabIndex = 2;
            // 
            // btnAcuerdoVecinos
            // 
            btnAcuerdoVecinos.Dock = DockStyle.Top;
            btnAcuerdoVecinos.FlatAppearance.BorderSize = 0;
            btnAcuerdoVecinos.FlatStyle = FlatStyle.Flat;
            btnAcuerdoVecinos.Location = new Point(0, 135);
            btnAcuerdoVecinos.Name = "btnAcuerdoVecinos";
            btnAcuerdoVecinos.Padding = new Padding(38, 0, 0, 0);
            btnAcuerdoVecinos.Size = new Size(220, 46);
            btnAcuerdoVecinos.TabIndex = 7;
            btnAcuerdoVecinos.Text = "Convivencia";
            btnAcuerdoVecinos.TextAlign = ContentAlignment.MiddleLeft;
            btnAcuerdoVecinos.UseVisualStyleBackColor = true;
            // 
            // btnNrosUtiles
            // 
            btnNrosUtiles.Dock = DockStyle.Top;
            btnNrosUtiles.FlatAppearance.BorderSize = 0;
            btnNrosUtiles.FlatStyle = FlatStyle.Flat;
            btnNrosUtiles.Location = new Point(0, 90);
            btnNrosUtiles.Name = "btnNrosUtiles";
            btnNrosUtiles.Padding = new Padding(38, 0, 0, 0);
            btnNrosUtiles.Size = new Size(220, 45);
            btnNrosUtiles.TabIndex = 6;
            btnNrosUtiles.Text = "Números Útiles";
            btnNrosUtiles.TextAlign = ContentAlignment.MiddleLeft;
            btnNrosUtiles.UseVisualStyleBackColor = true;
            btnNrosUtiles.Click += btnNrosUtiles_Click;
            // 
            // btnReclamo
            // 
            btnReclamo.Dock = DockStyle.Bottom;
            btnReclamo.FlatAppearance.BorderSize = 0;
            btnReclamo.FlatStyle = FlatStyle.Flat;
            btnReclamo.Location = new Point(0, 180);
            btnReclamo.Name = "btnReclamo";
            btnReclamo.Padding = new Padding(38, 0, 0, 0);
            btnReclamo.Size = new Size(220, 45);
            btnReclamo.TabIndex = 5;
            btnReclamo.Text = "Iniciar Reclamo";
            btnReclamo.TextAlign = ContentAlignment.MiddleLeft;
            btnReclamo.UseVisualStyleBackColor = true;
            // 
            // btnComunicados
            // 
            btnComunicados.Dock = DockStyle.Top;
            btnComunicados.FlatAppearance.BorderSize = 0;
            btnComunicados.FlatStyle = FlatStyle.Flat;
            btnComunicados.Location = new Point(0, 45);
            btnComunicados.Name = "btnComunicados";
            btnComunicados.Padding = new Padding(38, 0, 0, 0);
            btnComunicados.Size = new Size(220, 45);
            btnComunicados.TabIndex = 4;
            btnComunicados.Text = "Comunicados";
            btnComunicados.TextAlign = ContentAlignment.MiddleLeft;
            btnComunicados.UseVisualStyleBackColor = true;
            btnComunicados.Click += btnComunicados_Click;
            // 
            // btnVerVecinos
            // 
            btnVerVecinos.Dock = DockStyle.Top;
            btnVerVecinos.FlatAppearance.BorderSize = 0;
            btnVerVecinos.FlatStyle = FlatStyle.Flat;
            btnVerVecinos.Location = new Point(0, 0);
            btnVerVecinos.Name = "btnVerVecinos";
            btnVerVecinos.Padding = new Padding(38, 0, 0, 0);
            btnVerVecinos.Size = new Size(220, 45);
            btnVerVecinos.TabIndex = 3;
            btnVerVecinos.Text = "Listado Vecinos";
            btnVerVecinos.TextAlign = ContentAlignment.MiddleLeft;
            btnVerVecinos.UseVisualStyleBackColor = true;
            btnVerVecinos.Click += btnVerVecinos_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.Location = new Point(0, 168);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(11, 0, 0, 0);
            btnMenu.Size = new Size(220, 50);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menú";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImage = Properties.Resources.WGSN_Login;
            pnlLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pnlLogo.Controls.Add(label1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 168);
            pnlLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // InicioAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 640);
            Controls.Add(pnlMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "InicioAdmin";
            Text = "InicioAdmin";
            Load += InicioAdmin_Load;
            pnlMenu.ResumeLayout(false);
            pnlSubMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Panel pnlMenu;
        private Panel pnlSubMenu;
        private Button btnAcuerdoVecinos;
        private Button btnNrosUtiles;
        private Button btnReclamo;
        private Button btnComunicados;
        private Button btnVerVecinos;
        private Button btnMenu;
        private Panel pnlLogo;
        private Label label1;
    }
}