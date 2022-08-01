namespace ShapesMaster
{
    public class Triangle : IShape
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }
        public double SemiPerimeter => Perimeter / 2;
        public double Perimeter => A + B + C;
        public double Area => Math.Sqrt(SemiPerimeter *
            (SemiPerimeter - A) *
            (SemiPerimeter - B) *
            (SemiPerimeter - C));
        public bool IsRight 
        { 
            get
            {
                double aSqr = Math.Pow(A, 2),
                   bSqr = Math.Pow(B, 2),
                   cSqr = Math.Pow(C, 2);
                return aSqr == bSqr + cSqr || bSqr == aSqr + cSqr || cSqr == aSqr + bSqr;
            }
        }
       
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Each side must be greater than 0");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Conditions of existence of a triangle are not met");

            A = a;
            B = b;
            C = c;
        }
    }
}