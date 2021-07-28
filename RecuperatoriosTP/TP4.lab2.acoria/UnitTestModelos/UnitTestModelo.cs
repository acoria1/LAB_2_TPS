using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
using Entidades;
using Entidades.Modelos;
using Entidades.Materiales;


namespace UnitTestFabricaMuebles
{
    [TestClass]
    public class UnitTestModelo
    {
        #region Materiales
        public static Ceramica ceramica1, ceramica2, ceramica3;
        public static Madera madera1, madera2, madera3, madera4;
        public static Vidrio vidrio1, vidrio2, vidrio3, vidrio4;
        public static Plastico plastico1, plastico2, plastico3;
        public static Metal metal1, metal2, metal3, metal4;
        #endregion
        public static Dimensiones d1, d2;

        public static List<Material> materiales1, materiales2, materiales3, materiales4, materiales5;

        public static EColor[] colores1, colores2, colores3, colores4, colores5;

        public static Fabrica miFabrica;

        #region Modelos
        public static ModeloMesa modeloM1, modeloM2, modeloM3, modeloM4, modeloM5, modeloM6, modeloM7, modeloM8;
        public static ModeloEstanteria modeloE1, modeloE2, modeloE3, modeloE4;
        public static ModeloPlacar modeloP1, modeloP2, modeloP3;
        public static ModeloSillon modeloS1, modeloS2, modeloS3;
        #endregion

        [TestInitialize]
        public void Initialize()
        {
            #region Materiales

            ceramica1 = new Ceramica(0.5);
            ceramica2 = new Ceramica(0.5);
            ceramica3 = new Ceramica(1.0);
            madera1 = new Madera(3, EMadera.Arce);
            madera2 = new Madera(3, EMadera.Arce);
            madera3 = new Madera(2, EMadera.Cedro);
            madera4 = new Madera(2, EMadera.Arce);
            vidrio1 = new Vidrio(0.6, EVidrio.Comun);
            vidrio2 = new Vidrio(0.6, EVidrio.Comun);
            vidrio3 = new Vidrio(0.6, EVidrio.Empañado);
            vidrio4 = new Vidrio(1.2, EVidrio.Comun);
            plastico1 = new Plastico(0.5);
            plastico2 = new Plastico(0.5);
            plastico3 = new Plastico(1.0);
            metal1 = new Metal(3.2, EMetal.AceroInoxidable);
            metal2 = new Metal(3.2, EMetal.AceroInoxidable);
            metal3 = new Metal(1.2, EMetal.Bronze);
            metal4 = new Metal(1.2, EMetal.AceroInoxidable);
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

            colores1 = new EColor[] { EColor.Natural };
            colores2 = new EColor[] { EColor.Natural };
            colores3 = new EColor[] { EColor.Natural, EColor.Marron };
            colores4 = new EColor[] { EColor.Marron, EColor.Natural };
            colores5 = new EColor[] { };
            #endregion
            #region Mesas

            modeloM1 = new ModeloMesa(d1, "Mesa Redonda", materiales1, EEspacio.Exterior, colores1);
            modeloM2 = new ModeloMesa(d1, "Mesa Redonda", materiales1, EEspacio.Exterior, colores1);

            modeloM3 = new ModeloMesa(d1, "Mesa Cuadrada", materiales1, EEspacio.Exterior, colores1);
            modeloM4 = new ModeloMesa(d2, "Mesa Redonda", materiales1, EEspacio.Exterior, colores1);
            modeloM5 = new ModeloMesa(d1, "Mesa Redonda", materiales1, EEspacio.Interior, colores1);
            modeloM6 = new ModeloMesa(d1, "Mesa Redonda", materiales1, EEspacio.Exterior, colores3);
            modeloM7 = new ModeloMesa(d1, "Mesa Redonda", materiales2, EEspacio.Exterior, colores1);
            modeloM8 = null;
            #endregion
            #region Estanterias

            modeloE1 = new ModeloEstanteria(d1, "Estanteria Doble", materiales1, EEstanteria.Abierta, colores1, 0);
            modeloE2 = new ModeloEstanteria(d1, "Estanteria Doble", materiales1, EEstanteria.Abierta, colores1);
            modeloE3 = new ModeloEstanteria(d1, "Estanteria Doble", materiales1, EEstanteria.Abierta, colores1, 5);
            modeloE4 = new ModeloEstanteria(d1, "Estanteria Doble", materiales1, EEstanteria.Cerrada, colores1, 0);
            #endregion
            #region Placares

            modeloP1 = new ModeloPlacar(d1, "Placar", materiales1, colores1);
            modeloP2 = new ModeloPlacar(d1, "Placar", materiales1, colores1, 0);
            modeloP3 = new ModeloPlacar(d1, "Placar", materiales1, colores1, 2);
            #endregion
            #region Sillones
            modeloS1 = new ModeloSillon(d1, "Sillon a", materiales1, colores1, 2);
            modeloS2 = new ModeloSillon(d1, "Sillon b", materiales1, colores1, 2);
            modeloS3 = new ModeloSillon(d1, "Sillon doble", materiales1, colores1, 3);
            #endregion
            miFabrica = new Fabrica();
            miFabrica += modeloM1;
            miFabrica += modeloM2;
            miFabrica += modeloM3;
            miFabrica += modeloM4;
            miFabrica += modeloM5;
            miFabrica += modeloM6;
            miFabrica += modeloM7;
            miFabrica += modeloM8;
            miFabrica += modeloE1;
            miFabrica += modeloE2;
            miFabrica += modeloE3;
            miFabrica += modeloE4;
            miFabrica += modeloP1;
            miFabrica += modeloP2;
            miFabrica += modeloP3;
            miFabrica += modeloS1;
            miFabrica += modeloS2;
            miFabrica += modeloS3;

        }

