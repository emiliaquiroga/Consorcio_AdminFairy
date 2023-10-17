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
    public partial class FrmExpensas : Form
    {
        public FrmExpensas()
        {
            InitializeComponent();
        }

        private void FrmVerExpensas_Load(object sender, EventArgs e)
        {
            ActualizarLabelSegunHora();
        }
        private void ActualizarLabelSegunHora()
        {
            DateTime horaActual = DateTime.Now;
            string mensaje = "";

            switch (horaActual.Hour)
            {
                case >= 0 and < 6:
                    mensaje = "¡Buenas noches!";
                    break;
                case >= 6 and < 12:
                    mensaje = "¡Buenos días!";
                    break;
                case >= 12 and < 20:
                    mensaje = "¡Buenas tardes!";
                    break;
                default:
                    mensaje = "¡Buenas noches!";
                    break;
            }

            lblSaludo.Text = mensaje;
        }
    }
}
