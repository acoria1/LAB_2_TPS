using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelos;
using Entidades.Excepciones;
using Entidades.Muebles;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Concurrent;
using Entidades.Materiales;

namespace Entidades
{
    public class Fabrica
    {
        public Dictionary<string, Material> stockMateriales;
        public Dictionary<string, Modelo> modelosDisponibles;
        public List<Mueble> stockMuebles;
        public ConcurrentQueue<Mueble> mueblesEnProduccion;

        #region Constructores
        /// <summary>
        /// Inicializa todas las colecciones
        /// </summary>
        public Fabrica()
        {
            stockMateriales = new Dictionary<string, Material>();
            modelosDisponibles = new Dictionary<string, Modelo>();
            stockMuebles = new List<Mueble>();
            mueblesEnProduccion = new ConcurrentQueue<Mueble>();
        }

        #endregion
        #region Propiedades

        public Modelo this[string identificador]
        {
            get
            {
                Modelo modeloRetorno = null;
                foreach (KeyValuePair<string, Modelo> item in this.modelosDisponibles)
                {
                    if (item.Key == identificador)
                    {
                        modeloRetorno = item.Value;
                    }
                }
                return modeloRetorno;
            }
        }
        #endregion
        #region Operaciones con materiales
        /// <summary>
        /// True si el material existe en mi fabrica, tenga o no stock.
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="material"></param>
        /// <returns></returns>
        public static bool operator == (Fabrica fabrica, Material material)
        {
            if (material is null)
            {
                return false;
            }
            Material materialExistente;  
            return fabrica.stockMateriales.TryGetValue(material.Key, out materialExistente);
        }

        public static bool operator !=(Fabrica fabrica, Material material)
        {
            return !(fabrica == material);
        }

        /// <summary>
        /// Si existe en mi fábrica, agrego el peso adecuado
        /// SI no existe el material lo creo y lo agrego a mi fabrica
        /// 
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="material"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica fabrica, Material material)
        {
            if (material is null)
            {
                return fabrica;
            }
            Material materialExistente;
            if (fabrica == material)
            {
                fabrica.stockMateriales.TryGetValue(material.Key, out materialExistente);
                materialExistente.AgregarPeso(material.PesoEnKG);
            } else
            {
                fabrica.stockMateriales.Add(material.Key, material);
            }
            return fabrica;
        }

        /// <summary>
        /// Gastará peso de material indicado de ser posible. 
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="material"></param>
        /// <returns> True si pudo gastar </returns>
        public static bool operator -(Fabrica fabrica, Material material)
        {
            bool sePudoGastar = false;
            Material materialExistente;
            double diferencia;
            if (fabrica.PuedeGastarMaterial(material, out diferencia)) 
            {
                fabrica.stockMateriales.TryGetValue(material.Key, out materialExistente);
                materialExistente.Gastar(material.PesoEnKG);
                sePudoGastar = true;    
            }
            return sePudoGastar;
        }

