using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        #region atributos
        protected float _litros;
        protected static bool DeConsumo;
        #endregion

        #region propiedades
        /// <summary>
        /// Calcula el costo del producto
        /// </summary>
        public override float CalcularCostoProduccion { get { return base.Precio * 0.42F; } }
        #endregion

        #region constructores
        static Gaseosa()
        {
            DeConsumo = true;
        }

        public Gaseosa(int codigo, float precio, EMarcaProducto marca, float litros)
            : base(codigo, marca, precio)
        { }

        public Gaseosa(Producto prod, float litros)
            : this(prod.CodigoBarra, prod.Precio, prod.Marca, litros)
        {
            this._litros = litros;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra el detalle del producto
        /// </summary>
        /// <returns>string</returns>
        private string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Codigo: " + base._codigoBarra.ToString());
            sb.AppendLine("Marca: " + base.Marca.ToString());
            sb.AppendLine("Precio: " + base.Precio.ToString());
            sb.AppendLine("Litros: " + this._litros.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Vuelve publico el detalle del producto
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return MostrarGaseosa();
        }

        /// <summary>
        /// Aprobacion
        /// </summary>
        /// <returns>string</returns>
        protected override string Consumir()
        {
            return "Bebible";
        }
        #endregion
    }
}
