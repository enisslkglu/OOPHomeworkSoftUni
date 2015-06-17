using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
    class MainProgram
    {
        static void Main()
        {
            try
            {
                Point3D coorFirst = new Point3D(5, 3, 8);
                Point3D coorSecond = new Point3D(2, 4, 8);
                Point3D coorThirs = new Point3D(2, 4, 6);
                List<Point3D> points = new List<Point3D>() { coorFirst, coorSecond, coorThirs };
                Path3D newPath = new Path3D(points);

                Storage.SavePath("../../path.txt", newPath.ToString());
                Console.WriteLine(Storage.LoadPath("../../path.txt"));
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