        /// <summary>
        /// Muestra los materiales en mi fábrica. Utilizado solo en pruebas de consola.
        /// </summary>
        /// <returns></returns>
        public string MostrarStockMateriales()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Material item in this.stockMateriales.Values)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        #endregion
        #region operaciones con modelos
        /// <summary>
        /// Dos modelos son iguales si tienen mismo nombre o si todos sus otros campos son iguales
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public static bool operator ==(Fabrica fabrica, Modelo modelo)
        {
            if (modelo == null)
            {
                return false;
            }
            bool esta = false;
            foreach (Modelo item in fabrica.modelosDisponibles.Values)
            {
                if (item.Equals(modelo) || modelo.Nombre == item.Nombre)
                {
                    esta = true;
                }
            }
            return esta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="modelo"></param>
        /// <returns>true si el modelo no existe en mi fábrica</returns>
        public static bool operator !=(Fabrica fabrica, Modelo modelo)
        {
            return !(fabrica == modelo);
        }

        /// <summary>
        /// Añade modelo a mi fábrica
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica fabrica, Modelo modelo)
        {
            if (modelo != null && fabrica != modelo)
            {
                fabrica.modelosDisponibles.Add(modelo.Identificador, modelo);
            }
            return fabrica;
        }

        /// <summary>
        /// Elimina modelo de mi fábrica
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="modelo"></param>
        /// <returns></returns>
        public static bool operator -(Fabrica fabrica, Modelo modelo)
        {
            bool removed = false;
            if (fabrica == modelo)
            {
                removed = fabrica.modelosDisponibles.Remove(modelo.Identificador);
            }
            return removed;
        }

        /// <summary>
        /// Muestra los ID de modelos en mi fábrica. Utilizado sólo en pruebas de consola
        /// </summary>
        /// <returns></returns>
        public string MostrarModelosDisponibles()
        {
            StringBuilder sb = new StringBuilder("Modelos:\n");
            foreach (Modelo item in this.modelosDisponibles.Values)
            {
                sb.AppendLine(item.Identificador);
            }
            return sb.ToString();
        }
        #endregion
        #region Operaciones con muebles
        /// <summary>
        /// Revisa si un mueble ya existe en mi fabrica (usa Guid)
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="mueble"></param>
        /// <returns>true si el mueble ya existe</returns>
        public static bool operator == (Fabrica fabrica, Mueble mueble)
        {
            
            if (mueble is null )
            {
                return false;
            }
            bool esta = false;
            
            if (fabrica.stockMuebles.Count > 0)
            {
                foreach (Mueble item in fabrica.stockMuebles)
                {
                    if (item.CodigoGuid == mueble.CodigoGuid)
                    {
                        esta = true;
                        break;
                    }
                }
            }  
            return esta;
        }
        public static bool operator !=(Fabrica fabrica, Mueble mueble)
        {
            return !(fabrica == mueble);
        }
        /// <summary>
        /// Añade mueble a fábrica si no existe.
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="mueble"></param>
        /// <returns></returns>
        public static Fabrica operator +(Fabrica fabrica, Mueble mueble)
        {
            if (mueble != null && fabrica != mueble)
            {
                fabrica.stockMuebles.Add(mueble);
            }
            return fabrica;
        }
        /// <summary>
        /// Elimina mueble de mi fábrica
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="mueble"></param>
        /// <returns></returns>
        public static bool operator -(Fabrica fabrica, Mueble mueble)
        {
            bool eliminado = false;
            
            if (fabrica == mueble)
            {
                fabrica.stockMuebles.Remove(mueble);
                eliminado = true;
            }
            return eliminado;
        }

        /// <summary>
        /// Muestra los muebles en stock de mi fábrica. Utilizado solo en pruebas de consola
        /// </summary>
        /// <returns></returns>
        public string MostrarMuebles()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Mueble item in this.stockMuebles)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }


        /// <summary>
        /// Devuelve el peso de un material en mi fabrica, devuelve 0 si no existe o si es 0
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public double GetPesoDeMaterialEnFabrica(Material m)
        {
            double peso = 0;
            
            foreach (Material item in this.stockMateriales.Values)
            {
                if (item.Key == m.Key)
                {
                    peso = item.PesoEnKG;
                    break;
                }
            }
            return peso;
        }

