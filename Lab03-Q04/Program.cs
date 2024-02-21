// As part of a geometry library, design a class hierarchy for geometric shapes.
//
// Shape CLASS
// - ShapeType (String)
// - Area (double)
// - CalculateArea(double val1, val2)
// + DisplayShapeInfo()
// + Shape()
//
//
// Rectangle CLASS inherited by shape
// - length
// - width
// - SetDimensions(double length, double width)
//
// Circle CLASS inherited by shape
// - radius
// + SetRadius(double radius)
//
// a) Create an instance of the Rectangle class representing a rectangle with a length of 5 and a width of 3.
// b) Display the shape information for the rectangle.
// c) Create an instance of the Circle class representing a circle with a radius of 4.
// d) Display the shape information for the circle.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q04
{
    class Shape
    {
        public string shapeType;
        public double area;

        public Shape()
        {
            shapeType = "Shape";
        }

        public virtual void CalculateArea() { }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {shapeType}");
            Console.WriteLine($"Area: {area}");
        }
    }

    class Circle : Shape
    {
        public Circle()
        {
            shapeType = "Circle";
        }

        private double radius;

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            area = Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle()
        {
            shapeType = "Rectangle";
        }

        private double width;
        private double height;

        public void SetDimension(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override void CalculateArea()
        {
            area = width * height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetDimension(5, 3);
            rect.CalculateArea();
            rect.DisplayShapeInfo();

            Console.WriteLine();

            Circle circle = new Circle();
            circle.SetRadius(4);
            circle.CalculateArea();
            circle.DisplayShapeInfo();
        }
    }
}
