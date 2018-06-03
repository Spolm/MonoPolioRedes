
using ClienteMonopolio.Conection.Mensajes.Entrada;
using ClienteMonopolio.Conection.Mensajes.Interfaz;
using ClienteMonopolio.Conection.Mensajes.Entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteMonopolio.Conection.Mensajes
{
    class MensajeManager
    {
        private Dictionary<int, IMensajeEntrante> _mensajesEntrantes;

        public MensajeManager()
        {
            _mensajesEntrantes = new Dictionary<int, IMensajeEntrante>();
            RegistrarMensajes();

        }

        private void RegistrarMensajes()
        {
            _mensajesEntrantes.Add(Codigos_Entradas.Entrada_Crear_Jugador, new Entrada_CrearJugador());
            _mensajesEntrantes.Add(Codigos_Entradas.Entrada_RechazarJugador, new Entrada_RechazarJugador());
            _mensajesEntrantes.Add(Codigos_Entradas.Entrada_AsignarJugador, new Entrada_AsignarJugador());
            _mensajesEntrantes.Add(Codigos_Entradas.Entrada_BorrarJugador, new Entrada_BorrarJugador());
            _mensajesEntrantes.Add(Codigos_Entradas.Entrada_SesionFallida, new Entrada_SesionFallida());
            _mensajesEntrantes.Add(Codigos_Entradas.Entrada_ConexionCerrada, new Entrada_ConexionCerrada());
        }

        public void EjecutarMensaje(PaqueteEntrada mensaje, ClienteMonopolio.Modelo.Jugador jugador, ClienteMonopolio.Modelo.Juego juego, ClienteMonopolio.Graficos.GestionarVentanas graficos)
        {
            IMensajeEntrante IMensaje = Verificar_Mensaje(mensaje, graficos);

            if (IMensaje == null)
                return; //throw new PaqueteNoEncontradoException();

            try
            {
                IMensaje.Ejecutar(mensaje, jugador, juego, graficos);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
                //throw new PaqueteLecturaException();
            }
        }

        private IMensajeEntrante Verificar_Mensaje(PaqueteEntrada Split, ClienteMonopolio.Graficos.GestionarVentanas graficos)
        {
            int Codigo_Entrada = -1;
            IMensajeEntrante IMensaje = null;
            try
            {
                Codigo_Entrada = Convert.ToInt32(Split.PopString());

                if (!_mensajesEntrantes.TryGetValue(Codigo_Entrada, out IMensaje)) {

                    //graficos.Imprimir_Log("Codigo de entrada desconocido: " + Codigo_Entrada);
                    return null;
                }

                return IMensaje;

            }
            catch (Exception)
            {
                //graficos.Imprimir_Log("Error al convertir el código de entrada: "+Split[0]);
                return null;
            }

        }
    }
}
