using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorMonopolio.Modelo.Casillas
{
    public class ArcaComunal : Casilla
    {
        public override void EjecutarEfecto(Jugador jugador)
        {
            MessageBox.Show("Soy la arca comunal, Posicion: " + Posicion);
        }
    }
}
