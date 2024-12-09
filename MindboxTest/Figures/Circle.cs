using CalcFigureLib.Figures.Interfaces;

namespace CalcFigureLib.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    internal class Circle : IFigure
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;

            Validation();
        }
        public double CalcArea()
        {          
            return Math.PI * Math.Pow(Radius, 2);
        }

        public void Validation()
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля.");
            }
        }
    }
}