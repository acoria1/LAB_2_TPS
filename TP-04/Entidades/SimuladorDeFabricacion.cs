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
