using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0,0,0);
       

        public Point3D(double xInput, double yInput, double zInput)
        {
            this.X = xInput;
            this.Y = yInput;
            this.Z = zInput;
        }

        public Point3D()
        {
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public static Point3D StartingPoint3D
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            StringBuilder printPoint3D = new StringBuilder();
            printPoint3D.AppendLine(string.Format("X: {0}", this.X.ToString()));
            printPoint3D.AppendLine(string.Format("Y: {0}", this.Y.ToString()));
            printPoint3D.AppendLine(string.Format("Z: {0}", this.Z.ToString()));
            return printPoint3D.ToString();
        }
         
    }
}
