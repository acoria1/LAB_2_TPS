using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Entidades.Materiales;
using Entidades;
using System.Windows.Forms;
using Entidades.Excepciones;

namespace Entidades
{
    public delegate string NombraArchivo<T>(T miObjeto);
    public static class Serializer<T>
    {
        public static NombraArchivo<T> nombraArchivo; 
        /// <summary>
        /// Serializa una lista de objetos al path indicado
        /// Si el path no existe lo crea
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool SerializeListXML(List<T> lista,string path) 
        {     
            if (!ValidateOrCreatePath(path) || nombraArchivo == null)
            {
                return false;
            }

            foreach (T item in lista)
            {
                if (item != null)
                {
                    XmlTextWriter xmlTextWriter = new XmlTextWriter($@"{path}\{nombraArchivo(item)}.xml", Encoding.UTF8);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(xmlTextWriter, item);
                    xmlTextWriter.Close();                               
                }              
            }
            return true;                    
        }

        /// <summary>
        /// Deserializa archivos XML en una lista genérica. Busca en el path indicado.
        /// Lanza exepción si el directorio no existe
        /// </summary>
        /// <param name="myList"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool DeserializeListXML(List<T> myList, string path)
        {
            if (!Directory.Exists(path))
            {
                throw new ArchivoInvalidoException($"{path}");
            }
            foreach (string item in Directory.GetFiles(path, "*.xml"))
            {
                XmlTextReader xmlTextReader = new XmlTextReader(item);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                myList.Add((T)xmlSerializer.Deserialize(xmlTextReader));
                xmlTextReader.Close();
            }
            return true;
        }        

        /// <summary>
        /// Valida que existe un Directorio, Lo crea si no existe.
        /// Atrapa excepciones y devuelve false en caso de error
        /// </summary>
        /// <param name="path">Directorio a validar</param>
        /// <returns>true si lo pudo crear o existe
        /// false si se lanzó una excepción</returns>
        static bool ValidateOrCreatePath (string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);                  
                }
                return true;
            }
            catch 
            {
                return false;
            }           
        }

        /// <summary>
        /// Borra archivos de un directorio.
        /// </summary>
        /// <param name="path">Directorio del cual elimina archivos</param>
        public static void ClearDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                foreach (string item in Directory.GetFiles(path))
                {
                    File.Delete(item);
                }
            }
        }
    }
}
