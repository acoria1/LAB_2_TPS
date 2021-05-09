using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Llama al constructor de Vehiculo
        /// </summary>
        /// <param name="marca">marca del vehiculo, enum EMarca</param>
        /// <param name="chasis">chasis del vehiculo, string alfanumerico </param>
        /// <param name="color">color del vehiculo, ConsoleColor</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Llama a Mostrar() de base, le agrega un separador y devuelve como string.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
