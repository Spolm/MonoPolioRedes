using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServidorMonopolio.Modelo;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    public class Servidor_AsignarJugador : Paquete
    {

        public Servidor_AsignarJugador(Jugador jugador)
        {
            AgregarElemento(Codigos_Salidas.Salida_AsignarJugador.ToString());
            AgregarElemento(jugador.Id.ToString()); //1
            AgregarElemento(jugador.Usuario.ToString()); //2
            AgregarElemento(jugador.Posicion.ToString()); //3
            AgregarElemento(jugador.Turnos_Carcel.ToString()); //4
            AgregarElemento(jugador.Turno_Activo.ToString()); //5
            AgregarElemento(jugador.Cartera.ToString()); //6
            AgregarElemento(jugador.Detenido.ToString()); //7
        }

    }
}
