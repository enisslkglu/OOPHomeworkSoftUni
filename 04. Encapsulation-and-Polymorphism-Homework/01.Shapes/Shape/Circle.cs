using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Shape
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius should be bigger than \"0\"!");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = (this.Radius*this.Radius)*Math.PI;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2*this.Radius*Math.PI;
            return perimeter;
        }

        
    }
}
