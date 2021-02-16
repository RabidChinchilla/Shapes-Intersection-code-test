using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes_Intersection_test_with_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //border coolours
        Pen black = new Pen(Color.Black);
        Pen blue = new Pen(Color.Blue);
        Pen green = new Pen(Color.Green);

        Shape rectangle1 = new Shape(2, 55, 70, 170, 90);
        Shape rectangle2 = new Shape(3, 90, 120, 20, 90);
        Shape circle = new Shape(1, 20, 20, 90, 90);


        //x position, y position, width, height
        Rectangle rect1 = new Rectangle(55, 70, 170, 90);
        Rectangle circ = new Rectangle(20, 20, 90, 90);
        Rectangle rect2 = new Rectangle(90, 120, 20, 90);

        List <Shape> shapeList = new List<Shape>();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(black, rect1);
            g.DrawRectangle(green, rect2);
            g.DrawEllipse(blue, circ);
        }
    }

}
