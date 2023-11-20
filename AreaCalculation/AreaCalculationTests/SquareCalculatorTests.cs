using SquareCalculation;

namespace SquareCalculation.Tests
{
    [TestClass]
    public class SquareCalculatorTests
    {
        [TestMethod]
        public void Circle_NegativeValue()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-3));
        }

        [TestMethod]
        public void Circle_ZeroValue()
        {
            var circle = new Circle(0);

            var circleSquare = circle.Square;

            Assert.AreEqual(0, circleSquare);
        }

        [TestMethod]
        public void Circle_SquareCalculation()
        {
            var circle = new Circle(4);

            var circleSquare = circle.Square;

            Assert.AreEqual(50.26548245743669, circleSquare);
        }

        [TestMethod]
        public void Triangle_ZeroValue()
        {
            var triangle = new Triangle(0, 0, 0);

            var triangleSquare = triangle.Square;

            Assert.AreEqual(0, triangleSquare);
        }

        [TestMethod]
        public void Triangle_NegativeValue()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-3, 5, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, -5, 4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 5, -4));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-3, -5, -4));
        }

        [TestMethod]
        public void Triangle_WrongSidesValue()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 6, 1));
        }

        [TestMethod]
        public void Triangle_SquareCalculation()
        {
            var triangle = new Triangle(3, 4, 6);

            var triangleSquare = triangle.Square;

            Assert.AreEqual(5.332682251925386, triangleSquare);
        }

        [TestMethod]
        public void Triangle_IsRightTriangleTrue()
        {
            var triangle = new Triangle(3, 4, 5);

            var isTriangleRight = triangle.IsRightTriangle();

            Assert.AreEqual(true, isTriangleRight);
        }

        [TestMethod]
        public void Triangle_IsRightTriangleFalse()
        {
            var triangle = new Triangle(2, 3, 4);

            var isTriangleRight = triangle.IsRightTriangle();

            Assert.AreEqual(false, isTriangleRight);
        }
    }
}