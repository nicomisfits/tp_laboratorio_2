using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_12_Library_2
{
    public abstract class Vehiculo
    {
        
        EMarca _marca;
        string _patente;
        ConsoleColor _color;

        public Vehiculo(string patente, EMarca marca, ConsoleColor color)
        {
            this._patente = patente;
            this._marca = marca;
            this._color = color;
        }

        /// <summary>
        /// Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public virtual short CantidadRuedas { get { return this.CantidadRuedas;} }
        public string propMostrar { get { return this.Mostrar(); } }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("PATENTE: {0}\r\n", this._patente);
            sb.AppendFormat("MARCA  : {0}\r\n", this._marca.ToString());
            sb.AppendFormat("COLOR  : {0}\r\n", this._color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehículos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (v1._patente == v2._patente)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos vehículos son distintos si su patente es distinta
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
