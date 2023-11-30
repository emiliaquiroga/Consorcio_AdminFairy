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
using MySql.Data.MySqlClient;
using Entidades.DB;

namespace Administracion_Consorcio_AdminFairy
{
    public partial class FrmListadoUsuarios : Form
    {


        string consulta = "SELECT * FROM vecinos";
        int indexRow;

        public FrmListadoUsuarios()
        {
            InitializeComponent();

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=listadovecinos;Uid=root;Pwd=;"))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, connection))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        dtgUsuariosRegistrados.DataSource = tabla;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            dtgUsuariosRegistrados.ReadOnly = false;
            dtgUsuariosRegistrados.CellEndEdit += DtUsuariosRegistrados_CellEndEdit;
        }

        private void DtUsuariosRegistrados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dtgUsuariosRegistrados.Rows[e.RowIndex];
            DataGridViewCell cell = dgvRow.Cells[e.ColumnIndex];

            if (cell.OwningColumn.DataPropertyName == "Estado")
            {
                DataRowView dataRowView = (DataRowView)dgvRow.DataBoundItem;
                DataRow dataRow = dataRowView.Row;

                dataRow["Estado"] = cell.Value;

                // Asegúrate de actualizar el campo correcto en tu base de datos
                ActualizarBaseDeDatos(dataRow);
            }
        }

        private void dtgUsuariosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            
            DataGridViewRow fila = dtgUsuariosRegistrados.Rows[indexRow];

            // Asegúrate de utilizar nombres de columnas o índices constantes
            txtEstado.Text = fila.Cells["Estado"].Value.ToString();
            txtExpensas.Text = fila.Cells["situacion_expensa"].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow nuevaFila = dtgUsuariosRegistrados.Rows[indexRow];
                if (nuevaFila.DataBoundItem is DataRowView dataFilaView)
                {
                    DataRow dataFila = dataFilaView.Row;
                    dataFila["Estado"] = txtEstado.Text;
                    dataFila["situacion_expensa"] = txtExpensas.Text;

                    
                    ActualizarBaseDeDatos(dataFila);

                    
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error: DataBoundItem is null or not a DataRowView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ActualizarBaseDeDatos(DataRow row)
        {
            try
            {

                DataGridViewRow fila = dtgUsuariosRegistrados.Rows[indexRow];
                int dni = (int)fila.Cells["DNI"].Value;

                using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=listadovecinos;Uid=root;Pwd=;"))
                {
                    connection.Open();

                    // Debugging statements
                    Console.WriteLine($"Estado: {row["Estado"]}");
                    Console.WriteLine($"Expensa: {row["situacion_expensa"]}");
                    Console.WriteLine($"DNI: {dni}");

                    // Construye la sentencia UPDATE con parámetros
                    string updateQuery = "UPDATE vecinos SET Estado = @estado, situacion_expensa = @expensa WHERE DNI = @dni";
                    MySqlCommand update = new MySqlCommand(updateQuery, connection);

                    // Agrega parámetros con sus valores
                    update.Parameters.AddWithValue("@estado", row["Estado"]);
                    update.Parameters.AddWithValue("@expensa", row["situacion_expensa"]);
                    update.Parameters.AddWithValue("@dni", dni);

                    update.ExecuteNonQuery();

                    // Use the existing adapter to update the DataTable
                    if (dtgUsuariosRegistrados.DataSource is DataTable dataTable)
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, connection))
                        {
                            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                            adapter.UpdateCommand = builder.GetUpdateCommand();
                            adapter.Update(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje de error
                SerializadorTXT<Errores> serializador = new SerializadorTXT<Errores>();
                serializador.RegistrarError(ex.Message, ex.GetType().ToString(), "ListadoUsuarios > ActualizarBaseDeDatos");
            }
        }



    }

}
