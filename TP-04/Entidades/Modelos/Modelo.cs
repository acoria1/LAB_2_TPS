using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
using System.Xml;
using System.Xml.Serialization;


namespace Entidades.Modelos
{
    [Serializable]
    public struct Dimensiones
    {
        public double alto;
        public double ancho;
        public double profundidad;

        /// <summary>
        /// Unico constructor
        /// </summary>
        /// <param name="alto">Alto </param>
        /// <param name="ancho">Ancho</param>
        /// <param name="profundidad">Profundidad </param>
        public Dimensiones(double alto, double ancho, double profundidad)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
        }

        /// <summary>
        /// Dos dimensiones serán iguales si todos sus atributos coinciden.
        /// </summary>
        /// <param name="d1">dimension 1</param>
        /// <param name="d2">dimension 2</param>
        /// <returns></returns>
        public static bool operator == (Dimensiones d1, Dimensiones d2)
        {
            if (d1.alto == d2.alto && d1.ancho == d2.ancho && d1.profundidad == d2.profundidad)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator !=(Dimensiones d1, Dimensiones d2)
        {
            return !(d1 == d2);
        }
    }

    [Serializable]
    [XmlInclude(typeof(ModeloEstanteria))]
    [XmlInclude(typeof(ModeloMesa))]
    [XmlInclude(typeof(ModeloPlacar))]
    [XmlInclude(typeof(ModeloSillon))]
    public abstract class Modelo 
    {
        Dimensiones dimensiones;
        public EColor[] coloresDisponibles;
        string nombre;
        public List<Material> materialesNecesarios;

        protected string identificador;
        [XmlIgnoreAttribute]
        protected static int uniqueID = 0;

        /// <summary>
        /// Constructor sin parámetros para serializar. Inicializa la lista de materiales.
        /// </summary>
        public Modelo()
        {
            this.materialesNecesarios = new List<Material>();
        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="dimensiones">dimensiones del modelo en CM</param>
        /// <param name="nombre"> Descripcion del modelo</param>
        /// <param name="materiales"> Materiales necesarios para la fabricación de un mueble de este modelo</param>
        /// <param name="colores"> colores disponibles para este modelo</param>
        public Modelo (Dimensiones dimensiones, string nombre, List<Material> materiales, EColor[] colores): this ()
        {
            this.Dimensiones = dimensiones;
            this.Nombre = nombre;
            foreach (Material item in materiales)
            {
                this.materialesNecesarios.Add(item);
            }
            coloresDisponibles = colores;
        }
        
        public static int UniqueID
        {
            get
            {
                return Modelo.uniqueID;
            }
            set
            {
                Modelo.uniqueID = value;
            }
        }
        public string Identificador
        {
            get
            {
                return this.identificador;
            }
            set
            {
                this.identificador = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 100)
                {
                    throw new ExceptionNombreModeloInvalido("Nombre de modelo inválido");
                }
                this.nombre = value;
            }
        }

        public Dimensiones Dimensiones
        {
            get
            {
                return this.dimensiones;
            }
            set
            {
                if (value.alto < 1 || value.alto > 10000)
                {
                    throw new ExceptionDimensionesInvaldas("Alto de mueble inválido (1<=x<=10000)");
                }
                if (value.ancho < 1 || value.ancho> 10000)
                {
                    throw new ExceptionDimensionesInvaldas("Ancho de mueble inválido (1<=x<=10000)");
                }
                if (value.profundidad < 1 || value.profundidad > 10000)
                {
                    throw new ExceptionDimensionesInvaldas("Profundidad de mueble inválida (1<=x<=10000)");
                }
                this.dimensiones = value;
            }
        }

        public double Alto
        {
            get
            {
                return this.dimensiones.alto;
            }
        }

        public double Ancho
        {
            get
            {
                return this.dimensiones.ancho;
            }
        }

