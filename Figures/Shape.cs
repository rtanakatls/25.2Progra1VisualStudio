using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1252.Figures
{
    internal class Shape
    {
        protected string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual float GetArea()
        {
            return 0;
        }
    }
}
