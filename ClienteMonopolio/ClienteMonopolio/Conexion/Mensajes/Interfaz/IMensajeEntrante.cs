using ClienteMonopolio.Modelo;
using ClienteMonopolio.Graficos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteMonopolio.Conection.Mensajes.Entrada;

namespace ClienteMonopolio.Conection.Mensajes.Interfaz
{
    public interface IMensajeEntrante
    {
        void Ejecutar(PaqueteEntrada mensaje, Jugador jugador, Juego juego, GestionarVentanas grafico);
    }
}
