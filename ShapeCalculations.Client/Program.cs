using ShapeCalculations.Library;

namespace ShapeCalculations.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle1 = new TriangleSquare(10, 15, 7);

            var triangle2 = new TriangleSquare(3, 4, 5);

            Console.WriteLine($"Is right? - {triangle2.IsRight()}");

            var circle = new CircleSquare(20);

            var shapes = new ISquare[] { triangle1, triangle2, circle };

            DisplaySquare(shapes);

            Console.ReadKey();
        }

        static void DisplaySquare(ISquare[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Calculate();
            }
        }
    }
}