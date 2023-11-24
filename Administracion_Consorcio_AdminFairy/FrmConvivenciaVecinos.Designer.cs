namespace Administracion_Consorcio_AdminFairy
{
    partial class FrmConvivenciaVecinos
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
            lblConvivenciaVecinos = new Label();
            rtbConvivenciaLeer = new RichTextBox();
            lblEstrellitas1 = new Label();
            lblEstrellitas2 = new Label();
            SuspendLayout();
            // 
            // lblConvivenciaVecinos
            // 
            lblConvivenciaVecinos.AutoSize = true;
            lblConvivenciaVecinos.BackColor = Color.Transparent;
            lblConvivenciaVecinos.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblConvivenciaVecinos.Location = new Point(391, 63);
            lblConvivenciaVecinos.Name = "lblConvivenciaVecinos";
            lblConvivenciaVecinos.Size = new Size(298, 28);
            lblConvivenciaVecinos.TabIndex = 12;
            lblConvivenciaVecinos.Text = "Normas de convivencia";
            // 
            // rtbConvivenciaLeer
            // 
            rtbConvivenciaLeer.Location = new Point(358, 148);
            rtbConvivenciaLeer.Name = "rtbConvivenciaLeer";
            rtbConvivenciaLeer.ReadOnly = true;
            rtbConvivenciaLeer.Size = new Size(368, 531);
            rtbConvivenciaLeer.TabIndex = 13;
            rtbConvivenciaLeer.Text = "";
            // 
            // lblEstrellitas1
            // 
            lblEstrellitas1.AutoSize = true;
            lblEstrellitas1.BackColor = Color.Transparent;
            lblEstrellitas1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstrellitas1.Location = new Point(321, 139);
            lblEstrellitas1.Name = "lblEstrellitas1";
            lblEstrellitas1.Size = new Size(31, 540);
            lblEstrellitas1.TabIndex = 14;
            lblEstrellitas1.Text = "☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆";
            // 
            // lblEstrellitas2
            // 
            lblEstrellitas2.AutoSize = true;
            lblEstrellitas2.BackColor = Color.Transparent;
            lblEstrellitas2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstrellitas2.Location = new Point(732, 139);
            lblEstrellitas2.Name = "lblEstrellitas2";
            lblEstrellitas2.Size = new Size(31, 540);
            lblEstrellitas2.TabIndex = 15;
            lblEstrellitas2.Text = "☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆\r\n☆";
            // 
            // FrmConvivenciaVecinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 750);
            Controls.Add(lblEstrellitas2);
            Controls.Add(lblEstrellitas1);
            Controls.Add(rtbConvivenciaLeer);
            Controls.Add(lblConvivenciaVecinos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConvivenciaVecinos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmConvivenciaVecinos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConvivenciaVecinos;
        private RichTextBox rtbConvivenciaLeer;
        private Label lblEstrellitas1;
        private Label lblEstrellitas2;
    }
}