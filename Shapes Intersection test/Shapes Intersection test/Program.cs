using System;
using System.Collections.Generic;
using System.Drawing;

namespace Shapes_Intersection_test
{
    class Program
    {
        List<Shape> shapes;
        List<int> results;
        Dictionary<int, List<int>> intersectionDictionary;

        static void Main(string[] args)
        {

            Console.WriteLine("Shapes made");

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

        public void CreateShapes()
        {
            shapes = new List<Shape>();
            shapes.Add(new CustomRectangle(55, 70, 170, 90, 1));
            shapes.Add(new CustomRectangle(90, 120, 20, 90, 2));
            shapes.Add(new Circle(20, 20, 10, 3));
            shapes.Add(new Circle(12, 9, 15, 4));
        }

        public bool intersectionType(Shape a, Shape b)
        {
            bool returnBool = false;
            Type shapeA = a.GetType();
            Type shapeB = b.GetType();


            return returnBool;
        }
    }

    public class Shape
    {
        public int ID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
    }

    public class Circle : Shape
    {
        public int Radius { get; private set; }

        public Circle(float x, float y, int radius, int id)
        {
            Radius = radius;
            X = x;
            Y = y;
            ID = id;

        }
    }

    public class CustomRectangle : Shape
    {
        public Rectangle dimensions;

        public CustomRectangle(int x, int y, int width, int height, int id)
        {
            dimensions.X = x;
            dimensions.Y = y;
            dimensions.Width = width;
            dimensions.Height = height;
            ID = id;
        }
    }
}
