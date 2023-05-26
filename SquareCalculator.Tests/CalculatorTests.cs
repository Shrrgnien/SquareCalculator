namespace SquareCalculator.Tests;

public class CalculatorTests
{
    [Theory]
    [ClassData(typeof(TriangleTestData))]
    public void CalculatorShouldConsumeTriangles(double a, double b, double c, double expected)
    {
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(a, b, c), Constants.Digits));
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(new Triangle(a, b, c)), Constants.Digits));
    }


    [Theory]
    [ClassData(typeof(CircleTestData))]
    public void CalclulatorShouldConsumeCircles(double radius, double expected)
    {
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(radius), Constants.Digits));
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(new Circle(radius)), Constants.Digits));
    }

}