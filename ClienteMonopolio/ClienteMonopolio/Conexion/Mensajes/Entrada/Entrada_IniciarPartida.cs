using ClienteMonopolio.Conection.Mensajes.Interfaz;
using ClienteMonopolio.Conection.Mensajes.Entrada;
using ClienteMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteMonopolio.Conection.Mensajes.Entrada
{
    public class Entrada_IniciarPartida : IMensajeEntrante
    {
        public void Ejecutar(PaqueteEntrada mensaje, Jugador jugador, ClienteMonopolio.Modelo.Juego juego, ClienteMonopolio.Graficos.GestionarVentanas grafico)
        {
            int CantidadJugadores = mensaje.PopInt();

            Jugador _jugadorTurno = null;
            int idJugador = 0, turnoJugador = 0;

            for(int i = 0; i < CantidadJugadores; i++)
            {
                idJugador = mensaje.PopInt();
                turnoJugador = mensaje.PopInt();

                _jugadorTurno = juego.Jugadores.Find(j => j.Id == idJugador);

                if (_jugadorTurno == null)
                {
                    return;
                }

                _jugadorTurno.Turno = turnoJugador;

                if (_jugadorTurno.Turno == 1)
                    _jugadorTurno.Turno_Activo = true;
            }

            juego.PartidaIniciada = true;

            grafico.ComenzarJuego();
            
        }

    }
}
