using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections;
using Entidades.Excepciones;
using Entidades;
using Entidades.Modelos;
using Entidades.Materiales;

namespace UnitTestFabricaMuebles
{
    [TestClass]
    public class UnitTestMaterial
    {
        public static Ceramica ceramica1, ceramica2, ceramica3;
        public static Madera madera1, madera2, madera3, madera4;
        public static Vidrio vidrio1, vidrio2, vidrio3,vidrio4;
        public static Plastico plastico1, plastico2, plastico3;
        public static Metal metal1, metal2, metal3, metal4;

        public static List<Material> materiales1, materiales2, materiales3, materiales4, materiales5;



       [TestInitialize]
       public void Initialize()
        {
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

            materiales1 = new List<Material>();
            materiales2 = new List<Material>();
            materiales3 = new List<Material>();
            materiales4 = new List<Material>();
            materiales5 = new List<Material>();

            materiales1.Add(ceramica1);
            materiales1.Add(vidrio1);
            materiales1.Add(plastico1);
            materiales1.Add(metal1);
            materiales1.Add(madera1);

            materiales2.Add(ceramica1);
            materiales2.Add(vidrio1);
            materiales2.Add(plastico1);
            materiales2.Add(metal1);
            materiales2.Add(madera1);

            materiales3.Add(metal1);
            materiales3.Add(madera1);
            materiales3.Add(ceramica1);
            materiales3.Add(vidrio1);
            materiales3.Add(plastico1);

            materiales4.Add(metal1);
            materiales4.Add(madera1);
            materiales4.Add(ceramica1);
            materiales4.Add(vidrio1);

            materiales5.Add(ceramica2);
            materiales5.Add(vidrio2);
            materiales5.Add(plastico2);
            materiales5.Add(metal4);
            materiales5.Add(madera3);
        }


        [TestMethod]   
        // Prueba la sobrecarga del método Equals() en Entidades.Materiales.Material
        public void TestEqualsMaterialesSinTipoIguales()
        {
            bool mismoMaterial = ceramica1.Equals(ceramica1);
            bool mismoEstado = ceramica1.Equals(ceramica2);

            Assert.IsTrue(mismoMaterial);
            Assert.IsTrue(mismoEstado);

            mismoMaterial = plastico1.Equals(plastico1);
            mismoEstado = plastico1.Equals(plastico2);

            Assert.IsTrue(mismoMaterial);
            Assert.IsTrue(mismoEstado);

            //Distinto Peso
            bool sonIguales = ceramica1.Equals(ceramica3);
            Assert.IsTrue(sonIguales);
        }

        [TestMethod]
        public void TestEqualsMaterialesSinTipoDistintos()
        {

            // distinto Type, mismo peso
            bool sonIguales  = ceramica1.Equals(plastico1);
            Assert.IsFalse(sonIguales);
        }

        [TestMethod]
        public void TestEqualsMaterialesConTipoIguales()
        {
            bool mismoMaterial = metal1.Equals(metal1);
            bool mismoEstado = metal1.Equals(metal2);

            Assert.IsTrue(mismoMaterial);
            Assert.IsTrue(mismoEstado);

            mismoMaterial = vidrio1.Equals(vidrio1);
            mismoEstado = vidrio1.Equals(vidrio2);

            Assert.IsTrue(mismoMaterial);
            Assert.IsTrue(mismoEstado);

            mismoMaterial = madera1.Equals(madera1);
            mismoEstado = madera1.Equals(madera2);

            Assert.IsTrue(mismoMaterial);
            Assert.IsTrue(mismoEstado);
        }

        [TestMethod]
        public void TestEqualsMaterialesConTipoDistintos()
        {
            // distinto tipo (enum)
            bool sonIguales  = madera2.Equals(madera3);
            Assert.IsFalse(sonIguales);
            sonIguales = vidrio2.Equals(vidrio3);
            Assert.IsFalse(sonIguales);
            sonIguales = metal2.Equals(metal3);
            Assert.IsFalse(sonIguales);
        }

        [TestMethod]

        public void TestListasIguales()
        {
            // mismos materiales 
            bool sonIguales = Modelo.TienenMismosMateriales(materiales1,materiales2);
            Assert.IsTrue(sonIguales);
            // mismos materiales distinto orden
            sonIguales = Modelo.TienenMismosMateriales(materiales1, materiales3);
            Assert.IsTrue(sonIguales);
        }

        [TestMethod]
        public void TestListasDistintas()
        {
            // distintos materiales
            bool sonIguales = Modelo.TienenMismosMateriales(materiales1, materiales5);
            Assert.IsFalse(sonIguales);
            // lista 1 contenida en lista 2
            sonIguales = Modelo.TienenMismosMateriales(materiales4, materiales1);
            Assert.IsFalse(sonIguales);
            // lista 2 contenida en lista 1
            sonIguales = Modelo.TienenMismosMateriales(materiales1, materiales4);
            Assert.IsFalse(sonIguales);
        }
    }
}
