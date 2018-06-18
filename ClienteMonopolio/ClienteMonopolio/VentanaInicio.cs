using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteMonopolio.Conection;
using System.Net;
using ClienteMonopolio.Modelo;

namespace ClienteMonopolio
{
    public partial class vInicio : Form
    {
        Conexion conexion = new Conexion();

        public vInicio()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ipa;
            int nPort;

            try
            {
                if (string.IsNullOrEmpty(tIP.Text) || string.IsNullOrEmpty(tPort.Text) || string.IsNullOrEmpty(tUsuario.Text))
                    return;

                if (!IPAddress.TryParse(tIP.Text, out ipa))
                {
                    MessageBox.Show("Ingresa una IP válida.");
                    return;
                }

                if (!int.TryParse(tPort.Text, out nPort))
                {
                    MessageBox.Show("Ingresa un puerto válido.");
                    return;
                }

                if (!conexion.CrearConexion(this, ipa, nPort, tUsuario.Text, tContra.Text))
                    MessageBox.Show("Ha ocurrido un error en la conexión");
                else
                    bJugar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void vInicio_Load(object sender, EventArgs e)
        {

        }

        public void GestionarVentanas(JuegoForm ventanaJuego)
        {
            this.Invoke(new Action<JuegoForm>(InvokeVentanas), ventanaJuego);
        }

        public void GestionarJugadores(Jugador jugador, bool remover)
        {
            lJugadores.Invoke(new Action<Jugador, bool>(InvokeJugadores), jugador, remover);
        }

        private void InvokeJugadores(Jugador jugador, bool remove)
        {
            if (!remove)
                lJugadores.Items.Add(jugador.Nombre + " (ID: " + jugador.Id + " | Ficha: " + jugador.Ficha.Nombre + " | Principal: " + jugador.JugadorPrincipal.ToString().ToUpper() + ")");
            else
                lJugadores.Items.Remove(jugador.Nombre + " (ID: " + jugador.Id + " | Ficha: " + jugador.Ficha.Nombre + " | Principal: " + jugador.JugadorPrincipal.ToString().ToUpper() + ")");
        }

        private void InvokeVentanas(JuegoForm ventajaJuego)
        {
            this.Visible = false;
            ventajaJuego.Visible = true;
        }

        public void CerrarVentana()
        {
            this.Invoke(new Action(InvokeCerrar));
        }
        private void InvokeCerrar()
        {
            this.Close();
        }

        public void HabilitarBotonInicio()
        {
            bJugar.Invoke(new Action(InvokeHabilitarBoton));
        }
        private void InvokeHabilitarBoton()
        {
            bJugar.Enabled = true;
        }
    }
}
