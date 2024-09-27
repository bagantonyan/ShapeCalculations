namespace ShapeCalculations.Library
{
    public class TriangleSquare : ShapeSquare
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        public TriangleSquare(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        protected override void Validate()
        {
            IsValid = SideA + SideB > SideC
                   && SideA + SideC > SideB
                   && SideB + SideC > SideA;
        }

        protected override void CalculateSquare()
        {
            var s = (SideA + SideB + SideC) / 2;

            Square = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRight()
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)
                || Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)
                || Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }
    }
}