using System;

namespace Area
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a > 0)
            {
                A = a;
            }
            else
            {
                throw new ArgumentException($"Incorrect value of side A: {a}");
            }

            if (a > 0)
            {
                B = b;
            }
            else
            {
                throw new ArgumentException($"Incorrect value of side B: {b}");
            }

            if (a > 0)
            {
                C = c;
            }
            else
            {
                throw new ArgumentException($"Incorrect value of side C: {c}");
            }
        }

        public double getArea()
        {
            double semiPerimeter = (A + B + C) / 2;
            double result = Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
            return result;
        }

        public bool checkSquareness()
        {
            bool result = false;
            if (A >= B || A >= C)
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    result = true;
                }
            }
            if (B >= A || B >= C)
            {
                if (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2))
                {
                    result = true;
                }
            }
            if (C >= A || C >= B)
            {
                if (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
                {
                    result = true;
                }
            }
            return result;
        }
    }
}