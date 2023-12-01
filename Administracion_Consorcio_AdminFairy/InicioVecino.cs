using Entidades;
using Entidades.Serializadores;
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
    public partial class InicioVecino : Form
    {
        private FrmExpensas fe;
        private ComunicadosVecinos com;
        private NumerosUtiles numeros;
        private FrmReclamosVecino recVecinos;
        private FrmConvivenciaVecinos convivencia;
        Vecino vecino;
        Reloj reloj;

        public InicioVecino(Vecino vecino)
        {
            InitializeComponent();
            DisenioMenu();
            this.vecino = vecino;
        }

        #region Diseño menu
        private void DisenioMenu()
        {
            pnlMenu.Visible = true;
            pnlSubMenu.Visible = true;
        }


        private void MostrarSubMenu(Panel subMenu)
        {
            subMenu.Visible = true;

        }
        #endregion


        private void InicioVecino_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();
            reloj.SegundoCambiado += MostrarCambioTiempo; // Asociamos el evento con su respectivo manejador
            reloj.Ejecutar();
        }

        public void MostrarCambioTiempo(Reloj reloj) // Método manejador, que es el que va a reaccionar cuando disparemos el evento
        {
            if (lblTiempo.InvokeRequired)
            //Reinvocar el evento, debido a que queremos modificar un elemento que es parte del hilo principal, el label
            {
                Action<Reloj> delegado = MostrarCambioTiempo; // Declaro el delegado

                lblTiempo.Invoke(delegado, reloj); // Al label le paso el invoke con el delegado y los parametros del reloj
            }
            else
            {
                lblTiempo.Text = reloj.ToString(); // una vez hecho lo anterior se puede modificar el label           
            }


        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenu);

        }

        private void btnExpensas_Click(object sender, EventArgs e)
        {
            try
            {
                if (fe == null || fe.IsDisposed)
                {
                    fe = new FrmExpensas(vecino);
                    fe.MdiParent = this;
                    fe.Show();

                }
                else
                {
                    fe.BringToFront();
                }

            }
            catch (Exception ex)
            {
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioVecino > btnExpensas_Click");

            }

        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            try
            {
                if (com == null || com.IsDisposed)
                {
                    com = new ComunicadosVecinos();
                    com.MdiParent = this;
                    com.Show();
                }
                else
                {
                    com.BringToFront();
                }
            }
            catch (Exception ex)
            {
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioVecino > btnComunicadosClick");
            }

        }

        private void btnReclamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (recVecinos == null || recVecinos.IsDisposed)
                {
                    recVecinos = new FrmReclamosVecino();
                    recVecinos.MdiParent = this;
                    recVecinos.Show();
                }
                else
                {
                    fe.BringToFront();
                }
            }
            catch (Exception ex)
            {
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioVecino > btnReclamo_Click");
            }


        }

        private void btnNrosUtiles_Click(object sender, EventArgs e)
        {
            try
            {

                if (numeros == null || numeros.IsDisposed)
                {
                    numeros = new NumerosUtiles();
                    numeros.MdiParent = this;
                    numeros.Show();
                }
                else
                {
                    numeros.BringToFront();
                }
            }
            catch (Exception ex)
            {

                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioVecino > btnNrosUtiles_Click");

            }

        }

        private void btnAcuerdoVecinos_Click(object sender, EventArgs e) // PUSE EXACTAMENTE LO MISMO, PQ NO FUNCIONA
        {
            try
            {
                if (convivencia == null || convivencia.IsDisposed)
                {
                    convivencia = new FrmConvivenciaVecinos();
                    convivencia.MdiParent = this;
                    convivencia.Show();
                }
                else
                {
                    convivencia.BringToFront();
                }

            }
            catch (Exception ex)
            {
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioVecino > btnAcuerdoVecinos_Click");
                throw;
            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {

                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioVecino > btnCerrarSesion_Click");
            }


        }

    }
}
