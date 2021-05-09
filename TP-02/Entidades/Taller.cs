using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        public enum ETipo { Ciclomotor, Sedan, SUV, Todos }

        #region Atributos

        List<Vehiculo> vehiculos;
        int espacioDisponible;

        #endregion
        #region Constructores
        /// <summary>
        /// Instanciará la lista de vehiculos y seteará el espacio disponible en 0.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
            this.espacioDisponible = 0;
        }

        /// <summary>
        /// Llama al constructor sin parametros. Setea el espacio disponible. Si recibe int negativo o 0, quedará en 0.
        /// </summary>
        /// <param name="espacioDisponible">cantidad máxima de vehiculos que se podran agregar a mi taller</param>
        public Taller(int espacioDisponible):this()
        {
            if (espacioDisponible > 0)
            {
                this.espacioDisponible = espacioDisponible;
            }
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del Taller y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido. Si recibe 'ETipo.Todos' mostrará todos los vehiculos
        /// </summary>
        /// <param name="taller">Taller a exponer</param>
        /// <param name="ETipo">Types de ítems a mostrar en la lista</param>
        /// <returns></returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles\n", taller.vehiculos.Count, taller.espacioDisponible);

            foreach (Vehiculo v in taller.vehiculos)
            {
                if (tipo == ETipo.Todos) // Agrega todos los vehiculos
                {
                    sb.AppendLine(v.Mostrar());
                } 
                else if (v.GetType().Name.ToLower() == tipo.ToString().ToLower())
                    // convierto el Type de cada vehiculo a string y comparo con el 'ETipo' ingresado
                {
                    sb.AppendLine(v.Mostrar()); // si coniciden agrego el vehiculo
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestro el Taller y TODOS los vehículos. Llama a Listar()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Listar(this, ETipo.Todos);
        }
        #endregion

        #region Operadores
        /// <summary>
        /// Si hay lugar y el vehiculo NO se encuentra en el Taller, lo agregará a 
        /// la lista de vehiculos.
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el vehiculo</param>
        /// <param name="vehiculo">Vehiculo a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if (taller.espacioDisponible > taller.vehiculos.Count)
            {
                bool esta = false;
                foreach (Vehiculo v in taller.vehiculos) 
                {
                    if (v == vehiculo) // si los chasis son iguales dirá que esta en el taller
                    {
                        esta = true;
                        break; // si lo encuentra deja de buscar.
                    }
                }
                if (!esta) // si no está lo agregamos
                {
                    taller.vehiculos.Add(vehiculo);
                }
            }
            return taller;
        }
        /// <summary>
        /// Quitará un vehiculo de la lista
        /// </summary>
        /// <param name="taller">Taller del cual se quitará el vehiculo</param>
        /// <param name="vehiculo">Vehiculo a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            bool esta = false;
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo) // si hay un chasis en taller igual al del vehiculo a quitar nos dirá que es posible quitarlo.
                {
                    esta = true;
                    break; // si encuentra coincidencia de chasis deja de buscar.
                }
            }
            if (esta) // quita el vehiculo
            {
                taller.vehiculos.Remove(vehiculo); // Si hubiera dos vehiculos distintos con el mismo chasis (no en el taller, pero instanciados), al querer hacer el remove de la lista no removerá nada ya que el objeto es distinto.
            }
            return taller;
        }
        #endregion
    }
}
