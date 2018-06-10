using ServidorMonopolio.Conexion.Mensajes.Interfaz;
using ServidorMonopolio.Conexion.Mensajes.Servidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServidorMonopolio.Modelo;
using ServidorMonopolio.Modelo.Casillas;

namespace ServidorMonopolio.Conexion.Mensajes.Cliente
{
    public class Cliente_LanzarDado : IMensajeCliente
    {
        public void Ejecutar(PaqueteCliente mensaje, Jugador jugador, Juego juego, ServidorMonopolio.ServerForm ventanaServidor)
        {

            int idJugador = mensaje.PopInt();

            Jugador _jugador = juego.JugadoresConectados.Find(j => j.Id == idJugador);

            if (_jugador == null)
                return;

            juego.GestionarJugadaJugador(_jugador);

            /*foreach(Jugador j in juego.JugadoresConectados)
            {
                j.EnviarMensaje(new Servidor_LanzarDado(_jugador));
            }*/


        }

    }
}
