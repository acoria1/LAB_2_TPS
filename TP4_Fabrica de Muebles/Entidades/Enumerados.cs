using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Tipos De Material
    public enum EMetal { AceroInoxidable, Bronze, Hierro }
    public enum EMadera { Arce, Cedro, Fresno, Pino, Nogal, Roble}
    public enum EVidrio { Espejo = 0, Empañado = 15, Impreso = 26, Comun = 60, Traslucido = 99}

    #endregion
    #region Colores de Fabrica
    public enum EColor { Amarillo, Azul, Blanco, Gris, GrisClaro, GrisOscuro, Marron, Naranja, Natural, Negro, Plata, Rojo, VerdeClaro, VerdeOscuro, Violeta }
    #endregion
    #region Tipos de mueble 
    public enum EEstanteria { Abierta, Cerrada}
    public enum EEspacio { Interior, Exterior}

    public enum EEstadoMueble { EsperandoFabricacion, EnProduccion, Terminado, Enviado}
    #endregion
}