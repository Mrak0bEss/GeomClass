using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToSolveGeom
{
    public class Circle : Figure
    {
        public double rad { get; set; }
        public Circle(double r)
        {
            rad = r;
        }
        public override double GetSquare()
        {
            Square = Math.PI * rad * rad;
            return Square;
        }

    }
}
