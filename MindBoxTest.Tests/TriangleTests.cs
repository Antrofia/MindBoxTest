
using MindboxTest;

namespace MindBoxTest.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Pifagor_Calculate_Equals()
        {
            Triangle triangle = new Triangle(3d, 5d, 4d);

            double expected = 25d;
            double result = triangle.Pifagor;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Cathetuses_Calculate_Equals()
        {
            Triangle triangle = new Triangle(3d, 5d, 4d);

            double[] expected = [3d, 4d];
            double[] result = triangle.Cathetuses;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsRightTriangle_Calculate_RightAndNoRightTriangles()
        {
            Triangle triangleRight = new Triangle(3d, 5d, 4d);
            Assert.True(triangleRight.IsRightTriangle);

            Triangle triangleNoRight = new Triangle(3d, 7d, 5d);
            Assert.False(triangleNoRight.IsRightTriangle);
        }

        [Fact]
        public void Area_Calculate_Equals()
        {
            Triangle triangle = new Triangle(3d, 5d, 4d);

            double expected = 6d;
            double result = triangle.Area;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Perimeter_Calculate_Equals()
        {
            Triangle triangle = new Triangle(3d, 5d, 4d);

            double expected = 12d;
            double result = triangle.Perimeter;

            Assert.Equal(expected, result);
        }
    }
}
