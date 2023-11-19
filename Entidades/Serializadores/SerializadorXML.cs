//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Runtime.Serialization;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;

//namespace Entidades.Serializadores
//{
//    public class SerializadorXML<T> : Serializador, ISerializable<T> 
//    {
//        public SerializadorXML(string path) : base(path)
//        {

//        }
//        public bool Serializar(T datos)
//        {
//            try // Intentamos ejecutar el siguiente código: 
//            {
//                // ESTO VA CUANDO QUERRAMOS SERIALIZAR
//                //List<Vecino> lista; // Declaramos una lista del tipo vecino 

//                //if (File.Exists(Path))  // Si el archivo existe en la ruta pasada por parámetro...
//                //{
//                //    lista = Deserializar(); // Va a leer y deserializar la lista 
//                //}
//                //else // Si el archivo no existe...
//                //{
//                //    lista = new List<Vecino>(); // Va a crear una lista nueva de usuarios.
//                //}
//                //lista.Add(datos); // Ya sean cualquiera de los dos casos, va a agregar un nuevo al archivo
//             using (StreamWriter sw = new StreamWriter(Path))
//                {
//                    XmlSerializer ser = new XmlSerializer(typeof(T));
//                    ser.Serialize(sw, datos);
//                }
//                return true;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Erorr al serializar");
//                return false;
//            }
   
//        }

//        public List<T> Deserializar()
//        {
//            var lista = new List<T>();
//            try
//            {
//                using (var stream = new StreamReader(Path))
//                {
//                    var des = new XmlSerializer(typeof(List<T>));

//                    lista = (List<T>)des.Deserialize(stream);
//                }
//                return lista;
//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.ToString());  // Nos mostrará su mensaje.

//            }
            
//            return lista;
//        }
//    }
//}

///*
//this.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
//this.nombreXml = @"\UsuariosRegistrados.xml"; // nombre del archivo
//this.nombreJson = @"\UsuariosRegistradosJson.json";
//this.pathJson = ruta + nombreJson;
//this.pathXml = ruta + nombreXml;
// */