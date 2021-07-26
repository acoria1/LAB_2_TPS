using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades.Muebles;

namespace Entidades
{
    public delegate void AvisoCountCambio(string texto);
    public class TablaMueblesListener
    {
        public event AvisoCountCambio dataBaseChanged;
        int cantidadMuebles;

        public TablaMueblesListener()
        {
            this.cantidadMuebles = MuebleDAO.GetCountMuebles();
        }
        public void DataBaseListener()
        {
            while (true)
            {
                if (this.cantidadMuebles != MuebleDAO.GetCountMuebles())
                { 
                    if (this.dataBaseChanged != null)
                    {
                        this.dataBaseChanged.Invoke("La base de datos fue actualizada");
                        this.cantidadMuebles = MuebleDAO.GetCountMuebles();
                    }                                                
                }
                Thread.Sleep(1000);
            }                   
        }
    }
}
