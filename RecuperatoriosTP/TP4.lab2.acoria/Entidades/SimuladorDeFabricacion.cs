using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades.Muebles;

namespace Entidades
{
    public delegate void ComenzoProduccion();
    public delegate void TerminoProduccion();

    public class SimuladorDeFabricacion
    {
        public event ComenzoProduccion comenzoProduccionDeMueble;
        public event TerminoProduccion terminoProduccionDeMueble;
        Mueble currentMueble;

        /// <summary>
        /// Simula la fabricación de muebles
        // Constantemente estará fijandose si existe un item en la queue de mi fábrica.
        // de ser así llamará a los eventos de comienzo de producción, esperará, y avisará que terminó la producción.
        /// </summary>
        /// <param name="parameters"></param>
        public void SimularFabricacion(object parameters)
        {
            if (parameters.GetType() == typeof(ConcurrentQueue<Mueble>))
            {
                ConcurrentQueue<Mueble> cola = (ConcurrentQueue<Mueble>)parameters;
                while (true)
                {
                    if (comenzoProduccionDeMueble != null && terminoProduccionDeMueble != null)
                    {
                        if (cola.TryPeek(out currentMueble))
                        {
                            comenzoProduccionDeMueble.Invoke();
                            Thread.Sleep(Globals.milisegundosDeEsperaFabricacion);
                            terminoProduccionDeMueble.Invoke();
                        }
                    }
                    Thread.Sleep(Globals.milisegundosDeEsperaFabricacion);
                }
            }                  
        }
    }
}
