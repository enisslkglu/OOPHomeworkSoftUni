using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
    public class Path3D
    {
        private List<Point3D> pathPoint3D = new List<Point3D>();

        public List<Point3D> PathPoint3D
        {
            get { return this.pathPoint3D; }
            set { this.pathPoint3D = value; }
        }

        public Path3D() 
        {
            
        }

        public Path3D(Point3D first)
        {
            List<Point3D> list = new List<Point3D>(){first};
            this.PathPoint3D = list;
        }

        public Path3D(List<Point3D> coordinates)
        {
            this.pathPoint3D = coordinates;
        }

        public void AddCoord(Point3D newPoints)
        {
            if (pathPoint3D == null)
            {
                List<Point3D> list = new List<Point3D>(){newPoints};
                this.PathPoint3D = list;
                return;
            }
            this.pathPoint3D.Add(newPoints);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var point in pathPoint3D)
            {
                result.AppendFormat("x: {0}, y: {1}, z: {2}\n", point.X, point.Y, point.Z);
            }
            return result.ToString();
        }
    }
}
