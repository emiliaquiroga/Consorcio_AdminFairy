using Entidades;
using Entidades.Serializadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class InicioAdmin : Form
    {

        private FrmListadoUsuarios listausuarios;
        private FrmComunicados com;
        private NumerosUtiles numeros;

        //private FrmReclamosAdmin verReclamos; cree un form y no se guardó xd

        public InicioAdmin()
        {
            InitializeComponent();

        }
        private void InicioAdmin_Load(object sender, EventArgs e)
        {

        }
        private void btnVerVecinos_Click(object sender, EventArgs e)
        {
            try
            {
                if (listausuarios == null || listausuarios.IsDisposed)
                {
                    listausuarios = new FrmListadoUsuarios();
                    listausuarios.MdiParent = this;
                    listausuarios.Show();
                }
                else
                {
                    listausuarios.BringToFront();
                    if (com.IsDisposed || numeros.IsDisposed)
                    {
                        com.Close();
                        numeros.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioAdmin > btnVerVecinos_Click");
               
                
            }

        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            try
            {
                if (com == null || com.IsDisposed)
                {
                    com = new FrmComunicados();
                    com.MdiParent = this;
                    com.Show();
                }
                else
                {
                    com.BringToFront();
                    if (listausuarios.IsDisposed || numeros.IsDisposed)
                    {
                        listausuarios.Close();
                        numeros.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioAdmin > btnComunicados_Click");

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
                    if (com.IsDisposed || listausuarios.IsDisposed)
                    {
                        com.Close();
                        listausuarios.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioAdmin > btnNrosUtiles_Click");
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
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "InicioAdmin > btnCerrarSesion_Click");
            }

        }

        //private void btnReclamo_Click(object sender, EventArgs e)
        //{
        //    if (verReclamos == null || verReclamos.IsDisposed)
        //    {
        //        verReclamos = new FrmReclamosAdmin();
        //        verReclamos.MdiParent = this;
        //        verReclamos.Show();
        //    }
        //    else
        //    {
        //        verReclamos.BringToFront();
        //    }
        //}
    }
}