/// <summary>
/// 
/// </summary>
/// <param name="material"></param>
/// <param name="cantidadNecesaria">devuelve como out la diferencia de peso necesaria si no se puede gastar</param>
/// <returns></returns>
        public bool PuedeGastarMaterial (Material material, out double cantidadNecesaria)
        {
            bool sePuedeGastar = false;
            Material materialExistente;
            cantidadNecesaria = 0;
         
            if (this == material)
            {
                this.stockMateriales.TryGetValue(material.Key, out materialExistente);
                sePuedeGastar = materialExistente.PuedeGastar(material.PesoEnKG);
                cantidadNecesaria = material.PesoEnKG - materialExistente.PesoEnKG;
            }
            return sePuedeGastar;
        }

        /// <summary>
        /// Fabrica Mueble. Verifica que haya stock, gasta materiales y agrega mueble a
        /// queue de fabricación de mi fábrica.
        /// </summary>
        /// <param name="m"></param>
        /// <returns> True si se pudo fabricar y se agrego el mueble a mi queue de fabricación</returns>
        public void FabricarMueble (Mueble m)
        {                   
            if (this[m.IDModelo] != null)
            {
                foreach (Material item in this[m.IDModelo].materialesNecesarios)
                {
                    bool fabricado = this - item;
                }
                this.mueblesEnProduccion.Enqueue(m);
            }
        }

        /// <summary>
        /// Me indica si puede fabricar o no un mueble.
        /// </summary>
        /// <param name="materialesRequeridos"></param>
        /// <param name="materialesSinStock">lista de materiales que no tienen stock necesario</param>
        /// <param name="pesosDiferencias">array de diferencia de pesos correspondiente a cada item de la lista.
        /// para evitar modificar datos del item original </param>
        /// <returns></returns>
        public bool PuedeFabricarMueble (List<Material> materialesRequeridos, out List<Material> materialesSinStock, out double[] pesosDiferencias)
        {
            bool puedeFabricar = true;
            materialesSinStock = new List<Material>();
            double diferencia;
            // SI por alguna razon se quiere fabricar un mueble con mismo codigo guid

            foreach (Material item in materialesRequeridos)
            {
                //SI el material no existe en mi fábrica o no hay suficiente cantidad (peso)
                if (!this.PuedeGastarMaterial(item, out diferencia))
                {
                    puedeFabricar = false;
                    item.PesoEnKG = diferencia;
                    materialesSinStock.Add(item);                    
                }
            }
            pesosDiferencias = new double[materialesSinStock.Count];
            int i = 0;
            foreach (Material item in materialesSinStock)
            {
                pesosDiferencias[i] = item.PesoEnKG;
                i++;
            }
            return puedeFabricar;
        }

        /// <summary>
        /// Fabrica muebles en cantidad. No fabrica ninguno si no puede fabricar todos
        /// </summary>
        /// <param name="m">mueble a fabricar</param>
        /// <param name="cantidad">cantidad deseada del mueble a fabricar</param>
        /// <param name="materialesSinStock">lista de materiales que no tienen stock necesario</param>
        /// <param name="pesosDiff">array de diferencia de pesos correspondiente a cada item de la lista.
        /// para evitar modificar datos del item original </param>
        // 
        /// <returns></returns>
        public bool FabricarMueblesEnBatch(Mueble m, short cantidad, out List<Material> materialesSinStock, out double[] pesosDiff)
        {
            bool puedeFabricarMuebles;
            List<Material> materialesSinStock2 = new List<Material>();
            double[] pesosDeMateriales = new double [this[m.IDModelo].materialesNecesarios.Count];
            int i = 0;
            foreach (Material item in this[m.IDModelo].materialesNecesarios)
            {
                pesosDeMateriales[i] = item.PesoEnKG;
                i++;
                item.PesoEnKG = item.PesoEnKG * cantidad;
            }
            i = 0;
            puedeFabricarMuebles = this.PuedeFabricarMueble(this[m.IDModelo].materialesNecesarios, out materialesSinStock2,out pesosDiff);
            foreach (Material item in this[m.IDModelo].materialesNecesarios)
            {
                item.PesoEnKG = pesosDeMateriales[i];
                i++;
            }
            if (puedeFabricarMuebles)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    Mueble mNuevo = new Mueble(this[m.IDModelo], DateTime.Now, m.Color);
                    this.FabricarMueble(mNuevo);
                }             
            }
            materialesSinStock = materialesSinStock2;
            return puedeFabricarMuebles;
        }

        /// <summary>
        /// Utilizado para serialización.
        /// devuelve ToString() del objeto pasado.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto"></param>
        /// <returns>devuelve ToString() del objeto pasado.</returns>
        public static string GetNameForFile<T>(T objeto)
        {
            return objeto.ToString();
        }

        /// <summary>
        /// Guarda mi fábrica en archivos . Depende de los paths Globales
        /// Utiliza serialización XML para las listas y binaria para el uniqueID.
        /// </summary>
        /// <returns></returns>
        public bool GuardarFabricaEnArchivos()
        {
            bool guardadoConExito = true;
            try
            {
                Serializer<Material>.nombraArchivo += Fabrica.GetNameForFile<Material>;
                guardadoConExito = (guardadoConExito && Serializer<Material>.SerializeListXML(this.stockMateriales.Values.ToList(), Globals.pathMateriales));
                Serializer<Material>.nombraArchivo -= Fabrica.GetNameForFile<Material>;

                Serializer<Modelo>.ClearDirectory(Globals.pathModelos);
                Serializer<Modelo>.nombraArchivo += Fabrica.GetNameForFile<Modelo>;
                guardadoConExito = (guardadoConExito && Serializer<Modelo>.SerializeListXML(this.modelosDisponibles.Values.ToList(), Globals.pathModelos));
                Serializer<Modelo>.nombraArchivo -= Fabrica.GetNameForFile<Modelo>;

                Serializer<Mueble>.ClearDirectory(Globals.pathStockMuebles);
                Serializer<Mueble>.nombraArchivo += Fabrica.GetNameForFile<Mueble>;
                guardadoConExito = (guardadoConExito && Serializer<Mueble>.SerializeListXML(this.stockMuebles, Globals.pathStockMuebles));

                Serializer<Mueble>.ClearDirectory(Globals.pathQueueMuebles);
                guardadoConExito = (guardadoConExito && Serializer<Mueble>.SerializeListXML(this.mueblesEnProduccion.ToList(), Globals.pathQueueMuebles));
                Serializer<Mueble>.nombraArchivo -= Fabrica.GetNameForFile<Mueble>;

                FileStream fileStream = new FileStream(@".\UniqueID.dat", FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fileStream, Modelo.UniqueID);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                throw new ErrorAlGuardarFabricaException("No se pudo guardar la fabrica en archivos", ex);
            }
            return guardadoConExito;
        }

        /// <summary>
        /// Lee todos los elementos que componen a la fábrica.
        /// Guarda el uniqueID de modelos en la clase Modelo.
        /// Lanza exception si hay error al leer los archivos.
        /// </summary>
        /// <returns></returns>
        public static Fabrica LeerFabricaDesdeArchivos()
        {
            Fabrica miFabrica = new Fabrica();
            List<Material> materialesDeFabrica = new List<Material>();
            List<Modelo> modelosDeFabrica = new List<Modelo>();
            List<Mueble> mueblesDeFabrica = new List<Mueble>();
            List<Mueble> queueMueblesDeFabrica = new List<Mueble>();

            try
            {
                Serializer<Material>.DeserializeListXML(materialesDeFabrica, Globals.pathMateriales);
                foreach (Material item in materialesDeFabrica)
                {
                    miFabrica += item;
                }
                Serializer<Modelo>.DeserializeListXML(modelosDeFabrica, Globals.pathModelos);
                foreach (Modelo item in modelosDeFabrica)
                {
                    miFabrica += item;
                }
                Serializer<Mueble>.DeserializeListXML(mueblesDeFabrica, Globals.pathStockMuebles);
                foreach (Mueble item in mueblesDeFabrica)
                {
                    miFabrica += item;
                }
                Serializer<Mueble>.DeserializeListXML(queueMueblesDeFabrica, Globals.pathQueueMuebles);
                foreach (Mueble item in queueMueblesDeFabrica)
                {
                    miFabrica.mueblesEnProduccion.Enqueue(item);
                }

                foreach (string item in Directory.GetFiles(Environment.CurrentDirectory, "*.dat"))
                {
                    FileStream archivo = new FileStream(item, FileMode.Open);
                    BinaryFormatter serializador = new BinaryFormatter();
                    Modelo.UniqueID = (int)serializador.Deserialize(archivo);
                    archivo.Close();
                }
            } catch (Exception ex)
            {
                throw new ArchivoInvalidoException("Los archivos de fabrica no existen o se movieron",ex);
            }           
            return miFabrica;
        }

        #endregion
    }
}
