namespace AreaCalculation
{
    public static class AreaCalculator
    {
        /// <summary>
        /// Calculate circle area.
        /// </summary>
        /// <param name="r">
        /// Circle radius > 0.
        /// </param>
        /// <returns>
        /// Circle area.
        /// </returns>
        public static double Area(int r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /// <summary>
        /// Calculate triangle area.
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
        /// <returns>
        /// Triangle area.
        /// </returns>
        public static double Area(double aSide, double bSide, double cSide) 
        {
            double semiperimeter = (aSide + bSide + cSide) / 2;

            return Math.Sqrt(semiperimeter * (semiperimeter - aSide) * (semiperimeter - bSide) * (semiperimeter - cSide));
        }

        /// <summary>
        /// Calculate triangle area.
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
        /// <param name="isRightTriangle">
        /// Out value is right triangle.
        /// </param>
        /// <returns>
        /// Triangle area.
        /// </returns>
        public static double Area(double aSide, double bSide, double cSide, out bool isRightTriangle)
        {
            isRightTriangle = IsRightTriangle(aSide, bSide, cSide);

            return Area(aSide,bSide,cSide);
        }

        //Сhecking triangle for squareness
        private static bool IsRightTriangle(double aSide, double bSide, double cSide)
        {
            bool isRightTriangle = false;

            var maxSide = Math.Max(Math.Max(aSide, bSide), cSide);

            if (maxSide == aSide)
            {
                if (Math.Pow(aSide, 2) == Math.Pow(bSide, 2) + Math.Pow(cSide, 2))
                    isRightTriangle = true;
            }

            else if (maxSide == bSide)
            {
                if (Math.Pow(bSide, 2) == Math.Pow(aSide, 2) + Math.Pow(cSide, 2))
                    isRightTriangle = true;
            }

            else
            {
                if (Math.Pow(cSide, 2) == Math.Pow(bSide, 2) + Math.Pow(aSide, 2))
                    isRightTriangle = true;
            }

            return isRightTriangle;
        }
    }
}