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
    public class Entrada_AsignarJugador : IMensajeEntrante
    {
        public void Ejecutar(PaqueteEntrada mensaje, Jugador jugador, ClienteMonopolio.Modelo.Juego juego, ClienteMonopolio.Graficos.GestionarVentanas grafico)
        {
            int id_usuario = mensaje.PopInt();

            if (id_usuario == jugador.Id || juego.Jugadores.Exists(u => u.Id == id_usuario))
            {
                return;
            }

            string nombre = mensaje.PopString();
            
            Jugador _nuevoJugador = new Jugador(nombre);

            _nuevoJugador.Id = id_usuario;
            _nuevoJugador.Posicion = mensaje.PopInt();
            _nuevoJugador.Turnos_Carcel = mensaje.PopInt();
            _nuevoJugador.Turno_Activo = mensaje.PopBool();
            _nuevoJugador.Cartera = mensaje.PopInt();
            _nuevoJugador.Detenido = mensaje.PopBool();
            juego.AsignarFichaJugador(_nuevoJugador, mensaje.PopInt());
            _nuevoJugador.JugadorPrincipal = false;

            juego.Jugadores.Add(_nuevoJugador);

            grafico.GestionarListaJugadores(_nuevoJugador, false);
        }

    }
}
