using Entidades;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Entidades.Serializadores;
using Entidades.DB;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class FrmLogin : Form
    {
        string dni;
        string claveIngresado;
        Administrador admin;
        Vecino vecino;

        public FrmLogin()
        {
            InitializeComponent();
            admin = new Administrador("Admin", "AdminFairy", "87654321", "admin");
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
            string dni = this.txtDni.Text;
            string clave = this.txtClave.Text;

            try
            {

                Vecino vecino = DB.AutenticarVecino(dni, clave);

                if (dni == admin.Dni && clave == admin.Clave)
                {
                    InicioAdmin inicioAdmin = new InicioAdmin();
                    inicioAdmin.Show();
                    this.Hide();
                    txtDni.Clear();
                    txtClave.Clear();
                }
                else
                {
                    if (vecino != null)
                    {
                        MessageBox.Show("Ingreso Exitoso!", "Bienvenida/o!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicioVecino inicio = new InicioVecino(vecino);
                        inicio.Show();
                        txtDni.Clear();
                        txtClave.Clear();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error); // tirar excepcion propia
                    }
                }


            }
            catch (Exception ex)
            {
                // Manejar errores y registrarlos según sea necesario
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // tirar una excepcion propia
            }
        }


        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtClave.Text = admin.Clave;
            txtDni.Text = admin.Dni;
        }

        private void lblRegistro_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro registro = new FrmRegistro(this);
            registro.Show();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}