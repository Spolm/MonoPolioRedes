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
    public class Cliente_CrearJugador : IMensajeCliente
    {
        public void Ejecutar(PaqueteCliente mensaje,Jugador jugador,Juego juego,ServidorMonopolio.ServerForm ventanaServidor)
        {
            jugador.Nombre = mensaje.PopString();

            ventanaServidor.Mostrar_Cliente(jugador, false);

            if (jugador.Id == 1)
            {
                Propiedad p = juego.Casillas.OfType<Propiedad>().Where(u => u.Propietario == null).First();
                p.Propietario = jugador;
                ventanaServidor.Gestionar_PropietarioPropiedad(p, false);

                p = juego.Casillas.OfType<Propiedad>().Where(u => u.Propietario == null).First();
                p.Propietario = jugador;
                ventanaServidor.Gestionar_PropietarioPropiedad(p, false);
            }


            ventanaServidor.Imprimir_Log(DateTime.Now + " - " + jugador.Id.ToString() + ": Se le ha asignado el nombre: " + jugador.Nombre.ToUpper());

            jugador.EnviarMensaje(new Servidor_CrearJugador(jugador,juego));

            foreach(Jugador j in juego.Jugadores.Where(u => u.Id != jugador.Id))
            {
                j.EnviarMensaje(new Servidor_AsignarJugador(jugador));
            }
        }
    }
}
