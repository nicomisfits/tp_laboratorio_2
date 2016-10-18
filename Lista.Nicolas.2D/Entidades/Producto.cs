using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region atributos
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        #endregion

        #region constructor
        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }
        #endregion

        #region propiedades
        /// <summary>
        /// Devuelve el valor actual del atributo precio
        /// </summary>
        public float Precio { get { return this._precio; } }

        /// <summary>
        /// Devuelve el valor actual del atributo marca
        /// </summary>
        public EMarcaProducto Marca { get { return this._marca; } }

        /// <summary>
        /// devuelve el valor actual del atributo codigo
        /// </summary>
        public int CodigoBarra { get { return this._codigoBarra; } }

        /// <summary>
        /// Sirve para calcular los costos de produccion de los productos
        /// </summary>
        public abstract float CalcularCostoProduccion { get; }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra el detalle general de todos los productos de cada producto
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>string</returns>
        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Codigo de barra: " + prod._codigoBarra.ToString());
            sb.AppendLine("Marca: " + prod._marca.ToString());
            sb.AppendLine("Precio: " + prod._precio.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Aprobacion del producto
        /// </summary>
        /// <returns>string</returns>
        protected virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }
        #endregion

        #region sobrecarga de operadores
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            bool retorno = false;
            if (object.Equals(prod1, prod2))
            {
                if ((prod1._marca == prod2._marca) && (prod1._codigoBarra == prod2._codigoBarra))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public static bool operator ==(Producto prod1, EMarcaProducto marca)
        {
            bool retorno = false;
            if (prod1._marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto prod1, EMarcaProducto marca)
        {
            return !(prod1 == marca);
        }

        public static explicit operator int(Producto prod)
        {
            int x = prod._codigoBarra;
            return x;
        }

        //public static implicit operator string(Producto prod)
        //{

        //}

        #endregion    
    }
}
