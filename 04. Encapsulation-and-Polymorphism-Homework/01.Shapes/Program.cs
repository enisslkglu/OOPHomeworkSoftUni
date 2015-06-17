using System;
using System.Collections.Generic;
using TheSlum.Interfaces;
using TheSlum.Shape;

namespace TheSlum
{
    
    public class Program
    {
        public static void Main()
        {
            try
            {
                List<IShape> shapes = new List<IShape>()
                {
                    new Circle(4),
                    new Triangle(3.4, 5, 6),
                    new Rectangle(3, 4),
                    new Rectangle(4.5, 6.7),
                    new Circle(1.2),
                    new Triangle(1.2, 2, 3.4),
                };

                foreach (var shape in shapes)
                {
                    Console.WriteLine("{0} area = {1:F2}, perimeter = {2:F2}",
                        shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
                }
            }
            catch (ArgumentOutOfRangeException are)
            {
                Console.WriteLine(are.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
