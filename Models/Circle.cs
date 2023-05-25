using SquareCalculator.Interfaces;

namespace SquareCalculator.Models;

public class Circle : ISquareProvider
{
    public double Radius { get; private set; }
    public Circle(double radius)
    {
        if (!CircleExists(radius))
        {
            throw new CircleNotExistException();
        }

        Radius = radius;
    }
    public double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }

    private bool CircleExists(double radius)
    {
        return radius > 0;
    }
}
