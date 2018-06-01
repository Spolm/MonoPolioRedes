using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServidorMonopolio.Modelo;
using System.Windows.Forms;

namespace ServidorMonopolio
{
    public class JSON
    {
        private Juego _juego;
        public JSON(Juego juego)
        {
            _juego = juego;
            LoadJugadores();
        }

        private void LoadJugadores()
        {
            using (StreamReader JsonFile = new StreamReader(@"jugadores.txt"))
            {
                string json = JsonFile.ReadToEnd();
                List<Jugador> _jugadores = new List<Jugador>();
                _jugadores.Clear();
                _jugadores = JsonConvert.DeserializeObject<List<Jugador>>(json);

                if (_jugadores != null)
                {
                    _juego.Jugadores.Clear();
                    _juego.Jugadores = _jugadores;
                }
            }
        }

        public bool RegistrarJugador(Jugador jugador)
        {
            if (VerificarExiste(jugador))
                return false;

            if (_juego.Jugadores.Count < 1)
            {
                jugador.Id = 1;
            }
            else
            {
                jugador.Id = (_juego.Jugadores.OrderBy(j => j.Id).Last().Id + 1);
            }

            _juego.Jugadores.Add(jugador);

            JsonSerializer serializer = new JsonSerializer();

            File.Delete(@"jugadores.txt");
            using (StreamWriter jsonFile = File.AppendText(@"jugadores.txt"))
            using (JsonWriter writer = new JsonTextWriter(jsonFile))
            {
                serializer.Serialize(writer, _juego.Jugadores);
            }

            return true;

        }

        private bool VerificarExiste(Jugador jugador)
        {
            bool existe = _juego.Jugadores.Exists(j => j.Usuario.ToLower() == jugador.Usuario.ToLower());

            return existe;
        }
    }
}
