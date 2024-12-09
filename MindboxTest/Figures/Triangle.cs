using CalcFigureLib.Figures.Interfaces;

namespace CalcFigureLib.Figures
{    
    internal class Triangle : IFigure
    {
        private readonly double A;
        private readonly double B;
        private readonly double C;

        /// <summary>
        /// Треугольник.
        /// </summary>
        /// <param name="a">Сторона A.</param>
        /// <param name="b">Сторона B.</param>
        /// <param name="c">Сторона C.</param>
        public Triangle(double a, double b, double c)
        {            
            this.A = a;
            this.B = b;
            this.C = c;

            Validation();
        }

        public double CalcArea()
        {
            var halfPerimeter = (A + B + C) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            double[] sides = [A, B, C];
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

        /// <summary>
        /// Проверки входных данных.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void Validation()
        {
            if (A <= 0
                || B <= 0
                || C <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть больше нуля.");
            }

            if (A + B <= C
                || A + C <= B
                || B + C <= A)
            {
                throw new ArgumentException("Сумма двух сторон треугольника не может быть больше третьей.");
            }
        }
    }
}