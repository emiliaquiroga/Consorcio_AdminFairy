using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB
{
    public class VecinoADO : MySQLCrud<VecinoADO>, ICRUDOperaciones<VecinoADO>

    {
        private static readonly string[] columnas = ["Estado", "situacion_expensa"];

        public string Estado { get; set; }
        public string situacion_expensa { get; set; }

        public VecinoADO(string estado, string situacionExpensa) : base("vecinos", columnas)
        {
            Estado = estado;
            situacion_expensa = situacionExpensa;
        }

        public List<VecinoADO> Select()
        {
            var personas = GetAll();
            return personas;
        }

        string ICRUDOperaciones<VecinoADO>.Update()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public static explicit operator VecinoADO(MySqlDataReader reader)
        {
            var estado = reader["Estado"].ToString() ?? "";
            var situacionExpensa = reader["situacion_expensa"].ToString() ?? "";
            return new VecinoADO(estado, situacionExpensa);
        }
    }
}

