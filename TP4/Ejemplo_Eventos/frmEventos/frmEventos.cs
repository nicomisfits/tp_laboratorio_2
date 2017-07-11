using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Eventos
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            // Se genera un evento, con un tiempo de 3s
            Evento lanzaEvento = new Evento(3000);

            // Le asigno el puntero del metodo al evento
            lanzaEvento.EventoQueGenera += EventoGenerado;

            // Ejecuto un método de la clase que genera el evento
            lanzaEvento.esteMetodoGeneraEvento();
        }

        private void EventoGenerado(string mensaje)
        {
            // Mensaje del evento.
            MessageBox.Show(mensaje);
        }
    }
}
