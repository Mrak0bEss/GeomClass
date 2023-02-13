using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToSolveGeom
{
    public class Triangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
            if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
            {
                Console.WriteLine("Прямоугольный треугольник");
            }

        }
        public override double GetSquare()
        {
            double polyperimetr = (a + b + c) / 2;
            Square = Math.Sqrt(polyperimetr * (polyperimetr - a) * (polyperimetr - b) * (polyperimetr - c));
            return Square;
        }
    }
}
