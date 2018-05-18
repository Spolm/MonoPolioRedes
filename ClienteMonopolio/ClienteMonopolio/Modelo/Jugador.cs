using ClienteMonopolio.Modelo.Tarjetas;
using ClienteMonopolio.Modelo.Casillas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ClienteMonopolio.Modelo
{
    public class Jugador
    {
        private int _id;
        private string _nombre;
        private int _cartera;
        private bool _detenido;
        private int _turnos_carcel;
        private int _posicion;
        private bool _turno_activo;
        public List<Tarjeta_Casualidad> Tarjeta_Casualidad = new List<Tarjeta_Casualidad>();
        public List<Tarjeta_Arca> Tarjeta_Arca = new List<Tarjeta_Arca>();
        private TcpClient _cliente;
        public byte[] Lectura;
        public byte[] Escritura;

        public Jugador(string nombre)
        {
            _nombre = nombre;
            Lectura = new byte[512];
        }

        public int Id
        {
            set { this._id = value; }
            get { return this._id; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        public bool Detenido
        {
            get { return this._detenido; }
            set { this._detenido = value; }
        }

        public int Posicion
        {
            get { return this._posicion; }
            set { this._posicion = value; }
        }

        public int Cartera
        {
            get { return this._cartera; }
            set { this._cartera = value; }
        }

        public int Turnos_Carcel
        {
            get { return this._turnos_carcel; }
            set { this._turnos_carcel = value; }
        }

        public bool Turno_Activo
        {
            get { return this._turno_activo; }
            set { this._turno_activo = value; }
        }

        public TcpClient Cliente
        {
            get { return this._cliente; }
            set { this._cliente = value; }
        }

        public void EnviarMensaje(ClienteMonopolio.Conection.Mensajes.Interfaz.IMensajeSalida IMensajeSalida)
        {
            try
            {
                string[] paquete = IMensajeSalida.GetMensaje();

                if (_cliente == null)
                    return;

                if (!_cliente.Connected)
                    return;

                string mensaje = string.Join(";", paquete);

                Escritura = Encoding.ASCII.GetBytes(mensaje);
                _cliente.GetStream().Write(Escritura, 0, Escritura.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().FullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
