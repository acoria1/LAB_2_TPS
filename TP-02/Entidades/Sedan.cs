using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }

        ETipo tipo;

        /// <summary>
        /// Llama a constructor de Vehiculo.
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">marca del vehiculo, enum EMarca</param>
        /// <param name="chasis">chasis del vehiculo, string alfanumerico </param>
        /// <param name="color">color del vehiculo, ConsoleColor</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Llama a constructor de Vehiculo, cambia el tipo de sedan por el ingresado por param
        /// </summary>
        /// <param name="marca">marca del vehiculo, enum EMarca</param>
        /// <param name="chasis">chasis del vehiculo, string alfanumerico </param>
        /// <param name="color">color del vehiculo, ConsoleColor</param>
        /// <param name="tipo"> tipo de sedan </param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo)
            :this(marca,chasis,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Llama a Mostrar() de base, le agrega el Tipo de sedan, un separador
        /// y devuelve como string.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine(" TIPO: " + this.tipo);
            sb.AppendLine("\r\n---------------------");

            return sb.ToString();
        }
    }
}
