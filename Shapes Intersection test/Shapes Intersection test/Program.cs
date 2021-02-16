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

            List<Shape> shapes = new List<Shape>();
            shapes.Add(rectangle1);
            shapes.Add(rectangle2);
            shapes.Add(circle);

            Console.WriteLine("Shapes made");
            shapes.ForEach(i => Console.WriteLine("{0}\t", i.ID));
            shapes.ForEach(i => Console.WriteLine("{0}\t", i.dimensions));

        }

        public Dictionary<int, List<int>> FindIntersections(List<Shape> shapes)
        {
            Dictionary<int, List<int>> returnDictionary = new Dictionary<int, List<int>>();
            for(int i = 0; i < shapes.Count; i++)
            {
                List<int> intersections = new List<int>();
                for (int j = 0; j < shapes.Count; j++)
                {

                }
            }
            return returnDictionary;
        }
    }

    public class Shape
    {
        public int ID;
        public Rectangle dimensions;


        public Shape(int id, int x, int y, int height, int width)
        {
            ID = id;
            dimensions.X = x;
            dimensions.Y = y;
            dimensions.Height = height;
            dimensions.Width = width;
        }
    }
}
