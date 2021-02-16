﻿using System;
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

        //x position, y position, width, height
        Rectangle rect1 = new Rectangle(55, 70, 220, 90);
        Rectangle circle = new Rectangle(20, 20, 90, 90);
        Rectangle rect2 = new Rectangle(50, 120, 20, 90);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(black, rect1);
            g.DrawRectangle(green, rect2);
            g.DrawEllipse(blue, circle);


        }
    }
}
