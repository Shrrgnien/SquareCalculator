namespace SquareCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void TriangleShouldBeValid()
    {
        Assert.Throws<TriangleNotExistException>(() => { new Triangle(0, 1, 1); });
        Assert.Throws<TriangleNotExistException>(() => { new Triangle(-10, 8, 7); });
        Assert.Throws<TriangleNotExistException>(() => { new Triangle(5, 1, 1); });
        Assert.NotNull(new Triangle(1, 7, 7));
        Assert.NotNull(new Triangle(1, 1, 1));
    }
    [Fact]
    public void TriangleShouldCheckRight()
    {
        Triangle rightTriangle = new(3, 4, 5);
        Triangle rightTriangle2 = new(4, 3, 5);
        Triangle rightTriangle3 = new(5, 4, 3);
        Triangle notRightTriangle = new(1, 7, 7);
        Triangle notRightTriangle2 = new(1, 1, 1);
        Triangle notRightTriangle3 = new(7, 7, 7);

        Assert.True(rightTriangle.IsRight);
        Assert.True(rightTriangle2.IsRight);
        Assert.True(rightTriangle3.IsRight);

        Assert.False(notRightTriangle.IsRight);
        Assert.False(notRightTriangle2.IsRight);
        Assert.False(notRightTriangle3.IsRight);
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