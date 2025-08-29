using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1252
{
    internal class Enemy : Character
    {
        protected int respawnTime;

        public int RespawnTime { get { return respawnTime; } }

        public Enemy(string name, int health, int respawnTime) : base(name, health)
        {
            this.respawnTime = respawnTime;
        }

        public override string ShowData()
        {
            return $"Nombre: {name}, Vida: {health}, Tiempo de reaparición: {respawnTime} segundos";
        }
    }
}
