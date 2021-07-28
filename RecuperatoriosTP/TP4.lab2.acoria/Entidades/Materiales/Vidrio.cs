using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Materiales
{
    public class Vidrio : Material
    {
        public EVidrio tipo;

        public Vidrio()
        {

        }
        public Vidrio (double peso, EVidrio tipo): base(peso)
        {
            this.tipo = tipo;
        }

        public EVidrio Tipo
        {
            get
            {
                return this.tipo;
            }
        }
        public override string Key
        {
            get
            {
                return $"Vidrio-{this.tipo.ToString()}";
            }
        }
        public override double CostoTotal
        {
            get
            {
                return base.PesoEnKG * Globals.precioVidrio;
            }
        }

        public override string ToString()
        {
            return this.Key;
        }
    }
}
