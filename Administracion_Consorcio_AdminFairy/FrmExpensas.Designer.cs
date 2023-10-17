namespace Administracion_Consorcio_AdminFairy
{
    partial class FrmExpensas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpensas));
            lblSaludo = new Label();
            rtbExpensas = new RichTextBox();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Century Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lblSaludo.ForeColor = Color.Navy;
            lblSaludo.Location = new Point(294, 26);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(52, 57);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "¡!";
            // 
            // rtbExpensas
            // 
            rtbExpensas.BackColor = Color.FromArgb(192, 192, 255);
            rtbExpensas.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rtbExpensas.ForeColor = Color.DarkSlateBlue;
            rtbExpensas.Location = new Point(88, 301);
            rtbExpensas.Name = "rtbExpensas";
            rtbExpensas.Size = new Size(763, 47);
            rtbExpensas.TabIndex = 1;
            rtbExpensas.Text = "Sus expensas son de este mes son de $";
            // 
            // FrmVerExpensas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 663);
            Controls.Add(rtbExpensas);
            Controls.Add(lblSaludo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVerExpensas";
            Text = "FrmVerExpensas";
            Load += FrmVerExpensas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private RichTextBox rtbExpensas;
    }
}