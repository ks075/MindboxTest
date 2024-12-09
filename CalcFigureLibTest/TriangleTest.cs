using CalcFigureLib;

namespace CalcFigureLibTest
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(1, 1, 1, 0.4330127018922193)]
        [InlineData(2, 2, 2, 1.7320508075688772)]
        [InlineData(20, 20, 20, 173.20508075688772)]
        [InlineData(3, 4, 5, 6)]
        public void TestCalcTriangleCorrectResult(double a, double b, double c, double correctResult)
        {
            var calcTest = new CalcFigure(a, b, c);
            var result = calcTest.GetArea();

            Assert.Equal(correctResult, result);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void TestCalcTriangleIsRightTriangle(double a, double b, double c)
        {
            var calcTest = new CalcFigure(a, b, c);

            Assert.True(calcTest.IsRightTriangle());
        }

        [Theory]
        [InlineData(3, 4, 6)]
        public void TestCalcTriangleIsNotRightTriangle(double a, double b, double c)
        {
            var calcTest = new CalcFigure(a, b, c);

            Assert.False(calcTest.IsRightTriangle());
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 1, 1)]
        [InlineData(20, -20, 20)]
        [InlineData(100, 100, -100)]
        [InlineData(1, 2, 10)]
        [InlineData(10, 2, 1)]
        [InlineData(1, 20, 3)]
        public void TestCalcTriangleArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new CalcFigure(a, b, c));
        }

        [Theory]
        [InlineData(2)]
        public void TestCalcTriangleIsRightTriangleInvalidOperationException(double a)
        {
            var calcTest = new CalcFigure(a);

            Assert.Throws<InvalidOperationException>(() => calcTest.IsRightTriangle());
        }
    }
}