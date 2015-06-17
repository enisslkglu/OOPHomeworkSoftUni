using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculatingDistance(Point3D first, Point3D second)
        {
            double deltaX = second.X - first.X;
            double deltaY = second.Y - first.Y;
            double deltaZ = second.Z - first.Z;
            double distance = (double) Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
            return distance;
        }
    }
}
