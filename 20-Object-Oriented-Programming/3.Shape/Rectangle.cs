using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Shape
{
    class Rectangle : Shape
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

        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
