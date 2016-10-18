using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        #region atributos
        protected float _peso;
        protected static bool DeConsumo;
        #endregion

        #region propiedades
        /// <summary>
        /// Calcula el costo del producto
        /// </summary>
        public override float CalcularCostoProduccion { get { return base.Precio * 0.33F; } }
        #endregion

        #region constructores
        static Galletita()
        {
            DeConsumo = true;
        }

        public Galletita(int codigo, EMarcaProducto marca, float precio, float peso)
            : base(codigo, marca, precio)
        {
            this._peso = peso;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra el detalle del producto
        /// </summary>
        /// <param name="galleta"></param>
        /// <returns>string</returns>
        private static string MostrarGalletita(Galletita galleta)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Codigo: " + galleta._codigoBarra.ToString());
            sb.AppendLine("Marca: " + galleta.Marca.ToString());
            sb.AppendLine("Precio: " + galleta.Precio.ToString());
            sb.AppendLine("Peso: " + galleta._peso.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Vuelve publico el detalle del producto
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Codigo: " + this._codigoBarra.ToString());
            sb.AppendLine("Marca: " + this.Marca.ToString());
            sb.AppendLine("Precio: " + this.Precio.ToString());
            sb.AppendLine("Peso: " + this._peso.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Aprobacion
        /// </summary>
        /// <returns>string</returns>
        protected override string Consumir()
        {
            return "Comestible";
        }
        #endregion
    }
}
