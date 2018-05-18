using ClienteMonopolio.Conection.Mensajes;
using ClienteMonopolio.Conection.Mensajes.Salida;
using ClienteMonopolio.Conection.Mensajes.Entrada;
using ClienteMonopolio.Graficos;
using ClienteMonopolio.Modelo;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClienteMonopolio.Conection
{

    public class Conexion
    {
        private GestionarVentanas _graficos;
        private Jugador _jugador;
        private MensajeManager _mensajeManager;
        private Juego _juego;
        private PaqueteEntrada _paquete;

        public bool CrearConexion(vInicio form, IPAddress ip, int port, string nombre)
        {
            try
            {
                _jugador = new Jugador(nombre);
                _jugador.Cliente = new TcpClient();

                _juego = new Juego();

                JuegoForm _juegoForm = new JuegoForm();

                _graficos = new GestionarVentanas(form, _juegoForm);

                _mensajeManager = new MensajeManager();

                _jugador.Cliente.BeginConnect(ip, port, ConexionCompleta, _jugador.Cliente);


                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }



        void ConexionCompleta(IAsyncResult iar)
        {

            try
            {
                //_ventanaInicio.GestionarVentanas(_juegoForm);

                _jugador.Cliente = (TcpClient)iar.AsyncState;
                _jugador.Cliente.EndConnect(iar);
                _jugador.Lectura = new byte[512];

                _jugador.Cliente.GetStream().BeginRead(_jugador.Lectura, 0, _jugador.Lectura.Length, LecturaDelServidor, _jugador.Cliente);

                _jugador.EnviarMensaje(new Salida_CrearJugador(_jugador));

            }
            catch (Exception exc)
            {
                _graficos.HabilitarJugar();
                MessageBox.Show(exc.Message);
            }

        }

        void LecturaDelServidor(IAsyncResult iar)
        {
            int BytesRecibidos;
            string mensajeRecibido;

            try
            {

                _jugador.Cliente = (TcpClient)iar.AsyncState;
                BytesRecibidos = _jugador.Cliente.GetStream().EndRead(iar);

                if (BytesRecibidos == 0)
                {
                    MessageBox.Show("Conexión cerrada.");
                    _graficos.CerrarVentanas();
                    return;
                }

                mensajeRecibido = Encoding.ASCII.GetString(_jugador.Lectura, 0, BytesRecibidos);

                _paquete = new PaqueteEntrada(mensajeRecibido.Split(';'));
                _mensajeManager.EjecutarMensaje(_paquete, _jugador, _juego, _graficos);

                _jugador.Lectura = new byte[512];
                _jugador.Cliente.GetStream().BeginRead(_jugador.Lectura, 0, _jugador.Lectura.Length, LecturaDelServidor, _jugador.Cliente);
            }
            catch (PaqueteNoEncontradoException)
            {
                MessageBox.Show("Mensaje desconocido");
            }
            catch(PaqueteLecturaException e)
            {
                MessageBox.Show(e.ToString());
                _graficos.CerrarVentanas();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
                _graficos.CerrarVentanas();
            }
        }


    }
}
