using Entidades;
using System.Runtime.CompilerServices;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class FrmLogin : Form
    {
        Usuario usuario;
        string dni;
        string claveIngresado;

        public FrmLogin()
        {

            InitializeComponent();
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            dni = txtDni.Text;
        }

        public bool validarDatos()
        {

            try 
            {
                if (dni == Usuario.dni && ClaveIngresado == Usuario.Clave)
                {
                    return true;

                }
                else
                {
                    MessageBox.Show("ERROR!", "Los datos ingresados no corresponden a un usuario registrado.\tVuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch {
                Console.WriteLine("Error en VALIDAR DATOS");
                return false;
            }

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            claveIngresado = txtClave.Text;
        }

        private void chkMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarClave.Checked)
            {
                this.txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtClave.UseSystemPasswordChar = true;
            }

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                MessageBox.Show("Ingreso Exitoso!", "Bienvenida/o!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los datos ingresados no corresponden a un usuario registrado.\tVuelva a intentarlo", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}