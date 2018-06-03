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
    public class Cliente_IniciarSesion : IMensajeCliente
    {
        public void Ejecutar(PaqueteCliente mensaje, Jugador jugador, Juego juego, ServidorMonopolio.ServerForm ventanaServidor)
        {
            jugador.Usuario = mensaje.PopString();
            jugador.Password = mensaje.PopString();

            Jugador _newJugador = null;

            _newJugador = juego.JugadoresRegistrados.Find(j => j.Usuario.ToLower() == jugador.Usuario.ToLower() && j.Password == jugador.Password);

            if (_newJugador == null)
            {
                juego.JugadoresConectados.Remove(jugador);
                jugador.EnviarMensaje(new Servidor_SesionFallida());
                return;
            }

            jugador.Id = _newJugador.Id;
            jugador.Nombre = _newJugador.Nombre;
            jugador.Apellido = _newJugador.Apellido;
            juego.AsignarFichaJugador(jugador);



            ventanaServidor.Mostrar_Cliente(jugador, false);


            ventanaServidor.Imprimir_Log(DateTime.Now + " - " + jugador.Id.ToString() + ": Se le ha asignado el nombre: " + jugador.Usuario.ToUpper());

            jugador.EnviarMensaje(new Servidor_CrearJugador(jugador, juego));

            foreach (Jugador j in juego.JugadoresConectados.Where(u => u.Id != jugador.Id))
            {
                j.EnviarMensaje(new Servidor_AsignarJugador(jugador));
            }


        }

    }
}
