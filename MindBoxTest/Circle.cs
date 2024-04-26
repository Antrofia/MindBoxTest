
namespace MindboxTest
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area => Math.PI * Math.Pow(Radius, 2);
        public override double Perimeter => 2d * Radius * Math.PI;

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
