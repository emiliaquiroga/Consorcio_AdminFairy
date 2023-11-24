using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Serializadores
{

    public class Serializador<T> : ISerializable<T>
    {
        public string Path { get; set; }

        public Serializador()
        {
                
        }
        public Serializador(string path)
        {
            Path = path;
        }

        //public bool VerificaArchivo(string path)
        //{
        //    try
        //    {
        //        List<T> lista;


        //        if (File.Exists(path))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        //excepcion para el archivo.txt
        // return false;

        //    }
        //}

        bool ISerializable<T>.Serializar(T datos)
        {
            throw new NotImplementedException();
        }

        List<T> ISerializable<T>.Deserializar()
        {
            throw new NotImplementedException();
        }
    }
}
