using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServidorMonopolio.Modelo;
using System.Windows.Forms;

namespace ServidorMonopolio.Conexion.Mensajes.Servidor
{
    public class Servidor_CrearJugador : Paquete
    {
     
        public Servidor_CrearJugador(Jugador jugador, Juego juego)
        {
            AgregarElemento(Codigos_Salidas.Salida_Crear_Jugador.ToString());
            AgregarElemento(jugador.Id.ToString());
            AgregarElemento(jugador.Posicion.ToString());
            AgregarElemento(jugador.Turnos_Carcel.ToString());
            AgregarElemento(jugador.Turno_Activo.ToString());
            AgregarElemento(jugador.Cartera.ToString());
            AgregarElemento(jugador.Detenido.ToString());
            AgregarElemento(jugador.Ficha.Id.ToString());

            AgregarElemento(juego.CantidadJugadores.ToString());
            AgregarElemento((juego.JugadoresConectados.Count - 1).ToString());

            foreach(Jugador j in juego.JugadoresConectados.Where(u => u.Id != jugador.Id))
            {

                AgregarElemento(j.Usuario);
                AgregarElemento(j.Id.ToString());              
                AgregarElemento(j.Posicion.ToString());
                AgregarElemento(j.Turnos_Carcel.ToString());
                AgregarElemento(j.Turno_Activo.ToString());
                AgregarElemento(j.Cartera.ToString());
                AgregarElemento(j.Detenido.ToString());
                AgregarElemento(j.Ficha.Id.ToString());
            }
        }

    }
}
