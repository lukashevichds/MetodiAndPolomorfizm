using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// перезагрузка методов
namespace MetodiAndPolomorfizm
{
    internal class SurfaceAreaCalculator
    {
        public static double CalculateSurfaceArea(double a)
        {
            return 6 * Math.Pow(a, 2);
        }
        public static double CalculateSurfaceArea(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        public static double CalculateSurfaceArea(double r, double h)
        {
            return 2 * Math.PI * r * (r + h);
        }
        public static double CalculateSurfaceAreaSphere(double r)
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            double cubeSide = 3;
            double cubeSurfaceArea = SurfaceAreaCalculator.CalculateSurfaceArea(cubeSide);
            Console.WriteLine($"Площадь поверхности куба: {cubeSurfaceArea}");

            double lenght = 2, width = 3, height = 4;
            double rectangularPrismSurfaceArea = SurfaceAreaCalculator.CalculateSurfaceArea(lenght, width, height);
            Console.WriteLine($"Площадь поверхности прямоугольного параллелепипеда: {rectangularPrismSurfaceArea}");

            double radius = 5; double cylinderHeight = 10; 
            double cylinderSurfaceArea = SurfaceAreaCalculator.CalculateSurfaceArea(radius, cylinderHeight);
            Console.WriteLine($"Пощадь поверхности цилиндра: {cylinderSurfaceArea}");

            double sphereRadius = 7;
            double sphereSurfaceArea = SurfaceAreaCalculator.CalculateSurfaceArea(sphereRadius);
            Console.WriteLine($"Площадь поверхности шара: {sphereSurfaceArea}");
        }
    }
}
