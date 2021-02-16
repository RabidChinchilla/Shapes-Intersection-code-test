using System;

namespace Shapes_Intersection_test_with_form
{
    public class Shape
    {
        public int ID; 
        public int X; 
        public int Y;
        public int Height;
        public int Width;

        public Shape(int id, int x, int y, int height, int width)
        {
            ID = id;
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

    }
}