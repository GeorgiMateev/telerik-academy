using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Shape
{
    class Triangle : Shape
    {
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }        

        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height / 2;
        }
    }
}
