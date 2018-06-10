using ClienteMonopolio.Modelo.Casillas;
using ClienteMonopolio.Modelo.Tarjetas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMonopolio.Modelo
{
    public class Juego
    {
        public List<Jugador> Jugadores = new List<Jugador>();
        public List<Casilla> Casillas = new List<Casilla>();
        public List<Tarjeta_Arca> Tarjetas_Arca = new List<Tarjeta_Arca>();
        public List<Tarjeta_Casualidad> Tarjetas_Casualidad = new List<Tarjeta_Casualidad>();
        public List<Ficha> Fichas = new List<Ficha>();
        public int Fondo_Impuesto;
        public Banco Banco;
        private int _cantidadJugadores;
        public bool PartidaIniciada;

        private static Juego _juego;

        private Juego()
        {

            this.Fondo_Impuesto = 0;

            this.Banco = new Banco();

            PartidaIniciada = false;

            CrearFichas();

        }

        public static Juego ObtenerJuego
        {
            get
            {
                if (_juego == null)
                    _juego = new Juego();

                return _juego;
            }
        }

        public int CantidadJugadores
        {
            get { return _cantidadJugadores; }
            set { _cantidadJugadores = value; }
        }

        public void AsignarFichaJugador(Jugador jugador, int idFicha)
        {
            if (jugador.Ficha != null)
                return;

            jugador.Ficha = Fichas.Find(f => f.Id == idFicha);
        }
        
        private void CrearFichas()
        {
            Ficha ficha;

            ficha = new Ficha(1, "Rojo");
            ficha.AsignarCoordenadaFicha(0, 495, 498);
            ficha.AsignarCoordenadaFicha(1, 447, 510);
            ficha.AsignarCoordenadaFicha(2, 402, 510);
            ficha.AsignarCoordenadaFicha(3, 357, 510);
            ficha.AsignarCoordenadaFicha(4, 311, 510);
            ficha.AsignarCoordenadaFicha(5, 267, 510);
            ficha.AsignarCoordenadaFicha(6, 220, 510);
            ficha.AsignarCoordenadaFicha(7, 175, 510);
            ficha.AsignarCoordenadaFicha(8, 129, 510);
            ficha.AsignarCoordenadaFicha(9, 85, 510);
            ficha.AsignarCoordenadaFicha(10, 16, 510);
            ficha.AsignarCoordenadaFicha(11, 37, 448);
            ficha.AsignarCoordenadaFicha(12, 37, 403);
            ficha.AsignarCoordenadaFicha(13, 37, 258);
            ficha.AsignarCoordenadaFicha(14, 37, 312);
            ficha.AsignarCoordenadaFicha(15, 37, 266);
            ficha.AsignarCoordenadaFicha(16, 37, 220);
            ficha.AsignarCoordenadaFicha(17, 37, 175);
            ficha.AsignarCoordenadaFicha(18, 37, 129);
            ficha.AsignarCoordenadaFicha(19, 37, 83);
            ficha.AsignarCoordenadaFicha(20, 37, 16);
            ficha.AsignarCoordenadaFicha(21, 107,16);
            ficha.AsignarCoordenadaFicha(22, 152, 16);
            ficha.AsignarCoordenadaFicha(23, 197, 16);
            ficha.AsignarCoordenadaFicha(24, 243, 16);
            ficha.AsignarCoordenadaFicha(25, 289, 16);
            ficha.AsignarCoordenadaFicha(26, 334, 16);
            ficha.AsignarCoordenadaFicha(27, 380, 16);
            ficha.AsignarCoordenadaFicha(28, 425, 16);
            ficha.AsignarCoordenadaFicha(29, 470, 16);
            ficha.AsignarCoordenadaFicha(30, 540, 16);
            ficha.AsignarCoordenadaFicha(31, 540, 84);
            ficha.AsignarCoordenadaFicha(32, 540, 129);
            ficha.AsignarCoordenadaFicha(33, 540, 175);
            ficha.AsignarCoordenadaFicha(34, 540, 220);
            ficha.AsignarCoordenadaFicha(35, 540, 266);
            ficha.AsignarCoordenadaFicha(36, 540, 312);
            ficha.AsignarCoordenadaFicha(37, 540, 358);
            ficha.AsignarCoordenadaFicha(38, 540, 403);
            ficha.AsignarCoordenadaFicha(39, 540, 448);
            Fichas.Add(ficha);

            ficha = new Ficha(2,  "Amarillo");
            ficha.AsignarCoordenadaFicha(0, 534, 530);
            ficha.AsignarCoordenadaFicha(1, 468, 542);
            ficha.AsignarCoordenadaFicha(2, 423, 542);
            ficha.AsignarCoordenadaFicha(3, 378, 542);
            ficha.AsignarCoordenadaFicha(4, 332, 542);
            ficha.AsignarCoordenadaFicha(5, 288, 542);
            ficha.AsignarCoordenadaFicha(6, 241, 542);
            ficha.AsignarCoordenadaFicha(7, 196, 542);
            ficha.AsignarCoordenadaFicha(8, 150, 542);
            ficha.AsignarCoordenadaFicha(9, 106, 542);
            ficha.AsignarCoordenadaFicha(10, 37, 542);
            ficha.AsignarCoordenadaFicha(11, 12, 469);
            ficha.AsignarCoordenadaFicha(12, 12, 424);
            ficha.AsignarCoordenadaFicha(13, 12, 379);
            ficha.AsignarCoordenadaFicha(14, 12, 333);
            ficha.AsignarCoordenadaFicha(15, 12, 287);
            ficha.AsignarCoordenadaFicha(16, 12, 241);
            ficha.AsignarCoordenadaFicha(17, 12, 196);
            ficha.AsignarCoordenadaFicha(18, 12, 150);
            ficha.AsignarCoordenadaFicha(19, 12, 104);
            ficha.AsignarCoordenadaFicha(20, 12, 37);
            ficha.AsignarCoordenadaFicha(21, 82, 37);
            ficha.AsignarCoordenadaFicha(22, 127, 37);
            ficha.AsignarCoordenadaFicha(23, 172, 37);
            ficha.AsignarCoordenadaFicha(24, 218, 37);
            ficha.AsignarCoordenadaFicha(25, 264, 37);
            ficha.AsignarCoordenadaFicha(26, 309, 37);
            ficha.AsignarCoordenadaFicha(27, 355, 37);
            ficha.AsignarCoordenadaFicha(28, 400, 37);
            ficha.AsignarCoordenadaFicha(29, 445, 37);
            ficha.AsignarCoordenadaFicha(30, 515, 37);
            ficha.AsignarCoordenadaFicha(31, 515, 105);
            ficha.AsignarCoordenadaFicha(32, 515, 150);
            ficha.AsignarCoordenadaFicha(33, 515, 196);
            ficha.AsignarCoordenadaFicha(34, 515, 241);
            ficha.AsignarCoordenadaFicha(35, 515, 287);
            ficha.AsignarCoordenadaFicha(36, 515, 333);
            ficha.AsignarCoordenadaFicha(37, 515, 379);
            ficha.AsignarCoordenadaFicha(38, 515, 424);
            ficha.AsignarCoordenadaFicha(39, 515, 469);
            Fichas.Add(ficha);

            ficha = new Ficha(3, "Azul");
            ficha.AsignarCoordenadaFicha(0, 495, 530);
            ficha.AsignarCoordenadaFicha(1, 447, 542);
            ficha.AsignarCoordenadaFicha(2, 402, 542);
            ficha.AsignarCoordenadaFicha(3, 357, 542);
            ficha.AsignarCoordenadaFicha(4, 311, 542);
            ficha.AsignarCoordenadaFicha(5, 267, 542);
            ficha.AsignarCoordenadaFicha(6, 220, 542);
            ficha.AsignarCoordenadaFicha(7, 175, 542);
            ficha.AsignarCoordenadaFicha(8, 129, 542);
            ficha.AsignarCoordenadaFicha(9, 85, 542);
            ficha.AsignarCoordenadaFicha(10, 16, 542);
            ficha.AsignarCoordenadaFicha(11, 12, 448);
            ficha.AsignarCoordenadaFicha(12, 12, 403);
            ficha.AsignarCoordenadaFicha(13, 12, 358);
            ficha.AsignarCoordenadaFicha(14, 12, 312);
            ficha.AsignarCoordenadaFicha(15, 12, 266);
            ficha.AsignarCoordenadaFicha(16, 12, 220);
            ficha.AsignarCoordenadaFicha(17, 12, 175);
            ficha.AsignarCoordenadaFicha(18, 12, 129);
            ficha.AsignarCoordenadaFicha(19, 12, 83);
            ficha.AsignarCoordenadaFicha(20, 12, 16);
            ficha.AsignarCoordenadaFicha(21, 82, 16);
            ficha.AsignarCoordenadaFicha(22, 127, 16);
            ficha.AsignarCoordenadaFicha(23, 172, 16);
            ficha.AsignarCoordenadaFicha(24, 218, 16);
            ficha.AsignarCoordenadaFicha(25, 264, 16);
            ficha.AsignarCoordenadaFicha(26, 309, 16);
            ficha.AsignarCoordenadaFicha(27, 355, 16);
            ficha.AsignarCoordenadaFicha(28, 400, 16);
            ficha.AsignarCoordenadaFicha(29, 445, 16);
            ficha.AsignarCoordenadaFicha(30, 515, 16);
            ficha.AsignarCoordenadaFicha(31, 515, 84);
            ficha.AsignarCoordenadaFicha(32, 515, 129);
            ficha.AsignarCoordenadaFicha(33, 515, 175);
            ficha.AsignarCoordenadaFicha(34, 515, 220);
            ficha.AsignarCoordenadaFicha(35, 515, 266);
            ficha.AsignarCoordenadaFicha(36, 515, 312);
            ficha.AsignarCoordenadaFicha(37, 515, 358);
            ficha.AsignarCoordenadaFicha(38, 515, 403);
            ficha.AsignarCoordenadaFicha(39, 515, 448);

            Fichas.Add(ficha);

            ficha = new Ficha(4, "Verde");
            ficha.AsignarCoordenadaFicha(0, 534, 498);
            ficha.AsignarCoordenadaFicha(1, 468, 510);
            ficha.AsignarCoordenadaFicha(2, 423, 510);
            ficha.AsignarCoordenadaFicha(3, 378, 510);
            ficha.AsignarCoordenadaFicha(4, 332, 510);
            ficha.AsignarCoordenadaFicha(5, 288, 510);
            ficha.AsignarCoordenadaFicha(6, 241, 510);
            ficha.AsignarCoordenadaFicha(7, 196, 510);
            ficha.AsignarCoordenadaFicha(8, 150, 510);
            ficha.AsignarCoordenadaFicha(9, 106, 510);
            ficha.AsignarCoordenadaFicha(10, 37, 510);
            ficha.AsignarCoordenadaFicha(11, 37, 469);
            ficha.AsignarCoordenadaFicha(12, 37, 424);
            ficha.AsignarCoordenadaFicha(13, 37, 379);
            ficha.AsignarCoordenadaFicha(14, 37, 333);
            ficha.AsignarCoordenadaFicha(15, 37, 287);
            ficha.AsignarCoordenadaFicha(16, 37, 241);
            ficha.AsignarCoordenadaFicha(17, 37, 196);
            ficha.AsignarCoordenadaFicha(18, 37, 150);
            ficha.AsignarCoordenadaFicha(19, 37, 104);
            ficha.AsignarCoordenadaFicha(20, 37, 37);
            ficha.AsignarCoordenadaFicha(21, 107, 37);
            ficha.AsignarCoordenadaFicha(22, 152, 37);
            ficha.AsignarCoordenadaFicha(23, 197, 37);
            ficha.AsignarCoordenadaFicha(24, 243, 37);
            ficha.AsignarCoordenadaFicha(25, 289, 37);
            ficha.AsignarCoordenadaFicha(26, 334, 37);
            ficha.AsignarCoordenadaFicha(27, 380, 37);
            ficha.AsignarCoordenadaFicha(28, 425, 37);
            ficha.AsignarCoordenadaFicha(29, 470, 37);
            ficha.AsignarCoordenadaFicha(30, 540, 37);
            ficha.AsignarCoordenadaFicha(31, 540, 105);
            ficha.AsignarCoordenadaFicha(32, 540, 150);
            ficha.AsignarCoordenadaFicha(33, 540, 196);
            ficha.AsignarCoordenadaFicha(34, 540, 241);
            ficha.AsignarCoordenadaFicha(35, 540, 287);
            ficha.AsignarCoordenadaFicha(36, 540, 333);
            ficha.AsignarCoordenadaFicha(37, 540, 379);
            ficha.AsignarCoordenadaFicha(38, 540, 424);
            ficha.AsignarCoordenadaFicha(39, 540, 469);
            Fichas.Add(ficha);

        }

    }
}
