using System;

namespace Area
{
    public class Circle : IFigure
    {
        public double Radius { get; }
        
        public Circle(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new ArgumentException($"Radius cannot take value {radius}");
            }
        }
        public double getArea()
        {
            double result = Math.PI * Math.Pow(Radius, 2);
            return result;
        }
    }
}