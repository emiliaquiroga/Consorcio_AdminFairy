using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class Registro : Form
    {
        private FrmLogin login;
        public Registro(FrmLogin login)
        {
            InitializeComponent();
            this.login = login;
            login.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPiso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Te has Registrado exitosamente!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClaveReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
