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
            cmbxEstadoVecino = new ComboBox();
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
            dtgUsuariosRegistrados.GridColor = Color.FromArgb(255, 192, 192);
            dtgUsuariosRegistrados.Location = new Point(4, 1);
            dtgUsuariosRegistrados.Margin = new Padding(4, 5, 4, 5);
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
            dtgUsuariosRegistrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuariosRegistrados.Size = new Size(1049, 578);
            dtgUsuariosRegistrados.TabIndex = 0;
            // 
            // serializadoraBindingSource
            // 
            serializadoraBindingSource.DataSource = typeof(Entidades.Serializadora);
            // 
            // cmbxEstadoVecino
            // 
            cmbxEstadoVecino.FormattingEnabled = true;
            cmbxEstadoVecino.Location = new Point(1234, 105);
            cmbxEstadoVecino.Name = "cmbxEstadoVecino";
            cmbxEstadoVecino.Size = new Size(299, 33);
            cmbxEstadoVecino.TabIndex = 1;
            cmbxEstadoVecino.SelectedIndexChanged += cmbxEstadoVecino_SelectedIndexChanged_1;
            // 
            // FrmListadoUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 183, 204);
            ClientSize = new Size(1586, 690);
            Controls.Add(cmbxEstadoVecino);
            Controls.Add(dtgUsuariosRegistrados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListadoUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListadoUsuarios";
            Load += FrmListadoUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuariosRegistrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)serializadoraBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgUsuariosRegistrados;
        private BindingSource serializadoraBindingSource;
        private ComboBox cmbxEstadoVecino;
    }
}