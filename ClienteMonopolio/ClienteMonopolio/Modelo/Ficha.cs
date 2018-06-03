using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMonopolio.Modelo
{
    public class Ficha
    {
        private int _id;
        private Image _imagen;
        private string _nombre;

        public Ficha(int id, Image imagen, string nombre)
        {
            _id = id;
            _imagen = imagen;
            _nombre = nombre;
        }

        public int Id
        {
            get { return _id; }
        }

        public Image Imagen
        {
            get { return _imagen; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

    }
}
