using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Materiales
{
    public class Tela : Material
    {
        public Tela()
        {

        }
        public Tela(double peso) : base(peso)
        {
        }
        public override string Key
        {
            get
            {
                return "Tela";
            }
        }
        public override double CostoTotal
        {
            get
            {
                return base.PesoEnKG * Globals.precioTela;
            }
        }

        public override string ToString()
        {
            return this.Key;
        }
    }
}
