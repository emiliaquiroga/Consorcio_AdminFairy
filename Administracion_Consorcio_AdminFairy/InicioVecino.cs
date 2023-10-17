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

        public InicioVecino()
        {
            InitializeComponent();
            DisenioMenu();
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



        private void btnMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenu);

        }

        private void btnExpensas_Click(object sender, EventArgs e)
        {
            //Muestro expensas

        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            FrmComunicados comunicados = new FrmComunicados();
            comunicados.MdiParent = this;
            comunicados.Show();
        }

        private void btnReclamo_Click(object sender, EventArgs e)
        {

            //Muestro reclamos

        }

        private void btnNrosUtiles_Click(object sender, EventArgs e)
        {
            NumerosUtiles numeros = new NumerosUtiles();
            numeros.MdiParent = this;
            numeros.Show();

        }

        private void btnAcuerdoVecinos_Click(object sender, EventArgs e)
        {
            //Muestro un modelo de acuerdo de convivencia


        }


    }
}
