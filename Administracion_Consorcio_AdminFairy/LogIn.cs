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
        Administrador admin;
        Vecino vecino;

        public FrmLogin()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.nombreXml = @"\UsuariosRegistrados.xml"; // nombre del archivo
            this.nombreJson = @"\UsuariosRegistradosJson.json";
            this.pathJson = ruta + nombreJson;
            this.pathXml = ruta + nombreXml;
            admin = new Administrador("Admin", "AdminFairy", "87654321", "admin");

        }

        //public Vecino VerificarUsuario(string dni, string clave) //verifica que vecino este dentro de los registrados en el json
        //{
        //    Vecino vecino = new Vecino(); 
        //    try
        //    {
        //        List<Vecino> usuarios = Serializadora.LeerJson(this.pathJson);

        //        if (usuarios != null)
        //        {
        //            foreach (Vecino usario in usuarios)
        //            {
        //                if(dni == usario.Dni && clave == usario.Clave)
        //                {
        //                    vecino = usario;
                            
        //                    break;
        //                }
        //            }
        //            return vecino;

        //        }
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        Console.WriteLine("El archivo JSON no se encontró: " + ex.Message);
        //    }
        //    catch (JsonException ex)
        //    {
        //        Console.WriteLine("Error en la deserialización JSON: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error desconocido al validar credenciales: " + ex.Message);
        //    }

        //    MessageBox.Show("Los datos ingresados no corresponden a un usuario registrado.\nVuelva a intentarlo", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
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
            List<Vecino> listaVecinos = Serializadora.LeerJson(this.pathJson);
            
            foreach(Vecino vecino in listaVecinos)
            {
                if (dni == vecino.Dni && clave == vecino.Clave)
                {

                    MessageBox.Show("Ingreso Exitoso!", "Bienvenida/o!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicioVecino inicio = new InicioVecino(vecino);
                    inicio.Show();
                    txtDni.Clear();
                    txtClave.Clear();
                    this.Hide();
                    break;
                }
            }

            if (dni == admin.Dni && clave == admin.Clave)
            {
                InicioAdmin inicioAdmin = new InicioAdmin();
                inicioAdmin.Show();
                this.Hide();
                txtDni.Clear();
                txtClave.Clear();
            }

        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            //SeleccionarUsuario su = new SeleccionarUsuario(); // Se instanció el formulario del autocompletar. 
            //su.ShowDialog();  // no se va a cerrar a menos que se termine de interactuar con este (en este caso por ahora con el btn cancelar o cerrandolo)
            txtClave.Text = admin.Clave;
            txtDni.Text = admin.Dni;
        }

        private void lblRegistro_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro(this);
            registro.Show();
        }
    }
}