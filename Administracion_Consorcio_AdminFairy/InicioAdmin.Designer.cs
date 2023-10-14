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
            btnUsuarios = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(692, 132);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(180, 82);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Ver Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // InicioAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 640);
            Controls.Add(btnUsuarios);
            Name = "InicioAdmin";
            Text = "InicioAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
    }
}