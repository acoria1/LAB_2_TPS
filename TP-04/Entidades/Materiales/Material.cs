using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades.Materiales;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Ceramica))]
    [XmlInclude(typeof(Madera))]
    [XmlInclude(typeof(Metal))]
    [XmlInclude(typeof(Plastico))]
    [XmlInclude(typeof(Tela))]
    [XmlInclude(typeof(Vidrio))]
    public abstract class Material 
    {
        protected double pesoEnKG;
        
        /// <summary>
        /// Constructor publico para Serializar el objeto
        /// </summary>
        public Material()
        {
            this.pesoEnKG = 0;
        }
        /// <summary>
        /// Constructor utilizado por fábrica para crear por primera vez un material
        /// </summary>
        /// <param name="peso"></param>
        public Material(double peso)
        {
            this.SetearPeso(peso);
        }

        /// <summary>
        /// Propiedad publica para Serializar el objeto. Setea o devuelve el peso.
        /// </summary>
        public double PesoEnKG
        {
            get
            {
                return this.pesoEnKG;
            }
            set
            {
                this.pesoEnKG = value;
            }
        }

        /// <summary>
        /// Key me retornará la clave del material que me permite identificarlo del resto.
        /// Sirve para diferenciar Maderas, Metales o Vidrios de distinto tipo.
        /// </summary>
        public abstract string Key {  get; }

        /// <summary>
        /// Todos los materiales devolverán un costo. Calculado por Peso * precio por kg (Globals.cs)
        /// </summary>
        public abstract double CostoTotal { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidadAGastar"> cantidad que se quiere usar de un material</param>
        /// <returns>true si se puede gastar.
        ///         false si no
        ///</returns>
        public bool PuedeGastar(double cantidadAGastar)
        {
            return !(cantidadAGastar <= 0 || cantidadAGastar > this.pesoEnKG);
        }
        /// <summary>
        /// Resta cantidad a gastar en el material
        /// </summary>
        /// <param name="cantidadAGastar"> Peso a gastar de mi material</param>
        public void Gastar(double cantidadAGastar)
        {
            this.pesoEnKG -= cantidadAGastar;
        }

        /// <summary>
        /// Propiedad que se asegura que el peso nunca pueda ser menor a 0
        /// </summary>
        /// <param name="peso"> peso en kg</param>
        void SetearPeso (double peso)
        {
            if (peso > 0)
            {
                this.pesoEnKG = peso;
            } else
            {
                this.pesoEnKG = 0;
            }
        }

        /// <summary>
        /// Suma peso a mi material siempre y cuando este sea mayor a 0.
        /// </summary>
        /// <param name="pesoAgregado"></param>
        public void AgregarPeso (double pesoAgregado)
        {
            if (pesoAgregado > 0)
            {
                this.pesoEnKG += pesoAgregado;
            }    
        }       

        /// <summary>
        /// Equals para comparar materiales por Type y luego por Key. 
        /// Se Asegura que se pueda agregar o gastar peso de un material.
        /// </summary>
        /// <param name="obj"> Material con el cual comparar 'this' (mi material)</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType() &&  this.Key == ((Material)obj).Key);
        }
    }
}
