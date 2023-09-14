using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Combat Zone.");
            Console.WriteLine("Ingresa la cantidad de vida de tu jugador (1-100):");
            int playerHealth = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad daño que hara tu jugador (1-100):");
            int playerDamage = int.Parse(Console.ReadLine());
            Game game = new Game(1, 1);
            game.StartGame(playerHealth, playerDamage);
        }
    }
}
