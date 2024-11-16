using System;

namespace OperatorOverloading
{
    class Box
    {
        public int Length { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.Length+box2.Length, box1.Width+box2.Width, box1.Height+box2.Height);
        }
        public void DisplayDimensions()
        {
            Console.WriteLine($"Box Dimensions:Length={Length}, Width={Width}, Height={Height}");
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Box b1= new Box(3, 4, 5);
            Box b2 = new Box(6, 7, 8);

            Box b3=b1 + b2;

            Console.WriteLine("BOX 1:");
            b1.DisplayDimensions();
            Console.WriteLine("BOX 2:");
            b2.DisplayDimensions();
            Console.WriteLine("Combined Box:");
            b3.DisplayDimensions();
        }
    }
}
