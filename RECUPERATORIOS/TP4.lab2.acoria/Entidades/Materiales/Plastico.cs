using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades.Materiales
{
    public class Plastico : Material
    {
        public Plastico()
        {

        }
        public Plastico (double peso) : base(peso)
        {
        }

        public override string Key
        {
            get
            {
                return "Plastico";
            }
        }
        public override double CostoTotal
        {
            get
            {
                return base.PesoEnKG * Globals.precioPlastico;
            }
        }

        public override string ToString()
        {
            return this.Key;
        }
    }
}
