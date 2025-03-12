using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Segundo_Parcial_ASPC
{
    internal class Acciones
    {
        public List<Juegos> listajuegos = new List<Juegos>();

        Juegos a = new Juegos();

        public void AgregarJuegos()
        {
            Console.WriteLine("Nombre");
            a.Nombre = Console.ReadLine();
            Console.WriteLine("Genero");
            a.Genero = Console.ReadLine();
            Console.WriteLine("Dificultad");
            a.Dificultad = Console.ReadLine();
            Console.WriteLine("Plataforma");
            a.Plataforma = Console.ReadLine();
            Console.WriteLine("Numero de Jugadores");
            a.NoJugadores = Convert.ToInt32(Console.ReadLine());

            listajuegos.Add(new Juegos(a.Nombre, a.Genero, a.Dificultad, a.Plataforma, a.NoJugadores));
        }
        public void MostrarJuegos()
        {
            foreach (var m in listajuegos)
            {
                Console.WriteLine($"Nombre:{m.Nombre} Genero: {m.Genero} Dificultad: {m.Dificultad} Plataforma: {m.Plataforma} Numero de Jugadores : {m.NoJugadores}");
            }
        }
        public int ContarJuegos()
        {
            return listajuegos.Count;
        }

        public void EliminarJuegos(string nombrejuegos)
        {
            var juegos = listajuegos.Find(x => x.Nombre == nombrejuegos);
            if (juegos != null)
                listajuegos.Remove(juegos);
            else
                Console.WriteLine("No se encontro tu juego");
        }
        public void ActualizarJuegos(string nombrejuego, string nuevonombre, string nuevogenero, string nuevodificultad, int nuevonojugadores)
        {
            var juegos = listajuegos.FirstOrDefault(x => x.Nombre == nombrejuego);

            if (juegos != null)
            {

                juegos.Nombre = nuevonombre;
                juegos.Genero = nuevogenero;
                juegos.Dificultad = nuevodificultad;
                juegos.NoJugadores = nuevonojugadores;

                Console.WriteLine("Juego actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("No se encontró el juego");
            }
        }

    }
}