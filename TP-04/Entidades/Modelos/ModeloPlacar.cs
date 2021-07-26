using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class ModeloPlacar : Modelo, ICajonera
    {
        ushort cantCajones;

        public ModeloPlacar()
        {

        }
        // Constructor completo.
        // con colores y cajones
        public ModeloPlacar(Dimensiones dimensiones, string nombre, List<Material> materiales,EColor[] colores, ushort cajones)
            : base(dimensiones, nombre, materiales, colores)
        {
            Modelo.uniqueID++;
            base.identificador = string.Concat(Globals.prefijoPlacar, Modelo.uniqueID.ToString().PadLeft(6, '0'));
            this.cantCajones = cajones;
        }

        // Constructor sin Cajones
        public ModeloPlacar(Dimensiones dimensiones, string nombre, List<Material> materiales, EColor[] colores)
            : this(dimensiones, nombre, materiales,colores, 0)
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
        /// Cantidad de cajones debe ser igual
        /// </summary>
        /// <param name="obj"> Placar a comparar </param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (base.Equals(obj) &&
                this.CantidadCajones == ((ModeloPlacar)obj).CantidadCajones)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        /// <summary>
        /// Agrega datos al método Mostrar() de Modelo.cs
        /// Muestra cantidad de cajones
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine($"Cantidad de cajones: {this.CantidadCajones}");
            return sb.ToString();
        }
    }
}