        [TestMethod]
        public void TestTienenMismosColores()
        {
            bool mismosColores = Modelo.TienenMismosColores(colores1, colores1);
            Assert.IsTrue(mismosColores);
            mismosColores = Modelo.TienenMismosColores(colores1, colores2);
            Assert.IsTrue(mismosColores);
            mismosColores = Modelo.TienenMismosColores(colores4, colores3);
            Assert.IsTrue(mismosColores);
            //arrays vacios
            mismosColores = Modelo.TienenMismosColores(colores5, colores5);
            Assert.IsTrue(mismosColores);
        }

        [TestMethod]
        public void TestTienenMismosColoresFalso()
        {
            // un array contiene a todos los elementos de la otra
            bool mismosColores = Modelo.TienenMismosColores(colores1, colores3);
            Assert.IsFalse(mismosColores);
            mismosColores = Modelo.TienenMismosColores(colores3, colores1);
            Assert.IsFalse(mismosColores);

            // nulls
            mismosColores = Modelo.TienenMismosColores(null, null);
            Assert.IsFalse(mismosColores);
            mismosColores = Modelo.TienenMismosColores(null, colores1);
            Assert.IsFalse(mismosColores);
            mismosColores = Modelo.TienenMismosColores(colores1, null);
            Assert.IsFalse(mismosColores);
            
        }

        [TestMethod]
        public void TestEqualsModelosIgualesMesa()
        {
            // mismo modelo, 2 instancias 
            bool iguales = modeloM1.Equals(modeloM1);
            Assert.IsTrue(iguales);
            iguales = modeloM1.Equals(modeloM2);
            Assert.IsTrue(iguales);

            // Mismo modelo, distinto nombre, los toma como iguales (intended).
            iguales = modeloM1.Equals(modeloM3);
            Assert.IsTrue(iguales);

        }

        [TestMethod]
        public void TestEqualsModelosIgualesEstanteria()
        {
            // mismos datos con distinto constructor
            bool iguales = modeloE1.Equals(modeloE2);
            Assert.IsTrue(iguales);
        }

        [TestMethod]
        public void TestEqualsModelosIgualesPlacar()
        {
            // misma cantidad de cajones
            bool iguales = modeloP1.Equals(modeloP2);
            Assert.IsTrue(iguales);
        }

        [TestMethod]
        public void TestEqualsModelosIgualesSillon()
        {
            //misma cantidad de almohadones
            bool iguales = modeloS1.Equals(modeloS2);
            Assert.IsTrue(iguales);
        }

        [TestMethod]
        public void TestEqualsModelosDistintosMesa()
        {
            // MESAS
            // mismos datos, distinto Type
            bool iguales = modeloM1.Equals(modeloE1);
            Assert.IsFalse(iguales);
            // Distintas dimensiones
            iguales = modeloM1.Equals(modeloM4);
            Assert.IsFalse(iguales);

            // distintos tipos
            iguales = modeloM1.Equals(modeloM5);
            Assert.IsFalse(iguales);

            // distintos colores
            iguales = modeloM1.Equals(modeloM6);
            Assert.IsFalse(iguales);

            // distintos materiales
            iguales = modeloM1.Equals(modeloM7);
            Assert.IsFalse(iguales);

            // nulls -> M8 es null
            iguales = modeloM1.Equals(null);
            Assert.IsFalse(iguales);
            iguales = modeloM1.Equals(modeloM8);
            Assert.IsFalse(iguales);
        }

        [TestMethod]
        public void TestEqualsModelosDistintosEstanteria()
        {
            // distinta cantidad de estantes
            bool iguales = modeloE1.Equals(modeloE3);
            Assert.IsFalse(iguales);
            // distinto tipo (abierta/cerrada)
            iguales = modeloE1.Equals(modeloE4);
            Assert.IsFalse(iguales);
        }

        [TestMethod]
        public void TestEqualsModelosDistintosPlacar()
        {
            //distinta cantidad de cajones
            bool iguales = modeloP1.Equals(modeloP3);
            Assert.IsFalse(iguales);
        }

        [TestMethod]
        public void TestEqualsModelosDistintosSillon()
        {
            //distinta cantidad de almohadones
            bool iguales  = modeloS1.Equals(modeloS3);
            Assert.IsFalse(iguales);
        }       
    }
}
