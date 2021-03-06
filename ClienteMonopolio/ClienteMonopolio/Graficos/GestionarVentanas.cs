﻿using ClienteMonopolio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMonopolio.Graficos
{
    public class GestionarVentanas
    {
        private vInicio _ventanaInicio;
        private JuegoForm _ventanaJuego;

        public GestionarVentanas(vInicio Inicio, JuegoForm Juego)
        {
            _ventanaInicio = Inicio;
            _ventanaJuego = Juego;
        }

        public vInicio ventanaInicio
        {
            get { return _ventanaInicio; }
            set { _ventanaInicio = value; }
        }

        public JuegoForm ventanaJuego
        {
            get { return _ventanaJuego; }
            set { _ventanaJuego = value; }
        }

        public void GestionarListaJugadores(Jugador jugador, bool remover)
        {
            _ventanaInicio.GestionarJugadores(jugador, remover);
        }

        public void ComenzarJuego()
        {
            _ventanaJuego.CargarJugadorPrincipal();
            _ventanaJuego.MostrarJugadorPrincipal();
            _ventanaJuego.MostrarFichas();
            _ventanaInicio.GestionarVentanas(_ventanaJuego);
            ActualizarInfoJugadores();
            _ventanaJuego.MostrarTurno();
        }

        public void ActualizarInfoJugadores()
        {
            _ventanaJuego.ActualizarJugadores();
        }

        public void CerrarVentanas()
        {
            //_ventanaJuego.CerrarVentana();
            _ventanaInicio.CerrarVentana();
        }

        public void HabilitarJugar()
        {
            _ventanaInicio.HabilitarBotonInicio();
        }

        public void ActualizarEstadoJugador(bool Propiedad, bool Casa, bool Hotel, bool CarcelArca, bool CarcelCasualidad)
        {
            _ventanaJuego.ActualizarEstado(Propiedad, Casa, Hotel, CarcelArca, CarcelCasualidad);
        }

        public void ActualizarFichaJugador(Jugador jugador)
        {
            _ventanaJuego.ActualizarFicha(jugador);
        }
    }
}
