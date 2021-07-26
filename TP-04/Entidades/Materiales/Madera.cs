using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades.Materiales
{
    public class Madera : Material
    {
        public EMadera tipo;

        public Madera()
        {

        }
        public Madera(double peso, EMadera tipo) : base(peso)
        {
            this.tipo = tipo;
        }

        public EMadera Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public override double CostoTotal
        {
            get
            {
                return base.PesoEnKG * Globals.precioMadera;
            }
        }

        public override string Key
        { 
            get
            {
                return this.tipo.ToString();
            }
        }
        public override string ToString()
        {
            return this.Key;
        }
    }
}
