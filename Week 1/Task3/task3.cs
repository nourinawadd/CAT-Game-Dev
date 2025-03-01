using System;

namespace Tasks
{
    interface IShape
    {
        void CalculateArea();
    }

    interface IColor
    {
        void PrintColor();
    }

    class Circle : IShape, IColor
    {
        private double radius;
        private string color;

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public void CalculateArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + Math.Round(area, 2));
        }

        public void PrintColor()
        {
            Console.WriteLine("The color of the circle is: " + color);
        }
    }

    class MainClass
    {
        public static void Main(string [] args)
        {
            Circle myCircle = new Circle(5.0, "yellow");

            myCircle.CalculateArea();
            myCircle.PrintColor();
        }
    }
}