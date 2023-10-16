using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class Registro : Form
    {
        public FrmLogin login;

        // Define un diccionario que relaciona ciudades con sus barrios.
        private Dictionary<string, List<string>> torresAdministradas = new Dictionary<string, List<string>> // INTENTAR METER EN UN ARCHIVO
        {
            {"Ciudad Autónoma de Buenos Aires", new List<string>{"Torre Azalea", "Torre Dalia", "Torre Clavel"}},
            {"La Plata", new List<string>{"Torre Amapola", "Torre Cerezo", "Torre Girasol"}},
            {"Córdoba", new List<string>{"Torre Orquidea", "Torre Margarita", "Torre Lavanda"}},
            {"Santa Fé", new List<string>{"Torre Magnolia", "Torre Jazmín", "Torre Loto"}},

        };

        public Registro(FrmLogin login)
        {
            InitializeComponent();
            this.login = login;
            login.Hide();
        }


        #region Metodos y Validaciones

        private bool ValidarDatos(string nombre, string apellido, string email, string dniText, string unidad, string piso, string clave, string claveConfirm)
        // metodo que valida los datos. CREO QUE DEBERIAMOS HACER TRY CATCH o crear excepciones propias para esto
        {
            lblError.Visible = false;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(dniText) || string.IsNullOrEmpty(unidad) || string.IsNullOrEmpty(piso) ||
                string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(claveConfirm))
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: Todos los campos son obligatorios";
                return false;
            }

            //NUEVO: verificar que dni no se haya registrado ya.
            // Verificar que DNI sea numérico   
            if (!ulong.TryParse(dniText, out ulong dni))
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: D.N.I. debe ser un valor numérico";
                return false;
            }

            if (clave != claveConfirm)
            {
                lblError.Visible = true;
                lblError.Text = "La clave y su confirmación no coinciden";
                return false;
            }

            if (!EsDireccionCorreoValida(email))
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: Ingresa una dirección de correo electrónico válida";
                return false;
            }

            string situacion = ObtenerSituacion();

            if (string.IsNullOrEmpty(situacion))
            {
                lblError.Visible = true;
                lblError.Text = "ERROR: Debes seleccionar \n    si eres Dueño o Inquilino";
                return false;
            }
            return true;

        }


        private void AsignarRegistro(string pathXML, string pathJson)//crea un nuevo vecino y le asigna los datos ingresados en el registro
        {

            Vecino vecinoNuevo = new Vecino();
            vecinoNuevo.Nombre = txtNombre.Text;
            vecinoNuevo.Apellido = txtApellido.Text;
            vecinoNuevo.Email = txtEmail.Text;
            vecinoNuevo.Dni = txtDocumento.Text;
            vecinoNuevo.Clave = txtClaveReg.Text;
            vecinoNuevo.Edificio = lstTorre.Text;
            vecinoNuevo.Ciudad = lstCiudad.Text;
            vecinoNuevo.PisoVivienda = dmUpDownPiso.Text;
            vecinoNuevo.UnidadVivienda = dmUpDownUnidad.Text;


            try
            {
                Serializadora.EscribirArchivos(pathJson, pathXML, vecinoNuevo);


                MessageBox.Show("Te has Registrado exitosamente!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                login.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        private string ObtenerSituacion() // Ahora se obtiene la situación del RadioButton seleccionado
        {

            foreach (Control opcion in grpSituacion.Controls)
            {
                if (opcion is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return null; // Devuelve null si ningún CheckBox está marcado
        }


        private bool EsDireccionCorreoValida(string email) // valida correo electronico ingresado
        {
            // regEx para validar una dirección de correo electrónico
            string patronCorreo = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            // Usar la regEx para verificar la dirección de correo electrónico
            return Regex.IsMatch(email, patronCorreo);
        }

        private void ValidarSoloLetras(object sender, KeyPressEventArgs e) // valida que en nombre y apellido solo se ingresen letras y NO numeros o caract. especiales
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Eventos
        private void Registro_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;

            // Agrega las ciudades al lstCiudades
            foreach (var ciudad in torresAdministradas.Keys)
            {
                lstCiudad.Items.Add(ciudad);
            }

            // inicializa el metodo de validacion para nombr ey apellido, para que no ingresen numeros ni carac teres especiales
            txtNombre.KeyPress += ValidarSoloLetras;
            txtApellido.KeyPress += ValidarSoloLetras;
        }


        private void btnRegistro_Click(object sender, EventArgs e) // cuando se hace click en "Registrar", se hacen todas las validaciones
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string dniText = txtDocumento.Text;
            string claveConfirm = txtConfirmeClave.Text;
            string clave = txtClaveReg.Text;
            string edificio = lstTorre.Text;
            string ciudad = lstCiudad.Text;
            string piso = dmUpDownPiso.Text;
            string unidad = dmUpDownUnidad.Text;

            lblError.Visible = false;

            if (ValidarDatos(nombre, apellido, email, dniText, unidad, piso, clave, claveConfirm))
            {
                AsignarRegistro(this.login.pathXml, this.login.pathJson);
                this.Close();
                login.Show();
            }
        }


        private void lstCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Borra los elementos existentes en listBoxBarrios
            lstTorre.Items.Clear();

            // Obtiene la ciudad seleccionada en listBoxCiudades
            string ciudadSeleccionada = lstCiudad.SelectedItem as string;

            // Verifica si se seleccionó una ciudad válida
            if (ciudadSeleccionada != null && torresAdministradas.ContainsKey(ciudadSeleccionada))
            {
                // Obtiene los barrios correspondientes a la ciudad seleccionada
                List<string> barrios = torresAdministradas[ciudadSeleccionada];

                // Agrega los barrios al listBoxBarrios
                foreach (var barrio in barrios)
                {
                    lstTorre.Items.Add(barrio);
                }
            }
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


        private void btnBorrarInfo_Click_1(object sender, EventArgs e)  // Ahora borra los textbox!!
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtDocumento.Clear();
            txtClaveReg.Clear();
            txtConfirmeClave.Clear();
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un dígito (0-9) o una tecla de control, y limitar a 8 caracteres como máximo 
            if (!char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar) && txtDocumento.Text.Length >= 8)
            {
                // Si no es un dígito, una tecla de control o se pasa de los 8 digitos: se ignora la acción
                e.Handled = true;
            }
        }
        #endregion



    }
}
