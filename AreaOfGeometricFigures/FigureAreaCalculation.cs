using AreaOfGeometricFigures.Abstractions;

namespace AreaOfGeometricFigures
{
    public class FigureAreaCalculation
    {
        private readonly IFigureCreator figureCreator = new FigureCreator();

        public double CalculateFigureArea(double[] parameters)
        {
            var geometryArea = figureCreator.CreateFigure(parameters);

            return geometryArea.GetFigureArea();
        }
    }
}
