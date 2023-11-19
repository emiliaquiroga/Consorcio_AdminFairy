using Entidades.Serializadores;

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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgUsuariosRegistrados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serializadoraBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgUsuariosRegistrados
            // 
            dtgUsuariosRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgUsuariosRegistrados.BackgroundColor = Color.FromArgb(233, 222, 245);
            dtgUsuariosRegistrados.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgUsuariosRegistrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuariosRegistrados.GridColor = Color.FromArgb(255, 192, 192);
            dtgUsuariosRegistrados.Location = new Point(38, 212);
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
            dtgUsuariosRegistrados.Size = new Size(1029, 353);
            dtgUsuariosRegistrados.TabIndex = 0;
            // 
            // serializadoraBindingSource
            // 
            serializadoraBindingSource.DataSource = typeof(Serializadora);
            // 
            // cmbxEstadoVecino
            // 
            cmbxEstadoVecino.FormattingEnabled = true;
            cmbxEstadoVecino.Location = new Point(38, 145);
            cmbxEstadoVecino.Margin = new Padding(2);
            cmbxEstadoVecino.Name = "cmbxEstadoVecino";
            cmbxEstadoVecino.Size = new Size(303, 23);
            cmbxEstadoVecino.TabIndex = 1;
            cmbxEstadoVecino.Tag = "Estado cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(422, 86);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 2;
            label1.Text = "Listado de vecinos ";
            // 
            // FrmListadoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 183, 204);
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 700);
            Controls.Add(label1);
            Controls.Add(cmbxEstadoVecino);
            Controls.Add(dtgUsuariosRegistrados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FrmListadoUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListadoUsuarios";
            Load += FrmListadoUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuariosRegistrados).EndInit();
            ((System.ComponentModel.ISupportInitialize)serializadoraBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgUsuariosRegistrados;
        private BindingSource serializadoraBindingSource;
        private ComboBox cmbxEstadoVecino;
        private Label label1;
    }
}