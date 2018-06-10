using ClienteMonopolio.Modelo.Tarjetas;
using ClienteMonopolio.Modelo.Casillas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using ClienteMonopolio.Conection.Mensajes.Salida;

namespace ClienteMonopolio.Modelo
{
    public class Jugador
    {
        private int _id;
        private string _nombre;
        private string _password;
        private int _cartera;
        private bool _detenido;
        private int _turnos_carcel;
        private int _posicion;
        private bool _turno_activo;
        private bool _jugadorPrincipal;
        public List<Tarjeta_Casualidad> Tarjeta_Casualidad = new List<Tarjeta_Casualidad>();
        public List<Tarjeta_Arca> Tarjeta_Arca = new List<Tarjeta_Arca>();
        public List<Propiedad> Propiedades = new List<Propiedad>();
        private TcpClient _cliente;
        private int _turno;
        public byte[] Lectura;
        public byte[] Escritura;
        private Ficha _ficha;

        public Jugador(string nombre, string password)
        {
            _nombre = nombre;
            _password = password;
            _turno = 0;
            Lectura = new byte[512];
            _ficha = null;
            _turno_activo = false;
        }

        public Jugador(string nombre)
        {
            _nombre = nombre;
            _turno_activo = false;
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

        public string Password
        {
            get { return _password; }
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

        public int Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        public Ficha Ficha
        {
            get { return _ficha; }
            set { _ficha = value; }
        }

        public bool JugadorPrincipal
        {
            get { return _jugadorPrincipal; }
            set { _jugadorPrincipal = value; }
        }

        public void AsignarPopiedad(Propiedad propiedad)
        {
            Propiedades.Add(propiedad);
        }

        public void RemoverPropiedad(Propiedad propiedad)
        {
            Propiedades.Remove(propiedad);
        }

        public void RemoverPropiedades()
        {
            foreach(Propiedad p in Propiedades)
            {
                p.Propietario = null;
            }

            Propiedades.Clear();
        }

        public void LanzarDado()
        {
            EnviarMensaje(new Salida_LanzarDado(this));
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
