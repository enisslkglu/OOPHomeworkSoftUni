using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Shape
{
    class Triangle:BasicShape
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
            : base(firstSide, Math.Sqrt((firstSide + secondSide + thirdSide) / 2))
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }


        public double FirstSide
        {
            get { return this.firstSide; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("First side","Side cannot be equal \"0\" or negative!");
                }
                this.firstSide = value;
            }
        }

        public double SecondSide
        {
            get { return this.secondSide; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Second side","Side cannot be equal \"0\" or negative!");
                }
                this.secondSide = value;
            }
        }

        public double ThirdSide
        {
            get { return this.thirdSide; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Third side","Side cannot be equal \"0\" or negative!");
                }
                this.thirdSide = value;
            }
        }

        public override double CalculateArea()
        {
            double u = (this.FirstSide + this.SecondSide + this.ThirdSide)/2;
            double area = Math.Sqrt(u*(u - this.FirstSide)*(u - this.SecondSide)*(u - this.ThirdSide));
            if (double.IsNaN(area))
            {
                throw new ArgumentOutOfRangeException("Triangle sides input!","Such triangle does not exist!");
            }
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = this.FirstSide + this.SecondSide + this.ThirdSide;
            return perimeter;
        }
    }
}
