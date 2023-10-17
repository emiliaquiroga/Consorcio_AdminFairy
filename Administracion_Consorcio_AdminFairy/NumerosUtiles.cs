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
    public partial class NumerosUtiles : Form
    {
        public NumerosUtiles()
        {
            InitializeComponent();
        }
        private void NumerosUtiles_Load(object sender, EventArgs e)
        {
            rchtxtTelefonos.Text = "";
        }
        private void btnAscensor_Click(object sender, EventArgs e)
        {
            rchtxtTelefonos.Text = "Técnico Ascensor:\nChiquiTapia Ascensores\nTel: 11 2832 8108\nViamonte 1366, CABA";
        }

        private void btnPlomero_Click(object sender, EventArgs e)
        {
            rchtxtTelefonos.Text = "Plomería:\nPepe Plomero\nTel: 011 2245-4625\nViamonte 1366, CABA";

        }

        private void btnCerrajero_Click(object sender, EventArgs e)
        {
            rchtxtTelefonos.Text = "Cerrajero 24hs:\nCerrajería Mario Bros\nTel: 011 2345-2345\nJulián Alvarez 0912, CABA";
        }
    }
}
