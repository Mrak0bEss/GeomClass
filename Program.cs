using System;
using ClassToSolveGeom;
namespace tryToclass
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();
          

            Console.WriteLine("Введите стороны треугольника");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Figure triangle = new Triangle(a, b, c);
            Console.WriteLine($"Его площадь:{triangle.GetSquare()}");

            Console.WriteLine();

            Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());
            Figure circ = new Circle(r);
            Console.WriteLine($"Его площадь:{circ.GetSquare()}");
        }
    }
}
