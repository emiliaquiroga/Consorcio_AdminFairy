namespace Administracion_Consorcio_AdminFairy
{
    partial class FrmListadoUsuarios
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtgUsuariosRegistrados = new DataGridView();
            serializadoraBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgUsuariosRegistrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serializadoraBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuariosRegistrados
            // 
            dtgUsuariosRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgUsuariosRegistrados.BackgroundColor = Color.FromArgb(255, 200, 221);
            dtgUsuariosRegistrados.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgUsuariosRegistrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuariosRegistrados.Dock = DockStyle.Fill;
            dtgUsuariosRegistrados.GridColor = Color.FromArgb(255, 192, 192);
            dtgUsuariosRegistrados.Location = new Point(0, 0);
            dtgUsuariosRegistrados.Name = "dtgUsuariosRegistrados";
            dtgUsuariosRegistrados.ReadOnly = true;
            dtgUsuariosRegistrados.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 200, 221);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 175, 204);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dtgUsuariosRegistrados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgUsuariosRegistrados.RowTemplate.Height = 33;
            dtgUsuariosRegistrados.Size = new Size(1179, 532);
            dtgUsuariosRegistrados.TabIndex = 0;
            // 
            // serializadoraBindingSource
            // 
            serializadoraBindingSource.DataSource = typeof(Entidades.Serializadora);
            // 
            // FrmListadoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 183, 204);
            ClientSize = new Size(1110, 414);
            Controls.Add(dtgUsuariosRegistrados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmListadoUsuarios";
            Text = "ListadoUsuarios";
            Load += FrmListadoUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuariosRegistrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)serializadoraBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgUsuariosRegistrados;
        private BindingSource serializadoraBindingSource;
    }
}