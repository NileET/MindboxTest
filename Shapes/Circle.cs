using System;

namespace Shapes
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public double Square { get => Math.PI * Radius * Radius; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}