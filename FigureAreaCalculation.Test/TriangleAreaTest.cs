using AreaOfGeometricFigures.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FigureAreaCalculation.Test
{
    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void GetFigureArea_CorrectSides_ReturnCorrectArea()
        {
            // Arrange
            double side1 = 2;
            double side2 = 4;
            double side3 = 5;
            double expectedResult = 3.799671038392666;

            var calc = new AreaOfGeometricFigures.FigureAreaCalculation();

            // Act
            var result = calc.CalculateFigureArea(new double[] { side1, side2, side3 });

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GetFigureArea_OneOfSideZero_ThrowArgumentException()
        {
            // Arrange
            double side1 = 0;
            double side2 = 3;
            double side3 = 5;

            var calc = new AreaOfGeometricFigures.FigureAreaCalculation();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => calc.CalculateFigureArea(new double[] { side1, side2, side3 }));
        }

        [TestMethod]
        public void GetFigureArea_SumOfTwoSides_ThrowArgumentException()
        {
            // Arrange
            double side1 = 2;
            double side2 = 3;
            double side3 = 6;

            var calc = new AreaOfGeometricFigures.FigureAreaCalculation();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => calc.CalculateFigureArea(new double[] { side1, side2, side3 }));
        }

        [TestMethod]
        public void IsTriangleRight_Right_ReturnTrue()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            var calc = new TriangleArea(side1, side2, side3);

            // Act
            var result = calc.IsTriangleRight();

            // Assert
            Assert.IsTrue(result.isRight);
        }
    }
}
