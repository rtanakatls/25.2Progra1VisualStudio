using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1252
{
    internal class Menu
    {
        private Character player;
        public void Execute()
        {
            Console.WriteLine("Se inició el programa");
            CreatePlayer();
        }

        private void CreatePlayer()
        {
            string name;
            int health;
            Console.WriteLine("Introduce el nombre del jugador:");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la vida del jugador:");
            health = int.Parse(Console.ReadLine());
            player = new Character(name, health);
        }
    }
}
