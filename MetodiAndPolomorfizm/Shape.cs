using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// полиморфизм
namespace MetodiAndPolomorfizm
{
    abstract class Shape
    {
        public abstract double CalculateSurfaceArea();
    }
    class Cube : Shape
    {
        private double side;

        public Cube(double side)
        {
            this.side = side;
        }
        public override double CalculateSurfaceArea()
        {
            return 6 * Math.Pow(side, 2);
        }
    }
    class RectangularPrism : Shape
    {
        private double length;
        private double width;
        private double height;

        public RectangularPrism(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public override double CalculateSurfaceArea()
        {
            return 2 * (length * width + length * height + width * height);
        }
    }

    class Cylinder : Shape
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public override double CalculateSurfaceArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }
    }
    class Sphere : Shape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Cube(3),
                new RectangularPrism(2, 3, 4),
                new Cylinder(5, 10),
                new Sphere(6)
            };
            foreach(var shape in shapes)
            {
                Console.WriteLine($"Площадь поверхности: {shape.CalculateSurfaceArea()}");
            }
        }
    }
}
