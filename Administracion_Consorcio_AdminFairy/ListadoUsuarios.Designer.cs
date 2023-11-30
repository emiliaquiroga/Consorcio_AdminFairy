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
            label1 = new Label();
            txtEstado = new TextBox();
            txtExpensas = new TextBox();
            lblEstado = new Label();
            label3 = new Label();
            lblExpensas = new Label();
            btnGuardar = new Button();
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
            dtgUsuariosRegistrados.Location = new Point(457, 353);
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
            dtgUsuariosRegistrados.Size = new Size(1067, 600);
            dtgUsuariosRegistrados.TabIndex = 0;
            dtgUsuariosRegistrados.CellClick += dtgUsuariosRegistrados_CellClick;
            // 
            // serializadoraBindingSource
            // 
            serializadoraBindingSource.DataSource = typeof(Serializadora);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(603, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(359, 43);
            label1.TabIndex = 2;
            label1.Text = "Listado de vecinos ";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(71, 579);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(241, 31);
            txtEstado.TabIndex = 3;
            // 
            // txtExpensas
            // 
            txtExpensas.Location = new Point(71, 690);
            txtExpensas.Name = "txtExpensas";
            txtExpensas.Size = new Size(241, 31);
            txtExpensas.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(71, 523);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(78, 25);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "ESTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 340);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 7;
            // 
            // lblExpensas
            // 
            lblExpensas.AutoSize = true;
            lblExpensas.Location = new Point(71, 642);
            lblExpensas.Name = "lblExpensas";
            lblExpensas.Size = new Size(182, 25);
            lblExpensas.TabIndex = 8;
            lblExpensas.Text = "SITUACION DE PAGO";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(71, 747);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 53);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmListadoUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(168, 183, 204);
            BackgroundImage = Properties.Resources.Fondo_app;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1586, 1167);
            Controls.Add(btnGuardar);
            Controls.Add(lblExpensas);
            Controls.Add(label3);
            Controls.Add(lblEstado);
            Controls.Add(txtExpensas);
            Controls.Add(txtEstado);
            Controls.Add(label1);
            Controls.Add(dtgUsuariosRegistrados);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label1;
        private TextBox txtEstado;
        private TextBox txtExpensas;
        private Label lblEstado;
        private Label label3;
        private Label lblExpensas;
        private Button btnGuardar;
    }
}