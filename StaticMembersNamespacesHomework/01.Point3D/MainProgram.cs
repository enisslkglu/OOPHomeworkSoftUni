using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class MainProgram
    {
        static void Main()
        {
            Point3D coordinates = new Point3D
            {
                X = double.Parse(Console.ReadLine()),
                Y = double.Parse(Console.ReadLine()),
                Z = double.Parse(Console.ReadLine())
            };
           
            Console.WriteLine(coordinates);
            Console.WriteLine(Point3D.StartingPoint3D);
        }

    }
}
