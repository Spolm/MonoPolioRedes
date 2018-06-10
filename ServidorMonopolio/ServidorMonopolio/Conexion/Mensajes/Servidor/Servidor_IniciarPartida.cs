using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    class Servidor_IniciarPartida : Paquete
    {
        public Servidor_IniciarPartida(Juego juego)
        {
            AgregarElemento(Codigos_Salidas.Salida_IniciarPartida.ToString());

            AgregarElemento(juego.JugadoresConectados.Count.ToString());

            foreach(Jugador jugador in juego.JugadoresConectados)
            {
                AgregarElemento(jugador.Id.ToString());
                AgregarElemento(jugador.Turno.ToString());
            }

        }
    }
}
