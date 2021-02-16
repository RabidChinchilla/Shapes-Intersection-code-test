using System.Drawing;
using System.Windows.Forms;

namespace Shapes_Intersection_test_with_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void StaticRectangleIntersection(PaintEventArgs e)
        {
            Rectangle rectangle1 = new Rectangle(50, 50, 200, 100);
            Rectangle rectangle2 = new Rectangle(70, 20, 100, 200);
            Rectangle rectangle3 = new Rectangle();

            e.Graphics.DrawRectangle(Pens.Black, rectangle1);
            e.Graphics.DrawRectangle(Pens.Red, rectangle2);

            if (rectangle1.IntersectsWith(rectangle2))
            {
                rectangle3 = Rectangle.Intersect(rectangle1, rectangle2);
                if (!rectangle3.IsEmpty)
                {
                    e.Graphics.FillRectangle(Brushes.Green, rectangle3);
                }
            }
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

    }
}

