﻿using System;
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
            Console.WriteLine("Checking intersections...");
            CreateShapes();
            intersectionDictionary = FindIntersections(shapes);
        }

        public Dictionary<int, List<int>> FindIntersections(List<Shape> shapes)
        {
            Dictionary<int, List<int>> returnDictionary = new Dictionary<int, List<int>>();
            for(int i = 0; i < shapes.Count; i++)
            {
                List<int> intersections = new List<int>();
                for (int j = 0; j < shapes.Count; j++)
                {
                    if(shapes[i] != shapes[j])
                    {
                        if(intersectionType(shapes[i], shapes[j]))
                        {
                            intersections.Add(shapes[j].ID);
                        }
                    }
                }
                returnDictionary.Add(shapes[i].ID, intersections);
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

            if (shapeA == typeof(CustomRectangle) && shapeB == typeof(Circle))
            {
                returnBool = intersectCheck(a as CustomRectangle, b as Circle);
            }
            if (shapeA == typeof(CustomRectangle) && shapeB == typeof(CustomRectangle))
            {
                returnBool = intersectCheck(a as CustomRectangle, b as CustomRectangle);
            }
            if (shapeA == typeof(Circle) && shapeB == typeof(CustomRectangle))
            {
                returnBool = intersectCheck(b as CustomRectangle, a as Circle);
            }
            if (shapeA == typeof(Circle) && shapeB == typeof(Circle))
            {
                returnBool = intersectCheck(b as Circle, a as Circle);
            }

            return returnBool;
        }

        public static bool intersectCheck(CustomRectangle rect1, CustomRectangle rect2)
        {
            Rectangle rectangle1 = new Rectangle(rect1.dimensions.X, rect1.dimensions.Y, rect1.dimensions.Width, rect1.dimensions.Height);
            Rectangle rectangle2 = new Rectangle(rect2.dimensions.X, rect2.dimensions.Y, rect2.dimensions.Width, rect2.dimensions.Height);

            if (rectangle1.IntersectsWith(rectangle2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool intersectCheck(Circle circ1, Circle circ2)
        {
            float xDistance = circ1.X - circ2.X;
            float yDistance = circ1.Y - circ2.Y;
            var distance = Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
            if (distance < circ1.Radius + circ2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool intersectCheck(CustomRectangle rect, Circle circ)
        {
            float cx = Math.Abs(circ.X - rect.dimensions.X - rect.dimensions.Width / 2);
            float distanceX = rect.dimensions.Width / 2 + circ.Radius;
            if(cx > distanceX)
            {
                return false;
            }
            float cy = Math.Abs(circ.Y - rect.dimensions.Y - rect.dimensions.Height / 2);
            float distanceY = rect.dimensions.Height / 2 + circ.Radius;
            if (cy > distanceY)
            {
                return false;
            }
            if (cx <= rect.dimensions.Width / 2 || cy <= rect.dimensions.Height / 2)
            {
                return true;
            }
            float xCornerDist = cx - rect.dimensions.Width / 2;
            float yCornerDist = cy - rect.dimensions.Height / 2;
            float xCornerDistSq = xCornerDist * xCornerDist;
            float yCornerDistSq = yCornerDist * yCornerDist;
            float maxCornerDistSq = circ.Radius * circ.Radius;
            return xCornerDistSq + yCornerDistSq <= maxCornerDistSq;
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
