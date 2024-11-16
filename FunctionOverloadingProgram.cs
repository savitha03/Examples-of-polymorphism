
using System;
    namespace FunctionOverloading
{
    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x,int y, int z)
        {
            return x + y + z;
        }
        public  double Add(double x, double y)
        {
            return x + y;
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add two integers: " + calc.Add(5, 10));
            Console.WriteLine("Add three integers :" + calc.Add(5, 10, 5));
            Console.WriteLine("Add two doubles :" + calc.Add(2.5, 2.5)); 
        }
    }
}
