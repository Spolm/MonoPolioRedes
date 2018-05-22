using ServidorMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServidorMonopolio.Conexion.Mensajes;
using ServidorMonopolio.Conexion.Mensajes.Servidor;
using ServidorMonopolio.Conexion.Mensajes.Cliente;
using ServidorMonopolio.Modelo.Casillas;

namespace ServidorMonopolio.Conexion
{
    public class Conection
    {
        private IPAddress _ip_address;
        private int _puerto;
        private TcpListener _servidor;
        private ServerForm _form;
        private Juego _juego;
        private MensajeManager _mensajeManager;
        private PaqueteCliente _paquete;
        private int count_id = 0;

        public bool Crear_Conexion(string ip, int puerto, ServerForm form, int cantidadJugadores)
        {
            try
            {
                IPAddress.TryParse(ip, out _ip_address);

                _puerto = puerto;

                _form = form;

                _mensajeManager = new MensajeManager();

                _servidor = new TcpListener(_ip_address, _puerto);

                _servidor.Start();

                _form.Imprimir_Log("Conexión abierta.");

                _juego = new Juego(cantidadJugadores);

                _servidor.BeginAcceptTcpClient(AceptandoCliente, _servidor);

                _form.Imprimir_Log("Esperando clientes...");

                MostrarPropiedades();



                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+e.ToString());
                return false;
            }

        }

        private void MostrarPropiedades()
        {
            foreach(Propiedad propiedad in _juego.Casillas.OfType<Propiedad>().OrderBy(o => o.Tipo))
            {
                _form.Mostrar_Propiedad(propiedad);
            }
        }
        private void AceptandoCliente(IAsyncResult AsyncResult)
        {
            _servidor = (TcpListener)AsyncResult.AsyncState;
            TcpClient Cliente_Entrante = null;
            Jugador _jugador;

            try
            {

                Cliente_Entrante = _servidor.EndAcceptTcpClient(AsyncResult);
                _servidor.BeginAcceptTcpClient(AceptandoCliente, _servidor); //Sigue el loop para aceptar mas clientes.

                count_id++;

                _jugador = new Jugador(count_id);
                _jugador.Cliente = Cliente_Entrante;

                if ((_juego.Jugadores.Count+1) > _juego.CantidadJugadores)
                {
                    MessageBox.Show(_jugador.Id.ToString());
                    _jugador.EnviarMensaje(new Servidor_RechazarJugador(_juego));
                    return;
                }


                _form.Imprimir_Log("Recibiendo información de un cliente...");


                lock (_juego.Jugadores)
                {
                    _juego.Jugadores.Add(_jugador);
                }

                _jugador.Lectura = new byte[512];

                // _jugador.Cliente.GetStream().BeginRead(_jugador.Lectura, 0, _jugador.Lectura.Length, RecibiendoMensajeCliente, _jugador.Cliente);

                _jugador.Cliente.Client.BeginReceive(_jugador.Lectura, 0, _jugador.Lectura.Length,0 ,new AsyncCallback(RecibiendoMensajeCliente), _jugador.Cliente);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecibiendoMensajeCliente(IAsyncResult AsyncResult)
        {
            int nCountReadBytes = 0;
            string mensaje_lectura = "";
            Jugador _jugador = null;

            lock (_juego.Jugadores)
            {
                try
                {
                    _jugador = _juego.Jugadores.Find(x => x.Cliente == (TcpClient)AsyncResult.AsyncState);

                    nCountReadBytes = _jugador.Cliente.GetStream().EndRead(AsyncResult);

                    mensaje_lectura = Encoding.ASCII.GetString(_jugador.Lectura, 0, nCountReadBytes).Trim();

                    _paquete = new PaqueteCliente(mensaje_lectura.Split(';'));

                    _mensajeManager.EjecutarMensaje(_paquete, _jugador, _juego, _form);

                }
                catch (IndexOutOfRangeException)
                {
                    _form.Imprimir_Log("Error al decodificar el mensaje: " + mensaje_lectura);
                }
                catch (System.IO.IOException)
                {
                    _form.Imprimir_Log("ATENCION: El jugador: " + _jugador.Nombre + " se ha desconectado.");
                    RemoverJugador(_jugador);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().FullName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (_jugador.Cliente.Connected)
                    {
                        _jugador.Lectura = new byte[512];
                        _jugador.Cliente.Client.BeginReceive(_jugador.Lectura, 0, _jugador.Lectura.Length, 0, new AsyncCallback(RecibiendoMensajeCliente), _jugador.Cliente);
                        //_jugador.Cliente.GetStream().BeginRead(_jugador.Lectura, 0, _jugador.Lectura.Length, RecibiendoMensajeCliente, _jugador.Cliente);
                    }
                }
            }
        }

        private void EnviarJugadorDesconectado(Jugador jugador)
        {
            foreach(Jugador j in _juego.Jugadores)
            {
                j.EnviarMensaje(new Servidor_BorrarJugador(jugador));
            }
        }

        private void RemoverJugador(Jugador jugador)
        {
            foreach (Propiedad propiedad in _juego.Casillas.OfType<Propiedad>().Where(p => p.Propietario == jugador))
            {
                _form.Gestionar_PropietarioPropiedad(propiedad, true);
                propiedad.Nivel_Penitencia = 1;
                propiedad.Propietario = null;
            }

            _juego.Jugadores.Remove(jugador);

            EnviarJugadorDesconectado(jugador);

            _form.Mostrar_Cliente(jugador, true);
        }


    }
}
