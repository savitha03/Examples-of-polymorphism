using System;

namespace FunctionOverriding
{
    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }
    class Circle : Shape
    { 
        public double Radius {  get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double Area()
        { 
        return Length*Width;
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(10, 8);

            Console.WriteLine("Area of Circle: "+ circle.Area());
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());
        }
    }

}
