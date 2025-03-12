using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Segundo_Parcial_ASPC
{
    internal class Juegos
    {
        public Juegos() { } 
        public Juegos(string nombre, string genero, string dificultad, string plataforma, int noJugadores)
        {
            Nombre = nombre;
            Genero = genero;
            Dificultad = dificultad;
            Plataforma = plataforma;
            NoJugadores = noJugadores;
        }

        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Dificultad { get; set; }
        public string Plataforma{ get; set; }
        public int NoJugadores { get; set; }

    }
}
