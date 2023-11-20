using System;

namespace SquareCalculation
{
    /// <summary>
    /// Interface for classes which can calculate square.
    /// </summary>
    public interface ISquareable
    {
        /// <summary>
        /// Square of this figure.
        /// </summary>
        public double Square { get; }
    }

    /// <summary>
    /// Circle figure.
    /// </summary>
    public class Circle : ISquareable
    {
        /// <inheritdoc />
        public double Square { get; private set; }

        /// <summary>
        /// Create circle with specified radius.
        /// </summary>
        /// <param name="radius">
        /// Circle radius > 0.
        /// </param>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be less than zero");
            }

            Square = Math.PI * Math.Pow(radius, 2);
        }
    }

    /// <summary>
    /// Triangle figure.
    /// </summary>
    public class Triangle : ISquareable
    {
        private double[] sides;

        /// <inheritdoc />
        public double Square { get; private set; }

        /// <summary>
        /// Create triangle with specified sides.
        /// </summary>
        /// <param name="aSide">
        /// A side of triangle > 0.
        /// </param>
        /// <param name="bSide">
        /// B side of triangle > 0.
        /// </param>
        /// <param name="cSide">
        /// C side of triangle > 0.
        /// </param>
        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
            {
                throw new ArgumentException("Sides can't be less than zero");
            }

            if (aSide + bSide < cSide || aSide + cSide < bSide || bSide + cSide < aSide)
            {
                throw new ArgumentException("These sides don't form tringle");
            }

            sides = new double[3] { aSide, bSide, cSide };

            var semiperimeter = (aSide + bSide + cSide) / 2;

            Square = Math.Sqrt(semiperimeter * (semiperimeter - aSide) * (semiperimeter - bSide) * (semiperimeter - cSide));
        }

        /// <summary>
        /// Сhecking triangle is right.
        /// </summary>
        public bool IsRightTriangle()
        {
            var eps = double.Epsilon;

            Array.Sort(sides);

            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) <= eps;
        }
    }
}