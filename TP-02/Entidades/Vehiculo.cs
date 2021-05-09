﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region enums
        /// <summary>
        /// Marcas posibles de vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Tamaños posibles de vehiculos
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion
        #region atributos

        EMarca marca;
        string chasis;
        ConsoleColor color;
        #endregion

        #region constructores
        /// <summary>
        /// Instancia un vehiculo nuevo y le carga todos sus atributos
        /// </summary>
        /// <param name="marca">enum EMarca</param>
        /// <param name="chasis">string alfanumerico</param>
        /// <param name="color">enum ConsoleColor</param>
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        #endregion

        #region propiedades

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        #endregion

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// Convierte el Type de vehiculo y sus atributos a string, los agrega a un
        ///  StringBuilder y devuelve este como string.
        /// </summary>
        /// <param name="p">vehiculo a mostrar</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{(p.GetType()).Name.ToUpper()}");
            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------\n");
            sb.AppendFormat("TAMAÑO : {0}", p.Tamanio);
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">vehiculo 1</param>
        /// <param name="v2">vehiculo 2</param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">vehiculo 1</param>
        /// <param name="v2">vehiculo 2</param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
