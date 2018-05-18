using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMonopolio.Conection.Mensajes.Entrada
{
    public class PaqueteEntrada
    {
        private string[] _mensaje;
        private int _posicion;

        public PaqueteEntrada(string[] mensaje)
        {
            _mensaje = mensaje;
            _posicion = 0;
        }

        public string PopString()
        {
            _posicion++;
            return _mensaje[_posicion-1];
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

        public string GetItem(int pos)
        {
            return _mensaje[pos];
        }
        
    }
}
