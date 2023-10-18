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
            lblComunicados = new Label();
            lblAdmin = new Label();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // rchtxtAdmi
            // 
            rchtxtAdmi.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rchtxtAdmi.Location = new Point(21, 78);
            rchtxtAdmi.Name = "rchtxtAdmi";
            rchtxtAdmi.Size = new Size(352, 284);
            rchtxtAdmi.TabIndex = 0;
            rchtxtAdmi.Text = "";
            rchtxtAdmi.TextChanged += rchtxtAdmi_TextChanged;
            // 
            // rchtxtComunicado
            // 
            rchtxtComunicado.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rchtxtComunicado.Location = new Point(448, 78);
            rchtxtComunicado.Name = "rchtxtComunicado";
            rchtxtComunicado.ReadOnly = true;
            rchtxtComunicado.Size = new Size(479, 385);
            rchtxtComunicado.TabIndex = 1;
            rchtxtComunicado.Text = "";
            rchtxtComunicado.TextChanged += rchtxtComunicado_TextChanged;
            // 
            // lblComunicados
            // 
            lblComunicados.AutoSize = true;
            lblComunicados.BackColor = Color.Transparent;
            lblComunicados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblComunicados.Location = new Point(566, 27);
            lblComunicados.Name = "lblComunicados";
            lblComunicados.Size = new Size(212, 30);
            lblComunicados.TabIndex = 2;
            lblComunicados.Text = "COMUNICADOS:";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.BackColor = Color.Transparent;
            lblAdmin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdmin.Location = new Point(69, 27);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(244, 30);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = "Emitir Comunicado";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(255, 175, 204);
            btnAdmin.FlatAppearance.BorderSize = 5;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Location = new Point(121, 400);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(143, 63);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Emitir Comunicado";
            btnAdmin.UseVisualStyleBackColor = false;
            //btnAdmin.Click += btnAdmin_Click;
            // 
            // FrmComunicados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1586, 690);
            Controls.Add(btnAdmin);
            Controls.Add(lblAdmin);
            Controls.Add(lblComunicados);
            Controls.Add(rchtxtComunicado);
            Controls.Add(rchtxtAdmi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComunicados";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Comunicados";
            //Load += FrmComunicados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rchtxtAdmi;
        private RichTextBox rchtxtComunicado;
        private Label lblComunicados;
        private Label lblAdmin;
        private Button btnAdmin;
    }
}