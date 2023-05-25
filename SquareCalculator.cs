using System.Reflection.Metadata.Ecma335;
using SquareCalculator.Interfaces;
using SquareCalculator.Models;

namespace SquareCalculator;
public static class SquareCalculator
{
    public static double CalculateSquare(ISquareProvider figure)
    {
        return figure.CalculateSquare();
    }

    public static double CalculateSquare(double a, double b, double c)
    {
        return CalculateSquare(new Triangle(a, b, c));
    }

    public static double CalculateSquare(double radius)
    {
        return CalculateSquare(new Circle(radius));
    }
}