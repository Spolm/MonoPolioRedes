﻿using ServidorMonopolio.Modelo.Casillas;
using ServidorMonopolio.Modelo.Tarjetas;
using ServidorMonopolio.Conexion.Mensajes.Servidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorMonopolio.Modelo
{
    public class Juego
    {
        public List<Jugador> JugadoresRegistrados;
        public List<Jugador> JugadoresConectados;
        public List<Casilla> Casillas;
        public List<Tarjeta_Arca> Tarjetas_Arca;
        public List<Tarjeta_Casualidad> Tarjetas_Casualidad;
        public List<Ficha> Fichas;
        public int Fondo_Impuesto;
        public Banco Banco;
        public bool Connected;
        private int _cantidadJugadores;
        private JSON _json;
        public bool Iniciado;
        private Random turnoJugador;

        private static Juego _juego = null;

        private Juego()
        {
            ValoresIniciales();
        }

        public static Juego ObtenerJuego
        {
            get
            {
                if (_juego == null)
                    _juego = new Juego();

                return _juego;
            }

            private set { }
        }

        private void ValoresIniciales()
        {
            Casillas = new List<Casilla>();

            JugadoresRegistrados = new List<Jugador>();
            JugadoresConectados = new List<Jugador>();

            Tarjetas_Arca = new List<Tarjeta_Arca>();

            Tarjetas_Casualidad = new List<Tarjeta_Casualidad>();

            Fichas = new List<Ficha>();

            this.Fondo_Impuesto = 0;

            this.Banco = new Banco();

            Crear_Tablero();

            Crear_Tarjetas_Arca();

            Crear_Tarjetas_Casualidad();

            CrearFichas();

            Connected = false;

            _json = new JSON(this);

            Iniciado = false;

            turnoJugador = new Random();
        }

        public bool IniciarPartida()
        {
            if (JugadoresConectados.Count < CantidadJugadores)
                return false;


            Iniciado = true;

            List<int> OrdenTurno = new List<int>();

            for(int i = 1; i <= JugadoresConectados.Count; i++)
            {
                OrdenTurno.Add(i);
            }

            int index = 0;

            foreach(Jugador jugador in JugadoresConectados)
            {
                index = turnoJugador.Next(0, OrdenTurno.Count);
                jugador.Turno = OrdenTurno.ElementAt(index);
                OrdenTurno.RemoveAt(index);

                if (jugador.Turno == 1)
                    jugador.Turno_Activo = true;
            }

            AsigarTurnosJugadores();

            return true;

        }

        private void AsigarTurnosJugadores()
        {
            foreach(Jugador jugador in JugadoresConectados)
            {
                jugador.EnviarMensaje(new Servidor_IniciarPartida(this));
            }
        }

        public void AsignarFichaJugador(Jugador jugador)
        {
            if (jugador.Ficha != null)
                return;

            jugador.Ficha = _juego.Fichas.Find(f => !f.Asignada);
            jugador.Ficha.Asignada = true;
        }

        public void ReiniciarJuego()
        {
            ValoresIniciales();
        }


        public void GestionarJugadaJugador(Jugador jugador)
        {
            jugador.Realizar_Jugada();

            foreach(Jugador j in JugadoresConectados)
            {
                j.EnviarMensaje(new Servidor_LanzarDado(jugador));
            }

            int CasillaId = jugador.Posicion;

            Casilla _casilla = Casillas.Find(c => c.Posicion == CasillaId);

            if (_casilla == null)
                return;

            _casilla.EjecutarEfecto(jugador);



        }
        public int CantidadJugadores
        {
            get { return _cantidadJugadores; }
            set { _cantidadJugadores = value; }
        }

        public bool RegistrarJugador(Jugador jugador)
        {
            return _json.RegistrarJugador(jugador);
        }

        private void Crear_Tablero()
        {
            for (int i = 0; i <= 39; i++)
            {

                Propiedad Propiedad;
                Casilla Casilla;

                if (i == 0)
                {
                    Casilla = new Inicio(); //Ya
                    Casilla.Posicion = i;
                    Casilla.Tipo = Tipo_Casilla.Inicio;
                    Casilla.Imagen = null; //Imagen

                    this.Casillas.Add(Casilla);
                }
                else if (i == 1)
                {
                    Propiedad = new Avenida("San Luis Norte", Color_Avenida.Morado, 60, 2, 10, 30, 90, 160, 250, 30, 50, 50, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 2 || i == 17 || i == 33)
                {
                    Casilla = new ArcaComunal();
                    Casilla.Posicion = i;
                    Casilla.Tipo = Tipo_Casilla.Arca_Comunal;
                    Casilla.Imagen = null;

                    this.Casillas.Add(Casilla);
                }
                else if (i == 3)
                {
                    Propiedad = new Avenida("San Luis Sur", Color_Avenida.Morado, 60, 4, 20, 60, 180, 320, 450, 30, 50, 50, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 4 || i == 38)
                {
                    Casilla = new Impuesto();
                    Casilla.Posicion = i;
                    Casilla.Tipo = Tipo_Casilla.Impuesto; // 150
                    Casilla.Imagen = null;

                    this.Casillas.Add(Casilla);
                }
                else if (i == 5)
                {
                    Propiedad = new Tren("Tren Norte", Tipo_Tren.Tren_Norte, 200, 25, 50, 100, 200, 100, i, Tipo_Casilla.Tren, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 6)
                {
                    Propiedad = new Avenida("Formosa Este", Color_Avenida.Azul_claro, 100, 6, 30, 90, 270, 400, 550, 50, 50, 50, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 7 || i == 22 || i == 36)
                {
                    Casilla = new Casualidad();
                    Casilla.Posicion = i;
                    Casilla.Tipo = Tipo_Casilla.Casualidad;
                    Casilla.Imagen = null;

                    this.Casillas.Add(Casilla);
                }
                else if (i == 8)
                {
                    Propiedad = new Avenida("Formosa Norte", Color_Avenida.Azul_claro, 100, 6, 30, 90, 270, 400, 550, 50, 50, 50, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 9)
                {
                    Propiedad = new Avenida("Formosa Sur", Color_Avenida.Azul_claro, 120, 8, 40, 100, 300, 450, 600, 60, 50, 50, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 10)
                {
                    Casilla = new Carcel();
                    Casilla.Posicion = i;
                    Casilla.Tipo = Tipo_Casilla.Carcel;
                    Casilla.Imagen = null;

                    this.Casillas.Add(Casilla);
                }
                else if (i == 11)
                {
                    Propiedad = new Avenida("San Juan Este", Color_Avenida.Rosado, 140, 10, 50, 150, 450, 625, 750, 70, 100, 100, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 12)
                {
                    Propiedad = new Servicio("Luz", Tipo_Servicio.Servicio_Luz, 150, 75, i, Tipo_Casilla.Servicio, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 13)
                {
                    Propiedad = new Avenida("San Juan Sur", Color_Avenida.Rosado, 140, 10, 50, 150, 450, 625, 750, 70, 100, 100, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 14)
                {
                    Propiedad = new Avenida("San Juan Norte", Color_Avenida.Rosado, 160, 12, 60, 80, 500, 700, 900, 80, 100, 100, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 15)
                {
                    Propiedad = new Tren("Tren Oeste", Tipo_Tren.Tren_Oeste, 200, 25, 50, 100, 200, 100, i, Tipo_Casilla.Tren, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 16)
                {
                    Propiedad = new Avenida("Neuquen Este", Color_Avenida.Naranja, 180, 14, 70, 200, 550, 750, 950, 90, 100, 100, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 18)
                {
                    Propiedad = new Avenida("Neuquen Sur", Color_Avenida.Naranja, 180, 14, 70, 200, 550, 750, 950, 90, 100, 100, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 19)
                {
                    Propiedad = new Avenida("Neuquen Norte", Color_Avenida.Naranja, 200, 16, 80, 220, 600, 800, 1000, 100, 100, 100, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 20)
                {
                    Casilla = new Parking();
                    Casilla.Posicion = i;
                    Casilla.Tipo = Tipo_Casilla.Parking;
                    Casilla.Imagen = null;

                    this.Casillas.Add(Casilla);
                }
                else if (i == 21)
                {
                    Propiedad = new Avenida("Mendoza Este", Color_Avenida.Rojo, 220, 18, 90, 250, 700, 875, 1050, 110, 150, 150, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 23)
                {
                    Propiedad = new Avenida("Mendoza Sur", Color_Avenida.Rojo, 220, 18, 90, 250, 700, 875, 1050, 110, 150, 150, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 24)
                {
                    Propiedad = new Avenida("Mendoza Norte", Color_Avenida.Rojo, 240, 20, 100, 300, 750, 925, 1100, 120, 150, 150, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 25)
                {
                    Propiedad = new Tren("Tren Este", Tipo_Tren.Tren_Este, 200, 25, 50, 100, 200, 100, i, Tipo_Casilla.Tren, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 26)
                {
                    Propiedad = new Avenida("Santa fe Este", Color_Avenida.Amarillo, 260, 22, 110, 330, 800, 975, 1150, 130, 150, 150, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 27)
                {
                    Propiedad = new Avenida("Santa fe Sur", Color_Avenida.Amarillo, 260, 22, 110, 330, 800, 975, 1150, 130, 150, 150, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 28)
                {
                    Propiedad = new Servicio("Agua", Tipo_Servicio.Servicio_Agua, 150, 75, i, Tipo_Casilla.Servicio, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 29)
                {
                    Propiedad = new Avenida("Santa fe Norte", Color_Avenida.Amarillo, 280, 24, 120, 360, 850, 1025, 1200, 140, 150, 150, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 30)
                {
                    Casilla = new Detencion();
                    Casilla.Posicion = i;
                    Casilla.Tipo = Tipo_Casilla.Detencion;
                    Casilla.Imagen = null;

                    this.Casillas.Add(Casilla);
                }
                else if (i == 31)
                {
                    Propiedad = new Avenida("Cordoba Este", Color_Avenida.Verde, 300, 26, 130, 390, 900, 1100, 1275, 150, 200, 200, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 32)
                {
                    Propiedad = new Avenida("Cordoba Sur", Color_Avenida.Verde, 300, 26, 130, 390, 900, 1100, 1275, 150, 200, 200, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 34)
                {
                    Propiedad = new Avenida("Cordoba Norte", Color_Avenida.Verde, 320, 28, 150, 450, 1000, 1200, 1400, 160, 200, 200, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 35)
                {
                    Propiedad = new Tren("Tren Sur", Tipo_Tren.Tren_Sur, 200, 25, 50, 100, 200, 100, i, Tipo_Casilla.Tren, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 37)
                {
                    Propiedad = new Avenida("Buenos Aires Norte", Color_Avenida.Azul_Oscuro, 350, 35, 175, 500, 1100, 1300, 1500, 175, 200, 200, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
                else if (i == 39)
                {
                    Propiedad = new Avenida("Buenos Aires Sur", Color_Avenida.Azul_Oscuro, 400, 50, 200, 600, 1400, 1700, 2000, 200, 200, 200, i, Tipo_Casilla.Propiedad, null);

                    this.Casillas.Add(Propiedad);
                }
            }
        }

        private void Crear_Tarjetas_Arca()
        {
            Tarjeta_Arca Tarjeta;

            Tarjeta = new Tarjeta_Arca(1, Efecto_Arca.Ir_Carcel, "Secuestraste a Biagio, vas a la cárcel");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(2, Efecto_Arca.Recibir_10, "Primer lugar en concurso de belleza, ganas 10$ de premio");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(3, Efecto_Arca.Recibir_50_Jugador, "Rescaste a Biagio, cada jugador te paga 50$");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(4, Efecto_Arca.Recibir_100, "Tu abuelo murió, heredas 100$");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(5, Efecto_Arca.Recibir_200, "Ganaste 200$ por error del banco");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(6, Efecto_Arca.Recibir_200_Inicio, "Ve hasta el inicio y oobra 200$");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(7, Efecto_Arca.Restar_20, "Dañaste la puerta del laboratorio, paga 20$");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(8, Efecto_Arca.Restar_25_Propiedad, "Paga 25$ por cada propiedad");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(9, Efecto_Arca.Restar_50_Jugador, "Te robaste unos cables del laboratorio, paga 50$ a cada jugador");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(10, Efecto_Arca.Restar_100, "Reprobaste redes, pagas 100$ para pasar");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(11, Efecto_Arca.Restar_150, "Dañaste una computadora de laboratorio, paga 150$");
            Tarjetas_Arca.Add(Tarjeta);

            Tarjeta = new Tarjeta_Arca(12, Efecto_Arca.Salir_Prision, "Pasaste redes, sales de prisión.");
            Tarjetas_Arca.Add(Tarjeta);

        }

        private void Crear_Tarjetas_Casualidad()
        {
            Tarjeta_Casualidad Tarjeta;

            Tarjeta = new Tarjeta_Casualidad(1, Efecto_Casualidad.Dar_25_Jugador, "Das 25$ a cada jugador");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(2, Efecto_Casualidad.Ir_Carcel, "Mataste a Igor, vas a la carcel");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(3, Efecto_Casualidad.Ir_Mendoza_Sur, "Visita a los mendoza, ve a Mendoza Sur");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(4, Efecto_Casualidad.Ir_San_Luis, "Ve hasta San Luis Norte");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(5, Efecto_Casualidad.Recibir_50, "Banco Venezuela te regala 50$");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(6, Efecto_Casualidad.Recibir_100, "Has ganado el concurso de Counter Strike, ganas 100$");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(7, Efecto_Casualidad.Recibir_150, "Le robas 150$ a Biagio");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(8, Efecto_Casualidad.Recibir_200_Inicio, "Ve al inicio y recibes 200$");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(9, Efecto_Casualidad.Restar_3_Pasos, "Se te quedó el celular, vuelve 3 pasos atrás");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(10, Efecto_Casualidad.Restar_25_Propiedad, "Pagas 25$ por cada propiedad.");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(11, Efecto_Casualidad.Restar_50, "Perdiste en Counter Strike, paga 50$");
            Tarjetas_Casualidad.Add(Tarjeta);

            Tarjeta = new Tarjeta_Casualidad(12, Efecto_Casualidad.Salir_Prision, "Pasaste redes, sales de prisión.");
            Tarjetas_Casualidad.Add(Tarjeta);

        }

        private void CrearFichas()
        {
            for(int i = 1; i <= 4; i++)
            {
                Fichas.Add(new Ficha(i));
            }
        }
    }
}
