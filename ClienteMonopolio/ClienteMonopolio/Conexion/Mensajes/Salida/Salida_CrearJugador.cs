using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteMonopolio.Modelo;

namespace ClienteMonopolio.Conection.Mensajes.Salida
{
    public class Salida_CrearJugador : Paquete
    {
     
        public Salida_CrearJugador(Jugador jugador)
        {
            AgregarElemento(Codigos_Salidas.Salida_Crear_Jugador.ToString());
            AgregarElemento(jugador.Nombre);
        }

    }
}
