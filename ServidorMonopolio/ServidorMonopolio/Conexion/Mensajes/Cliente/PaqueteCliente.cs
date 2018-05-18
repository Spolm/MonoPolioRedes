using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMonopolio.Conexion.Mensajes.Cliente
{
    public class PaqueteCliente
    {
        private string[] _mensaje;
        private int _posicion;

        public PaqueteCliente(string[] mensaje)
        {
            _mensaje = mensaje;
            _posicion = 0;
        }

        public string PopString()
        {
            _posicion++;
            return _mensaje[_posicion - 1];
        }

        public int PopInt()
        {
            _posicion++;
            return Convert.ToInt32(_mensaje[_posicion - 1]);
        }

        public bool PopBool()
        {
            _posicion++;
            return Convert.ToBoolean(_mensaje[_posicion - 1]);
        }

        public string GetITem(int pos)
        {
            return _mensaje[pos];
        }

    }
}
