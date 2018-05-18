using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    class Servidor_BorrarJugador : Paquete
    {
        public Servidor_BorrarJugador(Jugador jugador)
        {
            AgregarElemento(Codigos_Salidas.Salida_BorrarJugador.ToString());
            AgregarElemento(jugador.Id.ToString());
        }
    }
}
