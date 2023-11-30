using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB
{
    public class MySQLCrud<T> where T : ICRUDOperaciones<T>
    {
        private string _tableName;
        private string[] _columnas;

        public MySQLCrud(string tableName, string[] columnas)
        {
            _tableName = tableName;
            _columnas = columnas;
        }

        public MySQLCrud(string tableName)
        {
            _tableName = tableName;
        }

        public List<T> GetAll()
        {
            var query = $"SELECT {string.Join(",", _columnas)} FROM {_tableName}";
            return DB.Select(query, MapFromReader);
        }

        private T MapFromReader(MySqlDataReader reader)
        {
            return (T)Activator.CreateInstance(typeof(T), reader);
        }

    }

}

