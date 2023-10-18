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
    public partial class ComunicadosVecinos : Form
    {
        string ruta;
        string path;
        List<string> comunicadosCreados;
        public ComunicadosVecinos()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.path = ruta + @"\Comunicados.json";
            comunicadosCreados = new List<string>();
            rchtxtComunicado.ReadOnly = true;
        }

        private void ComunicadosVecinos_Load(object sender, EventArgs e)
        {
            //comunicadosCreados = Serializadora.LeerJsonComunicado(path);
        }

        private void rchtxtComunicado_TextChanged(object sender, EventArgs e)
        {
            //string comunicado = rchtxtComunicado.Text;
            //Serializadora.EscribirJsonComunicado(comunicado);
            //comunicadosCreados = Serializadora.LeerJsonComunicado(this.path);

            foreach (string elemento in comunicadosCreados)
            {
                rchtxtComunicado.Text = $"{elemento}\n";
            }
        }
    }
}
