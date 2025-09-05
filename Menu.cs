using Progra1252.Test;
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

        private List<Enemy> enemyList;

        public Menu()
        {
            enemyList = new List<Enemy>();
        }

        public void Execute()
        {
            Person s = new Student();
            Console.WriteLine(s.ShowData());




            return;
            Console.WriteLine("Se inició el programa");
            CreatePlayer();
            CreateEnemy();            
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

        private void CreateEnemy()
        {
            string name;
            int health;
            int respawnTime;
            Console.WriteLine("Introduce el nombre del enemigo:");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la vida del enemigo:");
            health = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tiempo de reaparición:");
            respawnTime = int.Parse(Console.ReadLine());
            Enemy enemy = new Enemy(name, health,respawnTime);
            enemyList.Add(enemy);
        }
    }
}
