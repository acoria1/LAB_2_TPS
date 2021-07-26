using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades.Excepciones;
using Entidades.Muebles;
using Entidades.Modelos;
using Entidades.Materiales;
using System.Collections.Generic;
using Entidades;

namespace UnitTestModelos
{
    [TestClass]
    public class UnitTestExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(ExceptionColorInvalido))]
        public void TestExceptionColorInvalido()
        {
            List<Material> materiales1 = new List<Material>();
            materiales1.Add(new Ceramica(2));
            EColor[] colores = { EColor.Azul, EColor.Gris };
            Modelo modelo1 = new ModeloMesa(new Dimensiones(1, 1, 1), "m1", materiales1, EEspacio.Exterior, colores);
            Mueble m = new Mueble(modelo1, DateTime.Now, EColor.Amarillo);
        }

        [DataTestMethod]    
        [DataRow(0,1,1)]
        [DataRow(1, 0, 1)]
        [DataRow(1, 1, 0)]
        [DataRow(10001, 5, 5)]
        [DataRow(5, 10001, 5)]
        [DataRow(5, 5, 10001)]
        [ExpectedException(typeof(ExceptionDimensionesInvaldas))]
        public void TestDimensionesInvalidas(double alto, double ancho, double profundidad)
        {
            Dimensiones d = new Dimensiones(alto, ancho, profundidad);
            List<Material> materiales1 = new List<Material>();
            materiales1.Add(new Ceramica(2));
            EColor[] colores = { EColor.Azul, EColor.Gris };
            Modelo modelo1 = new ModeloMesa(d, "m1", materiales1, EEspacio.Exterior, colores);
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789")]
        [ExpectedException(typeof(ExceptionNombreModeloInvalido))]
        public void TestNombreModeloInvalido(string nombre)
        {
            Dimensiones d = new Dimensiones(5,5,5);
            List<Material> materiales1 = new List<Material>();
            materiales1.Add(new Ceramica(2));
            EColor[] colores = { EColor.Azul, EColor.Gris };
            Modelo modelo1 = new ModeloMesa(d, nombre, materiales1, EEspacio.Exterior, colores);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionSillonSinAlmohadones))]
        public void TestSillonSinAlmohadones()
        {
            Dimensiones d = new Dimensiones(5, 5, 5);
            List<Material> materiales1 = new List<Material>();
            materiales1.Add(new Ceramica(2));
            EColor[] colores = { EColor.Azul, EColor.Gris };
            Modelo modelo1 = new ModeloSillon(d, "sillon", materiales1, colores, 0);
        }
    }
}
