using System;

namespace Shapes_Intersection_test_with_form
{
    public class Shape
    {
        public int ID; //{ get; private set; }
        public int X; //{ get; private set; }
        public int Y;//{ get; private set; }
        public int Height;//{ get; set; }
        public int Width;//{ get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }
}