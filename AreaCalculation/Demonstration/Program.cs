using AreaCalculation;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(AreaCalculator.Area(4));
        var area = AreaCalculator.Area(3, 4, 5, out var isRightTriangle);
        Console.WriteLine($"{area}\n{isRightTriangle}");
    }
}