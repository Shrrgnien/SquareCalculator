using SquareCalculator.Interfaces;
using SquareCalculator.Exceptions;

namespace SquareCalculator.Figures;

public class Triangle : ISquareProvider
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }

    public double Square => CalculateSquare();
    /// <summary>
    /// Initialize a new instance of <see cref="Triangle"/> class with edges <paramref name="a"/>, <paramref name="b"/>, <paramref name="c"/>
    /// </summary>
    /// <param name="a">Edge A</param>
    /// <param name="b">Edge B</param>
    /// <param name="c">Edge C</param>
    /// <exception cref="TriangleNotExistException"></exception>
    public Triangle(double a, double b, double c)
    {
        if (!TriangleExists(a, b, c))
        {
            throw new TriangleNotExistException(a, b, c);
        }

        A = a;
        B = b;
        C = c;
    }
    public double CalculateSquare()
    {
        double p = (A + B + C) / 2.0;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    private bool TriangleExists(double a, double b, double c)
    {
        if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            return true;
        return false;
    }
}
