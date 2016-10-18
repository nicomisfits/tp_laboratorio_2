using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        #region atributos
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;
        #endregion

        #region propiedades
        /// <summary>
        /// Calcula el costo del producto
        /// </summary>
        public override float CalcularCostoProduccion { get { return base.Precio * 0.4F; } }
        #endregion

        #region constructores
        static Jugo()
        {
            DeConsumo = true;
        }

        public Jugo(int codigo, EMarcaProducto marca, float precio, ESaborJugo sabor) : base(codigo, marca, precio)
        {
            this._sabor = sabor;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra el detalle del producto
        /// </summary>
        /// <returns>string</returns>
        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Codigo: " + base._codigoBarra.ToString());
            sb.AppendLine("Marca: " + base.Marca.ToString());
            sb.AppendLine("Precio: " + base.Precio.ToString());
            sb.AppendLine("Sabor: " + this._sabor.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Vuelve publico el detalle del producto
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return MostrarJugo();
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
