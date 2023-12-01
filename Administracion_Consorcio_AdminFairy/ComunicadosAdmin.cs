using Entidades.Serializadores;
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
    public delegate void ComunicadoEnviadoEventhandler(string comunicado);

    public partial class FrmComunicados : Form
    {
        string ruta;
        string path;
        string comunicado;

        List<string> comunicadosCreados;

        
        public event ComunicadoEnviadoEventhandler ComunicadoEnviado;

        public FrmComunicados()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.path = ruta + @"\Comunicados.json";
            comunicadosCreados = new List<string>();
            rtbComunicadoAdmin.ReadOnly = false;

        }

        private void FrmComunicados_Load(object sender, EventArgs e)
        {
            comunicado = rtbComunicadoAdmin.Text;
            comunicadosCreados = Serializadora.LeerJsonComunicado(path);

        }


        private void btnPublicarComunicado_Click(object sender, EventArgs e) // Efectivamente se ven en el json (creado manualmente), pero no se ven en el otro form
        {
            EnviarComunicado();
            Serializadora.EscribirJsonComunicado(rtbComunicadoAdmin.Text);
        }

        private void EnviarComunicado()
        {
            comunicado = rtbComunicadoAdmin.Text;
            ComunicadoEnviado?.Invoke(comunicado);
        }
    }
}
