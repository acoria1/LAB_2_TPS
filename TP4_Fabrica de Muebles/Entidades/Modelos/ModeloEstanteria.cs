using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class ModeloEstanteria : Modelo, ICajonera
    {
        public EEstanteria tipo;
        ushort cantCajones;

        public ModeloEstanteria()
        {

        }
        // Constructor completo.
        // con colores y cajones
        public ModeloEstanteria(Dimensiones dimensiones, string nombre, List<Material> materiales,EEstanteria tipo, EColor[] colores, ushort cajones) 
            : base(dimensiones,nombre, materiales, colores)
        {
            Modelo.uniqueID++;
            base.identificador = string.Concat(Globals.prefijoEstanteria,Modelo.uniqueID.ToString().PadLeft(6, '0'));
            this.tipo = tipo;
            this.cantCajones = cajones;
        }

        // Constructor sin cajones
        public ModeloEstanteria(Dimensiones dimensiones, string nombre, List<Material> materiales, EEstanteria tipo, EColor[] colores)
            : this(dimensiones, nombre, materiales, tipo, colores, 0)
        {
        }

        public ushort CantidadCajones
        {
            get
            {
                return this.cantCajones;
            }
            set
            {
                this.cantCajones = value;
            }
        }

        public bool TieneCajones()
        {
            if (this.CantidadCajones > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Agrega validación al método Equals de Modelo.cs 
        /// El tipo debe ser el mismo (ver enumerados)
        /// la cantidad de cajones debe ser igual
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (base.Equals(obj) && 
                this.tipo == ((ModeloEstanteria)obj).tipo &&
                this.CantidadCajones == ((ModeloEstanteria)obj).CantidadCajones)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        /// <summary>
        /// Agrega datos al método Mostrar() de Modelo.cs
        /// Muestra tipo de estantería (ver enumerados) y cantidad de cajones.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine($"Tipo: {this.tipo.ToString()}");
            sb.AppendLine($"Cantidad de cajones: {this.CantidadCajones}");
            return  sb.ToString();
        }
    }
}
