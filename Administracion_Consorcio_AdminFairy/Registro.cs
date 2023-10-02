using Entidades;
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
        private void Registro_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuario vecino = new Usuario();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string dniText = txtDocumento.Text;
            string claveConfirm = txtConfirmeClave.Text;
            string clave = txtClaveReg.Text;
            string direccion = txtDireccion.Text;
            string ciudad = lstCiudad.Text;
            string pisoText = txtPiso.Text;
            string departamento = txtDepto.Text;

            lblError.Visible = false;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(dniText) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(pisoText) ||
                string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(claveConfirm))
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: Todos los campos son obligatorios";
                return;
            }

            // Verificar que DNI sea numérico
            if (!ulong.TryParse(dniText, out ulong dni))
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: D.N.I. debe ser un valor numérico";
                return;
            }

            // Verificar que PISO sea numérico
            if (!int.TryParse(pisoText, out int piso))
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: N° de Piso debe ser un valor numérico";
                return;
            }

            if (clave != claveConfirm)
            {
                lblError.Visible = true;
                lblError.Text = "La clave y su confirmación no coinciden";
                return;
            }

            ObtenerSituacion(vecino);

            MessageBox.Show("Te has Registrado exitosamente!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
            login.Show();
        }

        private void ObtenerSituacion(Usuario vecino)
        {
            foreach (Control opcion in grpSituacion.Controls)
            {
                if (opcion is RadioButton radioButton && radioButton.Checked)
                {
                    vecino.situacion = radioButton.Text;
                    break;
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
    
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }


        private void lblInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            login.Show();
        }


    }
}
