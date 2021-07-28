using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Materiales
{
    public class Metal : Material
    {
        public EMetal tipo;
        
        public Metal(double peso, EMetal tipo): base(peso)
        {
            this.tipo = tipo;
        }
        public Metal()
        {

        }
        public EMetal Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public override string Key
        {
            get
            {
                return this.tipo.ToString();
            }
        }
        public override double CostoTotal
        {
            get
            {
                return base.PesoEnKG * Globals.precioMetal;
            }
        }

        public override string ToString()
        {
            return this.Key;
        }
    }
}
