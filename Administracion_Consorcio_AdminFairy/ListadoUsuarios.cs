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
using Entidades.Serializadores;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class FrmListadoUsuarios : Form
    {
        string ruta;
        string nombre;
        string path;
        EstadoVecino estadoVecino;
        List<Vecino> listaVecinos;
        //Vecino selectedNeighbor; // Track the selected neighbor



        public FrmListadoUsuarios()
        {
            InitializeComponent();
            this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.nombre = @"\UsuariosRegistradosJson.json";
            this.path = ruta + nombre;
            listaVecinos = new List<Vecino>();

        }
        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            cmbxEstadoVecino.DataSource = Enum.GetValues(typeof(EstadoVecino));
            listaVecinos = Serializadora.LeerJson(path);

            // Enlaza la lista de vecinos al DataGridView
            dtgUsuariosRegistrados.DataSource = listaVecinos;

            // Habilita la edición de celdas en el DataGridView
            dtgUsuariosRegistrados.ReadOnly = false;

            // Maneja el evento CellEndEdit para guardar los cambios en el JSON
            dtgUsuariosRegistrados.CellEndEdit += DtUsuariosRegistrados_CellEndEdit;
        }

        //este metodo no funciona del todo bien, porque creo que estan mal los getters y setters en vecino
        private void DtUsuariosRegistrados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Obtiene la fila y la celda editada
            DataGridViewRow row = dtgUsuariosRegistrados.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];

            // Verifica si la celda editada es la columna EstadoVecino
            if (cell.OwningColumn.DataPropertyName == "EstadoVecino")
            {
                // Obtiene el valor seleccionado en el ComboBox
                EstadoVecino estadoSeleccionado = (EstadoVecino)cell.Value;

                // Actualiza el valor en el objeto Vecino correspondiente en la lista
                Vecino vecino = (Vecino)row.DataBoundItem;
                vecino.EstadoVecino = estadoSeleccionado;

                // Llama al método para actualizar el JSON
                Serializadora.ActualizarVecinoEnJson(path, vecino);
                dtgUsuariosRegistrados.Refresh();
            }
        }
    }
}
