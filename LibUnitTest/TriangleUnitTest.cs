using CalculationAreaLib;

namespace LibUnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        /// <summary>
        /// Проверка корректности подсчета площади треугольника
        /// </summary>
        [TestMethod]
        public void TestGetCorrectArea()
        {
            // arrange
            var a = 3;
            var b = 4;
            var c = 5;
            Figure triangle = new Triangle(a, b, c);
            var expected = 6;
            // act
            var result = triangle.GetArea();
            // assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Проверка корректности определения прямоугольный треугольник или нет
        /// </summary>
        [TestMethod]
        public void TestCorrectRectangleMatches()
        {
            // arrange
            var a = 3;
            var b = 4;
            var c = 5;
            Figure triangle = new Triangle(a, b, c);
            var expected = true;
            // act
            var result = (triangle as Triangle)?.IstRiangleRectangular() ?? false;
            // assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Проверка подсчета площади треугольника со сторонами меньше или равными нулю
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithZeroOrLessSide()
        {
            // arrange
            double a = 0;
            double b = 10;
            double c = 40;
            var triangle = new Triangle(a, b, c);
            // act
            triangle.GetArea();
        }

        /// <summary>
        /// Проверка существования треугольника со стороной, большей или равной сумме двух других сторон
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExistenceTriangleWithSpecifiedSides()
        {
            // arrange
            double a = 10; 
            double b = 20;
            double c = 30;
            var triangle = new Triangle(a, b, c);
            // act
            triangle.GetArea();
        }
    }
}
