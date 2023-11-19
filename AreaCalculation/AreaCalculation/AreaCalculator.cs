namespace AreaCalculation
{
    public static class AreaCalculator
    {
        /// <summary>
        /// Calculate circle area
        /// </summary>
        /// <param name="r">circle radius</param>
        /// <returns></returns>
        public static double Area(int r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}