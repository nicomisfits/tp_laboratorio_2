using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        #region atributos
        protected ETipoHarina _tipo;
        protected static bool DeConsumo;
        #endregion

        #region propiedades
        /// <summary>
        /// Calcula el costo del producto
        /// </summary>
        public override float CalcularCostoProduccion { get { return base.Precio * 0.6F; } }
        #endregion

        #region constructores
        static Harina()
        {
            DeConsumo = false;
        }

        public Harina(int codigo, EMarcaProducto marca, float precio, ETipoHarina tipo): base(codigo, marca, precio)
        {
            this._tipo = tipo;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Muestra el detalle del producto
        /// </summary>
        /// <returns>string</returns>
        private string MostrarHarina()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Codigo: " + base._codigoBarra.ToString());
            sb.AppendLine("Marca: " + base.Marca.ToString());
            sb.AppendLine("Precio: " + base.Precio.ToString());
            sb.AppendLine("Tipo: " + this._tipo.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Vuelve publico el detalle del producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarHarina();
        }
        #endregion
    }
}
