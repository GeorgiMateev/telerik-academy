using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Shape
{
    class Circle : Shape
    {
        public double Radious
        {
            get { return this.width; }
            set { this.height = value; this.width = value; }
        }

        public Circle(double radius):base(radius*2,radius*2)
        {
        }
        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(this.Radious / 2, 2);
        }
    }
}
