using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    class Servidor_ConexionCerrada : Paquete
    {
        public Servidor_ConexionCerrada()
        {
            AgregarElemento(Codigos_Salidas.Salida_ConexionCerrada.ToString());
            AgregarElemento("El servidor ha cerrado la conexion.");
        }
    }
}
