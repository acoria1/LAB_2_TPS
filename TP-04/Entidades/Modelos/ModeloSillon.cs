using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades.Modelos
{
    public class ModeloSillon : Modelo
    {
        ushort cantAlmohadones;
        public ModeloSillon()
        {

        }
        public ModeloSillon(Dimensiones dimensiones, string nombre, List<Material> materiales, EColor[] colores, ushort almohadones)
            : base(dimensiones, nombre, materiales, colores)
        {
            Modelo.uniqueID++;
            base.identificador = string.Concat(Globals.prefijoSillon, Modelo.uniqueID.ToString().PadLeft(6, '0'));
            this.CantidadAlmohadones = almohadones;
        }

        public ushort CantidadAlmohadones
        {
            get
            {
                return this.cantAlmohadones;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ExceptionSillonSinAlmohadones("Un sillon debe tener almohadones");
                }
                this.cantAlmohadones = value;
            }
        }

        /// <summary>
        /// Agrega validación al método Equals de Modelo.cs 
        /// Cantidad de almohadones debe ser igual
        /// </summary>
        /// <param name="obj"> Placar a comparar </param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (base.Equals(obj) &&
                this.CantidadAlmohadones == ((ModeloSillon)obj).CantidadAlmohadones)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        /// <summary>
        /// Agrega datos al método Mostrar() de Modelo.cs
        /// Muestra cantidad de almohadones
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine($"Cantidad de almohadones: {this.CantidadAlmohadones}");
            return sb.ToString();
        }
    }
}
