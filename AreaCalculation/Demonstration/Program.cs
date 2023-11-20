using SquareCalculation;

public class Program
{
    //Calculating the square of ​​a figure without knowing it's type in compile time.
    private static void Main(string[] args)
    {
        ISquareable? figureWithSquare = null;

        Console.WriteLine("Input title of figure");

        var type = Console.ReadLine().ToLower();

        switch (type)
        {
            case "circle":
                figureWithSquare = new Circle(2);
                break;
            case "triangle":
                figureWithSquare = new Triangle(3,4,5);
                break;
        }

        if (figureWithSquare != null)
        {
            Console.WriteLine($"Square is {figureWithSquare.Square}.");

            if (figureWithSquare is Triangle triangle)
            {
                Console.WriteLine($"Is triangle right: {triangle.IsRightTriangle()}.");
            }
        }
    }
}