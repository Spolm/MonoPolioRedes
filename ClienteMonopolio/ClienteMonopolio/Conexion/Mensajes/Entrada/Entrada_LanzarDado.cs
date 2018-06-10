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
    public class Entrada_LanzarDado : IMensajeEntrante
    {
        public void Ejecutar(PaqueteEntrada mensaje, Jugador jugador, ClienteMonopolio.Modelo.Juego juego, ClienteMonopolio.Graficos.GestionarVentanas grafico)
        {
            int idJugador = mensaje.PopInt();
            int Posicion = mensaje.PopInt();
            bool Detenido = mensaje.PopBool();
            int TurnosEnCarcel = mensaje.PopInt();

            Jugador _jugador = juego.Jugadores.Find(j => j.Id == idJugador);

            if (_jugador == null)
                return;

            _jugador.Posicion = Posicion;
            _jugador.Detenido = Detenido;
            _jugador.Turnos_Carcel = TurnosEnCarcel;

            grafico.ActualizarFichaJugador(_jugador);   
        }

    }
}
