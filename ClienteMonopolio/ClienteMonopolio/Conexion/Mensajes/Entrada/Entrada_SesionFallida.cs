using ClienteMonopolio.Conection.Mensajes.Interfaz;
using ClienteMonopolio.Conection.Mensajes.Entrada;
using ClienteMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteMonopolio.Conection.Mensajes.Entrada
{
    public class Entrada_SesionFallida : IMensajeEntrante
    {
        public void Ejecutar(PaqueteEntrada mensaje, Jugador jugador, ClienteMonopolio.Modelo.Juego juego, ClienteMonopolio.Graficos.GestionarVentanas grafico)
        {
            MessageBox.Show(mensaje.PopString());
            grafico.HabilitarJugar();
            
        }

    }
}
