using Entidades;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class FrmLogin : Form
    {
        string dni;
        string claveIngresado;
        string ruta; 
        string nombreXml;
        string nombreJson;
        public string pathJson;
        public string pathXml;

        public FrmLogin()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.nombreXml = @"\UsuariosRegistrados.xml"; // nombre del archivo
            this.nombreJson = @"\UsuariosRegistradosJson.json";
            this.pathJson = ruta + nombreJson;
            this.pathXml = ruta + nombreXml;
          
        }

        public bool ValidarDatos(string dni, string claveIngresada)
        {
            try
            {
                List<Vecino> usuarios = Serializadora.LeerJson(this.pathJson);
                //Serializadora.EscribirJson(pathJson, usuarios);

                if (usuarios != null)
                {
                    Usuario usuarioEncontrado = usuarios.FirstOrDefault(u => u.Dni == dni && u.Clave == claveIngresada);

                    if (usuarioEncontrado != null)
                    {
                        return true;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo JSON no se encontró: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error en la deserialización JSON: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error desconocido al validar credenciales: " + ex.Message);
            }

            MessageBox.Show("Los datos ingresados no corresponden a un usuario registrado.\nVuelva a intentarlo", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
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
 
            if (dni == "38500278" && clave == "admin")
            {
                InicioAdmin inicioAdmin = new InicioAdmin();
                inicioAdmin.Show();

            }

            else if(ValidarDatos(dni, clave))
            {
                MessageBox.Show("Ingreso Exitoso!", "Bienvenida/o!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicioVecino inicio = new InicioVecino();
                inicio.Show();
                this.Hide();
            }

        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario su = new SeleccionarUsuario(); // Se instanció el formulario del autocompletar. 
            su.ShowDialog();  // no se va a cerrar a menos que se termine de interactuar con este (en este caso por ahora con el btn cancelar o cerrandolo)
        }

        private void lblRegistro_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro(this);
            registro.Show();
        }
    }
}