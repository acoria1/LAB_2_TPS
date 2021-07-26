using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades.Materiales
{
    public class Ceramica : Material
    {
        public Ceramica()
        {

        }
        public Ceramica(double peso): base(peso)
        {
        }

        public override string Key
        {
            get
            {
                return "Ceramica";
            }
        }
        public override double CostoTotal
        {
            get
            {
                return base.PesoEnKG * Globals.precioCeramica;
            }
        }

        public override string ToString()
        {
            return this.Key;
        }
    }
}
