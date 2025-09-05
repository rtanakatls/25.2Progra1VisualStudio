﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1252.Figures
{
    internal class Rectangle : Shape
    {
        protected float b;
        protected float h;

        public Rectangle(string name, float b, float h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h;
        }
    }
}
