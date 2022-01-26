using System;

namespace Shapes
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public double Square {
            get
            {
                var p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public bool IsRectangle { 
            get => (A * A + B * B == C * C) || (A * A + C * C == B * B) || (B * B + C * C == A * A);
        }

        public Triangle(double a, double b, double c)
        {
            if (!IsExist(a, b, c))
                throw new ArgumentException($"Треугольника со сторонами {a}, {b}, {c} не существует!");

            A = a; B = b; C = c;
        }

        private static bool IsExist(double a, double b, double c) =>
            a + b > c && a + c > b && b + c > a;
    }
}
