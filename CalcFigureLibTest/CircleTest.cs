using CalcFigureLib;

namespace CalcFigureLibTest
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(15, 706.85834705770347865409476123789)]
        [InlineData(int.MaxValue, 14488038902661207983.388225808961)]
        public void TestCalcCircleCorrectResult(double radius, double correctResult)
        {
            var calcTest = new CalcFigure(radius);
            var result = calcTest.GetArea();

            Assert.Equal(correctResult, result);
        }

        [Theory]
        [InlineData(-15)]
        [InlineData(0)]
        [InlineData(int.MinValue)]
        public void TestCalcCircleArgumentException(int radius)
        {
            Assert.Throws<ArgumentException>(() => new CalcFigure(radius));
        }        
    }
}