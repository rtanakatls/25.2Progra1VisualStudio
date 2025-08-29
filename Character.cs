using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1252
{
    internal class Character
    {
        protected string name;
        protected int health;

        public string Name { get { return name; } }
        public int Health { get { return health; } }

        public Character(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public virtual string ShowData()
        {
            return $"Nombre: {name}, Vida: {health}";
        }
    }
}
