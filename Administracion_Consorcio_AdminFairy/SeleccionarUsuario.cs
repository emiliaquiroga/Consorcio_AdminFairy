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
    public partial class SeleccionarUsuario : Form
    {
        public SeleccionarUsuario()
        {
            InitializeComponent();
        }

        /*
         por au¡hora los radio button no tiene mucha lógica armada, pero pensaría que:
        Al seleccionar algún tipo de usuario, debería retornar los datos de mismo, y de ahí cerrarse el form, pero faltan los datos
        del registro
         */
        private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void rdoVecino_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
        }
    }
}
