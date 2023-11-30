using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DB
{
    public interface ICRUDOperaciones<T>
    {

        string Update();

        void Insert();
        List<T> Select();
    }
}
