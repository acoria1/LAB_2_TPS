using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface ICajonera
    {
        /// <summary>
        /// Devuelve o setea la cantidad de cajones
        /// </summary>
        ushort CantidadCajones { get; set; }

        /// <summary>
        /// Pregunta si quien lo implementa tiene cajones o no
        /// </summary>
        /// <returns> true si tiene más de 0 cajones. false de lo contrario
        /// </returns>
        bool TieneCajones();
    }
}
