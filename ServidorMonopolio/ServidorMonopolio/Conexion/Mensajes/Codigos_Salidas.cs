﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes
{
    class Codigos_Salidas
    {
        public const int Salida_Crear_Jugador = 1;
        public const int Salida_RechazarJugador = 2;
        public const int Salida_AsignarJugador = 3;
        public const int Salida_BorrarJugador = 4;
        public const int Salida_SesionFallida = 5;
        public const int Salida_ConexionCerrada = 6;
        public const int Salida_IniciarPartida = 7;
        public const int Salida_LanzarDado = 8;
    }
}
