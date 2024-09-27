namespace ShapeCalculations.Library
{
    public class CircleSquare : ShapeSquare
    {
        public double Radius { get; init; }

        public CircleSquare(double radius)
        {
            Radius = radius;
        }

        protected override void Validate()
        {
            IsValid = Radius >= 0;
        }

        protected override void CalculateSquare()
        {
            Square = Math.PI * Radius * Radius;
        }
    }
}