        public double Profundidad
        {
            get
            {
                return this.dimensiones.profundidad;
            }
        }

        
        [XmlIgnore]
        public double CostoDeFabricacion
        {
            get
            {
                double costoTotal = 0;
                foreach (Material item in this.materialesNecesarios)
                {
                    costoTotal += item.CostoTotal;
                }
                return costoTotal;
            }
        }

        /// <summary>
        /// Dos modelos serán iguales si: 
        /// - Son de la misma clase
        /// - Tienen mismas dimensiones
        /// - Tienen mismos colores disponibles
        /// - Tienen mismos materiales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (this == null || obj == null)
            {
                return false;
            }
            bool sonIguales = false;
            if (this.GetType() == obj.GetType() &&
                this.dimensiones == ((Modelo)obj).dimensiones &&
                Modelo.TienenMismosColores(this.coloresDisponibles, ((Modelo)obj).coloresDisponibles) &&
                Modelo.TienenMismosMateriales(this.materialesNecesarios, ((Modelo)obj).materialesNecesarios))
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        public static bool TienenMismosColores (EColor[] colores1, EColor[] colores2)
        {
            return ContienenMismosObjetos<EColor>(colores1, colores2);
        }

        public static bool TienenMismosMateriales(List<Material> l1, List<Material> l2)
        {           
            return ContienenMismosObjetos<Material>(l1.ToArray(), l2.ToArray());
        }

        /// <summary>
        /// compara dos array de objetos del mismo tipo y verá que no sean null y 
        /// que cada uno contenga los elementos del otro. 
        /// Ignora el orden de los objetos.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequencia1">primer array</param>
        /// <param name="sequencia2">segundo array</param>
        /// <returns></returns>
        public static bool ContienenMismosObjetos<T> (T[] sequencia1, T[] sequencia2)
        {
            if (sequencia1 == null || sequencia2 == null)
            {
                return false;
            }
            bool mismosMateriales = true;
            foreach (T item in sequencia2)
            {
                if (!(sequencia1.Contains(item)))
                {
                    mismosMateriales = false;
                    break;
                }
            }
            foreach (T item in sequencia1)
            {
                if (!(sequencia2.Contains(item)))
                {
                    mismosMateriales = false;
                    break;
                }
            }
            return mismosMateriales;
        }

        /// <summary>
        /// Me dice si un color es válido para un modelo.
        /// </summary>
        /// <param name="color"> Color a buscar en modelo</param>
        /// <returns>
        /// True si el color está dentro de los colores de mi modelo
        /// false si el color no está en colores del modelo
        /// </returns>
        public bool ValidarColor(EColor color)
        {
            bool colorValido = false;
            foreach (EColor item in this.coloresDisponibles)
            {
                if (item == color)
                {
                    colorValido = true;
                    break;
                }
            }
            return colorValido;
        }

        /// <summary>
        /// Muestra todos los detalles de un modelo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID de modelo:           {this.identificador}");
            sb.AppendLine($"nombre:                 {this.nombre}");
            sb.Append("Colores disponibles:\n");
            foreach (EColor item in this.coloresDisponibles)
            {
                sb.Append(item + ", ");
            }
            sb = new StringBuilder(sb.ToString().Trim().Trim(','));
            sb.AppendLine
                ($"\nancho:                         {this.dimensiones.ancho} cm," +
                $" \nalto:                          {this.dimensiones.alto} cm," +
                $" \nprofundidad:                   {this.dimensiones.profundidad} cm\n");
            sb.AppendLine("Materiales necesarios:");
            foreach (Material item in this.materialesNecesarios)
            {
                sb.AppendLine($"{item.ToString()}       {item.PesoEnKG} Kg.");
            }
            sb.AppendLine($"COSTO DE FABRICACION:       ${this.CostoDeFabricacion}");
            return sb.ToString();
        }
        /// <summary>
        /// Devuelve ID del modelo ej: MES000001, EST000035
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Identificador;
        }
    }
}
