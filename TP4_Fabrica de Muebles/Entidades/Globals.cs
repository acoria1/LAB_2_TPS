using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Globals
    {
        public static double precioCeramica = 2000;
        public static double precioMadera = 800;
        public static double precioMetal = 950;
        public static double precioPlastico = 600;
        public static double precioVidrio = 1400;
        public static double precioTela = 750;

        public const string prefijoEstanteria = "EST";
        public const string prefijoMesa = "MES";
        public const string prefijoPlacar = "PLC";
        public const string prefijoSillon = "SLN";

        public const string pathMateriales = @".\Materiales";
        public const string pathModelos = @".\Modelos";
        public const string pathStockMuebles = @".\StockMuebles";
        public const string pathQueueMuebles = @".\QueueMuebles";

        public const string pathDataBase = "data source =.; Initial Catalog = Fabrica_TP4_AC; Integrated Security = True";

        public static int milisegundosDeEsperaFabricacion = 10000;
    }
}
