using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    class MainProgram
    {
        static void Main()
        {
            Point3D coordinateFirst = new Point3D
            {
                X = double.Parse(Console.ReadLine()),
                Y = double.Parse(Console.ReadLine()),
                Z = double.Parse(Console.ReadLine())
            };

            Point3D coordinateSecond = new Point3D
            {
                X = double.Parse(Console.ReadLine()),
                Y = double.Parse(Console.ReadLine()),
                Z = double.Parse(Console.ReadLine())
            };

            Console.WriteLine(DistanceCalculator.CalculatingDistance(coordinateFirst,coordinateSecond));
        }
    }
}
