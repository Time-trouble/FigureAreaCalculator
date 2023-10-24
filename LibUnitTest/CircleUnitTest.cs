namespace LibUnitTest
{
    [TestClass]
    public class CircleUnitTest
    {
        /// <summary>
        /// �������� �������� ������� ����� � �������� ������ ��� ������ ����
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithZeroOrLessRadius()
        {
            // arrange
            var radius = 0;
            var circle = new Circle(radius);
            // act
            circle.GetArea();
        }

        /// <summary>
        /// �������� ������������ �������� ������� �����
        /// </summary>
        [TestMethod]
        public void TestGetCorrectArea()
        {
            // arrange 
            var radius = 5;
            var circle = new Circle(radius);    
            var expectedArea = Math.PI * radius * radius;
            // act 
            var area = circle.GetArea();
            // assert 
            Assert.AreEqual(expectedArea, area);
        }
    }
}