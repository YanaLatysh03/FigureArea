using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAreaCalculation.Test
{
    [TestClass]
    public class CircleAreaTest
    {
        [TestMethod]
        public void GetFigureArea_CorrectRadius_ReturnCorrectArea()
        {
            // Arrange
            double radius = 3;
            double expectedResult = 28.274333882308138;

            var calc = new AreaOfGeometricFigures.FigureAreaCalculation();

            // Act
            var result = calc.CalculateFigureArea(new double[] { radius });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GetFigureArea_ZeroRadius_ThrowArgumentException()
        {
            // Arrange
            double radius = 0;

            var calc = new AreaOfGeometricFigures.FigureAreaCalculation();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => calc.CalculateFigureArea(new double[] { radius }));
        }
    }
}
