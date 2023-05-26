namespace SquareCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void TriangleShouldBeValid()
    {
        Assert.Throws<TriangleNotExistException>(() => { new Triangle(0, 1, 1); });
        Assert.Throws<TriangleNotExistException>(() => { new Triangle(-10, 8, 7); });
        Assert.Throws<TriangleNotExistException>(() => { new Triangle(5,1,1); });
        Assert.NotNull(new Triangle(1,7,7));
        Assert.NotNull(new Triangle(1, 1, 1));
    }

    [Theory]
    [ClassData(typeof(TriangleTestData))]
    public void SquareShouldBeCorrect(double a, double b, double c, double expected)
    {
        var figure1 = new Triangle(a, b, c);
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(figure1),Constants.Digits));
        Assert.Equal(expected, Math.Round(SquareCalculator.CalculateSquare(a,b,c), Constants.Digits));
        Assert.Equal(expected, Math.Round(figure1.CalculateSquare(), Constants.Digits));
    }

}