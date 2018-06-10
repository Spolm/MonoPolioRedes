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

        public bool Crear_Conexion(string ip, int puerto, ServerForm form, int cantidadJugadores, Juego juego)
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

                _juego = juego;

                _juego.CantidadJugadores = cantidadJugadores;

                _juego.Connected = true;

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
                if (_servidor == null || _servidor.Server == null)
                    return;

                Cliente_Entrante = _servidor.EndAcceptTcpClient(AsyncResult);
                _servidor.BeginAcceptTcpClient(AceptandoCliente, _servidor); //Sigue el loop para aceptar mas clientes.


                _jugador = new Jugador();
                _jugador.Cliente = Cliente_Entrante;

                if ((_juego.JugadoresConectados.Count + 1) > _juego.CantidadJugadores)
                {
                    _jugador.EnviarMensaje(new Servidor_RechazarJugador(_juego));
                    return;
                }

                if (_juego.Iniciado)
                {
                    //enviar rechazo
                    return;
                }


                _form.Imprimir_Log("Recibiendo información de un cliente...");


                lock (_juego.JugadoresConectados)
                {
                    _juego.JugadoresConectados.Add(_jugador);
                }

                _jugador.Lectura = new byte[512];

                // _jugador.Cliente.GetStream().BeginRead(_jugador.Lectura, 0, _jugador.Lectura.Length, RecibiendoMensajeCliente, _jugador.Cliente);

                _jugador.Cliente.Client.BeginReceive(_jugador.Lectura, 0, _jugador.Lectura.Length,0 ,new AsyncCallback(RecibiendoMensajeCliente), _jugador.Cliente);

            }
            catch(ObjectDisposedException)
            {
                MessageBox.Show("Conexión finalizada", "¡Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecibiendoMensajeCliente(IAsyncResult AsyncResult)
        {
            int nCountReadBytes = 0;
            string mensaje_lectura = "";
            Jugador _jugador = null;

            lock (_juego.JugadoresConectados)
            {
                try
                {
                    _jugador = _juego.JugadoresConectados.Find(x => x.Cliente == (TcpClient)AsyncResult.AsyncState);

                    if (_jugador == null)
                        return;

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
                    _form.Imprimir_Log("ATENCION: El jugador: " + _jugador.Usuario + " se ha desconectado.");
                    RemoverJugador(_jugador);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if(_jugador != null)
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
        }

        public void CerrarConexion()
        {
            foreach(Jugador _jugador in _juego.JugadoresConectados)
            {
                _jugador.EnviarMensaje(new Servidor_ConexionCerrada());
            }
            _servidor.Stop();
            _servidor = null;
            _juego.ReiniciarJuego();

        }

        private void EnviarJugadorDesconectado(Jugador jugador)
        {
            foreach(Jugador j in _juego.JugadoresConectados)
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

            jugador.Ficha.Asignada = false;

            _juego.JugadoresConectados.Remove(jugador);

            EnviarJugadorDesconectado(jugador);

            _form.Mostrar_Cliente(jugador, true);
        }


    }
}
