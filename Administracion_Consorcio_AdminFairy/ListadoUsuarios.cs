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
    public partial class FrmListadoUsuarios : Form
    {
        string ruta;
        string nombre;
        string path;
        List<Vecino> lista;
        public FrmListadoUsuarios()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.nombre = @"\UsuariosRegistradosJson.json";
            this.path = ruta + nombre;
            lista = new List<Vecino>();
        }
        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            lista = Serializadora.LeerJson(path);
            dtgUsuariosRegistrados.DataSource = null;
            dtgUsuariosRegistrados.DataSource = lista;
        }



    }
}
