using AreaOfGeometricFigures.Abstractions;

namespace AreaOfGeometricFigures.Figures
{
    public class CircleArea : IFigure
    {
        private readonly double _radius;

        public CircleArea(double radius)
        {
            _radius = radius;
        }

        public double GetFigureArea()
        {
            if (_radius <= 0)
            {
                throw new ArgumentException("Radius must be more than 0");
            }

            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
