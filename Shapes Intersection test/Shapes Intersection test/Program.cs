using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shapes_Intersection_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle1 = new Shape(2, 55, 70, 170, 90);
            Shape rectangle2 = new Shape(3, 90, 120, 20, 90);
            Shape circle = new Shape(1, 20, 20, 90, 90);
            Console.WriteLine("Shapes made");
            Console.WriteLine(rectangle1.ID);
            Console.WriteLine(rectangle2.ID);
            Console.WriteLine(circle.ID);
        }

        //public Dictionary<int, List<int>> FindIntersections(List<Shape> shapes)
        //{
        //    return shapes;
        //}
    }

    public class Shape
    {
        public int ID;
        public Rectangle dimensions;
        //public int X;
        //public int Y;
        //public int Height;
        //public int Width;

        public Shape(int id, int x, int y, int height, int width)
        {
            ID = id;
            dimensions.X = x;
            dimensions.Y = y;
            dimensions.Height = height;
            dimensions.Width = width;
            //X = x;
            //Y = y;
            //Height = height;
            //Width = width;
        }
    }
}
