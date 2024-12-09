using CalcFigureLib.Figures.Interfaces;

namespace CalcFigureLib.Figures
{
    public class FigureFactory
    {
        public static IFigure CreateFigure(params double[] parameters)
        {
            var type = GetTypeFigure(parameters);

            return type switch
            {
                FigureType.Circle => new Circle(parameters[0]),
                FigureType.Triangle => new Triangle(parameters[0], parameters[1], parameters[2]),
                _ => throw new NotImplementedException()
            };
        }

        /// <summary>
        /// Определение типа фигуры.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static FigureType GetTypeFigure(params double[] parameters)
        {
            if (parameters.Length == 1)
            {
                return FigureType.Circle;
            }

            if (parameters.Length == 3)
            {
                return FigureType.Triangle;
            }

            throw new ArgumentException("Неправильное количество параметров.");
        }
    }
}