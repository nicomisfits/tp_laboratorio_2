using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml;

namespace Entidades
{
    public class Estante
    {
        #region atributos
        protected sbyte _capacidad;
        protected List<Producto> _productos;
        #endregion

        #region propiedades
        /// <summary>
        /// Retorna el valor de todos los productos del estante
        /// </summary>
        public float ValorEstanteTotal 
        { get
            {
                float cont = 0F;
                for (int i = 0; i < this._productos.Count; i++)
                {
                    cont = cont + this._productos[i].Precio;
                }
                return cont;
            } 
        }
        #endregion

        #region constructores
        Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProducto()
        {
            return this._productos;
        }
        #endregion

        #region metodos
        /// <summary>
        /// devuelve el valor actual de la lista
        /// </summary>
        /// <returns></returns>
        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        /// <summary>
        /// Muestra el detalle de la lista
        /// </summary>
        /// <param name="e"></param>
        /// <returns>string</returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad: " + e._capacidad.ToString());
            for (int i = 0; i < e._productos.Count; i++)
            {
                if (e._productos[i] is Jugo)
                {
                    sb.AppendLine(e._productos[i].ToString());
                }
                if (e._productos[i] is Galletita)
                {
                    sb.AppendLine(e._productos[i].ToString());
                }
                if (e._productos[i] is Gaseosa)
                {
                    sb.AppendLine(e._productos[i].ToString());
                }
                if (e._productos[i] is Harina)
                {
                    sb.AppendLine(e._productos[i].ToString());
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// devuelve el valor total de un solo tipo de producto
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>float</returns>
        public float GetValorEstante(ETipoProducto tipo)
        {
            float total = 0F;
            for (int i = 0; i < this._capacidad; i++)
            {
                if (this._productos[i].GetType().Name == tipo.ToString())
                {
                    total = total + this._productos[i].Precio;
                }
            }
            return total;
        }

        /// <summary>
        /// llama a la propiedad que retorna el valor total del estante
        /// </summary>
        /// <returns>float</returns>
        private float GetValorEstante()
        {
            return ValorEstanteTotal;
        }

        /// <summary>
        /// Guarda la info del estante en un archivo de texto
        /// </summary>
        /// <param name="e"></param>
        public static void GuardarEstante(Estante e)
        {
            StreamWriter escrito = File.CreateText(@"C:\ArchivosTPrec.txt");
            for (int i = 0; i < e._productos.Count; i++)
            {
                escrito.Write(e._productos[i].ToString()); 
            }
            escrito.Flush();            
            escrito.Close(); 
        }

        /// <summary>
        /// guarda la info del estante en un archivo xml
        /// </summary>
        /// <param name="e"></param>
        public static void SerializarEstante(Estante e)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement raiz = doc.CreateElement("Estante");
            doc.AppendChild(raiz);

            XmlElement producto = doc.CreateElement("Producto");
            producto.AppendChild(doc.CreateTextNode(e._productos.ToString()));
            raiz.AppendChild(producto);

            doc.Save("c:\\archivoXml");
        }

        #endregion

        #region sobrecarga de operadores
        public static bool operator ==(Estante e, Producto prod1)
        {
            bool retorno = false;
            for (int i = 0; i < e._productos.Count; i++)
            {
                if (e._productos[i].Marca == prod1.Marca && e._productos[i].CodigoBarra== prod1.CodigoBarra)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto prod1)
        {
            return !(e == prod1);
        }

        public static Estante operator -(Estante e, Producto prod1)
        {
            if (e == prod1)
            {
                e._productos.Remove(prod1);
            }
            return e;
        }

        public static Estante operator -(Estante e, ETipoProducto tipo)
        {
            for (int i = e._capacidad-1; i > 0; i--)
            {
                if (e._productos[i].GetType().Name == tipo.ToString())
                {
                    e._productos.Remove(e._productos[i]);
                }
                if (tipo.ToString() == "Todos")
                {
                    e._productos.Clear();
                    break;
                }
            }
            return e;
        }

        public static bool operator +(Estante e, Producto prod1)
        {
            bool retorno = false;
            if (e._capacidad > e._productos.Count)
            {
                if (e != prod1)
                {
                    e._productos.Add(prod1);
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
