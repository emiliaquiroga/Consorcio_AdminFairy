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
    public partial class FrmExpensas : Form
    {
        Vecino vecino;

        public FrmExpensas(Vecino vecino)
        {
            InitializeComponent();
            rtbExpensas.ReadOnly = true;
            this.vecino = vecino;
        }

        private void FrmVerExpensas_Load(object sender, EventArgs e)
        {
            rtbExpensas.Text = $"Sus expensas de mes son de ${vecino.Expensas}";
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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pago ha sido efectuado. " +
                "¡Usted está al día! :) ");
        }
    }
}
