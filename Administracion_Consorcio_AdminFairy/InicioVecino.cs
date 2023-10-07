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
            pnlMenu.Visible = false;
            pnlSubMenu.Visible = false;
        }

        private void EsconderSubMenu()
        {
            if (pnlSubMenu.Visible == true)
            {
                pnlSubMenu.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (pnlSubMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;

            }
            else
            {
                pnlSubMenu.Visible = false;
            }
        }
        #endregion



        private void btnMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenu);

        }

        private void btnExpensas_Click(object sender, EventArgs e)
        {
            //Muestro expensas
            EsconderSubMenu();
        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            //Muestro comunicados
            EsconderSubMenu();
        }

        private void btnReclamo_Click(object sender, EventArgs e)
        {
            //Muestro reclamos
            EsconderSubMenu();
        }

        private void btnNrosUtiles_Click(object sender, EventArgs e)
        {
            //Muestro Numeros de Plomero, Cerrajero, Urgencias Ascensor
            EsconderSubMenu();
        }

        private void btnAcuerdoVecinos_Click(object sender, EventArgs e)
        {
            //Muestro un modelo de acuerdo de convivencia

            EsconderSubMenu();
        }


    }
}
