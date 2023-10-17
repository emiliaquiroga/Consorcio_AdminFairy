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
    public partial class FrmListadoUsuarios : Form
    {
        string ruta;
        string nombre;
        string path;
        public FrmListadoUsuarios()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.nombre = @"\UsuariosRegistradosJson.json";
            this.path = ruta + nombre;
        }

        private void dtgUsuariosRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgUsuariosRegistrados.DataSource = path;
        }
    }
}
