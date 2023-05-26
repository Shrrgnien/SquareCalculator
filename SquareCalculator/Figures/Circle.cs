using SquareCalculator.Interfaces;
using SquareCalculator.Exceptions;

namespace SquareCalculator.Figures;

public class Circle : ISquareProvider
{
    public double Radius { get; private set; }
    /// <summary>
    /// Initialize a new instance of <see cref="Circle"/> class with <paramref name="radius"/>
    /// </summary>
    /// <param name="radius"></param>
    /// <exception cref="CircleNotExistException"></exception>
    public Circle(double radius)
    {
        if (!CircleExists(radius))
        {
            throw new CircleNotExistException(radius);
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
