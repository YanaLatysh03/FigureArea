using AreaOfGeometricFigures.Abstractions;
using AreaOfGeometricFigures.Figures;

namespace AreaOfGeometricFigures
{
    public class FigureCreator : IFigureCreator
    {
        public IFigure CreateFigure(double[] parameters)
        {
            if (parameters.Length == 1)
            {
                return new CircleArea(parameters[0]);
            }
            else if (parameters.Length == 3)
            {
                return new TriangleArea(parameters[0], parameters[1], parameters[2]);
            }

            throw new ArgumentException("Can't create figure with such parameters");
        }
    }
}
