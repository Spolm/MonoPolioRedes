using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServidorMonopolio.Modelo;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    public class Servidor_LanzarDado : Paquete
    {

        public Servidor_LanzarDado(Jugador jugador)
        {
            AgregarElemento(Codigos_Salidas.Salida_LanzarDado.ToString());
            AgregarElemento(jugador.Id.ToString());
            AgregarElemento(jugador.Posicion.ToString());
            AgregarElemento(jugador.Detenido.ToString());
            AgregarElemento(jugador.Turnos_Carcel.ToString());
        }

    }
}
