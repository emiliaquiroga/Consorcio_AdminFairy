using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB
{
    public class DB
    {
        public static MySqlConnection connectionMysql; // MySQL 
        public static MySqlCommand commandMySql;

        static DB()
        {
            //var sqlStringConnection = @"Encrypt=False;TrustServerCertificate=True;";
            var mysqlStringConnection = @"Server = localhost;Database=listadovecinos;Uid=root;Pwd=;";
            //connection = new SqlConnection(sq)// cadena de conección
            connectionMysql = new MySqlConnection(mysqlStringConnection);

            commandMySql = new MySqlCommand();
            commandMySql.CommandType = System.Data.CommandType.Text;
            commandMySql.Connection = connectionMysql;
        }
        public static void Insert()
        {
            try
            {
                connectionMysql.Open();
                var query = $"INSERT INTO proveedores (`Nombre`, `Domicilio`, `Localidad`) VALUES ('@nombre','@domicilio','@localidad')";
                commandMySql.CommandText = query;
                var filasAfectadas = commandMySql.ExecuteNonQuery(); //DEVUELVE UN ENTERO
                commandMySql.Parameters.AddWithValue("@nombre", Nombre);
                commandMySql.Parameters.AddWithValue("@domicilio", Domicilio);
                commandMySql.Parameters.AddWithValue("@localidad", Localidad);
                Console.WriteLine($"Numero de filas afectadas: {filasAfectadas}");


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connectionMysql.Close();
            }

        }


        public static void Select<TS>()
        {
            try
            {
                connectionMysql.Open();
                var query = "SELECT * FROM proveedores";

                commandMySql.CommandText = query;

                using (var reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VecinoADO objeto = VecinoADO(MySqlDataReader v);
                        //var nombre = reader["Nombre"].ToString() ?? "";
                        //var id = Convert.ToInt32(reader["Numero_Proveedor"]);
                        //Console.WriteLine($"Numero Proveedor: {id}   nombre: {nombre}");

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connectionMysql.Close();
            }
        }
        public static void OpenConnection()
        {
            connectionMysql.Open();

        }
    }
}
    

