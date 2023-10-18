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
    public partial class ComunicadosVecinos : Form
    {
        public ComunicadosVecinos()
        {
            InitializeComponent();
        }

        private void ComunicadosVecinos_Load(object sender, EventArgs e)
        {

        }

        private void rchtxtComunicado_TextChanged(object sender, EventArgs e)
        {
            rchtxtComunicado.Text = "";
        }
    }
}
