using System;

namespace _3project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        {
            return a * b;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
}
