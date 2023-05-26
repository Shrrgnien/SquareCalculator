using SquareCalculator.Figures;
using SquareCalculator.Interfaces;

namespace SquareCalculator;
/// <summary>
/// Calculates figure square based on provided figure or values 
/// </summary>
public static class SquareCalculator
{
    /// <summary>
    /// Calculate figure square
    /// </summary>
    /// <param name="figure">Figure from SquareCalciulator.Figures</param>
    /// <returns>Figure square</returns>
    public static double CalculateSquare(ISquareProvider figure)
    {
        return figure.CalculateSquare();
    }

    /// <summary>
    /// Calculate triangle square
    /// </summary>
    /// <param name="a">Edge A</param>
    /// <param name="b">Edge B</param>
    /// <param name="c">Edge C</param>
    /// <returns>Triangle square</returns>
    public static double CalculateSquare(double a, double b, double c)
    {
        return CalculateSquare(new Triangle(a, b, c));
    }
    /// <summary>
    /// Calculate circle square
    /// </summary>
    /// <param name="radius">Circle radius</param>
    /// <returns>Circle square</returns>
    public static double CalculateSquare(double radius)
    {
        return CalculateSquare(new Circle(radius));
    }
}