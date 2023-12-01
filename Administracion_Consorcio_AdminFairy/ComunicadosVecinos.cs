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
    public partial class ComunicadosVecinos : Form
    {
        string ruta;
        string path;
        List<string> comunicadosCreados;
        FrmComunicados comunicadosEscritos;


        public ComunicadosVecinos()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
            this.path = ruta + @"\Comunicados.json";
            comunicadosCreados = new List<string>();
            rtbComunicado.ReadOnly = true;

            comunicadosEscritos = new FrmComunicados();
            comunicadosEscritos.ComunicadoEnviado += MostrarComunicado;
        }

        private async void ComunicadosVecinos_Load(object sender, EventArgs e)
        {
            try
            {
                // Si los comunicados son demasiados, podría llegar a realentizar/congelar la carga del form, por eso lo hacemos asincronico
                comunicadosCreados = await Task.Run(() => Serializadora.LeerJsonComunicado(path));
            }
            catch
            {
                throw new SinContenidoException("¡Nada que ver por aquí, todavía no hay comunicados!");
            }

        }

        private void rchtxtComunicado_TextChanged(object sender, EventArgs e)
        {
            //string comunicado = rchtxtComunicado.Text;
            //Serializadora.EscribirJsonComunicado(comunicado);
            comunicadosCreados = Serializadora.LeerJsonComunicado(this.path);
            rtbComunicado.Text = string.Join("\n", comunicadosCreados);

        }

        private void MostrarComunicado(string comunicado)
        {
            rtbComunicado.Text = comunicado;
        }
    }
}
