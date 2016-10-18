using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormEstante
{
    public partial class Form1 : Form
    {
        Estante est1 = new Estante(4);
        Estante est2 = new Estante(3);

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnExe_Click(object sender, EventArgs e)
        {            
            Harina h1 = new Harina(102, EMarcaProducto.Favorita, 37.5f, ETipoHarina.CuatroCeros);
            Harina h2 = new Harina(103, EMarcaProducto.Favorita, 40.25f, ETipoHarina.Integral);
            Galletita g1 = new Galletita(113, EMarcaProducto.Pitusas, 33.65f, 250f);
            Galletita g2 = new Galletita(111, EMarcaProducto.Diversión, 56f, 500f);
            Jugo j1 = new Jugo(112, EMarcaProducto.Naranjú, 25f, ESaborJugo.Pasable);
            Jugo j2 = new Jugo(333, EMarcaProducto.Swift, 33f, ESaborJugo.Asqueroso);
            Gaseosa g = new Gaseosa(j2, 2250f);
            if (!(est1 + h1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + j1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + h2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + j2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + g1))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            this.richTextBox1.Text = Estante.MostrarEstante(est1);
        }

        private void btnOrdernar_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            est1.GetProductos().Sort(Form1.OrdenarProductos);
            this.richTextBox1.Text = Estante.MostrarEstante(est1);
        }

        public static int OrdenarProductos(Producto prod1, Producto prod2)
        {
            int retorno = 0;
            if (prod1.CodigoBarra > prod2.CodigoBarra)
            {
                retorno = 1;
            }
            if (prod1.CodigoBarra == prod2.CodigoBarra)
            {
                retorno = 0;
            }
            if (prod1.CodigoBarra < prod2.CodigoBarra)
            {
                retorno = -1;
            }
            return retorno;
        }
    }
}
