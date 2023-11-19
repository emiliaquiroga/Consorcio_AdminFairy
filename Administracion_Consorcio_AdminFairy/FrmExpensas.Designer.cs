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
            btnPagar = new Button();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.Transparent;
            lblSaludo.Font = new Font("Century Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
            lblSaludo.ForeColor = Color.Navy;
            lblSaludo.Location = new Point(284, 135);
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
            rtbExpensas.Location = new Point(114, 298);
            rtbExpensas.Name = "rtbExpensas";
            rtbExpensas.Size = new Size(853, 47);
            rtbExpensas.TabIndex = 1;
            rtbExpensas.Text = "      Sus expensas son de este mes son de $";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(192, 192, 255);
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.Location = new Point(463, 433);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(164, 39);
            btnPagar.TabIndex = 13;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // FrmExpensas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 700);
            Controls.Add(btnPagar);
            Controls.Add(rtbExpensas);
            Controls.Add(lblSaludo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmExpensas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmVerExpensas";
            Load += FrmVerExpensas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private RichTextBox rtbExpensas;
        private Button btnPagar;
    }
}