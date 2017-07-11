using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    class Numero
    {
        /// <summary>
        /// Constructor por defecto de numero.
        /// </summary>
        private double numero;

        #region constructores
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// constructor de numero que toma un string
        /// </summary>
        /// <param name="numero">string recibido</param>
        public Numero(string numero): this()
        {
            setNumero(numero);
        }

        /// <summary>
        /// constructor de numero toma un double
        /// </summary>
        /// <param name="d1">double recibido</param>
        public Numero(double d1): this()
        {
            this.numero = d1;
        }

        #endregion

        # region metodos
        /// <summary>
        /// metodo que valida que el string recibido pueda convertirse en double
        /// </summary>
        /// <param name="numeroValida">sring a validar</param>
        /// <returns>0D si no valida | valor double si valida</returns>
        private static double ValidarNumero(string numeroValida)
        {            
            double retorno;
            bool aplica = double.TryParse(numeroValida, out retorno);
            if (!aplica)
            {
                retorno = 0D;
            }
            return retorno;
        }

        /// <summary>
        /// asigna valor validado al atributo de la clase.
        /// </summary>
        /// <param name="numeroSet">string a validar y asignar</param>
        private void setNumero(string numeroSet)
        {
            this.numero = ValidarNumero(numeroSet);
        }

        /// <summary>
        /// llama al numero asignado para utilizarlo como tal.
        /// </summary>
        /// <returns>double</returns>
        public double getNumero()
        {            
            double retorno = this.numero;
            return retorno;
        }

        # endregion

        # region sobrecarga de operadores (no utilizado)
        //public static double operator +(Numero n1, Numero n2)
        //{            
        //    double retorno = n1.numero + n2.numero;
        //    return retorno;
        //}

        //public static double operator -(Numero n1, Numero n2)
        //{            
        //    double retorno = n1.numero - n2.numero;
        //    return retorno;
        //}

        //public static double operator *(Numero n1, Numero n2)
        //{            
        //    double retorno = n1.numero * n2.numero;
        //    return retorno;
        //}

        //public static double operator /(Numero n1, Numero n2)
        //{            
        //    double retorno = n1.numero / n2.numero;
        //    return retorno;
        //}

        //public static bool operator ==(Numero n1, double d1)
        //{
        //    bool retorno = false;
        //    if (n1.numero == d1)
        //    {
        //        retorno = true;
        //    }
        //    return retorno;
        //}

        //public static bool operator !=(Numero n1, double d1)
        //{
        //    return !(n1 == d1);
        //}

        # endregion
    }
}
