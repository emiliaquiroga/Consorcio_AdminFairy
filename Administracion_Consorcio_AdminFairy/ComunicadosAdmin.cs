using Entidades.Serializadores;
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
        string ruta;
        string path;
        string comunicado;

        List<string> comunicadosCreados;

        public FrmComunicados()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.path = ruta + @"\Comunicados.json";
            comunicadosCreados = new List<string>();
            rchtxtComunicadoAdmin.ReadOnly = false;

        }
        private void FrmComunicados_Load(object sender, EventArgs e)
        {
            string comunicado = rchtxtComunicadoAdmin.Text;
            Serializadora.EscribirJsonComunicado(comunicado);
            comunicadosCreados = Serializadora.LeerJsonComunicado(path);

        }


        private void rchtxtAdmi_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            foreach (string elemento in comunicadosCreados)
            {
                rchtxtComunicadoAdmin.Text = $"{elemento}\n";
            }

        }

        private void rchtxtComunicado_TextChanged(object sender, EventArgs e)
        {

            rchtxtComunicadoAdmin.ReadOnly = true;

        }


    }
}
