using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Materiales;
using Entidades.Modelos;
using Entidades.Muebles;

namespace Prueba_en_Consola
{
    class Program
    {
        public static Ceramica ceramica1, ceramica2, ceramica3;
        public static Madera madera1, madera2, madera3, madera4;
        public static Vidrio vidrio1, vidrio2, vidrio3, vidrio4;
        public static Plastico plastico1, plastico2, plastico3;
        public static Metal metal1, metal2, metal3, metal4;
        public static Tela tela1;
        public static Dimensiones d1, d2;

        public static Madera maderaFabrica1, maderaFabrica2, maderaFabrica3, maderaFabrica4, maderaFabrica5, maderaFabrica6;
        public static Metal metalFabrica1, metalFabrica2, metalFabrica3;
        public static Ceramica ceramicaFabrica1;
        public static Vidrio vidrioFabrica1, vidrioFabrica2, vidrioFabrica3, vidrioFabrica4, vidrioFabrica5;
        public static Plastico plasticoFabrica1;
        public static Tela telaFabrica1;

        public static List<Material> materiales1, materiales2;

        public static EColor[] colores1, colores2, colores3, colores4, colores5;

        public static Fabrica miFabrica;

        #region Modelos
        public static ModeloMesa modeloM1, modeloM2, modeloM3, modeloM4, modeloM5, modeloM6, modeloM7, modeloM8;
        public static ModeloEstanteria modeloE1, modeloE2, modeloE3, modeloE4;
        public static ModeloPlacar modeloP1, modeloP2, modeloP3;
        public static ModeloSillon modeloS1, modeloS2, modeloS3;
        #endregion
        static void Main(string[] args)
        {
            #region Materiales

            ceramica1 = new Ceramica(0.5);
            ceramica2 = new Ceramica(1.5);
            ceramica3 = new Ceramica(2.0);
            madera1 = new Madera(3, EMadera.Arce);
            madera2 = new Madera(6, EMadera.Arce);
            madera3 = new Madera(10, EMadera.Cedro);
            madera4 = new Madera(2, EMadera.Arce);
            vidrio1 = new Vidrio(1, EVidrio.Comun);
            vidrio2 = new Vidrio(1, EVidrio.Comun);
            vidrio3 = new Vidrio(2, EVidrio.Empañado);
            vidrio4 = new Vidrio(3, EVidrio.Comun);
            plastico1 = new Plastico(0.5);
            plastico2 = new Plastico(3.5);
            plastico3 = new Plastico(1.0);
            metal1 = new Metal(3, EMetal.Acero_Inoxidable);
            metal2 = new Metal(2, EMetal.Acero_Inoxidable);
            metal3 = new Metal(10, EMetal.Bronze);
            metal4 = new Metal(3, EMetal.Hierro);
            tela1 = new Tela(3);

            maderaFabrica1 = new Madera(10, EMadera.Fresno);
            maderaFabrica2 = new Madera(10, EMadera.Arce);
            maderaFabrica3 = new Madera(10, EMadera.Cedro);
            maderaFabrica4 = new Madera(10, EMadera.Nogal);
            maderaFabrica5 = new Madera(10, EMadera.Pino);
            maderaFabrica6 = new Madera(10, EMadera.Roble);

            vidrioFabrica1 = new Vidrio(10, EVidrio.Comun);
            vidrioFabrica2 = new Vidrio(10, EVidrio.Empañado);
            vidrioFabrica3 = new Vidrio(10, EVidrio.Espejo);
            vidrioFabrica4 = new Vidrio(10, EVidrio.Impreso);
            vidrioFabrica5 = new Vidrio(10, EVidrio.Traslucido);

            metalFabrica1 = new Metal(10, EMetal.Acero_Inoxidable);
            metalFabrica2 = new Metal(10, EMetal.Bronze);
            metalFabrica3 = new Metal(10, EMetal.Hierro);

            ceramicaFabrica1 = new Ceramica(10);
            plasticoFabrica1 = new Plastico(10);
            telaFabrica1 = new Tela(10);

            #endregion
            #region Dimensiones

            d1 = new Dimensiones(140, 45, 34);
            d2 = new Dimensiones(40, 45, 34);
            #endregion
            #region Listas de Materiales

            materiales1 = new List<Material>();
            materiales2 = new List<Material>();

            materiales1.Add(ceramica1);
            materiales1.Add(vidrio1);
            materiales1.Add(plastico1);
            materiales1.Add(metal1);
            materiales1.Add(madera1);

            materiales2.Add(ceramica3);
            materiales2.Add(vidrio4);
            materiales2.Add(plastico1);
            materiales2.Add(metal4);
            #endregion
            #region Colores

            colores1 = new EColor[] { EColor.Natural, EColor.Negro, EColor.Rojo };
            colores2 = new EColor[] { EColor.Marron, EColor.Natural ,EColor.Blanco, EColor.Gris_Claro};
            #endregion
            #region Mesas

            modeloM1 = new ModeloMesa(d1, "Mesa Redonda 2m", materiales1, EEspacio.Exterior, colores1);
            modeloM2 = new ModeloMesa(d1, "Mesa Redonda", materiales1, EEspacio.Exterior, colores2);

            modeloM3 = new ModeloMesa(d1, "Mesa Cuadrada", materiales1, EEspacio.Exterior, colores1);
            modeloM4 = new ModeloMesa(d2, "Mesa Redonda", materiales1, EEspacio.Exterior, colores1);
            modeloM5 = new ModeloMesa(d1, "Mesa Redonda", materiales1, EEspacio.Interior, colores1);
            modeloM6 = new ModeloMesa(d1, "Mesa Redonda", materiales1, EEspacio.Exterior, colores3);
            modeloM7 = new ModeloMesa(d1, "Mesa Redonda", materiales2, EEspacio.Exterior, colores1);
            modeloM8 = null;
            #endregion
            #region Estanterias

            modeloE1 = new ModeloEstanteria(d1, "Estanteria Doble 8x", materiales1, EEstanteria.Abierta, colores1, 0);
            modeloE2 = new ModeloEstanteria(d1, "Estanteria Doble", materiales1, EEstanteria.Abierta, colores1);
            modeloE3 = new ModeloEstanteria(d1, "Estanteria Doble", materiales1, EEstanteria.Abierta, colores1, 5);
            modeloE4 = new ModeloEstanteria(d1, "Estanteria Doble", materiales1, EEstanteria.Cerrada, colores1, 0);
            #endregion
            #region Placares

            modeloP1 = new ModeloPlacar(d1, "Placar Vidriado Emet Black", materiales1, colores1);
            modeloP2 = new ModeloPlacar(d1, "Placar", materiales1, colores1, 0);
            modeloP3 = new ModeloPlacar(d1, "Placar", materiales1, colores1, 2);
            #endregion
            #region Sillones
            modeloS1 = new ModeloSillon(d1, "Sillon moderno LL1", materiales1, colores1, 2);
            modeloS2 = new ModeloSillon(d1, "Sillon b", materiales1, colores1, 2);
            modeloS3 = new ModeloSillon(d1, "Sillon doble", materiales1, colores1, 2);
            #endregion

            #region comment
            
            #endregion
            Fabrica miFabrica = new Fabrica();

            Mueble m1 = new Mueble(modeloM1, new DateTime(2021, 5, 21, 18, 40, 00));
            Mueble m2 = new Mueble(modeloM1, new DateTime(2021, 6, 21, 18, 40, 00));
            Mueble e1 = new Mueble(modeloE1, new DateTime(2021, 7, 21, 18, 40, 00));
            Mueble e2 = new Mueble(modeloE1, new DateTime(2021, 8, 21, 18, 40, 00));
            Mueble p1 = new Mueble(modeloP1, new DateTime(2021, 9, 21, 18, 40, 00));
            Mueble p2 = new Mueble(modeloP1, new DateTime(2021, 10, 21, 18, 40, 00));
            Mueble s1 = new Mueble(modeloS1, new DateTime(2021, 11, 21, 18, 40, 00));
            Mueble s2 = new Mueble(modeloS1, new DateTime(2021, 12, 21, 18, 40, 00));

            miFabrica = miFabrica + maderaFabrica1;
            miFabrica = miFabrica + maderaFabrica2;
            miFabrica = miFabrica + maderaFabrica3;
            miFabrica = miFabrica + maderaFabrica4;
            miFabrica = miFabrica + maderaFabrica5;
            miFabrica = miFabrica + maderaFabrica6;
            miFabrica = miFabrica + metalFabrica1;
            miFabrica = miFabrica + metalFabrica2;
            miFabrica = miFabrica + metalFabrica3;
            miFabrica = miFabrica + vidrioFabrica1;
            miFabrica = miFabrica + vidrioFabrica2;
            miFabrica = miFabrica + vidrioFabrica3;
            miFabrica = miFabrica + vidrioFabrica4;
            miFabrica = miFabrica + vidrioFabrica5;
            miFabrica = miFabrica + ceramicaFabrica1;
            miFabrica = miFabrica + plasticoFabrica1;
            miFabrica = miFabrica + telaFabrica1;


            // Console.WriteLine("-------MATERIALES-----------");
            //Console.WriteLine( miFabrica.MostrarStockMateriales());
            //bool a = miFabrica - ceramica1;
            //a = miFabrica - madera3;
            //a = miFabrica - madera3;
            //a = miFabrica - vidrio2;
            //a = miFabrica - metal2;
            // Console.WriteLine(miFabrica.MostrarStockMateriales());



            //miFabrica += modeloS2; // no lo debe agregar 
            //Console.WriteLine("-------MODELOS-----------");
            //Console.WriteLine(miFabrica.MostrarModelosDisponibles());
            //// quito:
            //bool a = miFabrica - modeloS1;
            // a = miFabrica - modeloS1; // no hace nada
            //Console.WriteLine(miFabrica.MostrarModelosDisponibles());
            //miFabrica += modeloS1; // lo vuelvo a agregar
            //Console.WriteLine(miFabrica.MostrarModelosDisponibles());
            // Console.WriteLine("-------MUEBLES-----------");

            miFabrica += modeloM1;
            miFabrica += modeloE1;
            miFabrica += modeloP1;
            miFabrica += modeloS1;

            miFabrica += m1;
            miFabrica.mueblesEnProduccion.Enqueue(m2);
            miFabrica += e1;
            miFabrica.mueblesEnProduccion.Enqueue(e2);
            miFabrica += p1;
            miFabrica.mueblesEnProduccion.Enqueue(p2);
            miFabrica += s1;
            miFabrica.mueblesEnProduccion.Enqueue(s2);

            //Console.WriteLine(miFabrica.MostrarMuebles());
            //bool a = miFabrica - p1;
            //a = miFabrica - p2;
            //a = miFabrica - s1;
            //a = miFabrica - s2;
            //Console.WriteLine("-------MUEBLES-----------");
            //Console.WriteLine(miFabrica.MostrarMuebles());

            //SERIALIZACIÓN Y DESERIALIZACIÓN

            //Console.WriteLine("MATERIALES ANTES DE DESERIALIZACION:");
            //Console.WriteLine(miFabrica.MostrarStockMateriales());
            //Console.ReadLine();

            List<Material> materialesDeFabrica = new List<Material>();
            List<Modelo> modelosDeFabrica = new List<Modelo>();
            List<Mueble> mueblesDeFabrica = new List<Mueble>();
            List<Mueble> queueMueblesDeFabrica = new List<Mueble>();

            //Serializer<Material>.DeserializeListXML(materialesDeFabrica, Globals.pathMateriales);           
            //foreach (Material item in materialesDeFabrica)
            //{
            //    miFabrica += item;
            //}
            //Console.WriteLine("MODELOS ANTES DE DESERIALIZACION:");
            //Console.WriteLine(miFabrica.MostrarModelosDisponibles());
            //Console.ReadLine();
            //Serializer<Modelo>.DeserializeListXML(modelosDeFabrica, Globals.pathModelos);
            //foreach (Modelo item in modelosDeFabrica)
            //{
            //    miFabrica += item;
            //}

            //Serializer<Mueble>.DeserializeListXML(mueblesDeFabrica, Globals.pathStockMuebles);
            //foreach (Mueble item in mueblesDeFabrica)
            //{
            //    miFabrica += item;
            //}

            //Serializer<Mueble>.DeserializeListXML(mueblesDeFabrica, Globals.pathQueueMuebles);
            //foreach (Mueble item in mueblesDeFabrica)
            //{
            //    miFabrica.mueblesEnProduccion.Enqueue(item);
            //}

            Console.WriteLine("STOCK MUEBLES LUEGO DE DESERIALIZACION:");
            Console.WriteLine(miFabrica.MostrarMuebles());
            Console.ReadLine();

            Console.WriteLine("QUEUE MUEBLES LUEGO DE DESERIALIZACION:");
            Console.WriteLine(miFabrica.mueblesEnProduccion.Count);
            Console.ReadLine();

            Console.WriteLine("MODELOS LUEGO DE DESERIALIZACION:");
            Console.WriteLine(miFabrica.MostrarModelosDisponibles());
            Console.ReadLine();

            Console.WriteLine("MATERIALES LUEGO DE DESERIALIZACION:");
            Console.WriteLine(miFabrica.MostrarStockMateriales());
            Console.ReadLine();

            //SERIALIZACION:

            

            Serializer<Material>.nombraArchivo += Fabrica.GetNameForFile<Material>; //Material.GetNameForFile;
            if (Serializer<Material>.SerializeListXML(miFabrica.stockMateriales.Values.ToList(), Globals.pathMateriales))
            {
                Console.Write("GUARDADO CON EXITO");
            }
            else
            {
                Console.Write("NO PUDO GUARDAR");
            }
            Console.Read();
            

            Serializer<Material>.nombraArchivo -= Fabrica.GetNameForFile<Material>; //Material.GetNameForFile;
            Serializer<Modelo>.nombraArchivo += Fabrica.GetNameForFile<Modelo>; // Modelo.GetNameForFile;
            if (Serializer<Modelo>.SerializeListXML(miFabrica.modelosDisponibles.Values.ToList(), Globals.pathModelos))
            {
                Console.Write("GUARDADO CON EXITO");
            }
            else
            {
                Console.Write("NO PUDO GUARDAR");
            }
            Console.Read();

            Serializer<Modelo>.nombraArchivo -= Fabrica.GetNameForFile<Modelo>;
            Serializer<Mueble>.nombraArchivo += Fabrica.GetNameForFile<Mueble>;
            if (Serializer<Mueble>.SerializeListXML(miFabrica.stockMuebles, Globals.pathStockMuebles))
            {
                Console.Write("GUARDADO CON EXITO");
            }
            else
            {
                Console.Write("NO PUDO GUARDAR");
            }
            Console.Read();
            
            if (Serializer<Mueble>.SerializeListXML(miFabrica.mueblesEnProduccion.ToList(), Globals.pathQueueMuebles))
            {
                Console.Write("GUARDADO CON EXITO");
            }
            else
            {
                Console.Write("NO PUDO GUARDAR");
            }
            Console.Read();
        }
    }
}
