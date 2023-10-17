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
            this.pnlPrincipal.Visible = false;
            FrmExpensas fe = new FrmExpensas();
            fe.MdiParent = this;
            fe.Show();
            fe.rtbExpensas.ReadOnly = false;
            

        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            //Muestro comunicados
            
        }

        private void btnReclamo_Click(object sender, EventArgs e)
        {

            //Muestro reclamos

        }

        private void btnNrosUtiles_Click(object sender, EventArgs e)
        {
            //Muestro Numeros de Plomero, Cerrajero, Urgencias Ascensor
            
        }

        private void btnAcuerdoVecinos_Click(object sender, EventArgs e)
        {
            //Muestro un modelo de acuerdo de convivencia


        }


    }
}
