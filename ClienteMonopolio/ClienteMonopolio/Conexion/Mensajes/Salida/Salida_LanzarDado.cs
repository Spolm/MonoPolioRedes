using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteMonopolio.Modelo;

namespace ClienteMonopolio.Conection.Mensajes.Salida
{
    public class Salida_LanzarDado : Paquete
    {
     
        public Salida_LanzarDado(Jugador jugador)
        {
            AgregarElemento(Codigos_Salidas.Salida_Lanzar_Dado.ToString());
            AgregarElemento(jugador.Id.ToString());
        }

    }
}
