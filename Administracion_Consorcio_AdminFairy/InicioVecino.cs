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
            // tenemos un problema con el reloj: cuando lo des-comento NO CARGA el form de InicioVecino. 
            //Reloj reloj = new Reloj();
            //reloj.SegundoCambiado += MostrarCambioTiempo;
            //reloj.Ejecutar();
        }

        public void MostrarCambioTiempo(object reloj, InfoTiempoEventArgs info)
        {
        
            lblTiempo.Text = $"{info.hora}{info.minuto}{info.segundo}";
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenu);

        }

        private void btnExpensas_Click(object sender, EventArgs e)
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

        private void btnComunicados_Click(object sender, EventArgs e)
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

        private void btnReclamo_Click(object sender, EventArgs e)
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
            }

        }

        private void btnAcuerdoVecinos_Click(object sender, EventArgs e) // PUSE EXACTAMENTE LO MISMO, PQ NO FUNCIONA
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

        private void InicioVecino_Activated(object sender, EventArgs e)
        {
            //reloj.Ejecutar();
        }
    }
}
