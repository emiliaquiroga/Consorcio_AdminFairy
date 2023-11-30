using Entidades.Serializadores;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB
{
    public class DB
    {
        public static MySqlConnection connectionMysql;
        public static MySqlCommand commandMySql;
        public static MySqlDataAdapter adapter;

        static DB()
        {
            var mysqlStringConnection = "Server=localhost;Database=listadovecinos;Uid=root;Pwd=;";
            connectionMysql = new MySqlConnection(mysqlStringConnection);

            commandMySql = new MySqlCommand();
            commandMySql.CommandType = System.Data.CommandType.Text;
            commandMySql.Connection = connectionMysql;
        }

        public static void InsertarVecino(Vecino vecino)
        {
            try
            {
                connectionMysql.Open();

                var query = "INSERT INTO vecinos (`Estado`, `expensas`, `dni`, `nombre`, `apellido`, `correoElectronico`, `ciudad`, `torre`, `piso`, `unidad`, `clave`) " +
                            "VALUES (@duenioInquilino, @expensas, @dni, @nombre, @apellido, @email,  @ciudad, @edificio, @pisoVivienda, @unidadVivienda, @clave)";

                commandMySql.CommandText = query;
                commandMySql.Parameters.Clear();

                // Agregar parámetros según la estructura de la tabla vecinos
                commandMySql.Parameters.AddWithValue("@duenioInquilino", vecino.DuenioInquilino);
                commandMySql.Parameters.AddWithValue("@expensas", vecino.Expensas);
                commandMySql.Parameters.AddWithValue("@dni", vecino.Dni);
                commandMySql.Parameters.AddWithValue("@nombre", vecino.Nombre);
                commandMySql.Parameters.AddWithValue("@apellido", vecino.Apellido);
                commandMySql.Parameters.AddWithValue("@email", vecino.Email);
                commandMySql.Parameters.AddWithValue("@ciudad", vecino.Ciudad);
                commandMySql.Parameters.AddWithValue("@edificio", vecino.Edificio);
                commandMySql.Parameters.AddWithValue("@pisoVivienda", vecino.PisoVivienda);
                commandMySql.Parameters.AddWithValue("@unidadVivienda", vecino.UnidadVivienda);
                commandMySql.Parameters.AddWithValue("@clave", vecino.Clave);


                var filasAfectadas = commandMySql.ExecuteNonQuery();
                Console.WriteLine($"Número de filas afectadas: {filasAfectadas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                connectionMysql.Close();
            }
        }

        public static List<T> Select<T>(string query, Func<MySqlDataReader, T> mapFunc) where T : ICRUDOperaciones<T>
        {
            var lista = new List<T>();
            try
            {
                connectionMysql.Open();

                commandMySql.CommandText = query;

                using (var reader = commandMySql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = mapFunc(reader);
                        lista.Add(objeto);
                    }
                }
                return lista;
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
        public static bool UsuarioExiste(string dni)
        {
            try
            {
                connectionMysql.Open();

                var query = "SELECT COUNT(*) FROM vecinos WHERE DNI = @dni";
                commandMySql.CommandText = query;
                commandMySql.Parameters.Clear();
                commandMySql.Parameters.AddWithValue("@dni", dni);

                var resultado = (long)commandMySql.ExecuteScalar();

                return resultado > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                connectionMysql.Close();
            }
        }

        public static Vecino AutenticarVecino(string dni, string clave)
        {
            try
            {
                connectionMysql.Open();

                var query = "SELECT * FROM vecinos WHERE DNI = @dni AND Clave = @clave";
                commandMySql.CommandText = query;
                commandMySql.Parameters.Clear();
                commandMySql.Parameters.AddWithValue("@dni", dni);
                commandMySql.Parameters.AddWithValue("@clave", clave);

                using (var reader = commandMySql.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Vecino
                        {
                            Dni = reader["DNI"].ToString(),
                            Clave = reader["Clave"].ToString(),
                        };
                    }
                    else
                    {
                        return null; // datos incorrectos
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al autenticar vecino: {ex.Message}");
            }
            finally
            {
                connectionMysql.Close();
            }
        }


    }

}


