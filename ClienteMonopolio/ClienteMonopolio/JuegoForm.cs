using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteMonopolio.Modelo;

namespace ClienteMonopolio
{
    public partial class bSaltar : Form
    {
        Juego _juego;
        Jugador jugadorPrincipal;

        private static bSaltar _juegoForm = null;

        private bSaltar()
        {
            InitializeComponent();
            _juego = Juego.ObtenerJuego;
            lverde.Visible = false;
            lazul.Visible = false;
            lamarilla.Visible = false;
            lroja.Visible = false;
            bComprarCasa.Enabled = false;
            bComprarHotel.Enabled = false;
            bComprarPropiedad.Enabled = false;
            bLanzar.Enabled = false;
            bSalirCarcelA.Enabled = false;
            bSalirCarcelC.Enabled = false;
            bSaltarTurno.Enabled = false;

        }

        public static bSaltar ObtenerJuegoForm
        {
            get
            {
                if (_juegoForm == null)
                    _juegoForm = new bSaltar();

                return _juegoForm;
            }
        }



        public void MostrarFichas()
        {
            foreach(Jugador jugador in _juego.Jugadores)
            {
                if (jugador.Ficha.Id == 1)
                    jugador.Ficha.AsignarLabel(lroja);
                else if (jugador.Ficha.Id == 2)
                    jugador.Ficha.AsignarLabel(lamarilla);
                else if (jugador.Ficha.Id == 3)
                    jugador.Ficha.AsignarLabel(lazul);
                else
                    jugador.Ficha.AsignarLabel(lverde);

                jugador.Ficha.Imagen.Visible = true;
                jugador.Ficha.Imagen.Location = jugador.Ficha.Coordenadas[0];
            }
        }

        public void ActualizarEstado(bool Propiedad, bool Casa, bool Hotel, bool CarcelArca, bool CarcelCasualidad)
        {
            bComprarPropiedad.Enabled = Propiedad;

            bComprarCasa.Enabled = Casa;

            bComprarHotel.Enabled = Hotel;

            bSalirCarcelA.Enabled = CarcelArca;

            bSalirCarcelC.Enabled = CarcelCasualidad;

            bLanzar.Enabled = false;
            bSaltarTurno.Enabled = true;

        }

        public void ActualizarFicha(Jugador jugador)
        {
            jugador.Ficha.Imagen.Invoke(new Action<Jugador>(InvokeActualizarFicha), jugador);
        }

        private void InvokeActualizarFicha(Jugador jugador)
        {
            jugador.Ficha.Imagen.Location = jugador.Ficha.Coordenadas[jugador.Posicion];
        }

        public void CargarJugadorPrincipal()
        {
            jugadorPrincipal = _juego.Jugadores.Find(j => j.JugadorPrincipal);
        }

        public void MostrarJugadorPrincipal()
        {
            string mensaje = "Jugador: " + jugadorPrincipal.Nombre + " - Turno: " + jugadorPrincipal.Turno.ToString() + " - Ficha: "+jugadorPrincipal.Ficha.Nombre.ToUpper();
            this.Text = mensaje;
        }

        public void MostrarTurno()
        {
            if (jugadorPrincipal.Turno_Activo)
                MessageBox.Show("Es tu turno!");
            else
                MessageBox.Show("Es el turno del jugador: " + _juego.Jugadores.Find(j => j.Turno_Activo == true).Nombre);
        }

        public void ActualizarJugadores()
        {
            lJugadores.Invoke(new Action(MostrarJugadores));
        }

        private void MostrarJugadores()
        {
            lJugadores.Items.Clear();
            foreach (Jugador jugador in _juego.Jugadores)
            {
                string turno = "";

                if (jugador.Turno_Activo)
                    turno = "Si";
                else
                    turno =  "No";

                lJugadores.Items.Add(jugador.Nombre + " Dinero: " + jugador.Cartera + " Propiedades: " + jugador.Propiedades.Count+" Turno Activo: "+turno.ToUpper());
            }

            if (jugadorPrincipal.Turno_Activo)
                bLanzar.Enabled = true;
            else
                bLanzar.Enabled = false;
        }


        private void JuegoForm_Load(object sender, EventArgs e)
        {

        }

        private void JuegoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void JuegoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar el juego?", "¡Atención!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("¡Cobarde! Que mal perdedor", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Jaja casi pierdes todo tu esfuerzo",":D",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void bLanzar_Click(object sender, EventArgs e)
        {
            jugadorPrincipal.LanzarDado();
        }
    }
}
