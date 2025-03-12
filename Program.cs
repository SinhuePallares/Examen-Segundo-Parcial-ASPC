using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Segundo_Parcial_ASPC
{
    internal class Program
    {

        public enum Menu
        {
            AgregarJuego = 1, MostrarJuegos, ContarJuegos, EliminarJuegos, ActualizarJuegos
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();

            while (true)
            {
                switch (men())
                {
                    case Menu.AgregarJuego:
                        acciones.AgregarJuegos();
                        break;
                    case Menu.MostrarJuegos:
                        acciones.MostrarJuegos();
                        break;
                    case Menu.ContarJuegos:
                        Console.WriteLine($"Total de juegos: {acciones.ContarJuegos()}");
                        break;
                    case Menu.EliminarJuegos:
                        Console.WriteLine("Dame el nombre");
                        string nombre = Console.ReadLine();
                        acciones.EliminarJuegos(nombre);
                        break;
                    case Menu.ActualizarJuegos:
                        Console.WriteLine("Dame el nombre del juego que vas a actualizar");
                        string nombreactualizar = Console.ReadLine();
                        Console.WriteLine("Nuevo nombre");
                        string nuevonombre = Console.ReadLine();
                        Console.WriteLine("Nuevo genero");
                        string nuevogenero = Console.ReadLine();
                        Console.WriteLine("Nueva dificultad");
                        string nuevodificultad = Console.ReadLine();
                        Console.WriteLine("Nuevo numero de jugadores");
                        int nuevonojugadores = Convert.ToInt32(Console.ReadLine());

                        acciones.ActualizarJuegos(nombreactualizar, nuevonombre, nuevogenero, nuevodificultad, nuevonojugadores);
                        break;
   
                }

            }
        }
        static Menu men()
        {
            Console.WriteLine("1) Agregar Juegos");
            Console.WriteLine("2) Mostrar Juegos");
            Console.WriteLine("3) Contar Juegos");
            Console.WriteLine("4) Eliminar Juegos");
            Console.WriteLine("5) Actualizar Juegos");

            Menu menu = (Menu)Convert.ToInt32(Console.ReadLine());

            return menu;
        }
    }
}
