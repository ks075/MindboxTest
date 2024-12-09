using CalcFigureLib.Figures;
using CalcFigureLib.Figures.Interfaces;

namespace CalcFigureLib
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="values">Параметры фигуры.</param>
    public class CalcFigure(params double[] values)
    {
        private readonly IFigure figure = FigureFactory.CreateFigure(values);

        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return this.figure.CalcArea();
        }

        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public bool IsRightTriangle()
        {
            if (this.figure.GetType() == typeof(Triangle))
            {
                return ((Triangle)figure).IsRightTriangle();
            }

            throw new InvalidOperationException("Операция не поддерживается для данного типа фигуры.");
        }
    }
}