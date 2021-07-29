using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Globals
    {
        // precio de los materiales por KG.
        public static double precioCeramica = 2000;
        public static double precioMadera = 800;
        public static double precioMetal = 950;
        public static double precioPlastico = 600;
        public static double precioVidrio = 1400;
        public static double precioTela = 750;

        // Prefijo que tomaran los Identificadores de cada modelo

        public const string prefijoEstanteria = "EST";
        public const string prefijoMesa = "MES";
        public const string prefijoPlacar = "PLC";
        public const string prefijoSillon = "SLN";

        // PATHs en donde se hará la serialización
        public const string pathMateriales = @".\Materiales";
        public const string pathModelos = @".\Modelos";
        public const string pathStockMuebles = @".\StockMuebles";
        public const string pathQueueMuebles = @".\QueueMuebles";

        // base de datos
        public const string pathDataBase = "data source =.; Initial Catalog = Fabrica_TP4_AC; Integrated Security = True";

        // se fabricará un mueble cada (milisegundosDeEsperaFabricacion * 2) milisegundos.
        public static int milisegundosDeEsperaFabricacion = 1000; 
    }
}
