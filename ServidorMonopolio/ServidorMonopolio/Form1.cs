using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServidorMonopolio.Modelo;
using ServidorMonopolio.Modelo.Casillas;
using ServidorMonopolio.Conexion;

namespace ServidorMonopolio
{
    public  partial class ServerForm : Form
    {



        
        Conection Conexion = new Conection();
        
        public ServerForm()
        {
            InitializeComponent();
            cCantidadJugadores.SelectedIndex = 0;
            Gestionar_ListaRegistrados();
            bFinalizar.Enabled = false;
            bComenzarPartida.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void bApagar_Click(object sender, EventArgs e)
        {
            //J1.Realizar_Jugada();

            //MessageBox.Show("Casilla Jugador: " + J1.Posicion.ToString() + " d1: " + Dado.Dado_1.ToString() + " d2: " + Dado.Dado_2.ToString() + " Doble: " + Dado.Doble.ToString());

            //Casilla c_destino = Juego.Casillas.Find(c => c.Posicion == J1.Posicion);

            //if (c_destino.Tipo == Tipo_Casilla.Propiedad)
            //{
            //    Propiedad p_destino = (Propiedad)c_destino;
            //    MessageBox.Show(p_destino.Posicion.ToString() + " - " + p_destino.Tipo.ToString() + " " + p_destino.Color.ToString() + " - " + p_destino.Nombre.ToString() + " Penitencia: " + p_destino.Precio);
            //}
            //else if (c_destino.Tipo == Tipo_Casilla.Tren)
            //{
            //    Tren t_destino = (Tren)c_destino;
            //    MessageBox.Show(t_destino.Posicion.ToString() + " - " + t_destino.Tipo.ToString() + " " + t_destino.Tipo_Tren.ToString() + " Penitencia: " + t_destino.Precio);
            //}
            //else if (c_destino.Tipo == Tipo_Casilla.Servicio)
            //{
            //    Servicio s_destino = (Servicio)c_destino;
            //    MessageBox.Show(s_destino.Posicion.ToString() + " - " + s_destino.Tipo.ToString() + " " + s_destino.Tipo_Servicio.ToString() + " Penitencia: " + s_destino.Precio);
            //}
            //else if (c_destino.Tipo == Tipo_Casilla.Detencion)
            //{
            //    J1.Detenido = true;
            //    J1.Posicion = 10;
            //    MessageBox.Show(c_destino.Posicion.ToString() + " - " + c_destino.Tipo.ToString());
            //}
            //else
            //{
            //    J1.Detenido = true;
            //    J1.Posicion = 10;
            //    MessageBox.Show(c_destino.Posicion.ToString() + " - " + c_destino.Tipo.ToString());
            //}
        }

        private void bIniciar_Click(object sender, EventArgs e)
        { 
            int puerto = 0;
            try
            {
               puerto = Convert.ToInt32(tPuerto.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa un número de puerto válido.");
                return;
            }

            if (!Conexion.Crear_Conexion(tIP.Text, puerto, this, Convert.ToInt32(cCantidadJugadores.SelectedItem), Juego.ObtenerJuego))
                MessageBox.Show("Ingresa una dirección IP valida");
            else
            {
                bIniciar.Enabled = false;
                bFinalizar.Enabled = true;
                bRegistarJugador.Enabled = false;
                bComenzarPartida.Enabled = true;
            }


        }

        public void Imprimir_Log(string _mensaje)
        {
            tLogs.Invoke(new Action<string>(Agregar_Log), _mensaje);
        }

        public void Agregar_Log(string _mensaje)
        {
            if (!String.IsNullOrEmpty(tLogs.Text))
                tLogs.Text = tLogs.Text + Environment.NewLine + _mensaje;
            else
                tLogs.Text = _mensaje;

        }

        public void CerrarConexion()
        {
            tLogs.Clear();
            bIniciar.Enabled = true;
            bFinalizar.Enabled = false;
            bRegistarJugador.Enabled = true;
            bComenzarPartida.Enabled = false;
            lListaPropiedades.Items.Clear();
            lListaJugadores.Items.Clear();
            
        }

        public void Mostrar_Cliente(Jugador jugador, bool remover)
        {
           lListaJugadores.Invoke(new Action<Jugador, bool>(Gestionar_ListaJugador), jugador, remover);
        }

        public void Mostrar_Propiedad(Propiedad propiedad)
        {
            lListaPropiedades.Invoke(new Action<Propiedad>(AddPropiedad), propiedad);
        }

        public void Gestionar_PropietarioPropiedad(Propiedad propiedad, bool remover)
        {
            lListaPropiedades.Invoke(new Action<Propiedad, bool>(GestionarPropietario), propiedad, remover);
        }

        private void Gestionar_ListaJugador(Jugador jugador, bool remover)
        {
            if (!remover)
                lListaJugadores.Items.Add(jugador.Usuario);
            else
                lListaJugadores.Items.Remove(jugador.Usuario);
        }

        void Gestionar_ListaRegistrados()
        {
            lJugadoresRegistrados.Items.Clear();
            foreach(Jugador j in Juego.ObtenerJuego.JugadoresRegistrados.OrderBy(j => j.Id))
            {
                lJugadoresRegistrados.Items.Add("Id: " + j.Id + " - Usuario: " + j.Usuario);
            }
        }

        private void AddPropiedad(Propiedad propiedad)
        {
            lListaPropiedades.Items.Add(propiedad.Nombre);     
        }

        private void GestionarPropietario(Propiedad propiedad, bool remover)
        {
            if (!remover)
            {
                int index = lListaPropiedades.Items.IndexOf(propiedad.Nombre);
                lListaPropiedades.Items.Remove(propiedad.Nombre);
                lListaPropiedades.Items.Insert(index , propiedad.Nombre + " (Propietario: " + propiedad.Propietario.Usuario + ")");
            }
            else
            {
                int index = lListaPropiedades.Items.IndexOf(propiedad.Nombre + " (Propietario: " + propiedad.Propietario.Usuario + ")");
                lListaPropiedades.Items.Remove(propiedad.Nombre + " (Propietario: " + propiedad.Propietario.Usuario + ")");
                lListaPropiedades.Items.Insert(index, propiedad.Nombre);
            }
        }




        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bRegistarJugador_Click(object sender, EventArgs e)
        {

            Jugador j = new Jugador();
            j.Usuario = tUsuario.Text;
            j.Password = tContra.Text;
            j.Nombre = tNombre.Text;
            j.Apellido = tApellido.Text;

            if (!Juego.ObtenerJuego.RegistrarJugador(j))
                MessageBox.Show("El nombre de usuario registrado ya existe");
            else
            {
                MessageBox.Show("Usuario registrado con éxito");
                Gestionar_ListaRegistrados();
                tUsuario.Clear();
                tContra.Clear();
                tNombre.Clear();
                tApellido.Clear();
            }

        }

        private void bFinalizar_Click(object sender, EventArgs e)
        {
            CerrarConexion();
            Conexion.CerrarConexion();
        }

        private void bComenzarPartida_Click(object sender, EventArgs e)
        {
            if (!Juego.ObtenerJuego.IniciarPartida())
                MessageBox.Show("Faltan jugadores para iniciar la partida. (" + Juego.ObtenerJuego.JugadoresConectados.Count + "/" + Juego.ObtenerJuego.CantidadJugadores + ")");
            else
            {
                MessageBox.Show("Partida Iniciada.");
                bComenzarPartida.Enabled = false;
            }
        }
    }
}
