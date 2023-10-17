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
        public string nombre;
        public string path;
        public string ruta;

        public InicioAdmin()
        {
            InitializeComponent();

        }
        private void InicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnVerVecinos_Click(object sender, EventArgs e)
        {
            FrmListadoUsuarios listausuarios = new FrmListadoUsuarios();

            listausuarios.MdiParent = this;
            listausuarios.Show();
        }

        private void btnComunicados_Click(object sender, EventArgs e)
        {
            FrmComunicados com = new FrmComunicados();
            com.MdiParent = this;
            com.Show();
        }
    }
}
