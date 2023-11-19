using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Serializadores
{
    public class SerializadorJSON : Serializador, ISerializable<T>
    {
        public SerializadorJSON(string path) : base(path)
        {
        }

        public bool Serializar(T datos)
        {
            //try
            //{
            //    List<Vecino> lista;

            //    if (File.Exists(Path))
            //    {
            //        lista = Deserializar(Path);
            //    }
            //    else
            //    {
            //        lista = new List<Vecino>();
            //    }

            //    lista.Add(usuario);
            try
            {
                using (var stream = new StreamWriter(Path))
                {
                    var options = new JsonSerializerOptions();
                    options.WriteIndented = true;

                    string json = JsonConvert.SerializeObject(typeof(T), Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Path, json);

                }
                return true;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S al leer/escribir el archivo JSON: {ex.ToString()}");
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                Console.WriteLine($"Error al deserializar/serializar JSON: {ex.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erorr al serializar");
                return false;
            }

        }
        //public List<T> Deserializar()
        //{
        //    List<T> lista = new List<T>();
        //    string json = "";

        //    try
        //    {
        //        json = File.ReadAllText(path);
        //        lista = JsonConvert.DeserializeObject<List<Vecino>>(json);
        //    }

        //}
    }
}
