using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Xml;



namespace Entidades
{
    
    public class Serializadora
    {
      
        /*    
         Tuve que cambiar los tipos Usuario por tipo Vecino, por la razón de que, en los métodos queríamos instanciar listas de tipo Usuario, y me tiraba excepciones, ya que 
        como Usuario es una clase de tipo Abstracta, esta no se puede instanciar. En fin, YA NOS PODEMOS REGISTRAR EXITOSAMENTE!!!
        pd: EscribirXMl funciona como EscribirArchivos, nomás dejo una indicación en la primera así te ubicas en pasos. Dsps documentamos bien
         */
        public static void EscribirXML(string pathXML, Vecino usuario) // Pasamos como parámetro la ruta donde estará ubicado el archivo xml y al usuario a agregar de tipo vecino
        {
            try // Intentamos ejecutar el siguiente código: 
            {
                List<Vecino> lista; // Declaramos una lista del tipo vecino 

                if (File.Exists(pathXML))  // Si el archivo existe en la ruta pasada por parámetro...
                {
                    lista = LeerXML(pathXML); // Va a leer y deserializar la lista 
                }
                else // Si el archivo no existe...
                {
                    lista = new List<Vecino>(); // Va a crear una lista nueva de usuarios.
                }
                lista.Add(usuario); // Ya sean cualquiera de los dos casos, va a agregar un nuevo al archivo

                using (StreamWriter sw = new StreamWriter(pathXML)) // Abrimos el archivo xml
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Vecino>)); // Indicamos que tipo de objeto vamos a serialzar.
                    ser.Serialize(sw, lista); // Serializamos la lista de tipo vecino a un formato xml
                }
            }
            catch (Exception ex) // Sino encontramos alguna excepción en el camino... 
            {
                Console.WriteLine(ex.ToString());  // Nos mostrará su mensaje.
            }

        }
        //public static void EscribirJsonComunicado(string comunicado)
        //{
        //    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // donde va a estar ubicado
        //    string path = ruta + @"\Comunicados.json";
            
        //    try
        //    {
        //        List<string> listaComunicados;

        //        if (File.Exists(path))
        //        {
        //            listaComunicados = LeerJsonComunicado(path);
        //        }
        //        else
        //        {
        //            listaComunicados = new List<string>();
        //        }

        //        listaComunicados.Add(comunicado);
        //        string json = JsonConvert.SerializeObject(listaComunicados, Newtonsoft.Json.Formatting.Indented);
        //        File.WriteAllText(path, json);
        //    }
        //    catch (IOException ex)
        //    {
        //        Console.WriteLine($"Error de E/S al leer/escribir el archivo JSON: {ex.ToString()}");
                
        //    }

        //}
        //public static List<string> LeerJsonComunicado(string path)
        //{
        //    List<string> lista = new List<string>();
        //     string json = File.ReadAllText(path);

        //    try
        //    {
               
        //        lista = JsonConvert.DeserializeObject<List<string>>(json);

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error while parsing JSON:");
        //        Console.WriteLine(e.ToString());
        //        Console.WriteLine("JSON Content:");
        //        Console.WriteLine(json); // Add this line to log the JSON content causing the issue.
        //    }
        //    return lista;

        //}


        public static List<Vecino> LeerXML(string path)
        {
            List<Vecino> lista;
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer des = new XmlSerializer(typeof(List<Vecino>));

                lista = (List<Vecino>)des.Deserialize(sr);
            }
            return lista;
        }

        public static void EscribirArchivos(string pathJson, string pathXML, Vecino usuario) 
            /* EscribirJson pasó a ser llamado así, ya que, incluimos el método EscribirXml, lo cual hace que se creen los dos archivos
             *aparentemente "al mismo tiempo" */
        {
            try
            {
                List<Vecino> lista; 

                if (File.Exists(pathJson))
                {
                    lista = LeerJson(pathJson);
                }
                else 
                {
                    lista = new List<Vecino>();
                }

                lista.Add(usuario);
                string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(pathJson, json);

                EscribirXML(pathXML, usuario);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S al leer/escribir el archivo JSON: {ex.ToString()}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error al deserializar/serializar JSON: {ex.ToString()}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error inesperado! : { ex.ToString()}");
            }

        }

        public static List<Vecino> LeerJson(string path)
        {
            List<Vecino> lista = new List<Vecino>();
            string json = File.ReadAllText(path);

            try
            {
                
                lista = JsonConvert.DeserializeObject<List<Vecino>>(json);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while parsing JSON:");
                Console.WriteLine(e.ToString());
                Console.WriteLine("JSON Content:");
                Console.WriteLine(json); // Add this line to log the JSON content causing the issue.
            }
            return lista;
        }
        public static void ActualizarVecinoEnJson(string pathJson, Vecino vecino)
        {
            try
            {
                List<Vecino> lista = LeerJson(pathJson);

                // Busca el vecino que se va a actualizar
                Vecino vecinoExistente = lista.FirstOrDefault(v => v.Dni == vecino.Dni);

                if (vecinoExistente != null)
                {
                    // Actualiza la propiedad EstadoVecino
                    vecinoExistente.EstadoVecino = vecino.EstadoVecino;

                    // Guarda la lista actualizada en el archivo JSON
                    string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(pathJson, json);
                    
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S al leer/escribir el archivo JSON: {ex.ToString()}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error al deserializar/serializar JSON: {ex.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.ToString()}");
            }
        }

    }

}
