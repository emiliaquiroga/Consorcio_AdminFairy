using Entidades;
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
            if (listausuarios == null || listausuarios.IsDisposed)
            {
                listausuarios = new FrmListadoUsuarios();
                listausuarios.MdiParent = this;
                listausuarios.Show();
            }
            else
            {
                listausuarios.BringToFront();
                if(com.IsDisposed || numeros.IsDisposed)
                {
                    com.Close();
                    numeros.Close();
                }
            }
        }

        private void btnComunicados_Click(object sender, EventArgs e)
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

        private void btnNrosUtiles_Click(object sender, EventArgs e)
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
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
