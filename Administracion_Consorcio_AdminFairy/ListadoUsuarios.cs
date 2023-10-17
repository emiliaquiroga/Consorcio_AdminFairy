using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Administracion_Consorcio_AdminFairy
{
    public partial class FrmListadoUsuarios : Form
    {
        string ruta;
        string nombre;
        string path;
        List<Vecino> listaVecinos;
        public FrmListadoUsuarios()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.nombre = @"\UsuariosRegistrados.xml";
            this.path = ruta + nombre;
            listaVecinos = new List<Vecino>();
        }

        private void dtgUsuariosRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgUsuariosRegistrados.DataSource = path;
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            listaVecinos = Serializadora.LeerXML(path);
            dtgUsuariosRegistrados.DataSource = null;
            dtgUsuariosRegistrados.DataSource = listaVecinos;

        }
    }
}
