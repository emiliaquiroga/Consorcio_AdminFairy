using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Serializadores
{
    public class SerializadorXML<T> : Serializador<T> where T : class
    {
        string ruta;
        string nombre;
        string path;

    public SerializadorXML(string path) : base(path)
    {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            nombre = @"\ArchivoXML.xml";
            path = ruta + nombre;
        }
    public bool Serializar(T datos)
    {
        try // Intentamos ejecutar el siguiente código: 
        {
            using (StreamWriter sw = new StreamWriter(this.path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(sw, datos);
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erorr al serializar");
            return false;
        }

    }

    public List<T> Deserializar()
    {
        var lista = new List<T>();
        try
        {
            using (var stream = new StreamReader(this.path))
            {
                var des = new XmlSerializer(typeof(List<T>));

                lista = (List<T>)des.Deserialize(stream);
            }
            return lista;
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.ToString());  // Nos mostrará su mensaje.

        }

        return lista;
    }
}
}
