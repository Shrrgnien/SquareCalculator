namespace SquareCalculator.Tests;

public class CircleTests
{
    [Fact]
    public void CircleShouldBeValid()
    {
        Assert.Throws<CircleNotExistException>(() => { new Circle(0); });
        Assert.Throws<CircleNotExistException>(() => { new Circle(-15); });
        Assert.NotNull(new Circle(10));
    }

    [Theory]
    [ClassData(typeof(CircleTestData))]
    public void SquareShouldBeCorrect(double radius, double expected)
    {
        Circle circle = new Circle(radius);
        Assert.Equal(expected, Math.Round(circle.CalculateSquare(), Constants.Digits));
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(circle), Constants.Digits));
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(radius), Constants.Digits));
    }
}