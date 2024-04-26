
using MindboxTest;

namespace MindBoxTest.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Area_Calculate_Equals()
        {
            Circle circle = new Circle(5d);

            double expected = 78.5d;
            double result = Math.Round(circle.Area, 1);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Perimeter_Calculate_NotEquals() 
        {
            Circle circle = new Circle(5f);

            double expected = 31.4d;
            double result = Math.Round(circle.Perimeter, 1);

            Assert.Equal(expected, result);
        }
    }
}
