namespace ShapeCalculations.Library
{
    public abstract class ShapeSquare : ISquare
    {
        public double Square { get; protected set; }

        public bool IsValid { get; protected set; }

        public void Calculate()
        {
            Validate();

            if (IsValid)
            {
                CalculateSquare();
                OutputResult();
            }
        }

        protected abstract void Validate();

        protected abstract void CalculateSquare();

        protected virtual void OutputResult()
        {
            Console.WriteLine($"{GetType()}, square: {Square}");
        }
    }
}