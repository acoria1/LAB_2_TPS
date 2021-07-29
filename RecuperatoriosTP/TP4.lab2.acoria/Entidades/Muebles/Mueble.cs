using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelos;
using Entidades.Excepciones;
using System.Xml.Serialization;

namespace Entidades.Muebles
{
    [Serializable]
    public class Mueble
    {
        Guid codigo;
        string idModelo;
        DateTime fechaDeFabricacion;
        EColor color;
        EEstadoMueble estado;

        /// <summary>
        /// Constructor para serializar
        /// </summary>
        public Mueble()
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="modelo">Modelo a usar para construir mueble</param>
        /// <param name="fecha"> fecha de fabricacion</param>
        /// <param name="color"> color del mueble, validado por el modelo </param>
        public Mueble (Modelo modelo, DateTime fecha, EColor color)
        {
            this.codigo = Guid.NewGuid();
            this.idModelo = modelo.Identificador;
            this.fechaDeFabricacion = fecha;
            if (modelo.ValidarColor(color))
            {
                this.color = color;
            }
            else
            {
                throw new ExceptionColorInvalido("Color inválido para el modelo indicado");
            }
            this.estado = EEstadoMueble.Esperando_Fabricacion;
        }

        public Mueble(Modelo modelo, DateTime fecha) : this(modelo,fecha,EColor.Natural)
        {
        }

        public string IDModelo
        {
            get
            {
                return this.idModelo;
            }
            set
            {
                this.idModelo = value;
            }
        }

        public Guid CodigoGuid
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public EColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public string ColorString
        {
            get
            {
                return this.color.ToString().Replace('_', ' ');
            }
        }

        public DateTime FechaDeFabricacion
        {
            get
            {
                return this.fechaDeFabricacion;
            }
            set
            {
                this.fechaDeFabricacion = value;
            }
        }

        public EEstadoMueble Estado 
        { 
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        [XmlIgnoreAttribute]
        public string EstadoString
        {
            get
            {
                return this.estado.ToString().Replace('_', ' ');
            }
        }

        /// <summary>
        /// Dos muebles serán iguales si coincide su Guid
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator == (Mueble m1, Mueble m2)
        {
            if (m1 is null || m2 is null)
            {
                return false;
            }
            return (m1.codigo == m2.codigo);
        }

        public static bool operator !=(Mueble m1, Mueble m2)
        {
            return !(m1 == m2);
        }
        /// <summary>
        /// Devuelve Código Guid
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.CodigoGuid.ToString();
        }
    }
}
