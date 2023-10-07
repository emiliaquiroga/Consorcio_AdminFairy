using Entidades;
using System.Runtime.CompilerServices;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class FrmLogin : Form
    {
        string dni;
        string claveIngresado;

        public FrmLogin()
        {

            InitializeComponent();
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        //public bool validarDatos(string dni, string claveIngresado)
        //{

        //    try 
        //    {
        //        if (dni == txtDni.Text && claveIngresado == usuario.Clave)
        //        {
        //            return true;

        //        }
        //        else
        //        {
        //            MessageBox.Show("ERROR!", "Los datos ingresados no corresponden a un usuario registrado.\tVuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }

        //    }
        //    catch {
        //        Console.WriteLine("Error en VALIDAR DATOS");
        //        return false;
        //    }

        //}

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
            string dni = this.txtDni.Text;
            string clave = this.txtClave.Text;

            if (dni == "a" && clave == "a")
            {
                MessageBox.Show("Ingreso Exitoso!", "Bienvenida/o!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ACÁ TIENE QUE ABRIR EL FORM DE INICIO VECINO!

            }
            else
            {
                MessageBox.Show("Los datos ingresados no corresponden a un usuario registrado.\tVuelva a intentarlo", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario su = new SeleccionarUsuario(); // Se instanció el formulario del autocompletar. 
            su.ShowDialog();  // no se va a cerrar a menos que se termine de interactuar con este (en este caso por ahora con el btn cancelar o cerrandolo)
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblRegistro_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro(this);
            registro.Show();
        }
    }
}