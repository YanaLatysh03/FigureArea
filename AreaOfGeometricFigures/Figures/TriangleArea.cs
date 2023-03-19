using AreaOfGeometricFigures.Abstractions;

namespace AreaOfGeometricFigures.Figures
{
    public class TriangleArea : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;


        public TriangleArea(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetFigureArea()
        {
            if (_side1 <= 0 || _side2 <= 0 || _side3 <= 0)
            {
                throw new ArgumentException("Side lengths must be greater than 0");
            }

            if (_side1 + _side2 < _side3 || _side1 + _side3 <= _side2 || _side2 + _side3 <= _side1)
            {
                throw new ArgumentException("It's not a triangle. The sum of two sides must be greater than the third.");
            }

            var rightTriangle = IsTriangleRight();

            if (rightTriangle.isRight)
            {
                return rightTriangle.side1 * rightTriangle.side2 / 2;
            }

            double p = (_side1 + _side2 + _side3) / 2;

            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public (bool isRight, double side1, double side2) IsTriangleRight()
        {
            double maxSide = Math.Max(_side1, Math.Max(_side2, _side3));

            double sumOfSquareSmallerSides;
            double sideA;
            double sideB;

            if (maxSide == _side1)
            {
                sideA = _side2;
                sideB = _side3;
                sumOfSquareSmallerSides = Math.Pow(_side2, 2) + Math.Pow(_side3, 2);
            }
            else if (maxSide == _side2)
            {
                sideA = _side1;
                sideB = _side3;
                sumOfSquareSmallerSides = Math.Pow(_side1, 2) + Math.Pow(_side3, 2);
            }
            else
            {
                sideA = _side1;
                sideB = _side2;
                sumOfSquareSmallerSides = Math.Pow(_side1, 2) + Math.Pow(_side2, 2);
            }

            if (Math.Pow(maxSide, 2) == sumOfSquareSmallerSides)
            {
                return (true, sideA, sideB);
            }

            return (false, 0, 0);
        }
    }
}
