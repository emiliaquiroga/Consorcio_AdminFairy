namespace Administracion_Consorcio_AdminFairy
{
    partial class NumerosUtiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumerosUtiles));
            lblTitulo = new Label();
            btnAscensor = new Button();
            btnPlomero = new Button();
            btnCerrajero = new Button();
            rchtxtTelefonos = new RichTextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(576, 75);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Teléfonos útiles";
            // 
            // btnAscensor
            // 
            btnAscensor.BackColor = Color.FromArgb(255, 175, 204);
            btnAscensor.FlatStyle = FlatStyle.Popup;
            btnAscensor.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAscensor.Location = new Point(93, 212);
            btnAscensor.Margin = new Padding(4, 5, 4, 5);
            btnAscensor.Name = "btnAscensor";
            btnAscensor.Size = new Size(259, 88);
            btnAscensor.TabIndex = 1;
            btnAscensor.Text = "Tecnico Ascensor";
            btnAscensor.UseVisualStyleBackColor = false;
            btnAscensor.Click += btnAscensor_Click;
            // 
            // btnPlomero
            // 
            btnPlomero.BackColor = Color.FromArgb(255, 175, 204);
            btnPlomero.FlatStyle = FlatStyle.Popup;
            btnPlomero.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlomero.Location = new Point(93, 363);
            btnPlomero.Margin = new Padding(4, 5, 4, 5);
            btnPlomero.Name = "btnPlomero";
            btnPlomero.Size = new Size(259, 88);
            btnPlomero.TabIndex = 2;
            btnPlomero.Text = "Plomero";
            btnPlomero.UseVisualStyleBackColor = false;
            btnPlomero.Click += btnPlomero_Click;
            // 
            // btnCerrajero
            // 
            btnCerrajero.BackColor = Color.FromArgb(255, 175, 204);
            btnCerrajero.FlatStyle = FlatStyle.Popup;
            btnCerrajero.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrajero.Location = new Point(93, 522);
            btnCerrajero.Margin = new Padding(4, 5, 4, 5);
            btnCerrajero.Name = "btnCerrajero";
            btnCerrajero.Size = new Size(259, 88);
            btnCerrajero.TabIndex = 3;
            btnCerrajero.Text = "Cerrajero";
            btnCerrajero.UseVisualStyleBackColor = false;
            btnCerrajero.Click += btnCerrajero_Click;
            // 
            // rchtxtTelefonos
            // 
            rchtxtTelefonos.BackColor = Color.FromArgb(255, 175, 204);
            rchtxtTelefonos.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rchtxtTelefonos.Location = new Point(424, 212);
            rchtxtTelefonos.Margin = new Padding(4, 5, 4, 5);
            rchtxtTelefonos.Name = "rchtxtTelefonos";
            rchtxtTelefonos.ReadOnly = true;
            rchtxtTelefonos.Size = new Size(601, 396);
            rchtxtTelefonos.TabIndex = 4;
            rchtxtTelefonos.Text = "";
            // 
            // NumerosUtiles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1586, 690);
            Controls.Add(rchtxtTelefonos);
            Controls.Add(btnCerrajero);
            Controls.Add(btnPlomero);
            Controls.Add(btnAscensor);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NumerosUtiles";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NumerosUtiles";
            Load += NumerosUtiles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAscensor;
        private Button btnPlomero;
        private Button btnCerrajero;
        private RichTextBox rchtxtTelefonos;
    }
}