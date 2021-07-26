using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class ModeloMesa : Modelo
    {
        public EEspacio tipo;

        public ModeloMesa()
        {

        }
        // Constructor completo.
        // con colores y cajones
        public ModeloMesa(Dimensiones dimensiones, string nombre, List<Material> materiales, EEspacio tipo, EColor[] colores)
            : base(dimensiones, nombre, materiales, colores)
        {
            Modelo.uniqueID++;
            base.identificador = string.Concat(Globals.prefijoMesa, Modelo.uniqueID.ToString().PadLeft(6, '0'));
            this.tipo = tipo;
        }

        /// <summary>
        /// Agrega validación al método Equals de Modelo.cs 
        /// El tipo debe ser el mismo (ver enumerados)
        /// </summary>
        /// <param name="obj">Mesa a comparar</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (base.Equals(obj) &&
                this.tipo == ((ModeloMesa)obj).tipo)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        /// <summary>
        /// Agrega datos al método Mostrar() de Modelo.cs
        /// Muestra tipo de mesa (ver enumerados)
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine($"Tipo: {this.tipo.ToString()}");
            return sb.ToString();
        }

    }

}

