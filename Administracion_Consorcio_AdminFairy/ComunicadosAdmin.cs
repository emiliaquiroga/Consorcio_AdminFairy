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
    public partial class FrmComunicados : Form
    {
        List<string> comunicados;

        public FrmComunicados()
        {
            InitializeComponent();

        }
        private void FrmComunicados_Load(object sender, EventArgs e)
        {
            comunicados = new List<string>();

            
        }


        private void rchtxtAdmi_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void rchtxtComunicado_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
