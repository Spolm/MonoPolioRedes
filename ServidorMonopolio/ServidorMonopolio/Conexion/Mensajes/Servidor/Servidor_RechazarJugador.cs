using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    class Servidor_RechazarJugador : Paquete
    {
        public Servidor_RechazarJugador(Juego _juego)
        {
            AgregarElemento(Codigos_Salidas.Salida_RechazarJugador.ToString());
            AgregarElemento("Lo sentimos, la partida esta llena. (Numero maximo de jugadores: "+_juego.CantidadJugadores+")");
        }
    }
}
