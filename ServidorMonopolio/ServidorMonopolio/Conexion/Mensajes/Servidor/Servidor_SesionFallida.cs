using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    class Servidor_SesionFallida : Paquete
    {
        public Servidor_SesionFallida()
        {
            AgregarElemento(Codigos_Salidas.Salida_SesionFallida.ToString());
            AgregarElemento("Error al iniciar sesion, datos incorrectos.");
        }
    }
}
