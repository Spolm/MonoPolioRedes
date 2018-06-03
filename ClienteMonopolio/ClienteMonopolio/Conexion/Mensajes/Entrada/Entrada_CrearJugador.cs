using ClienteMonopolio.Conection.Mensajes.Interfaz;
using ClienteMonopolio.Conection.Mensajes.Salida;
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
    public class Entrada_CrearJugador : IMensajeEntrante
    {

        public void Ejecutar(PaqueteEntrada mensaje, Jugador jugador, ClienteMonopolio.Modelo.Juego juego, ClienteMonopolio.Graficos.GestionarVentanas grafico)
        {
            jugador.Id = mensaje.PopInt();
            jugador.Posicion = mensaje.PopInt();
            jugador.Turnos_Carcel = mensaje.PopInt();
            jugador.Turno_Activo = mensaje.PopBool();
            jugador.Cartera = mensaje.PopInt();
            jugador.Detenido = mensaje.PopBool();
            juego.AsignarFichaJugador(jugador, mensaje.PopInt());
            jugador.JugadorPrincipal = true;

            juego.CantidadJugadores = mensaje.PopInt();

            int _jugadoresConectados = mensaje.PopInt();

            Jugador _asignarJugador;

            for(int i = 0; i < _jugadoresConectados; i++)
            {
                _asignarJugador = new Jugador(mensaje.PopString());
                _asignarJugador.Id = mensaje.PopInt();
                _asignarJugador.Posicion = mensaje.PopInt();
                _asignarJugador.Turnos_Carcel = mensaje.PopInt();
                _asignarJugador.Turno_Activo = mensaje.PopBool();
                _asignarJugador.Cartera = mensaje.PopInt();
                _asignarJugador.Detenido = mensaje.PopBool();
                juego.AsignarFichaJugador(_asignarJugador, mensaje.PopInt());
                _asignarJugador.JugadorPrincipal = false;

                juego.Jugadores.Add(_asignarJugador);

                grafico.GestionarListaJugadores(_asignarJugador, false);

            }


            grafico.GestionarListaJugadores(jugador, false);

        }
    }
}
