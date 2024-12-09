namespace CalcFigureLib.Figures.Interfaces
{
    public interface IFigure
    {
        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns></returns>
        public double CalcArea();

        /// <summary>
        /// Валидация входных параметров.
        /// </summary>
        public void Validation();
    }
}