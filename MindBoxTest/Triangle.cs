
namespace MindboxTest
{
    public class Triangle : Shape
    {
        public double SideAB { get; set; }
        public double SideAC { get; set; }
        public double SideBC { get; set; }


        public override double Area
        {
            get
            {
                double p = Perimeter / 2d;
                return Math.Sqrt(p * (p - SideAB) * (p - SideAC) * (p - SideBC));
            }
        }

        public override double Perimeter => SideAB + SideAC + SideBC;

        public bool IsRightTriangle
        {
            get
            {
                double maxSide = Math.Max(SideAB, SideAC);
                maxSide = Math.Max(maxSide, SideBC);
                maxSide *= maxSide;

                return Pifagor == maxSide;
            }
        }
        public double[] Cathetuses
        {
            get
            {
                double[] result = new double[2];

                result[0] = Math.Min(SideAC, SideAB);
                double maxFirst = Math.Max(SideAC, SideAB);

                result[1] = Math.Min(maxFirst, SideBC);

                return result;
            }
        }

        public double Pifagor
        {
            get
            {
                double[] cathetuses = Cathetuses;
                return Math.Pow(cathetuses[0], 2) + Math.Pow(cathetuses[1], 2);
            }
        }

        public Triangle(double sideAB, double sideAC, double sideBC)
        {
            SideAB = sideAB;
            SideAC = sideAC;
            SideBC = sideBC;
        }
    }
}
