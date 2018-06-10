using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMonopolio.Conection.Mensajes
{
    public static class Codigos_Entradas
    {
        //Inicio de sesion y manejo de conexión
        public const int Entrada_Crear_Jugador = 1;
        public const int Entrada_RechazarJugador = 2;
        public const int Entrada_AsignarJugador = 3;
        public const int Entrada_BorrarJugador = 4;
        public const int Entrada_SesionFallida = 5;
        public const int Entrada_ConexionCerrada = 6;


        //Partida Iniciada
        public const int Entrada_IniciarPartida = 7;
        public const int Entrada_LanzarDado = 8;
    }
}
